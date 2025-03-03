using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageConversationUpdate
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
