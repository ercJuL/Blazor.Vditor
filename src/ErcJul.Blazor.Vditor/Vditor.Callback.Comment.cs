namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Model;
using Microsoft.JSInterop;

public partial class Vditor
{
    // [Parameter]
    public Func<string, string, List<CommentsData>, Task>? CommentAddCallback { get; set; }

    public Func<List<string>, Task>? CommentRemoveCallback { get; set; }

    public Func<uint, Task>? CommentScrollCallback { get; set; }

    public Func<List<CommentsData>, Task>? CommentAdjustTopCallback { get; set; }

    [JSInvokable("InvokeCommentAdd")]
    public async Task InvokeCommentAdd(string id, string text, List<CommentsData> comments)
    {
        if (this.CommentAddCallback is not null)
        {
            await this.CommentAddCallback.Invoke(id, text, comments);
        }
    }

    [JSInvokable("InvokeCommentRemove")]
    public async Task InvokeCommentRemove(List<string> ids)
    {
        if (this.CommentRemoveCallback is not null)
        {
            await this.CommentRemoveCallback.Invoke(ids);
        }
    }

    [JSInvokable("InvokeCommentScroll")]
    public async Task InvokeCommentScroll(uint top)
    {
        if (this.CommentScrollCallback is not null)
        {
            await this.CommentScrollCallback.Invoke(top);
        }
    }

    [JSInvokable("InvokeCommentAdjustTop")]
    public async Task InvokeCommentAdjustTop(List<CommentsData> comments)
    {
        if (this.CommentAdjustTopCallback is not null)
        {
            await this.CommentAdjustTopCallback.Invoke(comments);
        }
    }
}
