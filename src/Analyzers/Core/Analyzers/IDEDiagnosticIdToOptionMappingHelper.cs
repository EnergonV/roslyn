﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    /// <summary>
    /// Helper type to map <see cref="IDEDiagnosticIds"/> to an unique editorconfig code style option, if any,
    /// such that diagnostic's severity can be configured in .editorconfig with an entry such as:
    ///     "%option_name% = %option_value%:%severity%
    /// </summary>
    internal static class IDEDiagnosticIdToOptionMappingHelper
    {
        private static readonly ConcurrentDictionary<string, ImmutableHashSet<IOption2>> s_diagnosticIdToOptionMap = new();
        private static readonly ConcurrentDictionary<string, ConcurrentDictionary<string, ImmutableHashSet<IOption2>>> s_diagnosticIdToLanguageSpecificOptionsMap = new();
        private static readonly ConcurrentDictionary<string, PerLanguageOption2<bool>> s_diagnosticIdToFadingOptionMap = new();

        public static bool TryGetMappedOptions(string diagnosticId, string language, [NotNullWhen(true)] out ImmutableHashSet<IOption2>? options)
            => s_diagnosticIdToOptionMap.TryGetValue(diagnosticId, out options) ||
               (s_diagnosticIdToLanguageSpecificOptionsMap.TryGetValue(language, out var map) &&
                map.TryGetValue(diagnosticId, out options));

        public static bool TryGetMappedFadingOption(string diagnosticId, [NotNullWhen(true)] out PerLanguageOption2<bool>? fadingOption)
            => s_diagnosticIdToFadingOptionMap.TryGetValue(diagnosticId, out fadingOption);

        public static bool IsKnownIDEDiagnosticId(string diagnosticId)
            => s_diagnosticIdToOptionMap.ContainsKey(diagnosticId) ||
               s_diagnosticIdToLanguageSpecificOptionsMap.Values.Any(map => map.ContainsKey(diagnosticId));

        public static void AddOptionMapping(string diagnosticId, ImmutableHashSet<IPerLanguageOption> perLanguageOptions)
        {
            diagnosticId = diagnosticId ?? throw new ArgumentNullException(nameof(diagnosticId));
            perLanguageOptions = perLanguageOptions ?? throw new ArgumentNullException(nameof(perLanguageOptions));

            var options = perLanguageOptions.Cast<IOption2>().ToImmutableHashSet();
            AddOptionMapping(s_diagnosticIdToOptionMap, diagnosticId, options);
        }

        public static void AddOptionMapping(string diagnosticId, ImmutableHashSet<ILanguageSpecificOption> languageSpecificOptions, string language)
        {
            diagnosticId = diagnosticId ?? throw new ArgumentNullException(nameof(diagnosticId));
            languageSpecificOptions = languageSpecificOptions ?? throw new ArgumentNullException(nameof(languageSpecificOptions));
            language = language ?? throw new ArgumentNullException(nameof(language));

            var map = s_diagnosticIdToLanguageSpecificOptionsMap.GetOrAdd(language, _ => new ConcurrentDictionary<string, ImmutableHashSet<IOption2>>());
            var options = languageSpecificOptions.Cast<IOption2>().ToImmutableHashSet();
            AddOptionMapping(map, diagnosticId, options);
        }

        private static void AddOptionMapping(ConcurrentDictionary<string, ImmutableHashSet<IOption2>> map, string diagnosticId, ImmutableHashSet<IOption2> options)
        {
            // Verify that the option is either being added for the first time, or the existing option is already the same.
            // Latter can happen in tests as we re-instantiate the analyzer for every test, which attempts to add the mapping every time.
            Debug.Assert(!map.TryGetValue(diagnosticId, out var existingOptions) || options.SetEquals(existingOptions));

            map.TryAdd(diagnosticId, options);
        }

        public static void AddFadingOptionMapping(string diagnosticId, PerLanguageOption2<bool> fadingOption)
        {
            diagnosticId = diagnosticId ?? throw new ArgumentNullException(nameof(diagnosticId));
            fadingOption = fadingOption ?? throw new ArgumentNullException(nameof(fadingOption));

            // Verify that the option is either being added for the first time, or the existing option is already the same.
            // Latter can happen in tests as we re-instantiate the analyzer for every test, which attempts to add the mapping every time.
            Debug.Assert(!s_diagnosticIdToFadingOptionMap.TryGetValue(diagnosticId, out var existingOption) || existingOption.Equals(fadingOption));

            s_diagnosticIdToFadingOptionMap.TryAdd(diagnosticId, fadingOption);
        }
    }
}
