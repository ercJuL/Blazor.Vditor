// <copyright file="SpeechOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents the speech options for the Vditor editor.
/// </summary>
public class SpeechOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether speech functionality is enabled.
    ///     A null value indicates that the setting is not specified.
    /// </summary>
    public bool? Enable { get; set; }
}
