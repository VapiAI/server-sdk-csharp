using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record GeminiMultimodalLiveVoiceConfig
{
    [JsonPropertyName("prebuiltVoiceConfig")]
    public required GeminiMultimodalLivePrebuiltVoiceConfig PrebuiltVoiceConfig { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
