// <copyright file="TooltipPositionEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the tooltip position options available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<TooltipPositionEnum>))]
public enum TooltipPositionEnum
{
    /// <summary>
    ///     The tooltip is positioned at the north (top).
    /// </summary>
    [JsonPropertyName("n")]
    North,

    /// <summary>
    ///     The tooltip is positioned at the northeast.
    /// </summary>
    [JsonPropertyName("ne")]
    NorthEast,

    /// <summary>
    ///     The tooltip is positioned at the east (right).
    /// </summary>
    [JsonPropertyName("e")]
    East,

    /// <summary>
    ///     The tooltip is positioned at the southeast.
    /// </summary>
    [JsonPropertyName("se")]
    SouthEast,

    /// <summary>
    ///     The tooltip is positioned at the south (bottom).
    /// </summary>
    [JsonPropertyName("s")]
    South,

    /// <summary>
    ///     The tooltip is positioned at the southwest.
    /// </summary>
    [JsonPropertyName("sw")]
    SouthWest,

    /// <summary>
    ///     The tooltip is positioned at the west (left).
    /// </summary>
    [JsonPropertyName("w")]
    West,

    /// <summary>
    ///     The tooltip is positioned at the northwest.
    /// </summary>
    [JsonPropertyName("nw")]
    NorthWest,
}
