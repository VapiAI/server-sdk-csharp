using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardAssistantGoalsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Requested assistant identity whose current published row remains visible.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// Empty when this visible assistant has no goals; no goal is automatically selected.
    /// </summary>
    [JsonPropertyName("goals")]
    public IEnumerable<CallHealthDashboardGoalOptionDto> Goals { get; set; } =
        new List<CallHealthDashboardGoalOptionDto>();

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
