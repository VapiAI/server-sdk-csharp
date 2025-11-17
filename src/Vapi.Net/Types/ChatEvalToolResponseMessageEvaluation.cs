using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalToolResponseMessageEvaluation
{
    /// <summary>
    /// This is the role of the message author.
    /// For a tool response message evaluation, the role is always 'tool'
    /// @default 'tool'
    /// </summary>
    [JsonPropertyName("role")]
    public required ChatEvalToolResponseMessageEvaluationRole Role { get; set; }

    /// <summary>
    /// This is the judge plan that instructs how to evaluate the tool response message.
    /// The tool response message can be evaluated with an LLM-as-judge by defining the evaluation criteria in a prompt.
    /// </summary>
    [JsonPropertyName("judgePlan")]
    public required AssistantMessageJudgePlanAi JudgePlan { get; set; }

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
