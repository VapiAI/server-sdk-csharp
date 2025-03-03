using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CartesiaExperimentalControls
{
    [JsonPropertyName("speed")]
    public CartesiaExperimentalControlsSpeed? Speed { get; set; }

    [JsonPropertyName("emotion")]
    public CartesiaExperimentalControlsEmotion? Emotion { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
