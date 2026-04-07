using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunItemImprovements : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is a summary analysis of why evaluations failed.
    /// </summary>
    [JsonPropertyName("analysis")]
    public required string Analysis { get; set; }

    /// <summary>
    /// This is the list of suggestions for improving the system prompt.
    /// </summary>
    [JsonPropertyName("systemPromptSuggestions")]
    public IEnumerable<SimulationRunItemImprovementSuggestion> SystemPromptSuggestions { get; set; } =
        new List<SimulationRunItemImprovementSuggestion>();

    /// <summary>
    /// This is the list of suggestions for improving tools.
    /// </summary>
    [JsonPropertyName("toolSuggestions")]
    public IEnumerable<SimulationRunItemImprovementSuggestion> ToolSuggestions { get; set; } =
        new List<SimulationRunItemImprovementSuggestion>();

    /// <summary>
    /// This is the list of suggestions for improving the scenario/evaluation plan.
    /// </summary>
    [JsonPropertyName("scenarioSuggestions")]
    public IEnumerable<SimulationRunItemImprovementSuggestion> ScenarioSuggestions { get; set; } =
        new List<SimulationRunItemImprovementSuggestion>();

    /// <summary>
    /// This is a complete revised system prompt if major changes are needed.
    /// </summary>
    [JsonPropertyName("suggestedSystemPrompt")]
    public string? SuggestedSystemPrompt { get; set; }

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
