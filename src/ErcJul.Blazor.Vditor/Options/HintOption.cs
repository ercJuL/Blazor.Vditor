namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Utils;

public class HintOption
{
    [JsonPropertyName("parse")]
    public bool? Parse { get; set; }

    [JsonPropertyName("emojiTail")]
    public string? EmojiTail { get; set; }

    [JsonPropertyName("delay")]
    public TimeSpan? Delay { get; set; } = TimeSpan.FromMicroseconds(200);

    [JsonPropertyName("emoji")]
    public Dictionary<string, string>? Emoji { get; set; }

    [JsonPropertyName("emojiPath")]
    public string? EmojiPath { get; set; } = $"https://unpkg.com/vditor@{Constant.VditorVersion}/dist/images/emoji";

//[JsonPropertyName("extend")]
    // public List<HintExtendOption>? Extend { get; set; } = new();
}
