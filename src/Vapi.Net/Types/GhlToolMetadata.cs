using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record GhlToolMetadata
{
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
