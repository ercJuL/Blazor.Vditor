// <copyright file="ThemeEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the theme options available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ThemeEnum>))]
public enum ThemeEnum
{
    /// <summary>
    ///     The classic theme option.
    /// </summary>
    [JsonStringEnumMemberName("classic")]
    Classic = 0,

    /// <summary>
    ///     The dark theme option.
    /// </summary>
    [JsonStringEnumMemberName("dark")]
    Dark = 1,
}
