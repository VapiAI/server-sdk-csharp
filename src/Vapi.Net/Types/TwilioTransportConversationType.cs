using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TwilioTransportConversationTypeSerializer))]
public enum TwilioTransportConversationType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class TwilioTransportConversationTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TwilioTransportConversationType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TwilioTransportConversationType
    > _stringToEnum = new() { { "voice", TwilioTransportConversationType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TwilioTransportConversationType,
        string
    > _enumToString = new() { { TwilioTransportConversationType.Voice, "voice" } };

    public override TwilioTransportConversationType Read(
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
        TwilioTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TwilioTransportConversationType ReadAsPropertyName(
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
        TwilioTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
