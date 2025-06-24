using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record NodeArtifact
{
    /// <summary>
    /// This is the node id.
    /// </summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary>
    /// This is the messages that were spoken during the node.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    /// <summary>
    /// This is the object containing the variables extracted from the node.
    /// </summary>
    [JsonPropertyName("variables")]
    public object? Variables { get; set; }

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
