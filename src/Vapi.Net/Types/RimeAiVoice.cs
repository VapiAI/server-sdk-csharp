using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record RimeAiVoice : IJsonOnDeserialized
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
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<RimeAiVoiceIdEnum, string> VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used. Defaults to 'arcana' when not specified.
    /// </summary>
    [JsonPropertyName("model")]
    public RimeAiVoiceModel? Model { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// This is a flag that controls whether to add slight pauses using angle brackets. Example: "Hi. &lt;200&gt; I'd love to have a conversation with you." adds a 200ms pause between the first and second sentences.
    /// </summary>
    [JsonPropertyName("pauseBetweenBrackets")]
    public bool? PauseBetweenBrackets { get; set; }

    /// <summary>
    /// This is a flag that controls whether text inside brackets should be phonemized (converted to phonetic pronunciation) - Example: "{h'El.o} World" will pronounce "Hello" as expected.
    /// </summary>
    [JsonPropertyName("phonemizeBetweenBrackets")]
    public bool? PhonemizeBetweenBrackets { get; set; }

    /// <summary>
    /// This is a flag that controls whether to optimize for reduced latency in streaming. https://docs.rime.ai/api-reference/endpoint/websockets#param-reduce-latency
    /// </summary>
    [JsonPropertyName("reduceLatency")]
    public bool? ReduceLatency { get; set; }

    /// <summary>
    /// This is a string that allows inline speed control using alpha notation. https://docs.rime.ai/api-reference/endpoint/websockets#param-inline-speed-alpha
    /// </summary>
    [JsonPropertyName("inlineSpeedAlpha")]
    public string? InlineSpeedAlpha { get; set; }

    /// <summary>
    /// Language for speech synthesis. Uses ISO 639 codes. Supported: en, es, de, fr, ar, hi, ja, he, pt, ta, si.
    /// </summary>
    [JsonPropertyName("language")]
    public RimeAiVoiceLanguage? Language { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

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
