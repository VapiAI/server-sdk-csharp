using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalAssistantMessageMock
{
    /// <summary>
    /// This is the content of the assistant message.
    /// This is the message that the assistant would have sent.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// This is the tool calls that will be made by the assistant.
    /// </summary>
    [JsonPropertyName("toolCalls")]
    public IEnumerable<ChatEvalAssistantMessageMockToolCall>? ToolCalls { get; set; }

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
