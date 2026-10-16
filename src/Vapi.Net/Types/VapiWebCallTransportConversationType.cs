using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiWebCallTransportConversationTypeSerializer))]
public enum VapiWebCallTransportConversationType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class VapiWebCallTransportConversationTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiWebCallTransportConversationType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiWebCallTransportConversationType
    > _stringToEnum = new() { { "voice", VapiWebCallTransportConversationType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiWebCallTransportConversationType,
        string
    > _enumToString = new() { { VapiWebCallTransportConversationType.Voice, "voice" } };

    public override VapiWebCallTransportConversationType Read(
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
        VapiWebCallTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiWebCallTransportConversationType ReadAsPropertyName(
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
        VapiWebCallTransportConversationType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
