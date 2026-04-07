using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiPronunciationDictionaryLocator : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The pronunciation dictionary ID
    /// </summary>
    [JsonPropertyName("pronunciationDictId")]
    public required string PronunciationDictId { get; set; }

    /// <summary>
    /// Version ID (only required for ElevenLabs, ignored for Cartesia)
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

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
