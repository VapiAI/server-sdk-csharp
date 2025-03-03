using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SipTrunkGateway
{
    /// <summary>
    /// This is the address of the gateway. It can be an IPv4 address like 1.1.1.1 or a fully qualified domain name like my-sip-trunk.pstn.twilio.com.
    /// </summary>
    [JsonPropertyName("ip")]
    public required string Ip { get; set; }

    /// <summary>
    /// This is the port number of the gateway. Default is 5060.
    ///
    /// @default 5060
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// This is the netmask of the gateway. Defaults to 32.
    ///
    /// @default 32
    /// </summary>
    [JsonPropertyName("netmask")]
    public double? Netmask { get; set; }

    /// <summary>
    /// This is whether inbound calls are allowed from this gateway. Default is true.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("inboundEnabled")]
    public bool? InboundEnabled { get; set; }

    /// <summary>
    /// This is whether outbound calls should be sent to this gateway. Default is true.
    ///
    /// Note, if netmask is less than 32, it doesn't affect the outbound IPs that are tried. 1 attempt is made to `ip:port`.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("outboundEnabled")]
    public bool? OutboundEnabled { get; set; }

    /// <summary>
    /// This is the protocol to use for SIP signaling outbound calls. Default is udp.
    ///
    /// @default udp
    /// </summary>
    [JsonPropertyName("outboundProtocol")]
    public SipTrunkGatewayOutboundProtocol? OutboundProtocol { get; set; }

    /// <summary>
    /// This is whether to send options ping to the gateway. This can be used to check if the gateway is reachable. Default is false.
    ///
    /// This is useful for high availability setups where you want to check if the gateway is reachable before routing calls to it. Note, if no gateway for a trunk is reachable, outbound calls will be rejected.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("optionsPingEnabled")]
    public bool? OptionsPingEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
