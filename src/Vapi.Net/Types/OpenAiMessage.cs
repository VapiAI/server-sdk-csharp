using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record OpenAiMessage
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("role")]
    public required OpenAiMessageRole Role { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
