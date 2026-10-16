using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A workflow node that invokes an inline tool or an existing saved tool.
/// </summary>
[Serializable]
public record ToolNode : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    /// <summary>
    /// Unique name used to identify this workflow node.
    /// </summary>
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
