using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ClientInboundMessageSay : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the flag for whether the message should replace existing assistant speech.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("interruptAssistantEnabled")]
    public bool? InterruptAssistantEnabled { get; set; }

    /// <summary>
    /// This is the content to say.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// This is the flag to end call after content is spoken.
    /// </summary>
    [JsonPropertyName("endCallAfterSpoken")]
    public bool? EndCallAfterSpoken { get; set; }

    /// <summary>
    /// This is the flag for whether the message is interruptible by the user.
    /// </summary>
    [JsonPropertyName("interruptionsEnabled")]
    public bool? InterruptionsEnabled { get; set; }

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
