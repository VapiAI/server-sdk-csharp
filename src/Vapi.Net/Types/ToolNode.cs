using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolNode
{
    /// <summary>
    /// This is the tool to call. To use an existing tool, send `toolId` instead.
    /// </summary>
    [JsonPropertyName("tool")]
    public object? Tool { get; set; }

    /// <summary>
    /// This is the tool to call. To use a transient tool, send `tool` instead.
    /// </summary>
    [JsonPropertyName("toolId")]
    public string? ToolId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is whether or not the node is the start of the workflow.
    /// </summary>
    [JsonPropertyName("isStart")]
    public bool? IsStart { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the task.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

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
