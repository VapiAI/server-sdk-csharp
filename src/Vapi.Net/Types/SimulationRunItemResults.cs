using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunItemResults : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the list of results from structured output evaluations.
    /// </summary>
    [JsonPropertyName("evaluations")]
    public IEnumerable<StructuredOutputEvaluationResult> Evaluations { get; set; } =
        new List<StructuredOutputEvaluationResult>();

    /// <summary>
    /// This indicates whether all required, non-skipped structured output evaluations and latency expectations passed.
    /// </summary>
    [JsonPropertyName("passed")]
    public required bool Passed { get; set; }

    /// <summary>
    /// This contains the latency metrics collected from the call.
    /// </summary>
    [JsonPropertyName("latencyMetrics")]
    public LatencyMetrics? LatencyMetrics { get; set; }

    /// <summary>
    /// This is the list of results from the scenario's latency expectations.
    /// Absent when the scenario has no latency expectations.
    /// </summary>
    [JsonPropertyName("latencyEvaluations")]
    public IEnumerable<LatencyEvaluationResult>? LatencyEvaluations { get; set; }

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
