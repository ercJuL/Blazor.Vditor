// <copyright file="FullScreenOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the configuration options for enabling fullscreen mode in the Vditor editor.
/// </summary>
public class FullScreenOption
{
    /// <summary>
    ///     Gets or sets the index value for the fullscreen option.
    /// </summary>
    /// <remarks>
    ///     The default value is 90, which specifies the priority or order of the fullscreen option.
    /// </remarks>
    [JsonPropertyName("index")]
    public uint Index { get; set; } = 90;
}
