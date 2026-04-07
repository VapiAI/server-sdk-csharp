using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackAssemblyAiTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackAssemblyAiTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Transcripts below this confidence threshold will be discarded.
    ///
    /// @default 0.4
    /// </summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>
    /// This enables formatting of transcripts.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("formatTurns")]
    public bool? FormatTurns { get; set; }

    /// <summary>
    /// This is the end of turn confidence threshold. The minimum confidence that the end of turn is detected.
    /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.
    /// @min 0
    /// @max 1
    /// @default 0.7
    /// </summary>
    [JsonPropertyName("endOfTurnConfidenceThreshold")]
    public double? EndOfTurnConfidenceThreshold { get; set; }

    /// <summary>
    /// This is the minimum end of turn silence when confident in milliseconds.
    /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.
    /// @default 160
    /// </summary>
    [JsonPropertyName("minEndOfTurnSilenceWhenConfident")]
    public double? MinEndOfTurnSilenceWhenConfident { get; set; }

    [JsonPropertyName("wordFinalizationMaxWaitTime")]
    public double? WordFinalizationMaxWaitTime { get; set; }

    /// <summary>
    /// This is the maximum turn silence time in milliseconds.
    /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.
    /// @default 400
    /// </summary>
    [JsonPropertyName("maxTurnSilence")]
    public double? MaxTurnSilence { get; set; }

    /// <summary>
    /// Use VAD to assist with endpointing decisions from the transcriber.
    /// When enabled, transcriber endpointing will be buffered if VAD detects the user is still speaking, preventing premature turn-taking.
    /// When disabled, transcriber endpointing will be used immediately regardless of VAD state, allowing for quicker but more aggressive turn-taking.
    /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("vadAssistedEndpointingEnabled")]
    public bool? VadAssistedEndpointingEnabled { get; set; }

    /// <summary>
    /// This is the speech model used for the streaming session.
    /// Note: Keyterms prompting is not supported with multilingual streaming.
    /// @default 'universal-streaming-english'
    /// </summary>
    [JsonPropertyName("speechModel")]
    public FallbackAssemblyAiTranscriberSpeechModel? SpeechModel { get; set; }

    /// <summary>
    /// The WebSocket URL that the transcriber connects to.
    /// </summary>
    [JsonPropertyName("realtimeUrl")]
    public string? RealtimeUrl { get; set; }

    /// <summary>
    /// Add up to 2500 characters of custom vocabulary.
    /// </summary>
    [JsonPropertyName("wordBoost")]
    public IEnumerable<string>? WordBoost { get; set; }

    /// <summary>
    /// Keyterms prompting improves recognition accuracy for specific words and phrases.
    /// Can include up to 100 keyterms, each up to 50 characters.
    /// Costs an additional $0.04/hour when enabled.
    /// </summary>
    [JsonPropertyName("keytermsPrompt")]
    public IEnumerable<string>? KeytermsPrompt { get; set; }

    /// <summary>
    /// The duration of the end utterance silence threshold in milliseconds.
    /// </summary>
    [JsonPropertyName("endUtteranceSilenceThreshold")]
    public double? EndUtteranceSilenceThreshold { get; set; }

    /// <summary>
    /// Disable partial transcripts.
    /// Set to `true` to not receive partial transcripts. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("disablePartialTranscripts")]
    public bool? DisablePartialTranscripts { get; set; }

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
