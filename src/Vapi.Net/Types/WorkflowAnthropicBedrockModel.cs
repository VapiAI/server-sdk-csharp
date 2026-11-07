using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Workflow model configuration for Anthropic through Amazon Bedrock, including model selection, thinking, temperature, and maximum output tokens.
/// </summary>
[Serializable]
public record WorkflowAnthropicBedrockModel : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// These are the messages used to customize the prompt used for structured output extraction.
    ///
    /// When provided, these messages replace the default prompts. For text extraction, message contents support LiquidJS templating with the following variables:
    /// - `{{transcript}}`, `{{messages}}`, or `{{messagesWithConfidence}}` to reference the conversation (one is required)
    /// - `{{structuredOutput.name}}`, `{{structuredOutput.description}}`, or `{{structuredOutput.schema}}` to reference the structured output definition (one is required)
    /// - `{{systemPrompt}}`, `{{callEndedReason}}`, `{{duration}}`, `{{startedAt}}`, `{{endedAt}}`, and any `assistantOverrides.variableValues`
    ///
    /// In structured outputs, `{{messages}}` includes conversation text and tool calls/results, but omits caller transcription-confidence fields. For text extraction, `{{messagesWithConfidence}}` includes the original message history with transcription confidence for outputs that explicitly need it. These variables also apply in structured-output schema descriptions. Audio-targeted (`messages-with-audio`) extraction ignores custom messages. Stored call artifacts and API messages retain their confidence data. `{{transcript}}` is the spoken text only, which uses significantly fewer tokens.
    ///
    /// If not provided, default system and user prompts are used.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<OpenAiMessage>? Messages { get; set; }

    /// <summary>
    /// This is the specific model that will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public required WorkflowAnthropicBedrockModelModel Model { get; set; }

    /// <summary>
    /// This is the optional configuration for Anthropic's thinking feature.
    ///
    /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
    /// </summary>
    [JsonPropertyName("thinking")]
    public AnthropicThinkingConfig? Thinking { get; set; }

    /// <summary>
    /// This is the temperature of the model.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This is the max tokens of the model.
    /// </summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

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
