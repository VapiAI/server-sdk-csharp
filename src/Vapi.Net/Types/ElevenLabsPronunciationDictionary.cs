using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ElevenLabsPronunciationDictionary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the pronunciation dictionary
    /// </summary>
    [JsonPropertyName("pronunciationDictionaryId")]
    public required string PronunciationDictionaryId { get; set; }

    /// <summary>
    /// The name of the pronunciation dictionary
    /// </summary>
    [JsonPropertyName("dictionaryName")]
    public required string DictionaryName { get; set; }

    /// <summary>
    /// The user ID of the creator
    /// </summary>
    [JsonPropertyName("createdBy")]
    public required string CreatedBy { get; set; }

    /// <summary>
    /// The creation time in Unix timestamp
    /// </summary>
    [JsonPropertyName("creationTimeUnix")]
    public required double CreationTimeUnix { get; set; }

    /// <summary>
    /// The version ID of the pronunciation dictionary
    /// </summary>
    [JsonPropertyName("versionId")]
    public required string VersionId { get; set; }

    /// <summary>
    /// The number of rules in this version
    /// </summary>
    [JsonPropertyName("versionRulesNum")]
    public required double VersionRulesNum { get; set; }

    /// <summary>
    /// The permission level on this resource
    /// </summary>
    [JsonPropertyName("permissionOnResource")]
    public ElevenLabsPronunciationDictionaryPermissionOnResource? PermissionOnResource { get; set; }

    /// <summary>
    /// The description of the pronunciation dictionary
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
