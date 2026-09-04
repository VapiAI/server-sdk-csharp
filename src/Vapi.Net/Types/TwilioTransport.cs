using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TwilioTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public TwilioTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This is the account SID of the Twilio account.
    /// </summary>
    [JsonPropertyName("accountSid")]
    public string? AccountSid { get; set; }

    /// <summary>
    /// This is the call SID of the Twilio call.
    /// </summary>
    [JsonPropertyName("callSid")]
    public string? CallSid { get; set; }

    /// <summary>
    /// This is the call token of the Twilio call.
    /// </summary>
    [JsonPropertyName("callToken")]
    public string? CallToken { get; set; }

    /// <summary>
    /// This is the phone number from which the call was forwarded.
    /// Undefined if the call was not forwarded.
    /// </summary>
    [JsonPropertyName("forwardedFrom")]
    public string? ForwardedFrom { get; set; }

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
