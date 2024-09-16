using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record UserMessage
{
    /// <summary>
    /// The role of the user in the conversation.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>
    /// The message content from the user.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// The timestamp when the message was sent.
    /// </summary>
    [JsonPropertyName("time")]
    public required double Time { get; set; }

    /// <summary>
    /// The timestamp when the message ended.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required double EndTime { get; set; }

    /// <summary>
    /// The number of seconds from the start of the conversation.
    /// </summary>
    [JsonPropertyName("secondsFromStart")]
    public required double SecondsFromStart { get; set; }

    /// <summary>
    /// The duration of the message in seconds.
    /// </summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
