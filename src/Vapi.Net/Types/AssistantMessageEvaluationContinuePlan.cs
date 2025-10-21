using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantMessageEvaluationContinuePlan
{
    /// <summary>
    /// This is whether the evaluation should exit if the assistant message evaluates to false.
    /// By default, it is false and the evaluation will continue.
    /// @default false
    /// </summary>
    [JsonPropertyName("exitOnFailureEnabled")]
    public bool? ExitOnFailureEnabled { get; set; }

    /// <summary>
    /// This is the content that will be used in the conversation for this assistant turn moving forward if provided.
    /// It will override the content received from the model.
    /// </summary>
    [JsonPropertyName("contentOverride")]
    public string? ContentOverride { get; set; }

    /// <summary>
    /// This is the tool calls that will be used in the conversation for this assistant turn moving forward if provided.
    /// It will override the tool calls received from the model.
    /// </summary>
    [JsonPropertyName("toolCallsOverride")]
    public IEnumerable<ChatEvalAssistantMessageMockToolCall>? ToolCallsOverride { get; set; }

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
