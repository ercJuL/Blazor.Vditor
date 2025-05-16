namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Options;
using Microsoft.JSInterop;

public partial class Vditor
{
    // [Parameter]
    public Func<uint, CounterOption, Task>? CounterAfterCallback { get; set; }

    [JSInvokable("InvokeCounterAfter")]
    public async Task InvokeCounterAfter(uint length, CounterOption counter)
    {
        if (this.CounterAfterCallback is not null)
        {
            await this.CounterAfterCallback.Invoke(length, counter);
        }
    }
}
