using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageWorkflowNodeStarted
{
    /// <summary>
    /// This is the type of the message. "workflow.node.started" is sent when the active node changes.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "workflow.node.started";

    /// <summary>
    /// This is the active node.
    /// </summary>
    [JsonPropertyName("node")]
    public object Node { get; set; } = new Dictionary<string, object?>();

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
