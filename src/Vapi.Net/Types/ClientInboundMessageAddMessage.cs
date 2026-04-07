using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ClientInboundMessageAddMessage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the message to add to the conversation.
    /// </summary>
    [JsonPropertyName("message")]
    public required OpenAiMessage Message { get; set; }

    /// <summary>
    /// This is the flag to trigger a response, or to insert the message into the conversation history silently. Defaults to `true`.
    ///
    /// Usage:
    /// - Use `true` to trigger a response.
    /// - Use `false` to insert the message into the conversation history silently.
    ///
    /// @default true
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
