namespace ErcJul.Blazor.Vditor.Options;

using ErcJul.Blazor.Vditor.Model;

public class VditorReadonlyOption
{
    public ReadonlyModeEnum Mode { get; set; }

    public Dictionary<string, string>? CustomEmoji { get; set; }

    public LanguageEnum? Language { get; set; }

    public I18nOption? I18n { get; set; }

    public string? LazyLoadImage { get; set; }

    public string EmojiPath { get; set; }

    public HljsOption? Hljs { get; set; }

    public SpeechOption? Speech { get; set; }

    public AnchorEnum? Anchor { get; set; }

    public MathOption? Math { get; set; }

    public string? Cdn { get; set; }

    public MarkdownConfig? Markdown { get; set; }

    // TODO renderers
    public PreviewThemeOption? Theme { get; set; }

    public IconEnum? Icon { get; set; }

    //TODO render
    public Action<string>? Transform { get; set; }

    public Action? After { get; set; }
}
