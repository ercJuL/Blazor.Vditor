namespace ErcJul.Blazor.Vditor.Model;

public record KeyEvent
{
    public bool IsTrusted { get; set; }

    public bool AltKey { get; set; }

    public bool Bubbles { get; set; }

    public string Code { get; set; }

    public bool CtrlKey { get; set; }

    public bool IsComposing { get; set; }

    public string Key { get; set; }

    public int Location { get; set; }

    public bool MetaKey { get; set; }

    public bool Repeat { get; set; }

    public bool ShiftKey { get; set; }

    public double TimeStamp { get; set; }
}
