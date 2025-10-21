using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EvalAnthropicModel
{
    /// <summary>
    /// This is the specific model that will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public required EvalAnthropicModelModel Model { get; set; }

    /// <summary>
    /// This is the optional configuration for Anthropic's thinking feature.
    ///
    /// - Only applicable for `claude-3-7-sonnet-20250219` model.
    /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
    /// </summary>
    [JsonPropertyName("thinking")]
    public AnthropicThinkingConfig? Thinking { get; set; }

    /// <summary>
    /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This is the max tokens of the model.
    /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
    /// </summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

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
