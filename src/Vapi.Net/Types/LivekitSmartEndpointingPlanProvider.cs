using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LivekitSmartEndpointingPlanProvider>))]
public enum LivekitSmartEndpointingPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "livekit")]
    Livekit,
}
