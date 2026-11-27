using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateScenarioDto
{
    /// <summary>
    /// This is the name of the scenario.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the script/instructions for the tester to follow during the simulation.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>
    /// This is the evaluation plan for the simulation.
    /// Each item defines a structured output to extract, or with `transcriptReplay` a built-in metric, and evaluates it
    /// against an expected value.
    /// </summary>
    [JsonPropertyName("evaluations")]
    public IEnumerable<EvaluationPlanItem>? Evaluations { get; set; }

    /// <summary>
    /// Hooks to run on simulation lifecycle events
    /// </summary>
    [JsonPropertyName("hooks")]
    public IEnumerable<object>? Hooks { get; set; }

    /// <summary>
    /// Complete override replacement. Omitted credentials and redacted server secrets are preserved when their endpoint URL is unchanged. Send credentials: [] to clear credentials; omit a server container to remove it.
    /// </summary>
    [JsonPropertyName("targetOverrides")]
    public AssistantOverrides? TargetOverrides { get; set; }

    [JsonPropertyName("toolMocks")]
    public IEnumerable<ScenarioToolMock>? ToolMocks { get; set; }

    /// <summary>
    /// Latency ceilings for voice simulations. Omit to leave unchanged; send an
    /// empty array to remove all latency expectations.
    /// </summary>
    [JsonPropertyName("latencyExpectations")]
    public IEnumerable<LatencyExpectation>? LatencyExpectations { get; set; }

    /// <summary>
    /// Transcript replay settings. Omit to leave unchanged; send null to turn the
    /// scenario back into a normal simulation, which then needs instructions and
    /// at least one evaluation. Turning a scenario into a replay needs
    /// `evaluations: []` in the same request.
    /// </summary>
    [JsonPropertyName("transcriptReplay")]
    public TranscriptReplay? TranscriptReplay { get; set; }

    /// <summary>
    /// Optional folder path for organizing scenarios.
    /// Supports up to 3 levels (e.g., "dept/feature/variant").
    /// Set to null to remove from folder.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
