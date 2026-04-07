using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LatencyMetrics : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the number of conversation turns.
    /// </summary>
    [JsonPropertyName("turnCount")]
    public required double TurnCount { get; set; }

    /// <summary>
    /// This is the average total turn latency in milliseconds.
    /// </summary>
    [JsonPropertyName("avgTurn")]
    public double? AvgTurn { get; set; }

    /// <summary>
    /// This is the average transcriber latency in milliseconds.
    /// </summary>
    [JsonPropertyName("avgTranscriber")]
    public double? AvgTranscriber { get; set; }

    /// <summary>
    /// This is the average LLM/model latency in milliseconds.
    /// </summary>
    [JsonPropertyName("avgModel")]
    public double? AvgModel { get; set; }

    /// <summary>
    /// This is the average voice/TTS latency in milliseconds.
    /// </summary>
    [JsonPropertyName("avgVoice")]
    public double? AvgVoice { get; set; }

    /// <summary>
    /// This is the average endpointing latency in milliseconds.
    /// </summary>
    [JsonPropertyName("avgEndpointing")]
    public double? AvgEndpointing { get; set; }

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
