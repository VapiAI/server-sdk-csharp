using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageSpeechUpdateRole>))]
public enum ServerMessageSpeechUpdateRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "user")]
    User,
}
