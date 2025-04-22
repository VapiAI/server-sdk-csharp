using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AnalysisPlan
{
    /// <summary>
    /// This is the plan for generating the summary of the call. This outputs to `call.analysis.summary`.
    /// </summary>
    [JsonPropertyName("summaryPlan")]
    public SummaryPlan? SummaryPlan { get; set; }

    /// <summary>
    /// This is the plan for generating the structured data from the call. This outputs to `call.analysis.structuredData`.
    /// </summary>
    [JsonPropertyName("structuredDataPlan")]
    public StructuredDataPlan? StructuredDataPlan { get; set; }

    /// <summary>
    /// This is an array of structured data plan catalogs. Each entry includes a `key` and a `plan` for generating the structured data from the call. This outputs to `call.analysis.structuredDataMulti`.
    /// </summary>
    [JsonPropertyName("structuredDataMultiPlan")]
    public IEnumerable<StructuredDataMultiPlan>? StructuredDataMultiPlan { get; set; }

    /// <summary>
    /// This is the plan for generating the success evaluation of the call. This outputs to `call.analysis.successEvaluation`.
    /// </summary>
    [JsonPropertyName("successEvaluationPlan")]
    public SuccessEvaluationPlan? SuccessEvaluationPlan { get; set; }

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
