using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalAssistantMessageMock : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the role of the message author.
    /// For a mock assistant message, the role is always 'assistant'
    /// @default 'assistant'
    /// </summary>
    [JsonPropertyName("role")]
    public required ChatEvalAssistantMessageMockRole Role { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
