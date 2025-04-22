using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TrieveKnowledgeBaseSearchPlan
{
    /// <summary>
    /// Specifies the number of top chunks to return. This corresponds to the `page_size` parameter in Trieve.
    /// </summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

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
    public required TrieveKnowledgeBaseSearchPlanSearchType SearchType { get; set; }

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
