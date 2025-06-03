// <copyright file="MathEngineEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the mathematical rendering engine options available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<MathEngineEnum>))]
public enum MathEngineEnum
{
    /// <summary>
    ///     Use KaTeX as the mathematical rendering engine.
    /// </summary>
    KaTeX,

    /// <summary>
    ///     Use MathJax as the mathematical rendering engine.
    /// </summary>
    MathJax,
}
