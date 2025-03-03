using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuiteRunTestResult
{
    /// <summary>
    /// This is the test that was run.
    /// </summary>
    [JsonPropertyName("test")]
    public required TestSuiteTestVoice Test { get; set; }

    /// <summary>
    /// These are the attempts made for this test.
    /// </summary>
    [JsonPropertyName("attempts")]
    public IEnumerable<TestSuiteRunTestAttempt> Attempts { get; set; } =
        new List<TestSuiteRunTestAttempt>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
