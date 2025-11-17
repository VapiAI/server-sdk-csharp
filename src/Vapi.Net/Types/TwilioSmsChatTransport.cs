using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TwilioSmsChatTransport
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
