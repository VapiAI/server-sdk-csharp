using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VoiceLibraryVoiceResponse
{
    [JsonPropertyName("voiceId")]
    public required string VoiceId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("publicOwnerId")]
    public string? PublicOwnerId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("age")]
    public object? Age { get; set; }

    [JsonPropertyName("accent")]
    public string? Accent { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
