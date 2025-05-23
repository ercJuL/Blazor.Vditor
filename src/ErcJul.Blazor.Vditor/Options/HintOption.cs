namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the configuration options for hints in the Vditor editor.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-hint">vditor.options-hint</see>.
/// </remarks>
public class HintOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether parsing is enabled.
    /// </summary>
    [JsonPropertyName("parse")]
    public bool? Parse { get; set; }

    /// <summary>
    ///     Gets or sets the text to append to emoji hints.
    /// </summary>
    [JsonPropertyName("emojiTail")]
    public string? EmojiTail { get; set; }

    /// <summary>
    ///     Gets or sets the delay time for displaying hints.
    /// </summary>
    /// <remarks>
    ///     The default value is 200 microseconds.
    /// </remarks>
    [JsonPropertyName("delay")]
    public TimeSpan? Delay { get; set; }

    /// <summary>
    ///     Gets or sets the dictionary of emoji hints.
    /// </summary>
    [JsonPropertyName("emoji")]
    public Dictionary<string, string>? Emoji { get; set; }

    /// <summary>
    ///     Gets or sets the path to the emoji images.
    /// </summary>
    /// <remarks>
    ///     The default value is "https://unpkg.com/vditor@${VDITOR_VERSION}/dist/images/emoji".
    /// </remarks>
    [JsonPropertyName("emojiPath")]
    public string? EmojiPath { get; set; }

    /// <summary>
    ///     Gets or sets the list of extended hint options.
    /// </summary>
    [JsonPropertyName("extend")]
    public List<HintExtendOption>? Extend { get; set; } = new();
}
