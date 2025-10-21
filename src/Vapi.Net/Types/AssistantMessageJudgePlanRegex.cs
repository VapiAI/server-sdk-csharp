using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantMessageJudgePlanRegex
{
    /// <summary>
    /// This is what that will be used to evaluate the model's message content.
    /// The content will be evaluated against the regex pattern provided in the Judge Plan content field.
    /// Evaluation is considered successful if the regex pattern matches any part of the assistant message content.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// This is the tool calls that will be used to evaluate the model's message content.
    /// The tool name must be a valid tool that the assistant is allowed to call.
    /// The values to the arguments for the tool call should be a Regular Expression.
    /// Evaluation is considered successful if the regex pattern matches any part of each tool call argument.
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
