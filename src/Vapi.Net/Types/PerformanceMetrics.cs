using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Call performance measurements, including per-turn and average provider, endpointing, transport, and interruption metrics.
/// </summary>
[Serializable]
public record PerformanceMetrics : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// These are the individual latencies for each turn, in milliseconds, measured on Vapi's servers without network or playback time.
    /// A turn is recorded only when the assistant replies to the user. A first message the assistant speaks first is not recorded; with `assistant-waits-for-user` it is recorded, with `endpointingLatency` 0. A component that was not measured on a turn is 0.
    /// </summary>
    [JsonPropertyName("turnLatencies")]
    public IEnumerable<TurnLatency>? TurnLatencies { get; set; }

    /// <summary>
    /// This is the average `modelLatency` across `turnLatencies`, in milliseconds.
    /// Turns that recorded 0 because the model latency was not measured are included in the average.
    /// </summary>
    [JsonPropertyName("modelLatencyAverage")]
    public double? ModelLatencyAverage { get; set; }

    /// <summary>
    /// This is the average `voiceLatency` across `turnLatencies`, in milliseconds.
    /// Turns that recorded 0 because the voice latency was not measured are included in the average.
    /// </summary>
    [JsonPropertyName("voiceLatencyAverage")]
    public double? VoiceLatencyAverage { get; set; }

    /// <summary>
    /// This is the average latency for the transcriber.
    /// </summary>
    [JsonPropertyName("transcriberLatencyAverage")]
    public double? TranscriberLatencyAverage { get; set; }

    /// <summary>
    /// This is the average latency for the endpointing.
    /// </summary>
    [JsonPropertyName("endpointingLatencyAverage")]
    public double? EndpointingLatencyAverage { get; set; }

    /// <summary>
    /// This is the average latency for complete turns.
    /// </summary>
    [JsonPropertyName("turnLatencyAverage")]
    public double? TurnLatencyAverage { get; set; }

    /// <summary>
    /// This is the average latency for packets received from the transport provider in milliseconds.
    /// </summary>
    [JsonPropertyName("fromTransportLatencyAverage")]
    public double? FromTransportLatencyAverage { get; set; }

    /// <summary>
    /// This is the average latency for packets sent to the transport provider in milliseconds.
    /// </summary>
    [JsonPropertyName("toTransportLatencyAverage")]
    public double? ToTransportLatencyAverage { get; set; }

    /// <summary>
    /// This is the number of times the user was interrupted by the assistant during the call.
    /// </summary>
    [JsonPropertyName("numUserInterrupted")]
    public double? NumUserInterrupted { get; set; }

    /// <summary>
    /// This is the number of times the assistant was interrupted by the user during the call.
    /// </summary>
    [JsonPropertyName("numAssistantInterrupted")]
    public double? NumAssistantInterrupted { get; set; }

    /// <summary>
    /// This is `true` when the call was recorded with `TurnLatency.unmeasured`, so a turn without that list had every component measured.
    /// Absent on calls recorded before `unmeasured` existed, where a 0 latency may mean either 0ms or "not measured".
    /// </summary>
    [JsonPropertyName("turnLatencyUnmeasuredTracked")]
    public bool? TurnLatencyUnmeasuredTracked { get; set; }

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
