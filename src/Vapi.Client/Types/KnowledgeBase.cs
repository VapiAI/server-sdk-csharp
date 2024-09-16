using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record KnowledgeBase
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    [JsonPropertyName("fileIds")]
    public IEnumerable<string> FileIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
