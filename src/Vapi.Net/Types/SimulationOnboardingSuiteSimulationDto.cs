using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingSuiteSimulationDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Simulation id; pass it back to edit or remove the simulation.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Scenario the simulation runs.
    /// </summary>
    [JsonPropertyName("scenarioId")]
    public required string ScenarioId { get; set; }

    /// <summary>
    /// Scenario name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Name of the simulated caller's personality.
    /// </summary>
    [JsonPropertyName("personalityName")]
    public string? PersonalityName { get; set; }

    /// <summary>
    /// Each success criterion, as the yes/no question it is judged by.
    /// </summary>
    [JsonPropertyName("successCriteria")]
    public IEnumerable<string> SuccessCriteria { get; set; } = new List<string>();

    /// <summary>
    /// Requirement ids this simulation covers, e.g. `R3`.
    /// </summary>
    [JsonPropertyName("requirementIds")]
    public IEnumerable<string> RequirementIds { get; set; } = new List<string>();

    /// <summary>
    /// Tools the scenario mocks.
    /// </summary>
    [JsonPropertyName("mockedTools")]
    public IEnumerable<string> MockedTools { get; set; } = new List<string>();

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
