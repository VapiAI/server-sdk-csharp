using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateTestSuiteTestVoiceDto
{
    /// <summary>
    /// These are the scorers used to evaluate the test.
    /// </summary>
    [JsonPropertyName("scorers")]
    public IEnumerable<TestSuiteTestScorerAi> Scorers { get; set; } =
        new List<TestSuiteTestScorerAi>();

    /// <summary>
    /// This is the script to be used for the voice test.
    /// </summary>
    [JsonPropertyName("script")]
    public required string Script { get; set; }

    /// <summary>
    /// This is the number of attempts allowed for the test.
    /// </summary>
    [JsonPropertyName("numAttempts")]
    public double? NumAttempts { get; set; }

    /// <summary>
    /// This is the name of the test.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
