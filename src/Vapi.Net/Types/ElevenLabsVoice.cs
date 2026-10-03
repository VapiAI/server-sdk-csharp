using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration for synthesizing assistant speech with ElevenLabs, including voice and model selection, language, voice tuning, streaming, Speech Synthesis Markup Language parsing, pronunciation dictionaries, chunking, caching, and fallback settings.
/// </summary>
[Serializable]
public record ElevenLabsVoice : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the flag to toggle voice caching for the assistant.
    /// </summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used. Ensure the Voice is present in your 11Labs Voice Library.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<ElevenLabsVoiceIdEnum, string> VoiceId { get; set; }

    /// <summary>
    /// Defines the stability for voice settings.
    /// </summary>
    [JsonPropertyName("stability")]
    public double? Stability { get; set; }

    /// <summary>
    /// Defines the similarity boost for voice settings. Ignored by `eleven_v4_turbo`.
    /// </summary>
    [JsonPropertyName("similarityBoost")]
    public double? SimilarityBoost { get; set; }

    /// <summary>
    /// Defines the style for voice settings. Ignored by `eleven_v4_turbo`.
    /// </summary>
    [JsonPropertyName("style")]
    public double? Style { get; set; }

    /// <summary>
    /// Defines the use speaker boost for voice settings. Ignored by `eleven_v4_turbo`.
    /// </summary>
    [JsonPropertyName("useSpeakerBoost")]
    public bool? UseSpeakerBoost { get; set; }

    /// <summary>
    /// Defines the speed for voice settings. Ignored by `eleven_v4_turbo`.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// Defines the optimize streaming latency for voice settings. Defaults to 3. Ignored by `eleven_v4_turbo`.
    /// </summary>
    [JsonPropertyName("optimizeStreamingLatency")]
    public double? OptimizeStreamingLatency { get; set; }

    /// <summary>
    /// This enables the use of https://elevenlabs.io/docs/speech-synthesis/prompting#pronunciation. Defaults to false to save latency. Ignored by `eleven_v4_turbo`.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enableSsmlParsing")]
    public bool? EnableSsmlParsing { get; set; }

    /// <summary>
    /// Defines the auto mode for voice settings. Defaults to false. Ignored by `eleven_v4_turbo`.
    /// </summary>
    [JsonPropertyName("autoMode")]
    public bool? AutoMode { get; set; }

    /// <summary>
    /// This is the model that will be used. Defaults to 'eleven_turbo_v2' if not specified.
    /// </summary>
    [JsonPropertyName("model")]
    public ElevenLabsVoiceModel? Model { get; set; }

    /// <summary>
    /// This is the language (ISO 639-1) that is enforced for the model. Currently only Turbo v2.5, Flash v2.5 and v4 Turbo support language enforcement; other models ignore it.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    /// <summary>
    /// This is the pronunciation dictionary locators to use.
    /// </summary>
    [JsonPropertyName("pronunciationDictionaryLocators")]
    public IEnumerable<ElevenLabsPronunciationDictionaryLocator>? PronunciationDictionaryLocators { get; set; }

    /// <summary>
    /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackPlan? FallbackPlan { get; set; }

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
