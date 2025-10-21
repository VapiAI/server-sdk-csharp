using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateChatDto
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
    /// These are the variable values that will be used to replace template variables in the assistant messages.
    /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
    /// </summary>
    [JsonPropertyName("squad")]
    public CreateSquadDto? Squad { get; set; }

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
    /// This is a flag that determines whether the response should be streamed.
    /// When true, the response will be sent as chunks of text.
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

    /// <summary>
    /// This is used to send the chat through a transport like SMS.
    /// If transport.phoneNumberId and transport.customer are provided, creates a new session.
    /// If sessionId is provided without transport fields, uses existing session data.
    /// Cannot specify both sessionId and transport fields (phoneNumberId/customer) together.
    /// </summary>
    [JsonPropertyName("transport")]
    public TwilioSmsChatTransport? Transport { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
