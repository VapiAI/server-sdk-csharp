using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ChatCompletionMessage
{
    [JsonPropertyName("role")]
    public object Role { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("metadata")]
    public ChatCompletionMessageMetadata? Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
