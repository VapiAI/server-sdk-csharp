using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuiteTestsPaginatedResponse
{
    /// <summary>
    /// A list of test suite tests.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<TestSuiteTestVoice> Results { get; set; } = new List<TestSuiteTestVoice>();

    /// <summary>
    /// Metadata about the pagination.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
