using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MicrosoftVoice : IJsonOnDeserialized
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
    /// MAI-Voice-2 voice ID. Built-in voices listed in enum.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required MicrosoftVoiceVoiceId VoiceId { get; set; }

    /// <summary>
    /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.
    /// </summary>
    [JsonPropertyName("style")]
    public MicrosoftVoiceStyle? Style { get; set; }

    /// <summary>
    /// Style intensity (0.01–2). Default 1 = the predefined style strength. Only applies when `style` is set.
    /// </summary>
    [JsonPropertyName("styleDegree")]
    public double? StyleDegree { get; set; }

    /// <summary>
    /// Role-play (age/gender imitation). Requires `style` to be set; ignored otherwise.
    /// </summary>
    [JsonPropertyName("role")]
    public MicrosoftVoiceRole? Role { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

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
