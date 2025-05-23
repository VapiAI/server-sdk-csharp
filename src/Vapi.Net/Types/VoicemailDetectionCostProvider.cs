using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VoicemailDetectionCostProvider>))]
public enum VoicemailDetectionCostProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "vapi")]
    Vapi,
}
