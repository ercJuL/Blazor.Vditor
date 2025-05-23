namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the supported languages for the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<LanguageEnum>))]
public enum LanguageEnum
{
    /// <summary>
    ///     English language (en_US).
    /// </summary>
    [JsonStringEnumMemberName("en_US")]
    English = 0,

    /// <summary>
    ///     Japanese language (ja_JP).
    /// </summary>
    [JsonStringEnumMemberName("ja_JP")]
    Japanese = 1,

    /// <summary>
    ///     Korean language (ko_KR).
    /// </summary>
    [JsonStringEnumMemberName("ko_KR")]
    Korean = 2,

    /// <summary>
    ///     Russian language (ru_RU).
    /// </summary>
    [JsonStringEnumMemberName("ru_RU")]
    Russian = 3,

    /// <summary>
    ///     Simplified Chinese language (zh_CN).
    /// </summary>
    [JsonStringEnumMemberName("zh_CN")]
    SimplifiedChinese = 4,

    /// <summary>
    ///     Traditional Chinese language (zh_TW).
    /// </summary>
    [JsonStringEnumMemberName("zh_TW")]
    TraditionalChinese = 5,
}
