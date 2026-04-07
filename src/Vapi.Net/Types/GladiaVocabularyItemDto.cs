using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GladiaVocabularyItemDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The vocabulary word or phrase
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    /// <summary>
    /// Alternative pronunciations for the vocabulary item
    /// </summary>
    [JsonPropertyName("pronunciations")]
    public IEnumerable<string>? Pronunciations { get; set; }

    /// <summary>
    /// Intensity for this specific vocabulary item (0.0 to 1.0)
    /// </summary>
    [JsonPropertyName("intensity")]
    public double? Intensity { get; set; }

    /// <summary>
    /// Language code for this vocabulary item (ISO 639-1)
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

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
