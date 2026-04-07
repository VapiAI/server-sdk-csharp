using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallPhoneCallTransportSerializer))]
public enum CallPhoneCallTransport
{
    [EnumMember(Value = "sip")]
    Sip,

    [EnumMember(Value = "pstn")]
    Pstn,
}

internal class CallPhoneCallTransportSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallPhoneCallTransport>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallPhoneCallTransport
    > _stringToEnum = new()
    {
        { "sip", CallPhoneCallTransport.Sip },
        { "pstn", CallPhoneCallTransport.Pstn },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallPhoneCallTransport,
        string
    > _enumToString = new()
    {
        { CallPhoneCallTransport.Sip, "sip" },
        { CallPhoneCallTransport.Pstn, "pstn" },
    };

    public override CallPhoneCallTransport Read(
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
        CallPhoneCallTransport value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallPhoneCallTransport ReadAsPropertyName(
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
        CallPhoneCallTransport value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
