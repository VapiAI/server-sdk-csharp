using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrieveKnowledgeBaseImport
{
    /// <summary>
    /// This is to import an existing dataset from Trieve.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "import";

    /// <summary>
    /// This is the `datasetId` of the dataset on your Trieve account.
    /// </summary>
    [JsonPropertyName("providerId")]
    public required string ProviderId { get; set; }

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
