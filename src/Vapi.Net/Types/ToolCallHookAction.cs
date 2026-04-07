using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolCallHookAction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of action - must be "tool"
    /// </summary>
    [JsonPropertyName("type")]
    public required ToolCallHookActionType Type { get; set; }

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
