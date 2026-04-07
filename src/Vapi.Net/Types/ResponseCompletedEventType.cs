using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseCompletedEventTypeSerializer))]
public enum ResponseCompletedEventType
{
    [EnumMember(Value = "response.completed")]
    ResponseCompleted,
}

internal class ResponseCompletedEventTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseCompletedEventType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseCompletedEventType
    > _stringToEnum = new()
    {
        { "response.completed", ResponseCompletedEventType.ResponseCompleted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseCompletedEventType,
        string
    > _enumToString = new()
    {
        { ResponseCompletedEventType.ResponseCompleted, "response.completed" },
    };

    public override ResponseCompletedEventType Read(
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
        ResponseCompletedEventType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseCompletedEventType ReadAsPropertyName(
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
        ResponseCompletedEventType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
