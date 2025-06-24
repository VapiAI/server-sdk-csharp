using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ClientMessageConversationUpdate
{
    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "conversation-update" is sent when an update is committed to the conversation history.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "conversation-update";

    /// <summary>
    /// This is the most up-to-date conversation history at the time the message is sent.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<UserMessage, SystemMessage, BotMessage, ToolCallMessage, ToolCallResultMessage>
    >? Messages { get; set; }

    /// <summary>
    /// This is the most up-to-date conversation history at the time the message is sent, formatted for OpenAI.
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
    /// This is the call that the message is associated with.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

    /// <summary>
    /// This is the customer that the message is associated with.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the assistant that the message is associated with.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

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
