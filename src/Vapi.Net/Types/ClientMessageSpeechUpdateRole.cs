using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageSpeechUpdateRole>))]
public enum ClientMessageSpeechUpdateRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "user")]
    User,
}
