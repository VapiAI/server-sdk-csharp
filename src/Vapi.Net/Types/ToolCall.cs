using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ToolCall
{
    /// <summary>
    /// This is the type of tool the model called.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the function the model called.
    /// </summary>
    [JsonPropertyName("function")]
    public required ToolCallFunction Function { get; set; }

    /// <summary>
    /// This is the unique identifier for the tool call.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
