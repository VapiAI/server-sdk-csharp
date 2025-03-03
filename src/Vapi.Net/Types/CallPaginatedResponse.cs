using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CallPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<Call> Results { get; set; } = new List<Call>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
