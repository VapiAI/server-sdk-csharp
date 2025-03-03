using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VapiPhoneNumberStatus>))]
public enum VapiPhoneNumberStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "activating")]
    Activating,

    [EnumMember(Value = "blocked")]
    Blocked,
}
