using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GoalEvaluationCurrentCallResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("callId")]
    public required string CallId { get; set; }

    [JsonPropertyName("goalId")]
    public required string GoalId { get; set; }

    /// <summary>
    /// Current revision of the requested goal for a visible call. Absent when that goal does not belong to the source assistant or the source is hidden. An absent evaluation does not imply queued or pending work.
    /// </summary>
    [JsonPropertyName("currentGoalVersion")]
    public string? CurrentGoalVersion { get; set; }

    [JsonPropertyName("currentEvaluation")]
    public GoalEvaluationCurrentDto? CurrentEvaluation { get; set; }

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
