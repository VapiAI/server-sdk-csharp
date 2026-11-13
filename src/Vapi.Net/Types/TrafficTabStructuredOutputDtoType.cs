using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficTabStructuredOutputDtoTypeSerializer))]
public enum TrafficTabStructuredOutputDtoType
{
    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "boolean")]
    Boolean,

    [EnumMember(Value = "unknown")]
    Unknown,
}

internal class TrafficTabStructuredOutputDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficTabStructuredOutputDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficTabStructuredOutputDtoType
    > _stringToEnum = new()
    {
        { "number", TrafficTabStructuredOutputDtoType.Number },
        { "string", TrafficTabStructuredOutputDtoType.String },
        { "boolean", TrafficTabStructuredOutputDtoType.Boolean },
        { "unknown", TrafficTabStructuredOutputDtoType.Unknown },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficTabStructuredOutputDtoType,
        string
    > _enumToString = new()
    {
        { TrafficTabStructuredOutputDtoType.Number, "number" },
        { TrafficTabStructuredOutputDtoType.String, "string" },
        { TrafficTabStructuredOutputDtoType.Boolean, "boolean" },
        { TrafficTabStructuredOutputDtoType.Unknown, "unknown" },
    };

    public override TrafficTabStructuredOutputDtoType Read(
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
        TrafficTabStructuredOutputDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficTabStructuredOutputDtoType ReadAsPropertyName(
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
        TrafficTabStructuredOutputDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
