using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessage
{
    /// <summary>
    /// These are all the messages that can be sent to your server before, after and during the call. Configure the messages you'd like to receive in `assistant.serverMessages`.
    ///
    /// The server where the message is sent is determined by the following precedence order:
    ///
    /// 1. `tool.server.url` (if configured, and only for "tool-calls" message)
    /// 2. `assistant.serverUrl` (if configure)
    /// 3. `phoneNumber.serverUrl` (if configured)
    /// 4. `org.serverUrl` (if configured)
    /// </summary>
    [JsonPropertyName("message")]
    public required OneOf<
        ServerMessageAssistantRequest,
        ServerMessageConversationUpdate,
        ServerMessageEndOfCallReport,
        ServerMessageHang,
        ServerMessageKnowledgeBaseRequest,
        ServerMessageModelOutput,
        ServerMessagePhoneCallControl,
        ServerMessageSpeechUpdate,
        ServerMessageStatusUpdate,
        ServerMessageToolCalls,
        ServerMessageTransferDestinationRequest,
        ServerMessageTransferUpdate,
        ServerMessageTranscript,
        ServerMessageUserInterrupted,
        ServerMessageLanguageChangeDetected,
        ServerMessageVoiceInput,
        ServerMessageVoiceRequest,
        ServerMessageCallEndpointingRequest
    > Message { get; set; }

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
