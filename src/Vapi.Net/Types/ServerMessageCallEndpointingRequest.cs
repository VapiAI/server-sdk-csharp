using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageCallEndpointingRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "call.endpointing.request" is sent when using `assistant.startSpeakingPlan.smartEndpointingPlan={ "provider": "custom-endpointing-model" }`.
    ///
    /// Here is what the request will look like:
    ///
    /// POST https://{assistant.startSpeakingPlan.smartEndpointingPlan.server.url}
    /// Content-Type: application/json
    ///
    /// {
    ///   "message": {
    ///     "type": "call.endpointing.request",
    ///     "messages": [
    ///       {
    ///         "role": "user",
    ///         "message": "Hello, how are you?",
    ///         "time": 1234567890,
    ///         "secondsFromStart": 0
    ///       }
    ///     ],
    ///     ...other metadata about the call...
    ///   }
    /// }
    ///
    /// The expected response:
    /// {
    ///   "timeoutSeconds": 0.5
    /// }
    /// </summary>
    [JsonPropertyName("type")]
    public required ServerMessageCallEndpointingRequestType Type { get; set; }

    /// <summary>
    /// This is the conversation history at the time of the endpointing request.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<UserMessage, SystemMessage, BotMessage, ToolCallMessage, ToolCallResultMessage>
    >? Messages { get; set; }

    /// <summary>
    /// This is just `messages` formatted for OpenAI.
    /// </summary>
    [JsonPropertyName("messagesOpenAIFormatted")]
    public IEnumerable<OpenAiMessage> MessagesOpenAiFormatted { get; set; } =
        new List<OpenAiMessage>();

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
    /// This is the chat object.
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat? Chat { get; set; }

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
