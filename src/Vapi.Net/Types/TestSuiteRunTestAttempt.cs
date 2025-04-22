using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuiteRunTestAttempt
{
    /// <summary>
    /// These are the results of the scorers used to evaluate the test attempt.
    /// </summary>
    [JsonPropertyName("scorerResults")]
    public IEnumerable<TestSuiteRunScorerAi> ScorerResults { get; set; } =
        new List<TestSuiteRunScorerAi>();

    /// <summary>
    /// This is the call made during the test attempt.
    /// </summary>
    [JsonPropertyName("call")]
    public TestSuiteRunTestAttemptCall? Call { get; set; }

    /// <summary>
    /// This is the call ID for the test attempt.
    /// </summary>
    [JsonPropertyName("callId")]
    public string? CallId { get; set; }

    /// <summary>
    /// This is the metadata for the test attempt.
    /// </summary>
    [JsonPropertyName("metadata")]
    public TestSuiteRunTestAttemptMetadata? Metadata { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
