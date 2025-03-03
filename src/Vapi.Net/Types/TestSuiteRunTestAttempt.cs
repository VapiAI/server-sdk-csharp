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
    public required TestSuiteRunTestAttemptCall Call { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
