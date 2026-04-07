using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrieveKnowledgeBaseCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
