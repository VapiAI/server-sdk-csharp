using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record GladiaTranscriber
{
    [JsonPropertyName("model")]
    public GladiaTranscriberModel? Model { get; set; }

    [JsonPropertyName("languageBehaviour")]
    public GladiaTranscriberLanguageBehaviour? LanguageBehaviour { get; set; }

    /// <summary>
    /// Defines the language to use for the transcription. Required when languageBehaviour is 'manual'.
    /// </summary>
    [JsonPropertyName("language")]
    public GladiaTranscriberLanguage? Language { get; set; }

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
