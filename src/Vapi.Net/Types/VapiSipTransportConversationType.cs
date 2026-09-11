using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiSipTransportConversationTypeSerializer))]
public enum VapiSipTransportConversationType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class VapiSipTransportConversationTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiSipTransportConversationType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiSipTransportConversationType
    > _stringToEnum = new() { { "voice", VapiSipTransportConversationType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiSipTransportConversationType,
        string
    > _enumToString = new() { { VapiSipTransportConversationType.Voice, "voice" } };

    public override VapiSipTransportConversationType Read(
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
        VapiSipTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiSipTransportConversationType ReadAsPropertyName(
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
        VapiSipTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
