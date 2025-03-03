using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnalyticsQueryGroupByItem>))]
public enum AnalyticsQueryGroupByItem
{
    [EnumMember(Value = "type")]
    Type,

    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "endedReason")]
    EndedReason,

    [EnumMember(Value = "analysis.successEvaluation")]
    AnalysisSuccessEvaluation,

    [EnumMember(Value = "status")]
    Status,
}
