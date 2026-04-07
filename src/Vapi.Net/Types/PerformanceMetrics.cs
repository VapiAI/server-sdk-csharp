using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PerformanceMetrics : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// These are the individual latencies for each turn.
    /// </summary>
    [JsonPropertyName("turnLatencies")]
    public IEnumerable<TurnLatency>? TurnLatencies { get; set; }

    /// <summary>
    /// This is the average latency for the model to output the first token.
    /// </summary>
    [JsonPropertyName("modelLatencyAverage")]
    public double? ModelLatencyAverage { get; set; }

    /// <summary>
    /// This is the average latency for the text to speech.
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
