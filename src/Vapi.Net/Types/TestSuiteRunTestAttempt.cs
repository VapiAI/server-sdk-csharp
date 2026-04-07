using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TestSuiteRunTestAttempt : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
