using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RelayTargetOptionsTypeSerializer))]
public enum RelayTargetOptionsType
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "squad")]
    Squad,
}

internal class RelayTargetOptionsTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RelayTargetOptionsType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RelayTargetOptionsType
    > _stringToEnum = new()
    {
        { "assistant", RelayTargetOptionsType.Assistant },
        { "squad", RelayTargetOptionsType.Squad },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RelayTargetOptionsType,
        string
    > _enumToString = new()
    {
        { RelayTargetOptionsType.Assistant, "assistant" },
        { RelayTargetOptionsType.Squad, "squad" },
    };

    public override RelayTargetOptionsType Read(
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
        RelayTargetOptionsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RelayTargetOptionsType ReadAsPropertyName(
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
        RelayTargetOptionsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
