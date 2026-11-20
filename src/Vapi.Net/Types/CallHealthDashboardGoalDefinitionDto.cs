using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardGoalDefinitionDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Explicit selected goal identity, stable across its revisions.
    /// </summary>
    [JsonPropertyName("goalId")]
    public required string GoalId { get; set; }

    /// <summary>
    /// Current visible revision of the selected goal.
    /// </summary>
    [JsonPropertyName("succeedsWhen")]
    public required string SucceedsWhen { get; set; }

    /// <summary>
    /// Current optional semantic exclusions.
    /// </summary>
    [JsonPropertyName("leaveOut")]
    public string? LeaveOut { get; set; }

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
