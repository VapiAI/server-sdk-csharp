using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TelnyxTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public TelnyxTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This is the call control ID of the Telnyx call.
    /// </summary>
    [JsonPropertyName("callControlId")]
    public string? CallControlId { get; set; }

    /// <summary>
    /// This is the call leg ID of the Telnyx call.
    /// </summary>
    [JsonPropertyName("callLegId")]
    public string? CallLegId { get; set; }

    /// <summary>
    /// This is the call session ID of the Telnyx call.
    /// </summary>
    [JsonPropertyName("callSessionId")]
    public string? CallSessionId { get; set; }

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
