// <copyright file="ResizePositionEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Defines the possible positions for resizing in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ResizePositionEnum>))]
public enum ResizePositionEnum
{
    /// <summary>
    ///     Represents the top position for resizing.
    /// </summary>
    [JsonStringEnumMemberName("top")]
    Top = 0,

    /// <summary>
    ///     Represents the bottom position for resizing.
    /// </summary>
    [JsonStringEnumMemberName("bottom")]
    Bottom = 1,
}
