using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PerformanceMetrics
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
