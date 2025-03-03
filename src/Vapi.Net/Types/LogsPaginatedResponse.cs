using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record LogsPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<Log> Results { get; set; } = new List<Log>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
