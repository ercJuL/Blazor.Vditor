// <copyright file="OutLineOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the configuration options for the outline feature in the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-outline">vditor.options-outline</see>.
/// </remarks>
public class OutLineOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether the outline feature is enabled.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; } = false;

    /// <summary>
    ///     Gets or sets the position of the outline in the editor.
    /// </summary>
    [JsonPropertyName("position")]
    public OutlinePositionEnum Position { get; set; } = OutlinePositionEnum.Left;
}
