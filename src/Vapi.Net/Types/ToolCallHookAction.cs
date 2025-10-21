using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolCallHookAction
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
