using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantMessageJudgePlanExact : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is what that will be used to evaluate the model's message content.
    /// If you provide a string, the assistant message content will be evaluated against it as an exact match, case-insensitive.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// This is the tool calls that will be used to evaluate the model's message content.
    /// The tool name must be a valid tool that the assistant is allowed to call.
    ///
    /// For the Query tool, the arguments for the tool call are in the format - {knowledgeBaseNames: ['kb_name', 'kb_name_2']}
    ///
    /// For the DTMF tool, the arguments for the tool call are in the format - {dtmf: "1234*"}
    ///
    /// For the Handoff tool, the arguments for the tool call are in the format - {destination: "assistant_id"}
    ///
    /// For the Transfer Call tool, the arguments for the tool call are in the format - {destination: "phone_number_or_assistant_id"}
    ///
    /// For all other tools, they are called without arguments or with user-defined arguments
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
