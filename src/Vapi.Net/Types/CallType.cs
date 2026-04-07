using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallTypeSerializer))]
public enum CallType
{
    [EnumMember(Value = "inboundPhoneCall")]
    InboundPhoneCall,

    [EnumMember(Value = "outboundPhoneCall")]
    OutboundPhoneCall,

    [EnumMember(Value = "webCall")]
    WebCall,

    [EnumMember(Value = "vapi.websocketCall")]
    VapiWebsocketCall,
}

internal class CallTypeSerializer : global::System.Text.Json.Serialization.JsonConverter<CallType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallType
    > _stringToEnum = new()
    {
        { "inboundPhoneCall", CallType.InboundPhoneCall },
        { "outboundPhoneCall", CallType.OutboundPhoneCall },
        { "webCall", CallType.WebCall },
        { "vapi.websocketCall", CallType.VapiWebsocketCall },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallType,
        string
    > _enumToString = new()
    {
        { CallType.InboundPhoneCall, "inboundPhoneCall" },
        { CallType.OutboundPhoneCall, "outboundPhoneCall" },
        { CallType.WebCall, "webCall" },
        { CallType.VapiWebsocketCall, "vapi.websocketCall" },
    };

    public override CallType Read(
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
        CallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallType ReadAsPropertyName(
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
        CallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
