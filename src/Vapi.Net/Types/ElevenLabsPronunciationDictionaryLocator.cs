using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Identifies a specific version of an ElevenLabs pronunciation dictionary.
/// </summary>
[Serializable]
public record ElevenLabsPronunciationDictionaryLocator : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the ID of the pronunciation dictionary to use.
    /// </summary>
    [JsonPropertyName("pronunciationDictionaryId")]
    public required string PronunciationDictionaryId { get; set; }

    /// <summary>
    /// This is the version ID of the pronunciation dictionary to use.
    ///
    /// Omit to use the dictionary's latest version.
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
