using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SuccessEvaluationPlan
{
    /// <summary>
    /// This enforces the rubric of the evaluation. The output is stored in `call.analysis.successEvaluation`.
    ///
    /// Options include:
    /// - 'NumericScale': A scale of 1 to 10.
    /// - 'DescriptiveScale': A scale of Excellent, Good, Fair, Poor.
    /// - 'Checklist': A checklist of criteria and their status.
    /// - 'Matrix': A grid that evaluates multiple criteria across different performance levels.
    /// - 'PercentageScale': A scale of 0% to 100%.
    /// - 'LikertScale': A scale of Strongly Agree, Agree, Neutral, Disagree, Strongly Disagree.
    /// - 'AutomaticRubric': Automatically break down evaluation into several criteria, each with its own score.
    /// - 'PassFail': A simple 'true' if call passed, 'false' if not.
    ///
    /// Default is 'PassFail'.
    /// </summary>
    [JsonPropertyName("rubric")]
    public SuccessEvaluationPlanRubric? Rubric { get; set; }

    /// <summary>
    /// These are the messages used to generate the success evaluation.
    ///
    /// @default: ```
    /// [
    ///   {
    ///     "role": "system",
    ///     "content": "You are an expert call evaluator. You will be given a transcript of a call and the system prompt of the AI participant. Determine if the call was successful based on the objectives inferred from the system prompt. DO NOT return anything except the result.\n\nRubric:\\n{{rubric}}\n\nOnly respond with the result."
    ///   },
    ///   {
    ///     "role": "user",
    ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n"
    ///   },
    ///   {
    ///     "role": "user",
    ///     "content": "Here was the system prompt of the call:\n\n{{systemPrompt}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"
    ///   }
    /// ]```
    ///
    /// You can customize by providing any messages you want.
    ///
    /// Here are the template variables available:
    /// - {{transcript}}: the transcript of the call from `call.artifact.transcript`- {{systemPrompt}}: the system prompt of the call from `assistant.model.messages[type=system].content`- {{rubric}}: the rubric of the success evaluation from `successEvaluationPlan.rubric`- {{endedReason}}: the ended reason of the call from `call.endedReason`
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    /// <summary>
    /// This determines whether a success evaluation is generated and stored in `call.analysis.successEvaluation`. Defaults to true.
    ///
    /// Usage:
    /// - If you want to disable the success evaluation, set this to false.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This is how long the request is tried before giving up. When request times out, `call.analysis.successEvaluation` will be empty.
    ///
    /// Usage:
    /// - To guarantee the success evaluation is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.
    ///
    /// @default 5 seconds
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

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
