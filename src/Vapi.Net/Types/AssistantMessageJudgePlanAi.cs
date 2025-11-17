using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantMessageJudgePlanAi
{
    /// <summary>
    /// This is the model to use for the LLM-as-a-judge.
    /// If not provided, will default to the assistant's model.
    ///
    /// The instructions on how to evaluate the model output with this LLM-Judge must be passed as a system message in the messages array of the model.
    ///
    /// The Mock conversation can be passed to the LLM-Judge to evaluate using the prompt {{messages}} and will be evaluated as a LiquidJS Variable. To access and judge only the last message, use {{messages[-1]}}
    ///
    /// The LLM-Judge must respond with "pass" or "fail" and only those two responses are allowed.
    /// </summary>
    [JsonPropertyName("model")]
    public required object Model { get; set; }

    /// <summary>
    /// This is the type of the judge plan.
    /// Use 'ai' to evaluate the assistant message content using LLM-as-a-judge.
    /// @default 'ai'
    /// </summary>
    [JsonPropertyName("type")]
    public required AssistantMessageJudgePlanAiType Type { get; set; }

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
