using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueSummaryDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("status")]
    public required CallHealthDashboardIssueSummaryDtoStatus Status { get; set; }

    [JsonPropertyName("rowVersion")]
    public required int RowVersion { get; set; }

    /// <summary>
    /// Owning goal identity; issue-ID routes derive this selection from the issue.
    /// </summary>
    [JsonPropertyName("goalId")]
    public required string GoalId { get; set; }

    /// <summary>
    /// The ranking category the issue belongs to, such as `step_skipped`.
    /// </summary>
    [JsonPropertyName("categoryKey")]
    public required string CategoryKey { get; set; }

    [JsonPropertyName("summary")]
    public required string Summary { get; set; }

    [JsonPropertyName("assistant")]
    public required CallHealthDashboardAssistantReferenceDto Assistant { get; set; }

    [JsonPropertyName("affectedCallCount")]
    public required int AffectedCallCount { get; set; }

    /// <summary>
    /// Same assistant/current-goal/window denominator used by the goal reads.
    /// </summary>
    [JsonPropertyName("analyzedCallCount")]
    public required int AnalyzedCallCount { get; set; }

    /// <summary>
    /// Distinct calls matching this issue / analyzedCallCount; absent at zero.
    /// </summary>
    [JsonPropertyName("affectedCallRate")]
    public double? AffectedCallRate { get; set; }

    /// <summary>
    /// One ascending contiguous page of daily buckets in the requested time zone; memberships across issues are not unique calls.
    /// </summary>
    [JsonPropertyName("dailySeries")]
    public IEnumerable<CallHealthDashboardIssueDailyDto> DailySeries { get; set; } =
        new List<CallHealthDashboardIssueDailyDto>();

    /// <summary>
    /// Full-window counts per assistant version the calls ran on, newest version first; they partition the totals.
    /// </summary>
    [JsonPropertyName("assistantVersions")]
    public IEnumerable<CallHealthDashboardIssueVersionDto> AssistantVersions { get; set; } =
        new List<CallHealthDashboardIssueVersionDto>();

    [JsonPropertyName("lastSeenAt")]
    public DateTime? LastSeenAt { get; set; }

    [JsonPropertyName("coverage")]
    public required CallHealthDashboardIssueCoverageDto Coverage { get; set; }

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
