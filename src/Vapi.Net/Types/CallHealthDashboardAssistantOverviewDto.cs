using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardAssistantOverviewDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Current permitted assistant metadata, fetched in a batch.
    /// </summary>
    [JsonPropertyName("assistant")]
    public required CallHealthDashboardAssistantReferenceDto Assistant { get; set; }

    /// <summary>
    /// Every row represents an explicitly selected, tenant-owned assistant goal.
    /// </summary>
    [JsonPropertyName("goalDefinition")]
    public required CallHealthDashboardGoalDefinitionDto GoalDefinition { get; set; }

    /// <summary>
    /// Window totals for the selected goal, including zero-result assistants.
    /// </summary>
    [JsonPropertyName("goal")]
    public required CallHealthDashboardGoalSummaryDto Goal { get; set; }

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
