using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PhoneNumberCallEndingHookFilterKey>))]
public enum PhoneNumberCallEndingHookFilterKey
{
    [EnumMember(Value = "call.endedReason")]
    CallEndedReason,
}
