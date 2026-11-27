using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardGoalCallDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The call this row reports the goal result for.
    /// </summary>
    [JsonPropertyName("callId")]
    public required string CallId { get; set; }

    /// <summary>
    /// Call completion time (endedAt), never startedAt.
    /// </summary>
    [JsonPropertyName("callTime")]
    public required DateTime CallTime { get; set; }

    /// <summary>
    /// Current goal revision the result belongs to; the list returns no other revision.
    /// </summary>
    [JsonPropertyName("goalVersion")]
    public required string GoalVersion { get; set; }

    /// <summary>
    /// Where this call's evaluation under goalVersion stands.
    /// </summary>
    [JsonPropertyName("processingState")]
    public required CallHealthDashboardGoalCallDtoProcessingState ProcessingState { get; set; }

    /// <summary>
    /// Absent until a result is accepted; a processing failure is never goal_not_met.
    /// </summary>
    [JsonPropertyName("goalOutcome")]
    public CallHealthDashboardGoalCallDtoGoalOutcome? GoalOutcome { get; set; }

    /// <summary>
    /// The assistant version the call ran on; absent when it ran on none.
    /// </summary>
    [JsonPropertyName("assistantVersionId")]
    public string? AssistantVersionId { get; set; }

    /// <summary>
    /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// The call's main failure category, the same as GET /call-health/call/{id} returns; absent when the call has no current classification or it selected none.
    /// </summary>
    [JsonPropertyName("primaryCategoryKey")]
    public string? PrimaryCategoryKey { get; set; }

    /// <summary>
    /// Visible issues the call joined, in ascending ID order, the same as GET /call-health/call/{id} returns; empty when it joined none.
    /// </summary>
    [JsonPropertyName("issues")]
    public IEnumerable<CallHealthDashboardGoalCallIssueDto> Issues { get; set; } =
        new List<CallHealthDashboardGoalCallIssueDto>();

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
