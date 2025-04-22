using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateWorkflowDto
{
    [JsonPropertyName("nodes")]
    public IEnumerable<object>? Nodes { get; set; }

    /// <summary>
    /// These are the options for the workflow's LLM.
    /// </summary>
    [JsonPropertyName("model")]
    public object? Model { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge>? Edges { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
