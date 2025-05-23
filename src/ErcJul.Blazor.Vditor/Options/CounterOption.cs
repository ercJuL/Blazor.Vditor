namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the configuration options for the counter in the Vditor editor.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-counter">vditor.options-counter</see>.
/// </remarks>
public class CounterOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether the counter is enabled.
    /// </summary>
    /// <remarks>
    ///     If set to <c>true</c>, the counter is enabled. Defaults to <c>false</c>.
    /// </remarks>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }

    /// <summary>
    ///     Gets or sets the maximum value for the counter.
    /// </summary>
    /// <remarks>
    ///     If not specified, there is no maximum limit.
    /// </remarks>
    [JsonPropertyName("max")]
    public uint? Max { get; set; }

    /// <summary>
    ///     Gets or sets the type of content to be counted.
    /// </summary>
    /// <remarks>
    ///     This specifies the type of content the counter will track, such as characters or words.
    /// </remarks>
    [JsonPropertyName("type")]
    public ContentTypeEnum? Type { get; set; }

    /// <summary>
    ///     Gets or sets a callback function to be executed after the counter updates.
    /// </summary>
    /// <remarks>
    ///     The function takes the current count and the <see cref="CounterOption" /> instance as parameters.
    /// </remarks>
    [JsonIgnore]
    public Func<uint, CounterOption, Task>? After { get; set; }
}
