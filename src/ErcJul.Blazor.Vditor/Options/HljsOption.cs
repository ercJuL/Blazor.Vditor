namespace ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents the configuration options for the Highlight.js integration in the Vditor editor.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-preview-hljs">vditor.options-preview-hljs</see>.
/// </remarks>
public class HljsOption
{
    /// <summary>
    ///     Gets or sets the default language for syntax highlighting.
    /// </summary>
    public string? DefaultLang { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether line numbers should be displayed.
    /// </summary>
    public bool? LineNumber { get; set; }

    /// <summary>
    ///     Gets or sets the style to be used for syntax highlighting.
    /// </summary>
    public string? Style { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether Highlight.js is enabled.
    /// </summary>
    public bool? Enable { get; set; }

    /// <summary>
    ///     Gets or sets the collection of supported languages for syntax highlighting.
    /// </summary>
    public IEnumerable<string>? Langs { get; set; }

    // TODO renderMenu
}
