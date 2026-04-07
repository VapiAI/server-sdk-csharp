using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SipTrunkGatewayOutboundProtocolSerializer))]
public enum SipTrunkGatewayOutboundProtocol
{
    [EnumMember(Value = "tls/srtp")]
    TlsSrtp,

    [EnumMember(Value = "tcp")]
    Tcp,

    [EnumMember(Value = "tls")]
    Tls,

    [EnumMember(Value = "udp")]
    Udp,
}

internal class SipTrunkGatewayOutboundProtocolSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SipTrunkGatewayOutboundProtocol>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SipTrunkGatewayOutboundProtocol
    > _stringToEnum = new()
    {
        { "tls/srtp", SipTrunkGatewayOutboundProtocol.TlsSrtp },
        { "tcp", SipTrunkGatewayOutboundProtocol.Tcp },
        { "tls", SipTrunkGatewayOutboundProtocol.Tls },
        { "udp", SipTrunkGatewayOutboundProtocol.Udp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SipTrunkGatewayOutboundProtocol,
        string
    > _enumToString = new()
    {
        { SipTrunkGatewayOutboundProtocol.TlsSrtp, "tls/srtp" },
        { SipTrunkGatewayOutboundProtocol.Tcp, "tcp" },
        { SipTrunkGatewayOutboundProtocol.Tls, "tls" },
        { SipTrunkGatewayOutboundProtocol.Udp, "udp" },
    };

    public override SipTrunkGatewayOutboundProtocol Read(
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
        SipTrunkGatewayOutboundProtocol value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SipTrunkGatewayOutboundProtocol ReadAsPropertyName(
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
        SipTrunkGatewayOutboundProtocol value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
