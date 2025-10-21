using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiVoicemailDetectionPlanType>))]
public enum OpenAiVoicemailDetectionPlanType
{
    [EnumMember(Value = "audio")]
    Audio,

    [EnumMember(Value = "transcript")]
    Transcript,
}
