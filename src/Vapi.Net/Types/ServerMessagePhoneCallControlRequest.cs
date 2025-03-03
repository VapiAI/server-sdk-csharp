using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessagePhoneCallControlRequest>))]
public enum ServerMessagePhoneCallControlRequest
{
    [EnumMember(Value = "forward")]
    Forward,

    [EnumMember(Value = "hang-up")]
    HangUp,
}
