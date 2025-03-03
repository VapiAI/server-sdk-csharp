using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuiteRunsPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<TestSuiteRun> Results { get; set; } = new List<TestSuiteRun>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
