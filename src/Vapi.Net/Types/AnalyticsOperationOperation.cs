using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnalyticsOperationOperation>))]
public enum AnalyticsOperationOperation
{
    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "avg")]
    Avg,

    [EnumMember(Value = "count")]
    Count,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,

    [EnumMember(Value = "history")]
    History,
}
