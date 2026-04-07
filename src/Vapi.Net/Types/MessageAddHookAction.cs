using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MessageAddHookAction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The message to add to the conversation in OpenAI format
    /// </summary>
    [JsonPropertyName("message")]
    public required OpenAiMessage Message { get; set; }

    /// <summary>
    /// Whether to trigger an assistant response after adding the message
    /// </summary>
    [JsonPropertyName("triggerResponseEnabled")]
    public bool? TriggerResponseEnabled { get; set; }

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
