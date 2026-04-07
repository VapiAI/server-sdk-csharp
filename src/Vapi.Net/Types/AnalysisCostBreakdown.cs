using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AnalysisCostBreakdown : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// This is the number of cached prompt tokens used to summarize the call.
    /// </summary>
    [JsonPropertyName("summaryCachedPromptTokens")]
    public double? SummaryCachedPromptTokens { get; set; }

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
    /// This is the number of cached prompt tokens used to extract structured data from the call.
    /// </summary>
    [JsonPropertyName("structuredDataCachedPromptTokens")]
    public double? StructuredDataCachedPromptTokens { get; set; }

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

    /// <summary>
    /// This is the number of cached prompt tokens used to evaluate if the call was successful.
    /// </summary>
    [JsonPropertyName("successEvaluationCachedPromptTokens")]
    public double? SuccessEvaluationCachedPromptTokens { get; set; }

    /// <summary>
    /// This is the cost to evaluate structuredOutputs from the call.
    /// </summary>
    [JsonPropertyName("structuredOutput")]
    public double? StructuredOutput { get; set; }

    /// <summary>
    /// This is the number of prompt tokens used to evaluate structuredOutputs from the call.
    /// </summary>
    [JsonPropertyName("structuredOutputPromptTokens")]
    public double? StructuredOutputPromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens used to evaluate structuredOutputs from the call.
    /// </summary>
    [JsonPropertyName("structuredOutputCompletionTokens")]
    public double? StructuredOutputCompletionTokens { get; set; }

    /// <summary>
    /// This is the number of cached prompt tokens used to evaluate structuredOutputs from the call.
    /// </summary>
    [JsonPropertyName("structuredOutputCachedPromptTokens")]
    public double? StructuredOutputCachedPromptTokens { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
