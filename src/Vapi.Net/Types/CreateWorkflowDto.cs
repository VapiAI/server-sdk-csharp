using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateWorkflowDto
{
    [JsonPropertyName("nodes")]
    public IEnumerable<object> Nodes { get; set; } = new List<object>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge> Edges { get; set; } = new List<Edge>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
