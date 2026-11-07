using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GoalEvaluationCurrentDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    [JsonPropertyName("goalId")]
    public required string GoalId { get; set; }

    /// <summary>
    /// Current immutable goal revision, encoded as a decimal bigint string.
    /// </summary>
    [JsonPropertyName("goalVersion")]
    public required string GoalVersion { get; set; }

    [JsonPropertyName("callEndedAt")]
    public required DateTime CallEndedAt { get; set; }

    [JsonPropertyName("processingState")]
    public required GoalEvaluationCurrentDtoProcessingState ProcessingState { get; set; }

    /// <summary>
    /// Absent until a semantic result is accepted. Processing failures are never goal_not_met.
    /// </summary>
    [JsonPropertyName("goalOutcome")]
    public GoalEvaluationCurrentDtoGoalOutcome? GoalOutcome { get; set; }

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
