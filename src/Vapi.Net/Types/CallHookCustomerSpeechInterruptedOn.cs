using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallHookCustomerSpeechInterruptedOn>))]
public enum CallHookCustomerSpeechInterruptedOn
{
    [EnumMember(Value = "customer.speech.interrupted")]
    CustomerSpeechInterrupted,
}
