using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseErrorEventTypeSerializer))]
public enum ResponseErrorEventType
{
    [EnumMember(Value = "error")]
    Error,
}

internal class ResponseErrorEventTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseErrorEventType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseErrorEventType
    > _stringToEnum = new() { { "error", ResponseErrorEventType.Error } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseErrorEventType,
        string
    > _enumToString = new() { { ResponseErrorEventType.Error, "error" } };

    public override ResponseErrorEventType Read(
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
        ResponseErrorEventType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseErrorEventType ReadAsPropertyName(
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
        ResponseErrorEventType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
