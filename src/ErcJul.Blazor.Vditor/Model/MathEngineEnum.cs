namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter<LanguageEnum>))]
public enum MathEngineEnum
{
    KaTeX,
    MathJax,
}
