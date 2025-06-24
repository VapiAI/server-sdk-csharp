using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

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

    [EnumMember(Value = "agency")]
    Agency,

    [EnumMember(Value = "startup")]
    Startup,

    [EnumMember(Value = "growth")]
    Growth,

    [EnumMember(Value = "scale")]
    Scale,
}
