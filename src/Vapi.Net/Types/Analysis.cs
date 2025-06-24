using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Analysis
{
    /// <summary>
    /// This is the summary of the call. Customize by setting `assistant.analysisPlan.summaryPrompt`.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// This is the structured data extracted from the call. Customize by setting `assistant.analysisPlan.structuredDataPrompt` and/or `assistant.analysisPlan.structuredDataSchema`.
    /// </summary>
    [JsonPropertyName("structuredData")]
    public object? StructuredData { get; set; }

    /// <summary>
    /// This is the structured data catalog of the call. Customize by setting `assistant.analysisPlan.structuredDataMultiPlan`.
    /// </summary>
    [JsonPropertyName("structuredDataMulti")]
    public IEnumerable<object>? StructuredDataMulti { get; set; }

    /// <summary>
    /// This is the evaluation of the call. Customize by setting `assistant.analysisPlan.successEvaluationPrompt` and/or `assistant.analysisPlan.successEvaluationRubric`.
    /// </summary>
    [JsonPropertyName("successEvaluation")]
    public string? SuccessEvaluation { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
