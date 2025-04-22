using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record KnowledgeBase
{
    /// <summary>
    /// The name of the knowledge base
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "google";

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
