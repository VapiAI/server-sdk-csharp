using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnalyticsOperationColumn>))]
public enum AnalyticsOperationColumn
{
    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "cost")]
    Cost,

    [EnumMember(Value = "costBreakdown.llm")]
    CostBreakdownLlm,

    [EnumMember(Value = "costBreakdown.stt")]
    CostBreakdownStt,

    [EnumMember(Value = "costBreakdown.tts")]
    CostBreakdownTts,

    [EnumMember(Value = "costBreakdown.vapi")]
    CostBreakdownVapi,

    [EnumMember(Value = "costBreakdown.transport")]
    CostBreakdownTransport,

    [EnumMember(Value = "costBreakdown.analysisBreakdown.summary")]
    CostBreakdownAnalysisBreakdownSummary,

    [EnumMember(Value = "costBreakdown.transcriber")]
    CostBreakdownTranscriber,

    [EnumMember(Value = "costBreakdown.ttsCharacters")]
    CostBreakdownTtsCharacters,

    [EnumMember(Value = "costBreakdown.llmPromptTokens")]
    CostBreakdownLlmPromptTokens,

    [EnumMember(Value = "costBreakdown.llmCompletionTokens")]
    CostBreakdownLlmCompletionTokens,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "concurrency")]
    Concurrency,

    [EnumMember(Value = "minutesUsed")]
    MinutesUsed,
}
