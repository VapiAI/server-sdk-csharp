using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VonageTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public VonageTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This is the conversation UUID of the Vonage call.
    /// </summary>
    [JsonPropertyName("conversationUUID")]
    public string? ConversationUuid { get; set; }

    /// <summary>
    /// This is the call ID of the Vonage call.
    /// </summary>
    [JsonPropertyName("callUUID")]
    public string? CallUuid { get; set; }

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
