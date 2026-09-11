using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdatePersonalityDto
{
    /// <summary>
    /// This is the name of the personality.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Complete assistant replacement. Omitted credentials and redacted server secrets are preserved when their endpoint URL is unchanged. Send credentials: [] to clear credentials; omit a server container to remove it.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// Optional folder path for organizing personalities.
    /// Supports up to 3 levels (e.g., "dept/feature/variant").
    /// Set to null to remove from folder.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
