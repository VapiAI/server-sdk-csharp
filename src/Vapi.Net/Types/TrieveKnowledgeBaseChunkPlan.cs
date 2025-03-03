using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TrieveKnowledgeBaseChunkPlan
{
    /// <summary>
    /// These are the file ids that will be used to create the vector store. To upload files, use the `POST /files` endpoint.
    /// </summary>
    [JsonPropertyName("fileIds")]
    public IEnumerable<string>? FileIds { get; set; }

    /// <summary>
    /// These are the websites that will be used to create the vector store.
    /// </summary>
    [JsonPropertyName("websites")]
    public IEnumerable<string>? Websites { get; set; }

    /// <summary>
    /// This is an optional field which allows you to specify the number of splits you want per chunk. If not specified, the default 20 is used. However, you may want to use a different number.
    /// </summary>
    [JsonPropertyName("targetSplitsPerChunk")]
    public double? TargetSplitsPerChunk { get; set; }

    /// <summary>
    /// This is an optional field which allows you to specify the delimiters to use when splitting the file before chunking the text. If not specified, the default [.!?\n] are used to split into sentences. However, you may want to use spaces or other delimiters.
    /// </summary>
    [JsonPropertyName("splitDelimiters")]
    public IEnumerable<string>? SplitDelimiters { get; set; }

    /// <summary>
    /// This is an optional field which allows you to specify whether or not to rebalance the chunks created from the file. If not specified, the default true is used. If true, Trieve will evenly distribute remainder splits across chunks such that 66 splits with a target_splits_per_chunk of 20 will result in 3 chunks with 22 splits each.
    /// </summary>
    [JsonPropertyName("rebalanceChunks")]
    public bool? RebalanceChunks { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
