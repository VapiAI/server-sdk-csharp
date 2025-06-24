using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageResponseKnowledgeBaseRequest
{
    /// <summary>
    /// This is the list of documents that will be sent to the model alongside the `messages` to generate a response.
    /// </summary>
    [JsonPropertyName("documents")]
    public IEnumerable<KnowledgeBaseResponseDocument>? Documents { get; set; }

    /// <summary>
    /// This can be used to skip the model output generation and speak a custom message.
    /// </summary>
    [JsonPropertyName("message")]
    public CustomMessage? Message { get; set; }

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
