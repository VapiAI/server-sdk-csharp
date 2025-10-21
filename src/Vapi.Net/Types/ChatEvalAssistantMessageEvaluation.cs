using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalAssistantMessageEvaluation
{
    /// <summary>
    /// This is the role of the message author.
    /// For an assistant message evaluation, the role is always 'assistant'
    /// @default 'assistant'
    /// </summary>
    [JsonPropertyName("role")]
    public string Role { get; set; } = "assistant";

    /// <summary>
    /// This is the judge plan that instructs how to evaluate the assistant message.
    /// The assistant message can be evaluated against fixed content (exact match or RegEx) or with an LLM-as-judge by defining the evaluation criteria in a prompt.
    /// </summary>
    [JsonPropertyName("judgePlan")]
    public required object JudgePlan { get; set; }

    /// <summary>
    /// This is the plan for how the overall evaluation will proceed after the assistant message is evaluated.
    /// This lets you configure whether to stop the evaluation if this message fails, and whether to override any content for future turns
    /// </summary>
    [JsonPropertyName("continuePlan")]
    public AssistantMessageEvaluationContinuePlan? ContinuePlan { get; set; }

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
