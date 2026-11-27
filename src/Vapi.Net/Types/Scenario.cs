using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Scenario : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the unique identifier for the scenario.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization this scenario belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the scenario was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the scenario was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the name of the scenario.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the script/instructions for the tester to follow during the simulation. Optional when `transcriptReplay` is set, which has no tester.
    /// </summary>
    [JsonPropertyName("instructions")]
    public required string Instructions { get; set; }

    /// <summary>
    /// This is the evaluation plan for the simulation. At least one is required. With `transcriptReplay`, only `metric` evaluations are allowed, and none are required.
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
    /// Latency ceilings for voice simulations. Each expectation aggregates the
    /// target call's per-turn latencies and fails the simulation (when required)
    /// if the aggregated value exceeds its threshold. Skipped for chat simulations
    /// and GPT Live targets; on any other voice simulation, a metric that no turn
    /// measured fails.
    /// </summary>
    [JsonPropertyName("latencyExpectations")]
    public IEnumerable<LatencyExpectation>? LatencyExpectations { get; set; }

    /// <summary>
    /// This turns the scenario into a transcription test: a recording is streamed
    /// into the target's call in place of a simulated caller, and the target's
    /// transcript is scored against an answer key.
    /// </summary>
    [JsonPropertyName("transcriptReplay")]
    public TranscriptReplay? TranscriptReplay { get; set; }

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
