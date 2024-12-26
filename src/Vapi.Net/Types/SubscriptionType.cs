using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SubscriptionType>))]
public enum SubscriptionType
{
    [EnumMember(Value = "trial")]
    Trial,

    [EnumMember(Value = "pay-as-you-go")]
    PayAsYouGo,

    [EnumMember(Value = "enterprise")]
    Enterprise,
}