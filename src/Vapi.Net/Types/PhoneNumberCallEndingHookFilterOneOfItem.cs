using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PhoneNumberCallEndingHookFilterOneOfItem>))]
public enum PhoneNumberCallEndingHookFilterOneOfItem
{
    [EnumMember(Value = "assistant-request-failed")]
    AssistantRequestFailed,

    [EnumMember(Value = "assistant-request-returned-error")]
    AssistantRequestReturnedError,

    [EnumMember(Value = "assistant-request-returned-unspeakable-error")]
    AssistantRequestReturnedUnspeakableError,

    [EnumMember(Value = "assistant-request-returned-invalid-assistant")]
    AssistantRequestReturnedInvalidAssistant,

    [EnumMember(Value = "assistant-request-returned-no-assistant")]
    AssistantRequestReturnedNoAssistant,

    [EnumMember(Value = "assistant-request-returned-forwarding-phone-number")]
    AssistantRequestReturnedForwardingPhoneNumber,
}
