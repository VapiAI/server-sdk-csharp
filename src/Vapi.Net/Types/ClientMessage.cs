using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ClientMessage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
    /// </summary>
    [JsonPropertyName("message")]
    public required OneOf<
        ClientMessageWorkflowNodeStarted,
        ClientMessageAssistantStarted,
        ClientMessageConversationUpdate,
        ClientMessageHang,
        ClientMessageMetadata,
        ClientMessageModelOutput,
        ClientMessageSpeechUpdate,
        ClientMessageTranscript,
        ClientMessageToolCalls,
        ClientMessageToolCallsResult,
        ClientMessageTransferUpdate,
        ClientMessageUserInterrupted,
        ClientMessageLanguageChangeDetected,
        ClientMessageVoiceInput,
        ClientMessageAssistantSpeech,
        ClientMessageChatCreated,
        ClientMessageChatDeleted,
        ClientMessageSessionCreated,
        ClientMessageSessionUpdated,
        ClientMessageSessionDeleted,
        ClientMessageCallDeleted,
        ClientMessageCallDeleteFailed
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
