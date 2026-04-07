using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateMakeToolDtoTypeSerializer))]
public enum CreateMakeToolDtoType
{
    [EnumMember(Value = "make")]
    Make,
}

internal class CreateMakeToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateMakeToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateMakeToolDtoType
    > _stringToEnum = new() { { "make", CreateMakeToolDtoType.Make } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateMakeToolDtoType,
        string
    > _enumToString = new() { { CreateMakeToolDtoType.Make, "make" } };

    public override CreateMakeToolDtoType Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        CreateMakeToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateMakeToolDtoType ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        CreateMakeToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
