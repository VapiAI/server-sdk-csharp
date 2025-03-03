using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackAzureVoice
{
    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<FallbackAzureVoiceVoiceId, string> VoiceId { get; set; }

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

    [JsonPropertyName("oneOf")]
    public object? OneOf { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
