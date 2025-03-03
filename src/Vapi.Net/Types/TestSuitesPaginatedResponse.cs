using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuitesPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<TestSuite> Results { get; set; } = new List<TestSuite>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
