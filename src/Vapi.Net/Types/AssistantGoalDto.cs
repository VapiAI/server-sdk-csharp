using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantGoalDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    [JsonPropertyName("goalId")]
    public required string GoalId { get; set; }

    /// <summary>
    /// Committed decimal bigint revision.
    /// </summary>
    [JsonPropertyName("goalVersion")]
    public required string GoalVersion { get; set; }

    [JsonPropertyName("succeedsWhen")]
    public required string SucceedsWhen { get; set; }

    [JsonPropertyName("leaveOut")]
    public string? LeaveOut { get; set; }

    /// <summary>
    /// Committed goal-change time anchoring its fixed backfill window.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
