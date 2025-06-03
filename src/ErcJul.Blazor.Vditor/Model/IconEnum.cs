// <copyright file="IconEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the icon options available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<IconEnum>))]
public enum IconEnum
{
    /// <summary>
    ///     The Ant Design icon option.
    /// </summary>
    [JsonStringEnumMemberName("ant")]
    Antd = 0,

    /// <summary>
    ///     The Material Design icon option.
    /// </summary>
    [JsonStringEnumMemberName("material")]
    Material = 1,
}
