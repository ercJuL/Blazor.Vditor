// <copyright file="HintData.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the data structure for hint information in the Vditor editor.
/// </summary>
public class HintData
{
    /// <summary>
    ///     Gets or sets the HTML content of the hint.
    /// </summary>
    public required string Html { get; set; }

    /// <summary>
    ///     Gets or sets the value associated with the hint.
    /// </summary>
    public required string Value { get; set; }
}
