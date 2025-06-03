// <copyright file="ReadonlyModeEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Defines the preview modes available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ReadonlyModeEnum>))]
public enum ReadonlyModeEnum
{
    /// <summary>
    ///     Represents the mode where both the editor and preview are displayed.
    /// </summary>
    Dark = 0,

    /// <summary>
    ///     Represents the mode where only the editor is displayed.
    /// </summary>
    Light = 1,
}
