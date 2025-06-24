using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiResponsesRequest
{
    /// <summary>
    /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the name of the chat. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the ID of the session that will be used for the chat.
    /// Mutually exclusive with previousChatId.
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>
    /// This is the input text for the chat.
    /// Can be a string or an array of chat messages.
    /// This field is REQUIRED for chat creation.
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
    /// This is the ID of the chat that will be used as context for the new chat.
    /// The messages from the previous chat will be used as context.
    /// Mutually exclusive with sessionId.
    /// </summary>
    [JsonPropertyName("previousChatId")]
    public string? PreviousChatId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
