using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateTrieveKnowledgeBaseDto
{
    /// <summary>
    /// This is the name of the knowledge base.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the searching plan used when searching for relevant chunks from the vector store.
    ///
    /// You should configure this if you're running into these issues:
    /// - Too much unnecessary context is being fed as knowledge base context.
    /// - Not enough relevant context is being fed as knowledge base context.
    /// </summary>
    [JsonPropertyName("searchPlan")]
    public TrieveKnowledgeBaseSearchPlan? SearchPlan { get; set; }

    /// <summary>
    /// This is the plan if you want us to create/import a new vector store using Trieve.
    /// </summary>
    [JsonPropertyName("createPlan")]
    public object? CreatePlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
