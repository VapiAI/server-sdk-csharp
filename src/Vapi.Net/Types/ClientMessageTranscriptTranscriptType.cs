using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageTranscriptTranscriptType>))]
public enum ClientMessageTranscriptTranscriptType
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "final")]
    Final,
}
