using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalAssistantMessageEvaluation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the role of the message author.
    /// For an assistant message evaluation, the role is always 'assistant'
    /// @default 'assistant'
    /// </summary>
    [JsonPropertyName("role")]
    public required ChatEvalAssistantMessageEvaluationRole Role { get; set; }

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
