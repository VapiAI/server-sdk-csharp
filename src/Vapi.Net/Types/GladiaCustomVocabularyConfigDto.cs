using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GladiaCustomVocabularyConfigDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Array of vocabulary items (strings or objects with value, pronunciations, intensity, language)
    /// </summary>
    [JsonPropertyName("vocabulary")]
    public IEnumerable<OneOf<string, GladiaVocabularyItemDto>> Vocabulary { get; set; } =
        new List<OneOf<string, GladiaVocabularyItemDto>>();

    /// <summary>
    /// Default intensity for vocabulary items (0.0 to 1.0)
    /// </summary>
    [JsonPropertyName("defaultIntensity")]
    public double? DefaultIntensity { get; set; }

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
