using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RelayCommandOptionsTypeSerializer))]
public enum RelayCommandOptionsType
{
    [EnumMember(Value = "say")]
    Say,

    [EnumMember(Value = "message.add")]
    MessageAdd,
}

internal class RelayCommandOptionsTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RelayCommandOptionsType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RelayCommandOptionsType
    > _stringToEnum = new()
    {
        { "say", RelayCommandOptionsType.Say },
        { "message.add", RelayCommandOptionsType.MessageAdd },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RelayCommandOptionsType,
        string
    > _enumToString = new()
    {
        { RelayCommandOptionsType.Say, "say" },
        { RelayCommandOptionsType.MessageAdd, "message.add" },
    };

    public override RelayCommandOptionsType Read(
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
        RelayCommandOptionsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RelayCommandOptionsType ReadAsPropertyName(
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
        RelayCommandOptionsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
