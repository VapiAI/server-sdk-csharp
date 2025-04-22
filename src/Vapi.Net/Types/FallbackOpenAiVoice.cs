using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackOpenAiVoice
{
    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// Please note that ash, ballad, coral, sage, and verse may only be used with realtime models.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<FallbackOpenAiVoiceIdEnum, string> VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used for text-to-speech.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackOpenAiVoiceModel? Model { get; set; }

    /// <summary>
    /// This is a prompt that allows you to control the voice of your generated audio.
    /// Does not work with 'tts-1' or 'tts-1-hd' models.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

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
