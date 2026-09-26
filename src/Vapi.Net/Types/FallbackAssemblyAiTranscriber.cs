using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Fallback configuration for transcribing speech with AssemblyAI, including language, streaming model, endpointing, and vocabulary.
/// </summary>
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
    /// This is the transcription mode used by the Universal Pro speech models. Only applies to `universal-3-5-pro` and `universal-3-6-pro`.
    ///
    /// @default 'balanced'
    /// </summary>
    [JsonPropertyName("mode")]
    public FallbackAssemblyAiTranscriberMode? Mode { get; set; }

    /// <summary>
    /// This is a prompt that provides additional context to the transcription model. Only applies to `universal-3-5-pro` and `universal-3-6-pro`.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }

    /// <summary>
    /// This is context about the voice agent that guides the transcription model. Only applies to `universal-3-5-pro` and `universal-3-6-pro`.
    /// </summary>
    [JsonPropertyName("agentContext")]
    public string? AgentContext { get; set; }

    /// <summary>
    /// When true, the text the assistant just spoke is sent to AssemblyAI as `agent_context` after every assistant turn, replacing the previous value, so the user's reply is transcribed in the context of the question it answers.
    /// `agentContext` still seeds the first turn. Text longer than 1750 characters keeps its last 1750 characters. Turns the user interrupted are not sent when the interruption is detected by voice activity (the default, `stopSpeakingPlan.numWords: 0`).
    /// Only applies to `universal-3-5-pro` and `universal-3-6-pro`.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("agentContextAutoUpdateEnabled")]
    public bool? AgentContextAutoUpdateEnabled { get; set; }

    /// <summary>
    /// These are language codes used to steer automatic language detection. Only applies to `universal-3-5-pro` and `universal-3-6-pro`.
    /// `ur`, `ru`, `ko`, `ca`, `gl`, `ro`, `et`, `fa`, `yue`, `af`, `mr`, `zu`, `xh` and `nn` were added with `universal-3-6-pro`.
    /// </summary>
    [JsonPropertyName("languageCodes")]
    public IEnumerable<FallbackAssemblyAiTranscriberLanguageCodesItem>? LanguageCodes { get; set; }

    /// <summary>
    /// This is the speech model used for the streaming session.
    /// Keyterms prompting is supported on universal-streaming-english, universal-3-5-pro and universal-3-6-pro.
    /// universal-3-6-pro is AssemblyAI's newest and most accurate voice-agent model.
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
    /// Costs an additional $0.04/hour on universal-streaming-english and is included at no extra cost on the Universal Pro models (universal-3-5-pro, universal-3-6-pro).
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
