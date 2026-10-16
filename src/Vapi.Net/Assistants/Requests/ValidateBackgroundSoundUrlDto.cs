using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ValidateBackgroundSoundUrlDto
{
    /// <summary>
    /// This is the background sound URL to validate. The server performs a ranged request and checks that the URL serves a live media file.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
