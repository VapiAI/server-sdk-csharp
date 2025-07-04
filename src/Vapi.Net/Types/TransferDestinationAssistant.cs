using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TransferDestinationAssistant
{
    /// <summary>
    /// This is spoken to the customer before connecting them to the destination.
    ///
    /// Usage:
    /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".
    /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.
    ///
    /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
    /// </summary>
    [JsonPropertyName("message")]
    public OneOf<string, CustomMessage>? Message { get; set; }

    /// <summary>
    /// This is the mode to use for the transfer. Defaults to `rolling-history`.
    ///
    /// - `rolling-history`: This is the default mode. It keeps the entire conversation history and appends the new assistant's system message on transfer.
    ///
    ///   Example:
    ///
    ///   Pre-transfer:
    ///     system: assistant1 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     assistant: (destination.message)
    ///
    ///   Post-transfer:
    ///     system: assistant1 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     assistant: (destination.message)
    ///     system: assistant2 system message
    ///     assistant: assistant2 first message (or model generated if firstMessageMode is set to `assistant-speaks-first-with-model-generated-message`)
    ///
    /// - `swap-system-message-in-history`: This replaces the original system message with the new assistant's system message on transfer.
    ///
    ///   Example:
    ///
    ///   Pre-transfer:
    ///     system: assistant1 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     assistant: (destination.message)
    ///
    ///   Post-transfer:
    ///     system: assistant2 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     assistant: (destination.message)
    ///     assistant: assistant2 first message (or model generated if firstMessageMode is set to `assistant-speaks-first-with-model-generated-message`)
    ///
    /// - `delete-history`: This deletes the entire conversation history on transfer.
    ///
    ///   Example:
    ///
    ///   Pre-transfer:
    ///     system: assistant1 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     assistant: (destination.message)
    ///
    ///   Post-transfer:
    ///     system: assistant2 system message
    ///     assistant: assistant2 first message
    ///     user: Yes, please
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///
    /// - `swap-system-message-in-history-and-remove-transfer-tool-messages`: This replaces the original system message with the new assistant's system message on transfer and removes transfer tool messages from conversation history sent to the LLM.
    ///
    ///   Example:
    ///
    ///   Pre-transfer:
    ///     system: assistant1 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     transfer-tool
    ///     transfer-tool-result
    ///     assistant: (destination.message)
    ///
    ///   Post-transfer:
    ///     system: assistant2 system message
    ///     assistant: assistant1 first message
    ///     user: hey, good morning
    ///     assistant: how can i help?
    ///     user: i need help with my account
    ///     assistant: (destination.message)
    ///     assistant: assistant2 first message (or model generated if firstMessageMode is set to `assistant-speaks-first-with-model-generated-message`)
    ///
    /// @default 'rolling-history'
    /// </summary>
    [JsonPropertyName("transferMode")]
    public TransferMode? TransferMode { get; set; }

    /// <summary>
    /// This is the assistant to transfer the call to.
    /// </summary>
    [JsonPropertyName("assistantName")]
    public required string AssistantName { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
