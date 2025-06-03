// <copyright file="OutlinePositionEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the position options for the outline feature in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<OutlinePositionEnum>))]
public enum OutlinePositionEnum
{
    /// <summary>
    ///     The outline is positioned on the left side of the editor.
    /// </summary>
    [JsonStringEnumMemberName("left")]
    Left = 0,

    /// <summary>
    ///     The outline is positioned on the right side of the editor.
    /// </summary>
    [JsonStringEnumMemberName("right")]
    Right = 1,
}
