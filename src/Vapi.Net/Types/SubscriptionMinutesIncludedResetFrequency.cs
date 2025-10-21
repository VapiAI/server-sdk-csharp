using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SubscriptionMinutesIncludedResetFrequency>))]
public enum SubscriptionMinutesIncludedResetFrequency
{
    [EnumMember(Value = "monthly")]
    Monthly,

    [EnumMember(Value = "annually")]
    Annually,
}
