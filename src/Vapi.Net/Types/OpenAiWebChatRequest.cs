using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiWebChatRequest
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
    /// This is the expiration time for the session. This can ONLY be set if starting a new chat and therefore a new session is created.
    /// If session already exists, this will be ignored and NOT be updated for the existing session. Use PATCH /session/:id to update the session expiration time.
    /// </summary>
    [JsonPropertyName("sessionExpirationSeconds")]
    public double? SessionExpirationSeconds { get; set; }

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
    /// Whether to stream the response or not.
    /// </summary>
    [JsonPropertyName("stream")]
    public bool? Stream { get; set; }

    /// <summary>
    /// This is a flag to indicate end of session. When true, the session will be marked as completed and the chat will be ended.
    /// Used to end session to send End-of-session report to the customer.
    /// When flag is set to true, any messages sent will not be processed and session will directly be marked as completed.
    /// </summary>
    [JsonPropertyName("sessionEnd")]
    public bool? SessionEnd { get; set; }

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
