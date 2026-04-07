using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record KnowledgeBase : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The name of the knowledge base
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    [JsonPropertyName("provider")]
    public required KnowledgeBaseProvider Provider { get; set; }

    /// <summary>
    /// The model to use for the knowledge base
    /// </summary>
    [JsonPropertyName("model")]
    public KnowledgeBaseModel? Model { get; set; }

    /// <summary>
    /// A description of the knowledge base
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The file IDs associated with this knowledge base
    /// </summary>
    [JsonPropertyName("fileIds")]
    public IEnumerable<string> FileIds { get; set; } = new List<string>();

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
