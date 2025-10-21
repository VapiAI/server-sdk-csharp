using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GladiaTranscriber
{
    /// <summary>
    /// This is the Gladia model that will be used. Default is 'fast'
    /// </summary>
    [JsonPropertyName("model")]
    public GladiaTranscriberModel? Model { get; set; }

    /// <summary>
    /// Defines how the transcription model detects the audio language. Default value is 'automatic single language'.
    /// </summary>
    [JsonPropertyName("languageBehaviour")]
    public GladiaTranscriberLanguageBehaviour? LanguageBehaviour { get; set; }

    /// <summary>
    /// Defines the language to use for the transcription. Required when languageBehaviour is 'manual'.
    /// </summary>
    [JsonPropertyName("language")]
    public GladiaTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Defines the languages to use for the transcription. Required when languageBehaviour is 'manual'.
    /// </summary>
    [JsonPropertyName("languages")]
    public GladiaTranscriberLanguages? Languages { get; set; }

    /// <summary>
    /// Provides a custom vocabulary to the model to improve accuracy of transcribing context specific words, technical terms, names, etc. If empty, this argument is ignored.
    /// ⚠️ Warning ⚠️: Please be aware that the transcription_hint field has a character limit of 600. If you provide a transcription_hint longer than 600 characters, it will be automatically truncated to meet this limit.
    /// </summary>
    [JsonPropertyName("transcriptionHint")]
    public string? TranscriptionHint { get; set; }

    /// <summary>
    /// If prosody is true, you will get a transcription that can contain prosodies i.e. (laugh) (giggles) (malefic laugh) (toss) (music)… Default value is false.
    /// </summary>
    [JsonPropertyName("prosody")]
    public bool? Prosody { get; set; }

    /// <summary>
    /// If true, audio will be pre-processed to improve accuracy but latency will increase. Default value is false.
    /// </summary>
    [JsonPropertyName("audioEnhancer")]
    public bool? AudioEnhancer { get; set; }

    /// <summary>
    /// Transcripts below this confidence threshold will be discarded.
    ///
    /// @default 0.4
    /// </summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>
    /// Endpointing time in seconds - time to wait before considering speech ended
    /// </summary>
    [JsonPropertyName("endpointing")]
    public double? Endpointing { get; set; }

    /// <summary>
    /// Speech threshold - sensitivity configuration for speech detection (0.0 to 1.0)
    /// </summary>
    [JsonPropertyName("speechThreshold")]
    public double? SpeechThreshold { get; set; }

    /// <summary>
    /// Enable custom vocabulary for improved accuracy
    /// </summary>
    [JsonPropertyName("customVocabularyEnabled")]
    public bool? CustomVocabularyEnabled { get; set; }

    /// <summary>
    /// Custom vocabulary configuration
    /// </summary>
    [JsonPropertyName("customVocabularyConfig")]
    public GladiaCustomVocabularyConfigDto? CustomVocabularyConfig { get; set; }

    /// <summary>
    /// Region for processing audio (us-west or eu-west)
    /// </summary>
    [JsonPropertyName("region")]
    public GladiaTranscriberRegion? Region { get; set; }

    /// <summary>
    /// Enable partial transcripts for low-latency streaming transcription
    /// </summary>
    [JsonPropertyName("receivePartialTranscripts")]
    public bool? ReceivePartialTranscripts { get; set; }

    /// <summary>
    /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackTranscriberPlan? FallbackPlan { get; set; }

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
