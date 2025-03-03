using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallPhoneCallTransport>))]
public enum CallPhoneCallTransport
{
    [EnumMember(Value = "sip")]
    Sip,

    [EnumMember(Value = "pstn")]
    Pstn,
}
