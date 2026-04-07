using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TwilioSmsChatTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public TwilioSmsChatTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This is the phone number that will be used to send the SMS.
    /// If provided, will create a new session. If not provided, uses existing session's phoneNumberId.
    /// The phone number must have SMS enabled and belong to your organization.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the customer who will receive the SMS.
    /// If provided, will create a new session. If not provided, uses existing session's customer.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the customerId of the customer who will receive the SMS.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// Whether to use LLM-generated messages for outbound SMS.
    /// When true (default), input is processed by the assistant for a response.
    /// When false, the input text is forwarded directly as the SMS message without LLM processing.
    /// Useful for sending pre-defined messages or notifications.
    /// </summary>
    [JsonPropertyName("useLLMGeneratedMessageForOutbound")]
    public bool? UseLlmGeneratedMessageForOutbound { get; set; }

    /// <summary>
    /// The type of transport to use for sending the chat response.
    /// Currently supports 'twilio.sms' for SMS delivery via Twilio.
    /// </summary>
    [JsonPropertyName("type")]
    public required TwilioSmsChatTransportType Type { get; set; }

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
