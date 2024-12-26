using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SubscriptionStatus>))]
public enum SubscriptionStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "frozen")]
    Frozen,
}
