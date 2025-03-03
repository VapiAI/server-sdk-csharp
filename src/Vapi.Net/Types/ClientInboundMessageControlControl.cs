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

    [EnumMember(Value = "say-first-message")]
    SayFirstMessage,
}
