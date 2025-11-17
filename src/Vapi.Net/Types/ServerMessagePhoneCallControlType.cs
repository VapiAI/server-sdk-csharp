using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessagePhoneCallControlType>))]
public enum ServerMessagePhoneCallControlType
{
    [EnumMember(Value = "phone-call-control")]
    PhoneCallControl,
}
