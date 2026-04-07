using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record DeepgramTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the Deepgram model that will be used. A list of models can be found here: https://developers.deepgram.com/docs/models-languages-overview
    /// </summary>
    [JsonPropertyName("model")]
    public DeepgramTranscriberModel? Model { get; set; }

    /// <summary>
    /// This is the language that will be set for the transcription. The list of languages Deepgram supports can be found here: https://developers.deepgram.com/docs/models-languages-overview
    /// </summary>
    [JsonPropertyName("language")]
    public DeepgramTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// This will be use smart format option provided by Deepgram. It's default disabled because it can sometimes format numbers as times but it's getting better.
    /// </summary>
    [JsonPropertyName("smartFormat")]
    public bool? SmartFormat { get; set; }

    /// <summary>
    /// If set to true, this will add mip_opt_out=true as a query parameter of all API requests. See https://developers.deepgram.com/docs/the-deepgram-model-improvement-partnership-program#want-to-opt-out
    ///
    /// This will only be used if you are using your own Deepgram API key.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("mipOptOut")]
    public bool? MipOptOut { get; set; }

    /// <summary>
    /// If set to true, this will cause deepgram to convert spoken numbers to literal numerals. For example, "my phone number is nine-seven-two..." would become "my phone number is 972..."
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("numerals")]
    public bool? Numerals { get; set; }

    /// <summary>
    /// If set to true, Deepgram will replace profanity in transcripts with surrounding asterisks, e.g. "f***".
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("profanityFilter")]
    public bool? ProfanityFilter { get; set; }

    /// <summary>
    /// Transcripts below this confidence threshold will be discarded.
    ///
    /// @default 0.4
    /// </summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>
    /// Eager end-of-turn confidence required to fire a eager end-of-turn event. Setting a value here will enable EagerEndOfTurn and SpeechResumed events. It is disabled by default. Only used with Flux models.
    /// </summary>
    [JsonPropertyName("eagerEotThreshold")]
    public double? EagerEotThreshold { get; set; }

    /// <summary>
    /// End-of-turn confidence required to finish a turn. Only used with Flux models.
    ///
    /// @default 0.7
    /// </summary>
    [JsonPropertyName("eotThreshold")]
    public double? EotThreshold { get; set; }

    /// <summary>
    /// A turn will be finished when this much time has passed after speech, regardless of EOT confidence. Only used with Flux models.
    ///
    /// @default 5000
    /// </summary>
    [JsonPropertyName("eotTimeoutMs")]
    public double? EotTimeoutMs { get; set; }

    /// <summary>
    /// These keywords are passed to the transcription model to help it pick up use-case specific words. Anything that may not be a common word, like your company name, should be added here.
    /// </summary>
    [JsonPropertyName("keywords")]
    public IEnumerable<string>? Keywords { get; set; }

    /// <summary>
    /// Keyterm Prompting allows you improve Keyword Recall Rate (KRR) for important keyterms or phrases up to 90%.
    /// </summary>
    [JsonPropertyName("keyterm")]
    public IEnumerable<string>? Keyterm { get; set; }

    /// <summary>
    /// This is the timeout after which Deepgram will send transcription on user silence. You can read in-depth documentation here: https://developers.deepgram.com/docs/endpointing.
    ///
    /// Here are the most important bits:
    /// - Defaults to 10. This is recommended for most use cases to optimize for latency.
    /// - 10 can cause some missing transcriptions since because of the shorter context. This mostly happens for one-word utterances. For those uses cases, it's recommended to try 300. It will add a bit of latency but the quality and reliability of the experience will be better.
    /// - If neither 10 nor 300 work, contact support@vapi.ai and we'll find another solution.
    ///
    /// @default 10
    /// </summary>
    [JsonPropertyName("endpointing")]
    public double? Endpointing { get; set; }

    /// <summary>
    /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackTranscriberPlan? FallbackPlan { get; set; }

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
