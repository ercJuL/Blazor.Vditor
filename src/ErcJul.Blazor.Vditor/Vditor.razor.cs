namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Options;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public partial class Vditor : ComponentBase, IAsyncDisposable
{
    private ElementReference? refEditor;
    private IJSObjectReference? vditorDotNetModule;

    [Inject]
    private IJSRuntime JsRuntime { get; set; }

    [Parameter]
    public VditorOption VditorOption { get; set; } = new();

    public async ValueTask DisposeAsync()
    {
        if (this.vditorDotNetModule is not null)
        {
            try
            {
                await this.vditorDotNetModule.DisposeAsync();
            }
            catch (JSDisconnectedException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            foreach (var item in this.VditorOption.Toolbar ?? [])
            {
                item.Register(ref this.ToolbarCallbackMap);
            }

            this.ResizeAfterCallback = this.VditorOption.Resize?.After;
            this.CounterAfterCallback = this.VditorOption.Counter?.After;
            this.CacheAfterCallback = this.VditorOption.Cache?.After;

            // TODO Preview
            this.LinkClickCallback = this.VditorOption.Link?.Click;
            this.ImagePreviewCallback = this.VditorOption.Image?.Preview;

            // TODO Hint
            // TODO Comment
            // TODO Upload
            // TODO customRenders

            this.vditorDotNetModule = await this.JsRuntime.InvokeAsync<IJSObjectReference>(
                "import",
                "./_content/ErcJul.Blazor.Vditor/Vditor.razor.js");

            // this.VditorOption
            await this.vditorDotNetModule.InvokeVoidAsync(
                "initVditor",
                "ercjul.vditor",
                DotNetObjectReference.Create(this),
                this.VditorOption);
        }
    }
}
