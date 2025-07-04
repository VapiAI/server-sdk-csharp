using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackDeepgramVoice
{
    /// <summary>
    /// This is the flag to toggle voice caching for the assistant.
    /// </summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required FallbackDeepgramVoiceId VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used. Defaults to 'aura-2' when not specified.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackDeepgramVoiceModel? Model { get; set; }

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
