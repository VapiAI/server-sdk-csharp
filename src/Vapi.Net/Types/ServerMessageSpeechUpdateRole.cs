using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<ServerMessageSpeechUpdateRole>))]
public enum ServerMessageSpeechUpdateRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "user")]
    User,
}