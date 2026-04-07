using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunSimulationEntry : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of an existing simulation to run. When provided, scenarioId/personalityId/inline fields are ignored.
    /// </summary>
    [JsonPropertyName("simulationId")]
    public string? SimulationId { get; set; }

    /// <summary>
    /// ID of an existing scenario. Cannot be combined with inline scenario.
    /// </summary>
    [JsonPropertyName("scenarioId")]
    public string? ScenarioId { get; set; }

    /// <summary>
    /// Inline scenario configuration. Cannot be combined with scenarioId.
    /// </summary>
    [JsonPropertyName("scenario")]
    public CreateScenarioDto? Scenario { get; set; }

    /// <summary>
    /// ID of an existing personality. Cannot be combined with inline personality.
    /// </summary>
    [JsonPropertyName("personalityId")]
    public string? PersonalityId { get; set; }

    /// <summary>
    /// Inline personality configuration. Cannot be combined with personalityId.
    /// </summary>
    [JsonPropertyName("personality")]
    public CreatePersonalityDto? Personality { get; set; }

    /// <summary>
    /// Optional name for this simulation entry
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
