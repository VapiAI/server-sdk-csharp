using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record BlockStartMessage
{
    /// <summary>
    /// This is an optional array of conditions that must be met for this message to be triggered.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<object>? Conditions { get; set; }

    /// <summary>
    /// This is the content that the assistant will say when this message is triggered.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
