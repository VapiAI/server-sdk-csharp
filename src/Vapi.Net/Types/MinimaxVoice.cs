using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MinimaxVoice
{
    /// <summary>
    /// This is the flag to toggle voice caching for the assistant.
    /// </summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used. Use a voice from MINIMAX_PREDEFINED_VOICES or a custom cloned voice ID.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required string VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used. Options are 'speech-02-hd' and 'speech-02-turbo'.
    /// speech-02-hd is optimized for high-fidelity applications like voiceovers and audiobooks.
    /// speech-02-turbo is designed for real-time applications with low latency.
    ///
    /// @default "speech-02-turbo"
    /// </summary>
    [JsonPropertyName("model")]
    public MinimaxVoiceModel? Model { get; set; }

    /// <summary>
    /// The emotion to use for the voice. If not provided, will use auto-detect mode.
    /// Options include: 'happy', 'sad', 'angry', 'fearful', 'surprised', 'disgusted', 'neutral'
    /// </summary>
    [JsonPropertyName("emotion")]
    public string? Emotion { get; set; }

    /// <summary>
    /// Voice pitch adjustment. Range from -12 to 12 semitones.
    /// @default 0
    /// </summary>
    [JsonPropertyName("pitch")]
    public double? Pitch { get; set; }

    /// <summary>
    /// Voice speed adjustment. Range from 0.5 to 2.0.
    /// @default 1.0
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// Voice volume adjustment. Range from 0.5 to 2.0.
    /// @default 1.0
    /// </summary>
    [JsonPropertyName("volume")]
    public double? Volume { get; set; }

    /// <summary>
    /// The region for Minimax API. Defaults to "worldwide".
    /// </summary>
    [JsonPropertyName("region")]
    public MinimaxVoiceRegion? Region { get; set; }

    /// <summary>
    /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
    /// </summary>
    [JsonPropertyName("languageBoost")]
    public MinimaxVoiceLanguageBoost? LanguageBoost { get; set; }

    /// <summary>
    /// Enable MiniMax text normalization to improve number reading and formatting.
    /// </summary>
    [JsonPropertyName("textNormalizationEnabled")]
    public bool? TextNormalizationEnabled { get; set; }

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
