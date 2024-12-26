using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record TrieveKnowledgeBaseVectorStoreSearchPlan
{
    /// <summary>
    /// If true, stop words (specified in server/src/stop-words.txt in the git repo) will be removed. This will preserve queries that are entirely stop words.
    /// </summary>
    [JsonPropertyName("removeStopWords")]
    public bool? RemoveStopWords { get; set; }

    /// <summary>
    /// This is the score threshold to filter out chunks with a score below the threshold for cosine distance metric. For Manhattan Distance, Euclidean Distance, and Dot Product, it will filter out scores above the threshold distance. This threshold applies before weight and bias modifications. If not specified, this defaults to no threshold. A threshold of 0 will default to no threshold.
    /// </summary>
    [JsonPropertyName("scoreThreshold")]
    public double? ScoreThreshold { get; set; }

    /// <summary>
    /// This is the search method used when searching for relevant chunks from the vector store.
    /// </summary>
    [JsonPropertyName("searchType")]
    public required TrieveKnowledgeBaseVectorStoreSearchPlanSearchType SearchType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}