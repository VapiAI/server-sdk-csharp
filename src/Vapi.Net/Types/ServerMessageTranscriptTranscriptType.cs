using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageTranscriptTranscriptType>))]
public enum ServerMessageTranscriptTranscriptType
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "final")]
    Final,
}
