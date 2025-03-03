using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallPhoneCallProvider>))]
public enum CallPhoneCallProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "vonage")]
    Vonage,

    [EnumMember(Value = "vapi")]
    Vapi,
}
