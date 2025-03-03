using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Workflow
{
    [JsonPropertyName("nodes")]
    public IEnumerable<object> Nodes { get; set; } = new List<object>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge> Edges { get; set; } = new List<Edge>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
