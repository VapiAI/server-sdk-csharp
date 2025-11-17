using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<StartSpeakingPlanSmartEndpointingEnabledOne>))]
public enum StartSpeakingPlanSmartEndpointingEnabledOne
{
    [EnumMember(Value = "livekit")]
    Livekit,
}
