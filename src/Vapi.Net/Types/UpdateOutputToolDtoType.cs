using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateOutputToolDtoTypeSerializer))]
public enum UpdateOutputToolDtoType
{
    [EnumMember(Value = "output")]
    Output,
}

internal class UpdateOutputToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateOutputToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateOutputToolDtoType
    > _stringToEnum = new() { { "output", UpdateOutputToolDtoType.Output } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateOutputToolDtoType,
        string
    > _enumToString = new() { { UpdateOutputToolDtoType.Output, "output" } };

    public override UpdateOutputToolDtoType Read(
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
        UpdateOutputToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateOutputToolDtoType ReadAsPropertyName(
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
        UpdateOutputToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
