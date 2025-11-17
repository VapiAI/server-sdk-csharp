using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleVoicemailDetectionPlanProvider>))]
public enum GoogleVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "google")]
    Google,
}
