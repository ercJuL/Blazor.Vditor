namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

public class PreviewOption
{
    [JsonPropertyName("delay")]
    public TimeSpan? Delay { get; set; } = TimeSpan.FromSeconds(1);

    [JsonPropertyName("maxWidth")]
    public uint? MaxWidth { get; set; } = 768;

    [JsonPropertyName("mode")]
    public PreviewModeEnum? Mode { get; set; } = PreviewModeEnum.Both;

    [JsonPropertyName("url")]
    public string? url { get; set; }// TODO: 直接实现?

    public HljsOption? Hljs { get; set; }

    public MathOption? Math { get; set; }

    public MarkdownConfig? Markdown { get; set; }

    public PreviewThemeOption? Theme { get; set; }

    public List<Action<PreviewActionCustom>> Actions { get; set; } = new();

    // public TODO? Render { get; set; }

    [JsonIgnore]
    public Action? Parse { get; set; }//Action<ElementReference>

    [JsonIgnore]
    public Action<string>? Transform { get; set; }
}
