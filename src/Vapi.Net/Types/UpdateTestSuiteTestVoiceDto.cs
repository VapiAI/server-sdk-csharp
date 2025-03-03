using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateTestSuiteTestVoiceDto
{
    /// <summary>
    /// These are the scorers used to evaluate the test.
    /// </summary>
    [JsonPropertyName("scorers")]
    public IEnumerable<TestSuiteTestScorerAi>? Scorers { get; set; }

    /// <summary>
    /// This is the name of the test.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the script to be used for the voice test.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// This is the number of attempts allowed for the test.
    /// </summary>
    [JsonPropertyName("numAttempts")]
    public double? NumAttempts { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
