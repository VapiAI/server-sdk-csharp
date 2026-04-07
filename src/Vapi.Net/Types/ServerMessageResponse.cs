using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the response that is expected from the server to the message.
    ///
    /// Note: Most messages don't expect a response. Only "assistant-request", "tool-calls" and "transfer-destination-request" do.
    /// </summary>
    [JsonPropertyName("messageResponse")]
    public required OneOf<
        ServerMessageResponseAssistantRequest,
        ServerMessageResponseHandoffDestinationRequest,
        ServerMessageResponseKnowledgeBaseRequest,
        ServerMessageResponseToolCalls,
        ServerMessageResponseTransferDestinationRequest,
        ServerMessageResponseVoiceRequest,
        ServerMessageResponseCallEndpointingRequest
    > MessageResponse { get; set; }

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
