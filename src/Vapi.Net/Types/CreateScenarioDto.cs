using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateScenarioDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the name of the scenario.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the script/instructions for the tester to follow during the simulation.
    /// </summary>
    [JsonPropertyName("instructions")]
    public required string Instructions { get; set; }

    /// <summary>
    /// This is the structured output-based evaluation plan for the simulation.
    /// Each item defines a structured output to extract and evaluate against an expected value.
    /// </summary>
    [JsonPropertyName("evaluations")]
    public IEnumerable<EvaluationPlanItem> Evaluations { get; set; } =
        new List<EvaluationPlanItem>();

    /// <summary>
    /// Hooks to run on simulation lifecycle events
    /// </summary>
    [JsonPropertyName("hooks")]
    public IEnumerable<object>? Hooks { get; set; }

    /// <summary>
    /// Overrides to inject into the simulated target assistant or squad
    /// </summary>
    [JsonPropertyName("targetOverrides")]
    public AssistantOverrides? TargetOverrides { get; set; }

    /// <summary>
    /// Scenario-level tool call mocks to use during simulations.
    /// </summary>
    [JsonPropertyName("toolMocks")]
    public IEnumerable<ScenarioToolMock>? ToolMocks { get; set; }

    /// <summary>
    /// Optional folder path for organizing scenarios.
    /// Supports up to 3 levels (e.g., "dept/feature/variant").
    /// Maps to GitOps resource folder structure.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

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
