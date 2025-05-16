// https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types#implement-an-enumeration-base-class
namespace ErcJul.Blazor.Vditor.Utils;

using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

public abstract class Enumeration : IComparable
{
    protected Enumeration(int id, string name)
    {
        (this.Id, this.Name) = (id, name);
    }

    public string Name { get; }

    public int Id { get; }

    public int CompareTo(object other) => this.Id.CompareTo(((Enumeration)other).Id);

    public override string ToString() => this.Name;

    public override bool Equals(object obj)
    {
        if (obj is not Enumeration otherValue)
        {
            return false;
        }

        var typeMatches = this.GetType() == obj.GetType();
        var valueMatches = this.Id.Equals(otherValue.Id);

        return typeMatches && valueMatches;
    }

    public static IEnumerable<T> GetAll<T>()
        where T : Enumeration
        => typeof(T).GetFields(
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly)
            .Select(f => f.GetValue(null))
            .Cast<T>();
}

public class EnumerationFactoryConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsSubclassOf(typeof(Enumeration));

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converter = (JsonConverter)Activator.CreateInstance(
            typeof(EnumerationConverterInner<>).MakeGenericType(typeToConvert),
            BindingFlags.Instance | BindingFlags.Public,
            null,
            [options],
            null)!;

        return converter;
    }

    private class EnumerationConverterInner<T> : JsonConverter<T>
        where T : Enumeration
    {
        public override T Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return Enumeration.GetAll<T>().FirstOrDefault(e => e.Name == value) ??
                   throw new ArgumentException($"'{value}' is not a valid {typeof(T).Name} enumeration value.");
        }

        public override void Write(
            Utf8JsonWriter writer,
            T enumeration,
            JsonSerializerOptions options) =>
            writer.WriteStringValue(enumeration.ToString());
    }
}
