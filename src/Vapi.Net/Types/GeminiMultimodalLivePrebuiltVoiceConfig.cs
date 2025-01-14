using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record GeminiMultimodalLivePrebuiltVoiceConfig
{
    [JsonPropertyName("voiceName")]
    public required GeminiMultimodalLivePrebuiltVoiceConfigVoiceName VoiceName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
