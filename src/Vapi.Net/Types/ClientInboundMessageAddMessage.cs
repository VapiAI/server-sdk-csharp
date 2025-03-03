using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientInboundMessageAddMessage
{
    /// <summary>
    /// This is the message to add to the conversation.
    /// </summary>
    [JsonPropertyName("message")]
    public required OpenAiMessage Message { get; set; }

    /// <summary>
    /// This is the flag to trigger a response, or to insert the message into the conversation history silently. Defaults to `true`.
    ///
    /// Usage:
    /// - Use `true` to trigger a response.
    /// - Use `false` to insert the message into the conversation history silently.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("triggerResponseEnabled")]
    public bool? TriggerResponseEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
