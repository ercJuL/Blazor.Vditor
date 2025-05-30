namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Model;
using Microsoft.JSInterop;

public partial class Vditor
{
    public Dictionary<string, Func<string, Task<List<HintData>>>> HintCallbackMap = new();

    [JSInvokable("InvokeHintCallback")]
    public async Task InvokeHintCallback(string id, string value)
    {
        if (this.HintCallbackMap.TryGetValue(id, out var callback))
        {
            await callback.Invoke(value);
        }
    }
}
