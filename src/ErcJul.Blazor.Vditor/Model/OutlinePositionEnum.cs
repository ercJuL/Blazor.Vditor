namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class OutlinePositionEnum : Enumeration
// {
//     public static OutlinePositionEnum Left = new(0, "left");
//     public static OutlinePositionEnum Right = new(1, "right");
//
//     public OutlinePositionEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<OutlinePositionEnum>))]
public enum OutlinePositionEnum
{
    [JsonStringEnumMemberName("left")] Left = 0,
    [JsonStringEnumMemberName("right")] Right = 1,
}
