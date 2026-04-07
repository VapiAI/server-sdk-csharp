using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
        ServerMessageHandoffDestinationRequest,
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
        ServerMessageAssistantSpeech,
        ServerMessageVoiceRequest,
        ServerMessageCallEndpointingRequest,
        ServerMessageChatCreated,
        ServerMessageChatDeleted,
        ServerMessageSessionCreated,
        ServerMessageSessionUpdated,
        ServerMessageSessionDeleted,
        ServerMessageCallDeleted,
        ServerMessageCallDeleteFailed
    > Message { get; set; }

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
