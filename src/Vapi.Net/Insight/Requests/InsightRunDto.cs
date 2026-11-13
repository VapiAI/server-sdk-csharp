using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InsightRunDto
{
    /// <summary>
    /// Output-formatting instructions applied to the insight run.
    /// </summary>
    [JsonPropertyName("formatPlan")]
    public InsightRunFormatPlan? FormatPlan { get; set; }

    /// <summary>
    /// This is the optional time range override for the insight.
    /// If provided, overrides every field in the insight's timeRange.
    /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.
    /// start default - "-7d"
    /// end default - "now"
    /// step default - "day"
    /// For Pie and Text Insights, step will be ignored even if provided.
    /// </summary>
    [JsonPropertyName("timeRangeOverride")]
    public InsightTimeRangeWithStep? TimeRangeOverride { get; set; }

    /// <summary>
    /// Optional runtime assistant scope for dashboards.
    /// This is applied to call-table queries without mutating the saved insight.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
