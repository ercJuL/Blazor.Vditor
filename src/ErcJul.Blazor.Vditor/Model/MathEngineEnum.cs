namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the mathematical rendering engine options available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<LanguageEnum>))]
public enum MathEngineEnum
{
    /// <summary>
    ///     Use KaTeX as the mathematical rendering engine.
    /// </summary>
    KaTeX,

    /// <summary>
    ///     Use MathJax as the mathematical rendering engine.
    /// </summary>
    MathJax,
}
