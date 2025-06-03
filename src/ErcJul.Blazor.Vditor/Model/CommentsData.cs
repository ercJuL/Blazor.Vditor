// <copyright file="CommentsData.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the data model for comments in the Vditor editor.
/// </summary>
public class CommentsData
{
    /// <summary>
    ///     Gets or sets the unique identifier for the comment.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the top position of the comment in pixels.
    /// </summary>
    public uint Top { get; set; }
}
