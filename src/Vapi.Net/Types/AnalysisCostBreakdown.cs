using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AnalysisCostBreakdown
{
    /// <summary>
    /// This is the cost to summarize the call.
    /// </summary>
    [JsonPropertyName("summary")]
    public double? Summary { get; set; }

    /// <summary>
    /// This is the number of prompt tokens used to summarize the call.
    /// </summary>
    [JsonPropertyName("summaryPromptTokens")]
    public double? SummaryPromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens used to summarize the call.
    /// </summary>
    [JsonPropertyName("summaryCompletionTokens")]
    public double? SummaryCompletionTokens { get; set; }

    /// <summary>
    /// This is the cost to extract structured data from the call.
    /// </summary>
    [JsonPropertyName("structuredData")]
    public double? StructuredData { get; set; }

    /// <summary>
    /// This is the number of prompt tokens used to extract structured data from the call.
    /// </summary>
    [JsonPropertyName("structuredDataPromptTokens")]
    public double? StructuredDataPromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens used to extract structured data from the call.
    /// </summary>
    [JsonPropertyName("structuredDataCompletionTokens")]
    public double? StructuredDataCompletionTokens { get; set; }

    /// <summary>
    /// This is the cost to evaluate if the call was successful.
    /// </summary>
    [JsonPropertyName("successEvaluation")]
    public double? SuccessEvaluation { get; set; }

    /// <summary>
    /// This is the number of prompt tokens used to evaluate if the call was successful.
    /// </summary>
    [JsonPropertyName("successEvaluationPromptTokens")]
    public double? SuccessEvaluationPromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens used to evaluate if the call was successful.
    /// </summary>
    [JsonPropertyName("successEvaluationCompletionTokens")]
    public double? SuccessEvaluationCompletionTokens { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
