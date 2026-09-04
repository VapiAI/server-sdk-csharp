using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record StructuredOutputCostBreakdown : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the unique identifier of the structured output that produced this cost.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public required string StructuredOutputId { get; set; }

    /// <summary>
    /// This is the name of the structured output, so this breakdown is readable without looking the id up.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the cost in USD of evaluating this structured output.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    /// <summary>
    /// This is the number of prompt tokens used to evaluate this structured output.
    /// </summary>
    [JsonPropertyName("promptTokens")]
    public required double PromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens generated for this structured output.
    /// </summary>
    [JsonPropertyName("completionTokens")]
    public required double CompletionTokens { get; set; }

    /// <summary>
    /// This is the number of cached prompt tokens used to evaluate this structured output. This is a subset of `promptTokens`, not an addition to it.
    /// </summary>
    [JsonPropertyName("cachedPromptTokens")]
    public double? CachedPromptTokens { get; set; }

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
