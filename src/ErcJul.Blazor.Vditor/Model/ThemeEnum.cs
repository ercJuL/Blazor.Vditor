namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class ThemeEnum : Enumeration
// {
//     public static ThemeEnum Classic = new(0, "classic");
//     public static ThemeEnum Dark = new(1, "dark");
//
//     public ThemeEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }

[JsonConverter(typeof(JsonStringEnumConverter<ThemeEnum>))]
public enum ThemeEnum
{
    [JsonStringEnumMemberName("classic")] Classic = 0,
    [JsonStringEnumMemberName("dark")] Dark = 1,
}
