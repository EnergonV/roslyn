﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.AutomaticCompletion;
using Microsoft.CodeAnalysis.Editor.UnitTests.AutomaticCompletion;
using Microsoft.CodeAnalysis.Editor.UnitTests.Workspaces;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using static Microsoft.CodeAnalysis.BraceCompletion.AbstractBraceCompletionService;

namespace Microsoft.CodeAnalysis.Editor.CSharp.UnitTests.AutomaticCompletion
{
    public class AutomaticParenthesisCompletionTests : AbstractAutomaticBraceCompletionTests
    {
        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void Creation()
        {
            using var session = CreateSession("$$");
            Assert.NotNull(session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void String1()
        {
            var code = @"class C
{
    void Method()
    {
        var s = """"$$
    }
}";
            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void String2()
        {
            var code = @"class C
{
    void Method()
    {
        var s = @""""$$
    }
}";
            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void ParameterList_OpenParenthesis()
        {
            var code = @"class C
{
    void Method$$
}";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void ParameterList_OpenParenthesis_Delete()
        {
            var code = @"class C
{
    void Method$$
}";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
            CheckBackspace(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void ParameterList_OpenParenthesis_Tab()
        {
            var code = @"class C
{
    void Method$$
}";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
            CheckTab(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void ParameterList_OpenParenthesis_CloseParenthesis()
        {
            var code = @"class C
{
    void Method$$
}";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
            CheckOverType(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void Argument()
        {
            var code = @"class C 
{
    void Method()
    {
        Method$$
    }
}";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void Argument_Invalid()
        {
            var code = @"class C 
{
    void Method()
    {
        Method($$)
    }
}";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
        }

        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void Array_Nested()
        {
            var code = @"class C
{
    int Method(int i)
    {
        Method(Method$$)
    }
}";
            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session);
        }

        [WorkItem(546337, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/546337")]
        [WpfFact, Trait(Traits.Feature, Traits.Features.AutomaticCompletion)]
        public void OpenParenthesisWithExistingCloseParen()
        {
            var code = @"class A
{
    public A(int a, int b) { }

    public static A Create()
    {
        return new A$$
            0, 0);
    }
}
";

            using var session = CreateSession(code);
            Assert.NotNull(session);
            CheckStart(session.Session, expectValidSession: false);
        }

        internal static Holder CreateSession(string code)
        {
            return CreateSession(
                TestWorkspace.CreateCSharp(code),
                Parenthesis.OpenCharacter, Parenthesis.CloseCharacter);
        }
    }
}
