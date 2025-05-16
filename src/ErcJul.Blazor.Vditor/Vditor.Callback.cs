namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public partial class Vditor
{
    [Parameter]
    public EventCallback AfterCallback { get; set; }

    [Parameter]
    public EventCallback<string> InputCallback { get; set; }

    [Parameter]
    public EventCallback<string> FocusCallback { get; set; }

    [Parameter]
    public EventCallback<string> BlurCallback { get; set; }

    [Parameter]
    public EventCallback<KeyEvent> KeydownCallback { get; set; }

    [Parameter]
    public EventCallback<string> EscCallback { get; set; }

    [Parameter]
    public EventCallback<string> CtrlEnterCallback { get; set; }

    [Parameter]
    public EventCallback<string> SelectCallback { get; set; }

    [Parameter]
    public EventCallback UnSelectCallback { get; set; }

    [JSInvokable("InvokeAfter")]
    public async Task InvokeAfter()
    {
        await this.AfterCallback.InvokeAsync(this);
    }

    [JSInvokable("InvokeInput")]
    public async Task InvokeInput(string value)
    {
        await this.InputCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeFocus")]
    public async Task InvokeFocus(string value)
    {
        await this.FocusCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeBlur")]
    public async Task InvokeBlur(string value)
    {
        await this.BlurCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeKeydown")]
    public async Task InvokeKeydown(KeyEvent value)
    {
        await this.KeydownCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeEscape")]
    public async Task InvokeEscape(string value)
    {
        await this.EscCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeCtrlEnter")]
    public async Task InvokeCtrlEnter(string value)
    {
        await this.CtrlEnterCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeSelect")]
    public async Task InvokeSelect(string value)
    {
        await this.SelectCallback.InvokeAsync(value);
    }

    [JSInvokable("InvokeUnSelect")]
    public async Task InvokeUnSelect()
    {
        await this.UnSelectCallback.InvokeAsync();
    }
}
