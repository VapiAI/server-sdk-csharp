using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TrieveKnowledgeBaseImport
{
    /// <summary>
    /// This is the `datasetId` of the dataset on your Trieve account.
    /// </summary>
    [JsonPropertyName("providerId")]
    public required string ProviderId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
