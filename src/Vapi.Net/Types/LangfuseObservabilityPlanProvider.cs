using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LangfuseObservabilityPlanProvider>))]
public enum LangfuseObservabilityPlanProvider
{
    [EnumMember(Value = "langfuse")]
    Langfuse,
}
