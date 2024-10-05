using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<CallPhoneCallTransport>))]
public enum CallPhoneCallTransport
{
    [EnumMember(Value = "sip")]
    Sip,

    [EnumMember(Value = "pstn")]
    Pstn,
}