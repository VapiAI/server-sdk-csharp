using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VapiPhoneNumber
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
    public VapiPhoneNumberStatus? Status { get; set; }

    /// <summary>
    /// These are the digits of the phone number you purchased from Vapi.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// This is the name of the phone number. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the assistant that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId` nor `squadId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the squad that will be used for incoming calls to this phone number.
    ///
    /// If neither `assistantId` nor `squadId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
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
    /// This is the area code of the phone number to purchase.
    /// </summary>
    [JsonPropertyName("numberDesiredAreaCode")]
    public string? NumberDesiredAreaCode { get; set; }

    /// <summary>
    /// This is the SIP URI of the phone number. You can SIP INVITE this. The assistant attached to this number will answer.
    ///
    /// This is case-insensitive.
    /// </summary>
    [JsonPropertyName("sipUri")]
    public string? SipUri { get; set; }

    /// <summary>
    /// This enables authentication for incoming SIP INVITE requests to the `sipUri`.
    ///
    /// If not set, any username/password to the 401 challenge of the SIP INVITE will be accepted.
    /// </summary>
    [JsonPropertyName("authentication")]
    public SipAuthentication? Authentication { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
