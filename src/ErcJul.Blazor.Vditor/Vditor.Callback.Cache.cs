namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

public partial class Vditor
{
    // [Parameter]
    public Func<string, Task>? CacheAfterCallback { get; set; }

    [JSInvokable("InvokeCacheAfter")]
    public async Task InvokeCacheAfter(string markdown)
    {
        if (this.CacheAfterCallback is not null)
        {
            await this.CacheAfterCallback.Invoke(markdown);
        }
    }
}
