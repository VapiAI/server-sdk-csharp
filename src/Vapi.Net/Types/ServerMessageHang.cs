using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageHang
{
    /// <summary>
    /// This is the phone number associated with the call.
    ///
    /// This matches one of the following:
    /// - `call.phoneNumber`,
    /// - `call.phoneNumberId`.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "hang" is sent when the assistant is hanging due to a delay. The delay can be caused by many factors, such as:
    /// - the model is too slow to respond
    /// - the voice is too slow to respond
    /// - the tool call is still waiting for a response from your server
    /// - etc.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "hang";

    /// <summary>
    /// This is the ISO-8601 formatted timestamp of when the message was sent.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>
    /// This is a live version of the `call.artifact`.
    ///
    /// This matches what is stored on `call.artifact` after the call.
    /// </summary>
    [JsonPropertyName("artifact")]
    public Artifact? Artifact { get; set; }

    /// <summary>
    /// This is the assistant that is currently active. This is provided for convenience.
    ///
    /// This matches one of the following:
    /// - `call.assistant`,
    /// - `call.assistantId`,
    /// - `call.squad[n].assistant`,
    /// - `call.squad[n].assistantId`,
    /// - `call.squadId-&gt;[n].assistant`,
    /// - `call.squadId-&gt;[n].assistantId`.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the customer associated with the call.
    ///
    /// This matches one of the following:
    /// - `call.customer`,
    /// - `call.customerId`.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the call object.
    ///
    /// This matches what was returned in POST /call.
    ///
    /// Note: This might get stale during the call. To get the latest call object, especially after the call is ended, use GET /call/:id.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
