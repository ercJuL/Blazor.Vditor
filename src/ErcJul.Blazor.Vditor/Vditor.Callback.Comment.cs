// <copyright file="Vditor.Callback.Comment.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Model;
using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for comment-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked when a comment is added.
    /// </summary>
    private Func<string, string, List<CommentsData>, Task>? CommentAddCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to adjust the top position of comments.
    /// </summary>
    private Func<List<CommentsData>, Task>? CommentAdjustTopCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when comments are removed.
    /// </summary>
    private Func<List<string>, Task>? CommentRemoveCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to handle scrolling to a specific comment position.
    /// </summary>
    private Func<uint, Task>? CommentScrollCallback { get; set; }

    /// <summary>
    ///     Invokes the callback function for adding a comment.
    /// </summary>
    /// <param name="id">The ID of the comment.</param>
    /// <param name="text">The text of the comment.</param>
    /// <param name="comments">The list of existing comments.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCommentAdd")]
    public async Task InvokeCommentAdd(string id, string text, List<CommentsData> comments)
    {
        if (this.CommentAddCallback is not null)
        {
            await this.CommentAddCallback.Invoke(id, text, comments);
        }
    }

    /// <summary>
    ///     Invokes the callback function to adjust the top position of comments.
    /// </summary>
    /// <param name="comments">The list of comments to adjust.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCommentAdjustTop")]
    public async Task InvokeCommentAdjustTop(List<CommentsData> comments)
    {
        if (this.CommentAdjustTopCallback is not null)
        {
            await this.CommentAdjustTopCallback.Invoke(comments);
        }
    }

    /// <summary>
    ///     Invokes the callback function for removing comments.
    /// </summary>
    /// <param name="ids">The list of IDs of comments to remove.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCommentRemove")]
    public async Task InvokeCommentRemove(List<string> ids)
    {
        if (this.CommentRemoveCallback is not null)
        {
            await this.CommentRemoveCallback.Invoke(ids);
        }
    }

    /// <summary>
    ///     Invokes the callback function for scrolling to a specific comment position.
    /// </summary>
    /// <param name="top">The top position to scroll to.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCommentScroll")]
    public async Task InvokeCommentScroll(uint top)
    {
        if (this.CommentScrollCallback is not null)
        {
            await this.CommentScrollCallback.Invoke(top);
        }
    }
}
