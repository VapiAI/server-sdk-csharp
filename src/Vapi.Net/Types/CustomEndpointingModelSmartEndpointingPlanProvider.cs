using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CustomEndpointingModelSmartEndpointingPlanProvider>))]
public enum CustomEndpointingModelSmartEndpointingPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "livekit")]
    Livekit,

    [EnumMember(Value = "custom-endpointing-model")]
    CustomEndpointingModel,
}
