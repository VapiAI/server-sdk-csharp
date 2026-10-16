using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantManagedVapiAgentsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Vapi Agents agent that manages the assistant.
    /// </summary>
    [JsonPropertyName("agentId")]
    public required string AgentId { get; set; }

    /// <summary>
    /// The agent's page in Vapi Agents.
    /// </summary>
    [JsonPropertyName("agentUrl")]
    public required string AgentUrl { get; set; }

    /// <summary>
    /// The Vapi Agents MCP server, where an AI client makes the change instead.
    /// </summary>
    [JsonPropertyName("mcpUrl")]
    public required string McpUrl { get; set; }

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
