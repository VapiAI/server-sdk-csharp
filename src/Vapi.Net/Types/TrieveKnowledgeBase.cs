using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrieveKnowledgeBase : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This knowledge base is provided by Trieve.
    ///
    /// To learn more about Trieve, visit https://trieve.ai.
    /// </summary>
    [JsonPropertyName("provider")]
    public required TrieveKnowledgeBaseProvider Provider { get; set; }

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
    /// This is the id of the knowledge base.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the org id of the knowledge base.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
