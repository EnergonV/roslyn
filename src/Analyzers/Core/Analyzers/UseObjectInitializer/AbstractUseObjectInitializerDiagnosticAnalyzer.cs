﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.CodeStyle;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.LanguageServices;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Shared.Collections;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.UseObjectInitializer
{
    internal abstract partial class AbstractUseObjectInitializerDiagnosticAnalyzer<
        TSyntaxKind,
        TExpressionSyntax,
        TStatementSyntax,
        TObjectCreationExpressionSyntax,
        TMemberAccessExpressionSyntax,
        TAssignmentStatementSyntax,
        TVariableDeclaratorSyntax>
        : AbstractBuiltInCodeStyleDiagnosticAnalyzer
        where TSyntaxKind : struct
        where TExpressionSyntax : SyntaxNode
        where TStatementSyntax : SyntaxNode
        where TObjectCreationExpressionSyntax : TExpressionSyntax
        where TMemberAccessExpressionSyntax : TExpressionSyntax
        where TAssignmentStatementSyntax : TStatementSyntax
        where TVariableDeclaratorSyntax : SyntaxNode
    {
        private static readonly DiagnosticDescriptor s_descriptor = CreateDescriptorWithId(
            IDEDiagnosticIds.UseObjectInitializerDiagnosticId,
            EnforceOnBuildValues.UseObjectInitializer,
            new LocalizableResourceString(nameof(AnalyzersResources.Simplify_object_initialization), AnalyzersResources.ResourceManager, typeof(AnalyzersResources)),
            new LocalizableResourceString(nameof(AnalyzersResources.Object_initialization_can_be_simplified), AnalyzersResources.ResourceManager, typeof(AnalyzersResources)),
            isUnnecessary: false);

        private static readonly DiagnosticDescriptor s_unnecessaryCodeDescriptor = CreateDescriptorWithId(
            IDEDiagnosticIds.UseObjectInitializerDiagnosticId,
            EnforceOnBuildValues.UseObjectInitializer,
            new LocalizableResourceString(nameof(AnalyzersResources.Simplify_object_initialization), AnalyzersResources.ResourceManager, typeof(AnalyzersResources)),
            new LocalizableResourceString(nameof(AnalyzersResources.Object_initialization_can_be_simplified), AnalyzersResources.ResourceManager, typeof(AnalyzersResources)),
            isUnnecessary: true);

        protected abstract bool FadeOutOperatorToken { get; }

        protected AbstractUseObjectInitializerDiagnosticAnalyzer()
            : base(ImmutableDictionary<DiagnosticDescriptor, IPerLanguageOption>.Empty
                    .Add(s_descriptor, CodeStyleOptions2.PreferObjectInitializer)
                    .Add(s_unnecessaryCodeDescriptor, CodeStyleOptions2.PreferObjectInitializer))
        {
        }

        protected abstract ISyntaxFacts GetSyntaxFacts();

        protected override void InitializeWorker(AnalysisContext context)
        {
            context.RegisterCompilationStartAction(context =>
            {
                if (!AreObjectInitializersSupported(context.Compilation))
                    return;

                var syntaxKinds = GetSyntaxFacts().SyntaxKinds;
                using var matchKinds = TemporaryArray<TSyntaxKind>.Empty;
                matchKinds.Add(syntaxKinds.Convert<TSyntaxKind>(syntaxKinds.ObjectCreationExpression));
                if (syntaxKinds.ImplicitObjectCreationExpression != null)
                    matchKinds.Add(syntaxKinds.Convert<TSyntaxKind>(syntaxKinds.ImplicitObjectCreationExpression.Value));

                context.RegisterSyntaxNodeAction(AnalyzeNode, matchKinds.ToImmutableAndClear());
            });
        }

        protected abstract bool AreObjectInitializersSupported(Compilation compilation);

        protected abstract bool IsValidContainingStatement(TStatementSyntax node);

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var objectCreationExpression = (TObjectCreationExpressionSyntax)context.Node;
            var language = objectCreationExpression.Language;
            var option = context.GetAnalyzerOptions().PreferObjectInitializer;
            if (!option.Value)
            {
                // not point in analyzing if the option is off.
                return;
            }

            var syntaxFacts = GetSyntaxFacts();
            var matches = UseNamedMemberInitializerAnalyzer<TExpressionSyntax, TStatementSyntax, TObjectCreationExpressionSyntax, TMemberAccessExpressionSyntax, TAssignmentStatementSyntax, TVariableDeclaratorSyntax>.Analyze(
                context.SemanticModel, syntaxFacts, objectCreationExpression, context.CancellationToken);

            if (matches == null || matches.Value.Length == 0)
                return;

            var containingStatement = objectCreationExpression.FirstAncestorOrSelf<TStatementSyntax>();
            if (containingStatement == null)
                return;

            if (!IsValidContainingStatement(containingStatement))
                return;

            var nodes = ImmutableArray.Create<SyntaxNode>(containingStatement).AddRange(matches.Value.Select(m => m.Statement));
            if (syntaxFacts.ContainsInterleavedDirective(nodes, context.CancellationToken))
                return;

            var locations = ImmutableArray.Create(objectCreationExpression.GetLocation());

            context.ReportDiagnostic(DiagnosticHelper.Create(
                s_descriptor,
                objectCreationExpression.GetFirstToken().GetLocation(),
                option.Notification.Severity,
                locations,
                properties: null));

            FadeOutCode(context, matches.Value, locations);
        }

        private void FadeOutCode(
            SyntaxNodeAnalysisContext context,
            ImmutableArray<Match<TExpressionSyntax, TStatementSyntax, TMemberAccessExpressionSyntax, TAssignmentStatementSyntax>> matches,
            ImmutableArray<Location> locations)
        {
            var syntaxTree = context.Node.SyntaxTree;

            var syntaxFacts = GetSyntaxFacts();

            foreach (var match in matches)
            {
                var end = FadeOutOperatorToken
                    ? syntaxFacts.GetOperatorTokenOfMemberAccessExpression(match.MemberAccessExpression).Span.End
                    : syntaxFacts.GetExpressionOfMemberAccessExpression(match.MemberAccessExpression)!.Span.End;

                var location1 = Location.Create(syntaxTree, TextSpan.FromBounds(
                    match.MemberAccessExpression.SpanStart, end));

                if (match.Statement.Span.End > match.Initializer.FullSpan.End)
                {
                    context.ReportDiagnostic(DiagnosticHelper.CreateWithLocationTags(
                        s_unnecessaryCodeDescriptor,
                        location1,
                        ReportDiagnostic.Default,
                        additionalLocations: locations,
                        additionalUnnecessaryLocations: ImmutableArray.Create(
                            syntaxTree.GetLocation(TextSpan.FromBounds(match.Initializer.FullSpan.End, match.Statement.Span.End)))));
                }
                else
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        s_unnecessaryCodeDescriptor, location1, additionalLocations: locations));
                }
            }
        }

        public override DiagnosticAnalyzerCategory GetAnalyzerCategory()
            => DiagnosticAnalyzerCategory.SemanticSpanAnalysis;
    }
}
