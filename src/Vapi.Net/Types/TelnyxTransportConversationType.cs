using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TelnyxTransportConversationTypeSerializer))]
public enum TelnyxTransportConversationType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class TelnyxTransportConversationTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TelnyxTransportConversationType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TelnyxTransportConversationType
    > _stringToEnum = new() { { "voice", TelnyxTransportConversationType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TelnyxTransportConversationType,
        string
    > _enumToString = new() { { TelnyxTransportConversationType.Voice, "voice" } };

    public override TelnyxTransportConversationType Read(
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
        TelnyxTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TelnyxTransportConversationType ReadAsPropertyName(
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
        TelnyxTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
