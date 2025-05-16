namespace ErcJul.Blazor.Vditor.Options;

public class HljsOption
{
    public string? DefaultLang { get; set; }

    public bool? LineNumber { get; set; }

    public string? Style { get; set; }

    public bool? Enable { get; set; }

    public IEnumerable<string>? Langs { get; set; }

    // TODO renderMenu
}
