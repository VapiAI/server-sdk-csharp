using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record RimeAiVoice
{
    /// <summary>
    /// This determines whether fillers are injected into the model output before inputting it into the voice provider.
    ///
    /// Default `false` because you can achieve better results with prompting the model.
    /// </summary>
    [JsonPropertyName("fillerInjectionEnabled")]
    public bool? FillerInjectionEnabled { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<RimeAiVoiceIdEnum, string> VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used. Defaults to 'v1' when not specified.
    /// </summary>
    [JsonPropertyName("model")]
    public RimeAiVoiceModel? Model { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

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
