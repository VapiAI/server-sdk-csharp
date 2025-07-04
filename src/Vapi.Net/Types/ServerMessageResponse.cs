using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
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
        ServerMessageResponseVoiceRequest,
        ServerMessageResponseCallEndpointingRequest
    > MessageResponse { get; set; }

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
