using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CallLogsPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<CallLogPrivileged> Results { get; set; } = new List<CallLogPrivileged>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
