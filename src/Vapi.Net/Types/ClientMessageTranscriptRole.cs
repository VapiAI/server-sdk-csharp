using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageTranscriptRole>))]
public enum ClientMessageTranscriptRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "user")]
    User,
}
