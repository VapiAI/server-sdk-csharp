using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record TextContent
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("language")]
    public required TextContentLanguage Language { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
