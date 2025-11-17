using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TwilioCredentialProvider>))]
public enum TwilioCredentialProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,
}
