using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrieveKnowledgeBaseCreate
{
    /// <summary>
    /// This is to create a new dataset on Trieve.
    /// </summary>
    [JsonPropertyName("type")]
    public required TrieveKnowledgeBaseCreateType Type { get; set; }

    /// <summary>
    /// These are the chunk plans used to create the dataset.
    /// </summary>
    [JsonPropertyName("chunkPlans")]
    public IEnumerable<TrieveKnowledgeBaseChunkPlan> ChunkPlans { get; set; } =
        new List<TrieveKnowledgeBaseChunkPlan>();

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
