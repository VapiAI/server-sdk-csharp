using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackElevenLabsTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackElevenLabsTranscriberModel? Model { get; set; }

    /// <summary>
    /// This is the language that will be used for the transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackElevenLabsTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// This is the number of seconds of silence before VAD commits (0.3-3.0).
    /// </summary>
    [JsonPropertyName("silenceThresholdSeconds")]
    public double? SilenceThresholdSeconds { get; set; }

    /// <summary>
    /// This is the VAD sensitivity (0.1-0.9, lower indicates more sensitive).
    /// </summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>
    /// This is the minimum speech duration for VAD (50-2000ms).
    /// </summary>
    [JsonPropertyName("minSpeechDurationMs")]
    public double? MinSpeechDurationMs { get; set; }

    /// <summary>
    /// This is the minimum silence duration for VAD (50-2000ms).
    /// </summary>
    [JsonPropertyName("minSilenceDurationMs")]
    public double? MinSilenceDurationMs { get; set; }

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
