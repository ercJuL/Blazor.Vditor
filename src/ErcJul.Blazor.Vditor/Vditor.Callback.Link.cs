namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

public partial class Vditor
{
    // [Parameter]
    public Func<Task>? LinkClickCallback { get; set; }

    [JSInvokable("InvokeLinkClick")]
    public async Task InvokeLinkClick()
    {
        if (this.LinkClickCallback is not null)
        {
            await this.LinkClickCallback.Invoke();
        }
    }
}
