using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration for synthesizing assistant speech with Deepgram, including voice and model selection, model-improvement preferences, chunking, caching, and fallback settings.
/// </summary>
[Serializable]
public record DeepgramVoice : IJsonOnDeserialized
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
    public required DeepgramVoiceId VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used. Defaults to 'aura' when not specified.
    /// </summary>
    [JsonPropertyName("model")]
    public DeepgramVoiceModel? Model { get; set; }

    /// <summary>
    /// If set to true, this will add mip_opt_out=true as a query parameter of all API requests. See https://developers.deepgram.com/docs/the-deepgram-model-improvement-partnership-program#want-to-opt-out
    ///
    /// This only applies to your own Deepgram API key. Requests on Vapi's key always opt out, whatever this is set to.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("mipOptOut")]
    public bool? MipOptOut { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used. Aura-2 accepts 0.7 to 1.5; Flux accepts 0.5 to 1.5 in steps of 0.05. Aura does not support speed.
    ///
    /// @default 1
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// This is the expressivity level for Flux voices, from -2 (flat) to 2 (lively). Deepgram marks this control as beta and may retune the scale. Aura and Aura-2 do not support it.
    ///
    /// @default 0
    /// </summary>
    [JsonPropertyName("expressivity")]
    public double? Expressivity { get; set; }

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
