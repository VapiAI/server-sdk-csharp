using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GenerateScenariosResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Generated scenarios
    /// </summary>
    [JsonPropertyName("scenarios")]
    public IEnumerable<GeneratedScenario> Scenarios { get; set; } = new List<GeneratedScenario>();

    /// <summary>
    /// Summary of test coverage
    /// </summary>
    [JsonPropertyName("coverageNotes")]
    public required string CoverageNotes { get; set; }

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
