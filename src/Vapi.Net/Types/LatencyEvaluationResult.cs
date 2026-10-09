using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LatencyEvaluationResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the latency component that was measured.
    /// </summary>
    [JsonPropertyName("metric")]
    public required LatencyEvaluationResultMetric Metric { get; set; }

    /// <summary>
    /// This is how the per-turn latencies were aggregated.
    /// </summary>
    [JsonPropertyName("aggregation")]
    public required LatencyEvaluationResultAggregation Aggregation { get; set; }

    /// <summary>
    /// This is the ceiling in milliseconds the aggregated latency was compared against.
    /// </summary>
    [JsonPropertyName("thresholdMs")]
    public required double ThresholdMs { get; set; }

    /// <summary>
    /// This is the aggregated latency in milliseconds, rounded to the nearest
    /// millisecond. The pass/fail verdict is decided on this rounded value.
    /// Absent when the expectation was skipped or no turn measured this metric.
    /// </summary>
    [JsonPropertyName("actualMs")]
    public double? ActualMs { get; set; }

    /// <summary>
    /// This is the number of turns that contributed a value for this metric.
    /// </summary>
    [JsonPropertyName("sampleCount")]
    public required double SampleCount { get; set; }

    /// <summary>
    /// This indicates whether the aggregated latency was at or below the threshold.
    /// </summary>
    [JsonPropertyName("passed")]
    public required bool Passed { get; set; }

    /// <summary>
    /// This indicates whether this expectation was required for the simulation to pass.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; set; }

    /// <summary>
    /// This indicates whether this expectation was skipped. Expectations are only
    /// skipped on chat simulations and GPT Live targets, which record no latency.
    /// </summary>
    [JsonPropertyName("isSkipped")]
    public bool? IsSkipped { get; set; }

    /// <summary>
    /// This contains the reason for skipping the expectation.
    /// </summary>
    [JsonPropertyName("skipReason")]
    public string? SkipReason { get; set; }

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
