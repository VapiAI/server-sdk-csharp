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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
