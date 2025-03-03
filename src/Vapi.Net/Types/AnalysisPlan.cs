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
    /// This is the plan for generating the success evaluation of the call. This outputs to `call.analysis.successEvaluation`.
    /// </summary>
    [JsonPropertyName("successEvaluationPlan")]
    public SuccessEvaluationPlan? SuccessEvaluationPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
