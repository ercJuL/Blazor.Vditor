namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

public partial class Vditor
{
    public Dictionary<string, Action> ToolbarCallbackMap = new();

    [JSInvokable("InvokeToolbarCallback")]
    public async Task InvokeToolbarCallback(string id)
    {
        if (this.ToolbarCallbackMap.TryGetValue(id, out var callback))
        {
            callback.Invoke();
        }
    }
}
