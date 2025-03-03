using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SystemMessage
{
    /// <summary>
    /// The role of the system in the conversation.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>
    /// The message content from the system.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// The timestamp when the message was sent.
    /// </summary>
    [JsonPropertyName("time")]
    public required double Time { get; set; }

    /// <summary>
    /// The number of seconds from the start of the conversation.
    /// </summary>
    [JsonPropertyName("secondsFromStart")]
    public required double SecondsFromStart { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
