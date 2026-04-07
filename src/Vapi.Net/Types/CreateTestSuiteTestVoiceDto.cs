using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateTestSuiteTestVoiceDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// These are the scorers used to evaluate the test.
    /// </summary>
    [JsonPropertyName("scorers")]
    public IEnumerable<TestSuiteTestScorerAi> Scorers { get; set; } =
        new List<TestSuiteTestScorerAi>();

    /// <summary>
    /// This is the type of the test, which must be voice.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreateTestSuiteTestVoiceDtoType Type { get; set; }

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
