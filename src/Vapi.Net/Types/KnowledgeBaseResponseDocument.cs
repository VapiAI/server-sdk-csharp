using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record KnowledgeBaseResponseDocument
{
    /// <summary>
    /// This is the content of the document.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// This is the similarity score of the document.
    /// </summary>
    [JsonPropertyName("similarity")]
    public required double Similarity { get; set; }

    /// <summary>
    /// This is the uuid of the document.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
