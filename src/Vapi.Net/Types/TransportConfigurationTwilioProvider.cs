using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransportConfigurationTwilioProvider>))]
public enum TransportConfigurationTwilioProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,
}
