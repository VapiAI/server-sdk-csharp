using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateVapiPhoneNumberDto
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
    /// This is the SIP URI of the phone number. You can SIP INVITE this. The assistant attached to this number will answer.
    ///
    /// This is case-insensitive.
    /// </summary>
    [JsonPropertyName("sipUri")]
    public required string SipUri { get; set; }

    /// <summary>
    /// This enables authentication for incoming SIP INVITE requests to the `sipUri`.
    ///
    /// If not set, any username/password to the 401 challenge of the SIP INVITE will be accepted.
    /// </summary>
    [JsonPropertyName("authentication")]
    public SipAuthentication? Authentication { get; set; }

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
    /// This is the server URL where messages will be sent for calls on this number. This includes the `assistant-request` message.
    ///
    /// You can see the shape of the messages sent in `ServerMessage`.
    ///
    /// This overrides the `org.serverUrl`. Order of precedence: tool.server.url &gt; assistant.serverUrl &gt; phoneNumber.serverUrl &gt; org.serverUrl.
    /// </summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>
    /// This is the secret Vapi will send with every message to your server. It's sent as a header called x-vapi-secret.
    ///
    /// Same precedence logic as serverUrl.
    /// </summary>
    [JsonPropertyName("serverUrlSecret")]
    public string? ServerUrlSecret { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
