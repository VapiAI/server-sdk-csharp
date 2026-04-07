using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TestSuiteRunTestResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
