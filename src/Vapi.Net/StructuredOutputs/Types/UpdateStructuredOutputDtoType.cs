using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateStructuredOutputDtoTypeSerializer))]
public enum UpdateStructuredOutputDtoType
{
    [EnumMember(Value = "ai")]
    Ai,

    [EnumMember(Value = "regex")]
    Regex,
}

internal class UpdateStructuredOutputDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateStructuredOutputDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateStructuredOutputDtoType
    > _stringToEnum = new()
    {
        { "ai", UpdateStructuredOutputDtoType.Ai },
        { "regex", UpdateStructuredOutputDtoType.Regex },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateStructuredOutputDtoType,
        string
    > _enumToString = new()
    {
        { UpdateStructuredOutputDtoType.Ai, "ai" },
        { UpdateStructuredOutputDtoType.Regex, "regex" },
    };

    public override UpdateStructuredOutputDtoType Read(
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
        UpdateStructuredOutputDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateStructuredOutputDtoType ReadAsPropertyName(
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
        UpdateStructuredOutputDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
