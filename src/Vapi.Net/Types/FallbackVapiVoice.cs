using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Fallback configuration for synthesizing assistant speech with Vapi, including voice selection, speed, pronunciation dictionary, chunking, and caching.
/// </summary>
[Serializable]
public record FallbackVapiVoice : IJsonOnDeserialized
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
    /// The voice to use: a built-in Vapi voice name, or a cloned voice id (used with version 2).
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required string VoiceId { get; set; }

    /// <summary>
    /// The Vapi voice routing generation. `latest` auto-updates to the newest generation; version 1 uses legacy mappings; version 2 can use xAI-backed voices when available. When omitted, Version 1 is used. Accepts the string channel ('latest', '1', '2'); legacy numeric values (1, 2) are also accepted and coerced to their string form.
    /// </summary>
    [JsonPropertyName("version")]
    public FallbackVapiVoiceVersion? Version { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used.
    ///
    /// @default 1
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// Language for Vapi voice synthesis. For Version 2, omit this field or set `auto` for automatic language detection. Version 1 supports legacy Vapi language values.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackVapiVoiceLanguage? Language { get; set; }

    /// <summary>
    /// List of pronunciation dictionary locators for custom word pronunciations.
    /// </summary>
    [JsonPropertyName("pronunciationDictionary")]
    public IEnumerable<VapiPronunciationDictionaryLocator>? PronunciationDictionary { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

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
