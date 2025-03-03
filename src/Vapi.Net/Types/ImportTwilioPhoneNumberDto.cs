using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ImportTwilioPhoneNumberDto
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
    /// These are the digits of the phone number you own on your Twilio.
    /// </summary>
    [JsonPropertyName("twilioPhoneNumber")]
    public required string TwilioPhoneNumber { get; set; }

    /// <summary>
    /// This is your Twilio Account SID that will be used to handle this phone number.
    /// </summary>
    [JsonPropertyName("twilioAccountSid")]
    public required string TwilioAccountSid { get; set; }

    /// <summary>
    /// This is the Twilio Auth Token that will be used to handle this phone number.
    /// </summary>
    [JsonPropertyName("twilioAuthToken")]
    public required string TwilioAuthToken { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
