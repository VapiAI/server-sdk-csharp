using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TwilioVoicemailDetectionPlanProvider>))]
public enum TwilioVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,
}
