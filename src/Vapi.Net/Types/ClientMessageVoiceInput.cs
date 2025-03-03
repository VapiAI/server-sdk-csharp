using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageVoiceInput
{
    /// <summary>
    /// This is the type of the message. "voice-input" is sent when a generation is requested from voice provider.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "voice-input";

    /// <summary>
    /// This is the voice input content
    /// </summary>
    [JsonPropertyName("input")]
    public required string Input { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
