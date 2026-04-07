using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GeneratedScenario : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Short descriptive name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Instructions for the tester
    /// </summary>
    [JsonPropertyName("instructions")]
    public required string Instructions { get; set; }

    /// <summary>
    /// Scenario category
    /// </summary>
    [JsonPropertyName("category")]
    public required GeneratedScenarioCategory Category { get; set; }

    /// <summary>
    /// Why this scenario is valuable
    /// </summary>
    [JsonPropertyName("reasoning")]
    public required string Reasoning { get; set; }

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
