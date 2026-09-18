using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Cost for an individual analysis request, including analysis type, model, token usage, and amount.
/// </summary>
[Serializable]
public record AnalysisCost : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of analysis performed.
    /// </summary>
    [JsonPropertyName("analysisType")]
    public required AnalysisCostAnalysisType AnalysisType { get; set; }

    /// <summary>
    /// This is the model that was used to perform the analysis.
    /// </summary>
    [JsonPropertyName("model")]
    public object Model { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the number of prompt tokens used in the analysis.
    /// </summary>
    [JsonPropertyName("promptTokens")]
    public required double PromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens generated in the analysis.
    /// </summary>
    [JsonPropertyName("completionTokens")]
    public required double CompletionTokens { get; set; }

    /// <summary>
    /// This is the number of cached prompt tokens used in the analysis. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
    /// </summary>
    [JsonPropertyName("cachedPromptTokens")]
    public double? CachedPromptTokens { get; set; }

    /// <summary>
    /// This is the per-structured-output breakdown of this cost. The `cost`, `promptTokens`, `completionTokens` and `cachedPromptTokens` above are the sums of these rows.
    ///
    /// This is only set when `analysisType` is `structuredOutput`, and it is omitted entirely rather than partially populated, so when it is present the rows always reconcile to the totals above.
    ///
    /// A structured output that was skipped, or that extracts via regex, makes no LLM call and so has no row here — this is not a complete list of the call's configured structured outputs. There is one row per evaluation, so a `structuredOutputId` can appear more than once if it was evaluated more than once; sum the rows rather than indexing them by id.
    /// </summary>
    [JsonPropertyName("structuredOutputBreakdown")]
    public IEnumerable<StructuredOutputCostBreakdown>? StructuredOutputBreakdown { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

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
