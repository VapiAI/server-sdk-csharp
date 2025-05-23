using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackVapiVoice
{
    /// <summary>
    /// This is the flag to toggle voice caching for the assistant.
    /// </summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>
    /// The voices provided by Vapi
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required FallbackVapiVoiceVoiceId VoiceId { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used.
    ///
    /// @default 1
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// This is the language code (ISO 639-1) that will be used.
    ///
    /// @default 'en-US'
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackVapiVoiceLanguage? Language { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

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
