using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseOutputMessageTypeSerializer))]
public enum ResponseOutputMessageType
{
    [EnumMember(Value = "message")]
    Message,
}

internal class ResponseOutputMessageTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseOutputMessageType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseOutputMessageType
    > _stringToEnum = new() { { "message", ResponseOutputMessageType.Message } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseOutputMessageType,
        string
    > _enumToString = new() { { ResponseOutputMessageType.Message, "message" } };

    public override ResponseOutputMessageType Read(
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
        ResponseOutputMessageType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseOutputMessageType ReadAsPropertyName(
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
        ResponseOutputMessageType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
