using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ElevenLabsPronunciationDictionary
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
