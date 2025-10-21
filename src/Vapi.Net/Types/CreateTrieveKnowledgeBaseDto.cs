using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateTrieveKnowledgeBaseDto
{
    /// <summary>
    /// This knowledge base is provided by Trieve.
    ///
    /// To learn more about Trieve, visit https://trieve.ai.
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "trieve";

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
    public TrieveKnowledgeBaseImport? CreatePlan { get; set; }

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
