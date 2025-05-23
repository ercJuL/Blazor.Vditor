namespace ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents the configuration options for Markdown rendering in the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-preview-markdown">vditor.options-preview-markdown</see>.
/// </remarks>
public class MarkdownConfig
{
    /// <summary>
    ///     Gets or sets a value indicating whether to automatically add spaces between Chinese and English or numbers.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>.
    /// </remarks>
    public bool? AutoSpace { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to add a space at the beginning of a paragraph.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>.
    /// </remarks>
    public bool? ParagraphBeginningSpace { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to fix common term typos.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>.
    /// </remarks>
    public bool? FixTermTypo { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable the Table of Contents (TOC) feature.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>. Set to <c>true</c> to enable the TOC feature.
    /// </remarks>
    public bool? Toc { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable footnotes in Markdown.
    /// </summary>
    /// <remarks>
    ///     Default is <c>true</c>.
    /// </remarks>
    public bool? Footnotes { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable code block previews in WYSIWYG or IR edit type.
    /// </summary>
    /// <remarks>
    ///     Default is <c>true</c>.
    /// </remarks>
    public bool? CodeBlockPreview { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable math block previews in WYSIWYG or IR edit type.
    /// </summary>
    /// <remarks>
    ///     Default is <c>true</c>.
    /// </remarks>
    public bool? MathBlockPreview { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to filter XSS content.
    /// </summary>
    /// <remarks>
    ///     Default is <c>true</c>.
    /// </remarks>
    public bool? Sanitize { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable the base URL for links.
    /// </summary>
    /// <remarks>
    ///     Default is <c>string.Empty</c>.
    /// </remarks>
    public string? LinkBase { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable a prefix for links.
    /// </summary>
    /// <remarks>
    ///     Default is <c>string.Empty</c>.
    /// </remarks>
    public string? LinkPrefix { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable custom list styles.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>. Set to <c>true</c> to enable custom list styles.
    ///     see <see href="https://github.com/Vanessa219/vditor/issues/390" />.
    /// </remarks>
    public bool? ListStyle { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable the mark syntax.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>.
    /// </remarks>
    public bool? Mark { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether to enable GitHub Flavored Markdown (GFM) auto-linking.
    /// </summary>
    /// <remarks>
    ///     Default is <c>true</c>.
    /// </remarks>
    public bool? GfmAutoLink { get; set; }
}
