using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientInboundMessageControlControl>))]
public enum ClientInboundMessageControlControl
{
    [EnumMember(Value = "mute-assistant")]
    MuteAssistant,

    [EnumMember(Value = "unmute-assistant")]
    UnmuteAssistant,

    [EnumMember(Value = "mute-customer")]
    MuteCustomer,

    [EnumMember(Value = "unmute-customer")]
    UnmuteCustomer,

    [EnumMember(Value = "say-first-message")]
    SayFirstMessage,
}
