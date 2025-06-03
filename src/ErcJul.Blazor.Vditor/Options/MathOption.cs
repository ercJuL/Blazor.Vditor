// <copyright file="MathOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the configuration options for mathematical rendering in the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-preview-math">vditor.options-preview-math</see>.
/// </remarks>
public class MathOption
{
    // TODO: Add documentation for the Macros property when it is implemented.
    // public object Macros { get; set; }

    /// <summary>
    ///     Gets or sets the math rendering engine to be used.
    /// </summary>
    /// <remarks>
    ///     The default is <see cref="MathEngineEnum.KaTeX" />, which means that the engine will be automatically detected.
    /// </remarks>
    public MathEngineEnum? Engine { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether numbers are allowed after the start '$' of the inline mathematical formula.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>.
    /// </remarks>
    public bool? InlineDigit { get; set; }

    // TODO: Add documentation for the MathJaxOptions property when it is implemented.
    // public any? MathJaxOptions { get; set; }
}
