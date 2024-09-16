using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<ClientMessageTranscriptTranscriptType>))]
public enum ClientMessageTranscriptTranscriptType
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "final")]
    Final,
}