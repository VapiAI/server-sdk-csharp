using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransportCostProvider>))]
public enum TransportCostProvider
{
    [EnumMember(Value = "daily")]
    Daily,

    [EnumMember(Value = "vapi.websocket")]
    VapiWebsocket,

    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "vonage")]
    Vonage,

    [EnumMember(Value = "telnyx")]
    Telnyx,

    [EnumMember(Value = "vapi.sip")]
    VapiSip,
}
