using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration for transcribing speech during assistant conversations with Soniox, including model, language detection, endpointing, vocabulary, and fallback settings.
/// </summary>
[Serializable]
public record SonioxTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Soniox model to use for transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public SonioxTranscriberModel? Model { get; set; }

    /// <summary>
    /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). For multi-language hints or to enable Soniox auto-detect, use `languages` instead — when `languages` is set (including to an empty array), this field is ignored when building the Soniox request. Defaults to `en` if neither this nor `languages` is set.
    /// </summary>
    [JsonPropertyName("language")]
    public SonioxTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Language hints sent to Soniox as `language_hints`. Provide `[lang1, lang2, ...]` (ISO 639-1 codes) to bias recognition toward specific languages, or provide an explicit empty array `[]` to enable Soniox auto-detect across all 60+ supported languages. When set (including the empty array), this field takes precedence over the singular `language` field. When omitted, falls back to the singular `language` (which defaults to `en` if also unset). Best accuracy is achieved with a single language.
    /// </summary>
    [JsonPropertyName("languages")]
    public IEnumerable<SonioxTranscriberLanguagesItem>? Languages { get; set; }

    /// <summary>
    /// When `true`, Soniox strictly restricts transcription to the languages in `languages` (or the singular `language` if `languages` is unset). When `false`, Soniox biases toward those languages but still allows transcription in other languages. Has no effect when no language hints are sent (e.g., `languages: []` for auto-detect). Defaults to `true` (strict mode).
    /// </summary>
    [JsonPropertyName("languageHintsStrict")]
    public bool? LanguageHintsStrict { get; set; }

    /// <summary>
    /// Maximum delay in milliseconds between when the speaker stops and when the endpoint is detected. Lower values mean faster turn-taking but more false endpoints. Range: 500-3000. Default: 500.
    /// </summary>
    [JsonPropertyName("maxEndpointDelayMs")]
    public double? MaxEndpointDelayMs { get; set; }

    /// <summary>
    /// How likely Soniox is to emit an endpoint (end the caller turn). Higher values make endpoints more likely for faster turn-taking; negative values make them less likely, which helps when callers pause mid-sentence (e.g. reading numbers group by group). Range: -1.0 to 1.0. Default: 0.3 (the platform low-latency voice profile; Soniox's own default is 0.0). Supported by stt-rt-v5; omitted from the Soniox request on explicit stt-rt-v4. Soniox recommends tuning endpointLatencyAdjustmentLevel first, and advises against negative sensitivity while the level is above 0 (the settings work against each other).
    /// </summary>
    [JsonPropertyName("endpointSensitivity")]
    public double? EndpointSensitivity { get; set; }

    /// <summary>
    /// How aggressively Soniox reduces endpoint latency. 0 is Soniox's default semantic endpointing; 3 is the most aggressive. Higher levels return endpoints sooner but may split speech into more segments and slightly reduce accuracy. Integer. Range: 0-3. Default: 2 (the platform low-latency voice profile; Soniox's own default is 0). Supported by stt-rt-v5; omitted from the Soniox request on explicit stt-rt-v4.
    /// </summary>
    [JsonPropertyName("endpointLatencyAdjustmentLevel")]
    public double? EndpointLatencyAdjustmentLevel { get; set; }

    /// <summary>
    /// Custom vocabulary terms to boost recognition accuracy. Useful for brand names, product names, and domain-specific terminology. Maps to Soniox context.terms.
    /// </summary>
    [JsonPropertyName("customVocabulary")]
    public IEnumerable<string>? CustomVocabulary { get; set; }

    /// <summary>
    /// General context key-value pairs that guide the AI model during transcription. Helps adapt vocabulary to the correct domain, improving accuracy. Recommended: 10 or fewer pairs. Maps to Soniox context.general.
    /// </summary>
    [JsonPropertyName("contextGeneral")]
    public IEnumerable<SonioxContextGeneralItem>? ContextGeneral { get; set; }

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
