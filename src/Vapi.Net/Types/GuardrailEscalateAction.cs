using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GuardrailEscalateAction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required GuardrailEscalateActionType Type { get; set; }

    /// <summary>
    /// Existing same-organization tool; attachment is checked at assignment. Tool edits/deletion can invalidate the action: activation must revalidate the current tool and arguments, and use failurePolicy on failure.
    /// </summary>
    [JsonPropertyName("toolId")]
    public required string ToolId { get; set; }

    /// <summary>
    /// Parameter names follow the normalized tool schema (SMS uses body/to).
    /// </summary>
    [JsonPropertyName("arguments")]
    public object Arguments { get; set; } = new Dictionary<string, object?>();

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
