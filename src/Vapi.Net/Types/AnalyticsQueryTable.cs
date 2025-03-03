using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnalyticsQueryTable>))]
public enum AnalyticsQueryTable
{
    [EnumMember(Value = "call")]
    Call,

    [EnumMember(Value = "subscription")]
    Subscription,
}
