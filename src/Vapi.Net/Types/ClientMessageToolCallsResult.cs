using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageToolCallsResult
{
    /// <summary>
    /// This is the type of the message. "tool-calls-result" is sent to forward the result of a tool call to the client.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "tool-calls-result";

    /// <summary>
    /// This is the result of the tool call.
    /// </summary>
    [JsonPropertyName("toolCallResult")]
    public object ToolCallResult { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
