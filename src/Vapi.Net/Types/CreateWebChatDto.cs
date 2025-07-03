using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateWebChatDto
{
    /// <summary>
    /// The assistant ID to use for this chat
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// This is the ID of the session that will be used for the chat.
    /// If provided, the conversation will continue from the previous state.
    /// If not provided or expired, a new session will be created.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>
    /// These are the variable values that will be used to replace template variables in the assistant messages.
    /// Only variable substitution is supported in web chat - other assistant properties cannot be overridden.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public ChatAssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// This is the customer information for the chat.
    /// Used to automatically manage sessions for repeat customers.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateWebCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the input text for the chat.
    /// Can be a string or an array of chat messages.
    /// </summary>
    [JsonPropertyName("input")]
    public required OneOf<
        string,
        IEnumerable<
            OneOf<SystemMessage, UserMessage, AssistantMessage, ToolMessage, DeveloperMessage>
        >
    > Input { get; set; }

    /// <summary>
    /// This is a flag that determines whether the response should be streamed.
    /// When true, the response will be sent as chunks of text.
    /// </summary>
    [JsonPropertyName("stream")]
    public bool? Stream { get; set; }

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
