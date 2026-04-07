using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateOutputToolDtoTypeSerializer))]
public enum CreateOutputToolDtoType
{
    [EnumMember(Value = "output")]
    Output,
}

internal class CreateOutputToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateOutputToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateOutputToolDtoType
    > _stringToEnum = new() { { "output", CreateOutputToolDtoType.Output } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateOutputToolDtoType,
        string
    > _enumToString = new() { { CreateOutputToolDtoType.Output, "output" } };

    public override CreateOutputToolDtoType Read(
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
        CreateOutputToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateOutputToolDtoType ReadAsPropertyName(
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
        CreateOutputToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
