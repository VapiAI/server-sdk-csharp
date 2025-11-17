using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiVoicemailDetectionPlanProvider>))]
public enum OpenAiVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "openai")]
    Openai,
}
