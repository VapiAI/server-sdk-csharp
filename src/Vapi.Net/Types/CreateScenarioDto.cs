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
    /// The display name of the scenario, for example `Book an appointment`.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// What the AI tester should try to accomplish in the conversation. Write it as the AI tester's goal, for example `Book an appointment for next week and confirm the time.`
    /// </summary>
    [JsonPropertyName("instructions")]
    public required string Instructions { get; set; }

    /// <summary>
    /// The checks that decide whether a run passes. Each evaluation compares a structured output against an expected value. At least one evaluation is required to run.
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
    /// Mock results for the assistant or squad's tools during the simulation, so the run stays deterministic without calling real services.
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
