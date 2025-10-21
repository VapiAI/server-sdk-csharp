using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VapiVoicemailDetectionPlanType>))]
public enum VapiVoicemailDetectionPlanType
{
    [EnumMember(Value = "audio")]
    Audio,

    [EnumMember(Value = "transcript")]
    Transcript,
}
