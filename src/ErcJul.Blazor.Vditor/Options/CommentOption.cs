namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the configuration options for comments in the Vditor editor.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-comment">vditor.options-comment</see>.
/// </remarks>
public class CommentOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether comments are enabled.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>. Set to <c>true</c> to enable comments in the editor.
    /// </remarks>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    ///     Gets or sets the action to add a comment with specified parameters.
    /// </summary>
    [JsonIgnore]
    public Func<string, string, List<CommentsData>, Task>? Add { get; set; }

    /// <summary>
    ///     Gets or sets the action to remove comments based on a list of identifiers.
    /// </summary>
    [JsonIgnore]
    public Func<List<string>, Task>? Remove { get; set; }

    /// <summary>
    ///     Gets or sets the action to scroll to a specific comment by its identifier.
    /// </summary>
    [JsonIgnore]
    public Func<uint, Task>? Scroll { get; set; }

    /// <summary>
    ///     Gets or sets the action to adjust the top position of comme
    /// </summary>
    [JsonIgnore]
    public Func<List<CommentsData>, Task>? AdjustTop { get; set; }
}
