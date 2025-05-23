namespace ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the data model for comments in the Vditor editor.
/// </summary>
public class CommentsData
{
    /// <summary>
    ///     Gets or sets the unique identifier for the comment.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the top position of the comment in pixels.
    /// </summary>
    public uint Top { get; set; }
}
