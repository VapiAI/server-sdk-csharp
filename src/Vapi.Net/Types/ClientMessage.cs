using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessage
{
    /// <summary>
    /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
    /// </summary>
    [JsonPropertyName("message")]
    public required OneOf<
        ClientMessageWorkflowNodeStarted,
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
        ClientMessageVoiceInput
    > Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
