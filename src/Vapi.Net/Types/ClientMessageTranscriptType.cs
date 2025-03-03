using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageTranscriptType>))]
public enum ClientMessageTranscriptType
{
    [EnumMember(Value = "transcript")]
    Transcript,

    [EnumMember(Value = "transcript[transcriptType='final']")]
    TranscriptTranscriptTypeFinal,
}
