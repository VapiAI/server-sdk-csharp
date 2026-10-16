using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantManagedConflictResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Vapi Agents manages the assistant. The lock refuses writes to the assistant itself (update, replace, delete, restore, version delete, traffic splits) and to outcomes, monitors and structured outputs that link or unlink it. It doesn't cover what changes a call without writing the assistant: call-level assistantOverrides or assistantVersion, squad member pins and overrides, which phone number points at it, edits to the tools or knowledge bases it references, or Vapi's own model-retirement sweep.
    /// </summary>
    [JsonPropertyName("error")]
    public required AssistantManagedConflictResponseDtoError Error { get; set; }

    /// <summary>
    /// Why the write was rejected and how to make the change in Vapi Agents instead: the agent link, the Vapi Agents MCP URL with the steps to connect it, and which of its tools to call.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("vapiAgents")]
    public required AssistantManagedVapiAgentsDto VapiAgents { get; set; }

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
