using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ElevenLabsPronunciationDictionaryLocator
{
    /// <summary>
    /// This is the ID of the pronunciation dictionary to use.
    /// </summary>
    [JsonPropertyName("pronunciationDictionaryId")]
    public required string PronunciationDictionaryId { get; set; }

    /// <summary>
    /// This is the version ID of the pronunciation dictionary to use.
    /// </summary>
    [JsonPropertyName("versionId")]
    public required string VersionId { get; set; }

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
