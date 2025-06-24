using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
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
