namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class LanguageEnum : Enumeration
// {
//     public static LanguageEnum English = new(0, "en_US");
//     public static LanguageEnum Japanese = new(1, "ja_JP");
//     public static LanguageEnum Korean = new(2, "ko_KR");
//     public static LanguageEnum Russian = new(3, "ru_RU");
//     public static LanguageEnum SimplifiedChinese = new(4, "zh_CN");
//     public static LanguageEnum TraditionalChinese = new(5, "zh_TW");
//
//     public LanguageEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<LanguageEnum>))]
public enum LanguageEnum
{
    [JsonStringEnumMemberName("en_US")] English = 0,
    [JsonStringEnumMemberName("ja_JP")] Japanese = 1,
    [JsonStringEnumMemberName("ko_KR")] Korean = 2,
    [JsonStringEnumMemberName("ru_RU")] Russian = 3,
    [JsonStringEnumMemberName("zh_CN")] SimplifiedChinese = 4,
    [JsonStringEnumMemberName("zh_TW")] TraditionalChinese = 5,
}
