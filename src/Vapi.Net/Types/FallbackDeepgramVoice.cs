using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackDeepgramVoice
{
    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<FallbackDeepgramVoiceIdEnum, string> VoiceId { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
