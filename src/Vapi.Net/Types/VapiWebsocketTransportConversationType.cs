using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiWebsocketTransportConversationTypeSerializer))]
public enum VapiWebsocketTransportConversationType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class VapiWebsocketTransportConversationTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiWebsocketTransportConversationType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiWebsocketTransportConversationType
    > _stringToEnum = new() { { "voice", VapiWebsocketTransportConversationType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiWebsocketTransportConversationType,
        string
    > _enumToString = new() { { VapiWebsocketTransportConversationType.Voice, "voice" } };

    public override VapiWebsocketTransportConversationType Read(
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
        VapiWebsocketTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiWebsocketTransportConversationType ReadAsPropertyName(
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
        VapiWebsocketTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
