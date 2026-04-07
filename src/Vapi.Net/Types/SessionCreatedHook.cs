using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SessionCreatedHook : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    [JsonPropertyName("on")]
    public required SessionCreatedHookOn On { get; set; }

    /// <summary>
    /// This is the set of actions to perform when the hook triggers.
    /// </summary>
    [JsonPropertyName("do")]
    public IEnumerable<ToolCallHookAction> Do { get; set; } = new List<ToolCallHookAction>();

    /// <summary>
    /// Optional name for this hook instance.
    /// If no name is provided, the hook will be auto generated as UUID.
    ///
    /// @default UUID
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
