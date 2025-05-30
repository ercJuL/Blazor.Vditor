namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

public partial class Vditor
{
    public Dictionary<string, Func<string, Task>> PreviewActionCallbackMap = new();

    // [Parameter]
    public Func<Task>? PreviewParseCallback { get; set; }

    // [Parameter]
    public Func<string, Task<string>>? PreviewTransformCallback { get; set; }

    [JSInvokable("InvokePreviewActionCallback")]
    public async Task InvokePreviewActionCallback(string key)
    {
        if (this.PreviewActionCallbackMap.TryGetValue(key, out var callback))
        {
            await callback.Invoke(key);
        }
    }

    [JSInvokable("InvokePreviewParse")]
    public async Task InvokePreviewParse()
    {
        if (this.PreviewParseCallback is not null)
        {
            await this.PreviewParseCallback.Invoke();
        }
    }

    [JSInvokable("InvokePreviewTransform")]
    public async Task<string> InvokePreviewTransform(string html)
    {
        if (this.PreviewTransformCallback is not null)
        {
            return await this.PreviewTransformCallback.Invoke(html);
        }

        return html;
    }
}
