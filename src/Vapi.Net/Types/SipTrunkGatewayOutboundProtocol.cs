using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<SipTrunkGatewayOutboundProtocol>))]
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