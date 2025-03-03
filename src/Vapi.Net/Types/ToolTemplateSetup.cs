using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ToolTemplateSetup
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("videoUrl")]
    public string? VideoUrl { get; set; }

    [JsonPropertyName("docsUrl")]
    public string? DocsUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
