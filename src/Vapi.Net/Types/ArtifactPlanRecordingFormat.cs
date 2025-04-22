using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ArtifactPlanRecordingFormat>))]
public enum ArtifactPlanRecordingFormat
{
    [EnumMember(Value = "wav;l16")]
    WavL16,

    [EnumMember(Value = "mp3")]
    Mp3,
}
