using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(StructuredOutputTypeSerializer))]
public enum StructuredOutputType
{
    [EnumMember(Value = "ai")]
    Ai,

    [EnumMember(Value = "regex")]
    Regex,
}

internal class StructuredOutputTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<StructuredOutputType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        StructuredOutputType
    > _stringToEnum = new()
    {
        { "ai", StructuredOutputType.Ai },
        { "regex", StructuredOutputType.Regex },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        StructuredOutputType,
        string
    > _enumToString = new()
    {
        { StructuredOutputType.Ai, "ai" },
        { StructuredOutputType.Regex, "regex" },
    };

    public override StructuredOutputType Read(
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
        StructuredOutputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override StructuredOutputType ReadAsPropertyName(
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
        StructuredOutputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
