﻿// <copyright file="FhirPackageUtils.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft.Health.Fhir.CodeGenCommon.Packaging;

public static partial class FhirPackageUtils
{

    /// <summary>Test if a name matches known core packages.</summary>
    /// <returns>A RegEx.</returns>
    [GeneratedRegex("^hl7\\.fhir\\.r\\d+[A-Za-z]?\\.(core|expansions|examples|search|elements|corexml)$")]
    public static partial Regex MatchCorePackageNames();

    /// <summary>
    /// Gets the regular expression for matching known core package names.
    /// </summary>
    /// <returns>A regular expression.</returns>
    private static Regex _matchCorePackageNames = MatchCorePackageNames();

    public static bool PackageIsFhirCore(string packageName)
    {
        string name = packageName.Contains('#')
            ? packageName.Substring(0, packageName.IndexOf('#'))
            : packageName;

        return _matchCorePackageNames.IsMatch(name);
    }
}
