using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ElevenLabsVoice
{
    /// <summary>
    /// This determines whether fillers are injected into the model output before inputting it into the voice provider.
    ///
    /// Default `false` because you can achieve better results with prompting the model.
    /// </summary>
    [JsonPropertyName("fillerInjectionEnabled")]
    public bool? FillerInjectionEnabled { get; set; }

    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used. Ensure the Voice is present in your 11Labs Voice Library.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string
    > VoiceId { get; set; }

    /// <summary>
    /// Defines the stability for voice settings.
    /// </summary>
    [JsonPropertyName("stability")]
    public double? Stability { get; set; }

    /// <summary>
    /// Defines the similarity boost for voice settings.
    /// </summary>
    [JsonPropertyName("similarityBoost")]
    public double? SimilarityBoost { get; set; }

    /// <summary>
    /// Defines the style for voice settings.
    /// </summary>
    [JsonPropertyName("style")]
    public double? Style { get; set; }

    /// <summary>
    /// Defines the use speaker boost for voice settings.
    /// </summary>
    [JsonPropertyName("useSpeakerBoost")]
    public bool? UseSpeakerBoost { get; set; }

    /// <summary>
    /// Defines the optimize streaming latency for voice settings. Defaults to 3.
    /// </summary>
    [JsonPropertyName("optimizeStreamingLatency")]
    public double? OptimizeStreamingLatency { get; set; }

    /// <summary>
    /// This enables the use of https://elevenlabs.io/docs/speech-synthesis/prompting#pronunciation. Defaults to false to save latency.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enableSsmlParsing")]
    public bool? EnableSsmlParsing { get; set; }

    /// <summary>
    /// This is the model that will be used. Defaults to 'eleven_turbo_v2' if not specified.
    /// </summary>
    [JsonPropertyName("model")]
    public ElevenLabsVoiceModel? Model { get; set; }

    /// <summary>
    /// This is the language (ISO 639-1) that is enforced for the model. Currently only Turbo v2.5 supports language enforcement. For other models, an error will be returned if language code is provided.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
