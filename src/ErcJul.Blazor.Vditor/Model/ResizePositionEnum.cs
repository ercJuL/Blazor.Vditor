namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class ResizePositionEnum : Enumeration
// {
//     public static ResizePositionEnum Top = new(0, "top");
//     public static ResizePositionEnum Bottom = new(1, "bottom");
//
//     protected ResizePositionEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<ResizePositionEnum>))]
public enum ResizePositionEnum
{
    [JsonStringEnumMemberName("top")] Top = 0,
    [JsonStringEnumMemberName("bottom")] Bottom = 1,
}
