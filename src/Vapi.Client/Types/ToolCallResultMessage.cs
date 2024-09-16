using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ToolCallResultMessage
{
    /// <summary>
    /// The role of the tool call result in the conversation.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>
    /// The ID of the tool call.
    /// </summary>
    [JsonPropertyName("toolCallId")]
    public required string ToolCallId { get; set; }

    /// <summary>
    /// The name of the tool that returned the result.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The result of the tool call in JSON format.
    /// </summary>
    [JsonPropertyName("result")]
    public required string Result { get; set; }

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
