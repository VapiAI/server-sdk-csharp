using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VapiVoicemailDetectionPlanProvider>))]
public enum VapiVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,
}
