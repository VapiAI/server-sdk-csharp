using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ToolCallMessage
{
    /// <summary>
    /// The role of the tool call in the conversation.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>
    /// The list of tool calls made during the conversation.
    /// </summary>
    [JsonPropertyName("toolCalls")]
    public IEnumerable<object> ToolCalls { get; set; } = new List<object>();

    /// <summary>
    /// The message content for the tool call.
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
