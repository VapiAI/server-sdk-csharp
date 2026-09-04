using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Identifies a pronunciation dictionary and optional version used for voice synthesis.
/// </summary>
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
    /// Version ID (only used by ElevenLabs, ignored for Cartesia)
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary>
    /// Provider that hosts this pronunciation dictionary
    /// </summary>
    [JsonPropertyName("provider")]
    public VapiPronunciationDictionaryLocatorProvider? Provider { get; set; }

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
