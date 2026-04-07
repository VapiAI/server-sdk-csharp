using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TwilioSmsChatTransportConversationTypeSerializer))]
public enum TwilioSmsChatTransportConversationType
{
    [EnumMember(Value = "chat")]
    Chat,
}

internal class TwilioSmsChatTransportConversationTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TwilioSmsChatTransportConversationType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TwilioSmsChatTransportConversationType
    > _stringToEnum = new() { { "chat", TwilioSmsChatTransportConversationType.Chat } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TwilioSmsChatTransportConversationType,
        string
    > _enumToString = new() { { TwilioSmsChatTransportConversationType.Chat, "chat" } };

    public override TwilioSmsChatTransportConversationType Read(
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
        TwilioSmsChatTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TwilioSmsChatTransportConversationType ReadAsPropertyName(
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
        TwilioSmsChatTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
