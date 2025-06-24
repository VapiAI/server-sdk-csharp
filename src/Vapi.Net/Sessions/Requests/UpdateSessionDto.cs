using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateSessionDto
{
    /// <summary>
    /// This is the new name for the session. Maximum length is 40 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the new status for the session.
    /// </summary>
    [JsonPropertyName("status")]
    public UpdateSessionDtoStatus? Status { get; set; }

    /// <summary>
    /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.
    /// </summary>
    [JsonPropertyName("expirationSeconds")]
    public double? ExpirationSeconds { get; set; }

    /// <summary>
    /// This is the updated array of chat messages.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<SystemMessage, UserMessage, AssistantMessage, ToolMessage, DeveloperMessage>
    >? Messages { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
