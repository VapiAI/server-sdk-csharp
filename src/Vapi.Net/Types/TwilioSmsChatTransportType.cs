using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TwilioSmsChatTransportType>))]
public enum TwilioSmsChatTransportType
{
    [EnumMember(Value = "twilio.sms")]
    TwilioSms,
}
