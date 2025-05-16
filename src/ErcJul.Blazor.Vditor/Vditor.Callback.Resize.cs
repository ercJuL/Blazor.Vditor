namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

public partial class Vditor
{
    // [Parameter]
    public Func<int, Task>? ResizeAfterCallback { get; set; }

    [JSInvokable("InvokeResizeAfter")]
    public async Task InvokeResizeAfter(int heightDelta)
    {
        if (this.ResizeAfterCallback is not null)
        {
            await this.ResizeAfterCallback.Invoke(heightDelta);
        }
    }
}
