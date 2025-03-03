using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageResponse
{
    /// <summary>
    /// This is the response that is expected from the server to the message.
    ///
    /// Note: Most messages don't expect a response. Only "assistant-request", "tool-calls" and "transfer-destination-request" do.
    /// </summary>
    [JsonPropertyName("messageResponse")]
    public required OneOf<
        ServerMessageResponseAssistantRequest,
        ServerMessageResponseKnowledgeBaseRequest,
        ServerMessageResponseToolCalls,
        ServerMessageResponseTransferDestinationRequest,
        ServerMessageResponseVoiceRequest
    > MessageResponse { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
