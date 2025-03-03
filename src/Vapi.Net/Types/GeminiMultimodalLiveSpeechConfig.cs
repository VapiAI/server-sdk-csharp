using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record GeminiMultimodalLiveSpeechConfig
{
    [JsonPropertyName("voiceConfig")]
    public required GeminiMultimodalLiveVoiceConfig VoiceConfig { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
