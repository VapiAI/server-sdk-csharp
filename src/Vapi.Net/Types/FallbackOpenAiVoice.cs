using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackOpenAiVoice
{
    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// Please note that ash, ballad, coral, sage, and verse may only be used with realtime models.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required FallbackOpenAiVoiceId VoiceId { get; set; }

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
