using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalToolResponseMessageEvaluation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
