using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageStatusUpdate
{
    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "status-update" is sent whenever the `call.status` changes.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "status-update";

    /// <summary>
    /// This is the status of the call.
    /// </summary>
    [JsonPropertyName("status")]
    public required ServerMessageStatusUpdateStatus Status { get; set; }

    /// <summary>
    /// This is the reason the call ended. This is only sent if the status is "ended".
    /// </summary>
    [JsonPropertyName("endedReason")]
    public ServerMessageStatusUpdateEndedReason? EndedReason { get; set; }

    /// <summary>
    /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<UserMessage, SystemMessage, BotMessage, ToolCallMessage, ToolCallResultMessage>
    >? Messages { get; set; }

    /// <summary>
    /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
    /// </summary>
    [JsonPropertyName("messagesOpenAIFormatted")]
    public IEnumerable<OpenAiMessage>? MessagesOpenAiFormatted { get; set; }

    /// <summary>
    /// This is the destination the call is being transferred to. This is only sent if the status is "forwarding".
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    /// <summary>
    /// This is the timestamp of the message.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double? Timestamp { get; set; }

    /// <summary>
    /// This is a live version of the `call.artifact`.
    ///
    /// This matches what is stored on `call.artifact` after the call.
    /// </summary>
    [JsonPropertyName("artifact")]
    public Artifact? Artifact { get; set; }

    /// <summary>
    /// This is the assistant that the message is associated with.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the customer that the message is associated with.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the call that the message is associated with.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

    /// <summary>
    /// This is the transcript of the call. This is only sent if the status is "forwarding".
    /// </summary>
    [JsonPropertyName("transcript")]
    public string? Transcript { get; set; }

    /// <summary>
    /// This is the summary of the call. This is only sent if the status is "forwarding".
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// This is the inbound phone call debugging artifacts. This is only sent if the status is "ended" and there was an error accepting the inbound phone call.
    ///
    /// This will include any errors related to the "assistant-request" if one was made.
    /// </summary>
    [JsonPropertyName("inboundPhoneCallDebuggingArtifacts")]
    public object? InboundPhoneCallDebuggingArtifacts { get; set; }

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
