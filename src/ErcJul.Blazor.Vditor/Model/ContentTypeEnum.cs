// <copyright file="ContentTypeEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Defines the types of content supported by the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ContentTypeEnum>))]
public enum ContentTypeEnum
{
    /// <summary>
    ///     Represents Markdown content type.
    /// </summary>
    [JsonStringEnumMemberName("markdown")]
    Markdown = 0,

    /// <summary>
    ///     Represents plain text content type.
    /// </summary>
    [JsonStringEnumMemberName("text")]
    Text = 1,
}
