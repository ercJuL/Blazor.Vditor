namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

public partial class Vditor
{
    // [Parameter]
    public Func<Task>? ImagePreviewCallback { get; set; }

    [JSInvokable("InvokeImagePreview")]
    public async Task InvokeImagePreview()
    {
        if (this.ImagePreviewCallback is not null)
        {
            await this.ImagePreviewCallback.Invoke();
        }
    }
}
