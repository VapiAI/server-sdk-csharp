using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallType>))]
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
