using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageResponseToolCalls
{
    /// <summary>
    /// These are the results of the "tool-calls" message.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<ToolCallResult>? Results { get; set; }

    /// <summary>
    /// This is the error message if the tool call was not successful.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
