using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LatencyExpectation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the latency component to measure.
    /// - turn: total time from the end of user speech to the start of assistant speech
    /// - model: LLM time to first token
    /// - voice: TTS time to first audio
    /// </summary>
    [JsonPropertyName("metric")]
    public required LatencyExpectationMetric Metric { get; set; }

    /// <summary>
    /// This is how the call's per-turn latencies are aggregated before comparing.
    /// p95 uses the nearest-rank method, so on calls with fewer than 20 turns it
    /// equals the max.
    /// </summary>
    [JsonPropertyName("aggregation")]
    public required LatencyExpectationAggregation Aggregation { get; set; }

    /// <summary>
    /// This is the ceiling in milliseconds. The expectation passes when the
    /// aggregated latency is less than or equal to this value.
    /// </summary>
    [JsonPropertyName("thresholdMs")]
    public required double ThresholdMs { get; set; }

    /// <summary>
    /// This is whether this expectation must pass for the simulation to pass.
    /// Defaults to true. If false, the result is informational only.
    /// On a voice simulation, a metric that no turn measured fails the expectation.
    /// GPT Live targets are skipped, because their latency is not measured yet.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

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
