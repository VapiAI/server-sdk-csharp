using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TrieveKnowledgeBaseCreate
{
    /// <summary>
    /// These are the chunk plans used to create the dataset.
    /// </summary>
    [JsonPropertyName("chunkPlans")]
    public IEnumerable<TrieveKnowledgeBaseChunkPlan> ChunkPlans { get; set; } =
        new List<TrieveKnowledgeBaseChunkPlan>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
