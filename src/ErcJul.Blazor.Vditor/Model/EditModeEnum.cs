// <copyright file="EditModeEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Defines the editing modes available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EditModeEnum>))]
public enum EditModeEnum
{
    /// <summary>
    ///     Represents the WYSIWYG (What You See Is What You Get) editing mode.
    /// </summary>
    [JsonStringEnumMemberName("wysiwyg")]
    Wysiwyg = 0,

    /// <summary>
    ///     Represents the SV (Split View) editing mode.
    /// </summary>
    [JsonStringEnumMemberName("sv")]
    Sv = 1,

    /// <summary>
    ///     Represents the IR (Instant Rendering) editing mode.
    /// </summary>
    [JsonStringEnumMemberName("ir")]
    Ir = 2,
}
