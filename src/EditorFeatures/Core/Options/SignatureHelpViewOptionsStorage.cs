﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Editor.Options;

internal sealed class SignatureHelpViewOptionsStorage
{
    private const string FeatureName = "SignatureHelpOptions";

    public static readonly PerLanguageOption2<bool> ShowSignatureHelp = new(
        FeatureName, "ShowSignatureHelp", defaultValue: true, new LocalClientSettingsStorageLocation("TextEditor.%LANGUAGE%.Auto List Params"));
}
