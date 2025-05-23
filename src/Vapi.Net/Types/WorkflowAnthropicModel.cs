using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record WorkflowAnthropicModel
{
    /// <summary>
    /// This is the specific model that will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public required WorkflowAnthropicModelModel Model { get; set; }

    /// <summary>
    /// This is the optional configuration for Anthropic's thinking feature.
    ///
    /// - Only applicable for `claude-3-7-sonnet-20250219` model.
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
