using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TwilioPhoneNumber
{
    /// <summary>
    /// This is the fallback destination an inbound call will be transferred to if:
    /// 1. `assistantId` is not set
    /// 2. `squadId` is not set
    /// 3. and, `assistant-request` message to the `serverUrl` fails
    ///
    /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
    /// </summary>
    [JsonPropertyName("fallbackDestination")]
    public object? FallbackDestination { get; set; }

    /// <summary>
    /// This is the hooks that will be used for incoming calls to this phone number.
    /// </summary>
    [JsonPropertyName("hooks")]
    public IEnumerable<PhoneNumberHookCallRinging>? Hooks { get; set; }

    /// <summary>
    /// Controls whether Vapi sets the messaging webhook URL on the Twilio number during import.
    ///
    /// If set to `false`, Vapi will not update the Twilio messaging URL, leaving it as is.
    /// If `true` or omitted (default), Vapi will configure both the voice and messaging URLs.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("smsEnabled")]
    public bool? SmsEnabled { get; set; }

    /// <summary>
    /// This is the unique identifier for the phone number.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this phone number belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the phone number was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the phone number was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the status of the phone number.
    /// </summary>
    [JsonPropertyName("status")]
    public TwilioPhoneNumberStatus? Status { get; set; }

    /// <summary>
    /// This is the Twilio Auth Token for the phone number.
    /// </summary>
    [JsonPropertyName("twilioAuthToken")]
    public string? TwilioAuthToken { get; set; }

    /// <summary>
    /// This is the Twilio API Key for the phone number.
    /// </summary>
    [JsonPropertyName("twilioApiKey")]
    public string? TwilioApiKey { get; set; }

    /// <summary>
    /// This is the Twilio API Secret for the phone number.
    /// </summary>
    [JsonPropertyName("twilioApiSecret")]
    public string? TwilioApiSecret { get; set; }

    /// <summary>
    /// This is the name of the phone number. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the assistant that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId`, `squadId` nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the workflow that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
    /// </summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>
    /// This is the squad that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.
    ///
    /// The order of precedence is:
    ///
    /// 1. assistant.server
    /// 2. phoneNumber.server
    /// 3. org.server
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    /// <summary>
    /// These are the digits of the phone number you own on your Twilio.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    /// <summary>
    /// This is the Twilio Account SID for the phone number.
    /// </summary>
    [JsonPropertyName("twilioAccountSid")]
    public required string TwilioAccountSid { get; set; }

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
