using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ModelCostServiceTierBreakdown : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the service tier OpenAI reported serving a request that asked for Fast mode, in Vapi's names: `fast` when Fast mode was served, otherwise the tier served, such as `default`. It is absent on the row for usage with no reported tier: requests that did not ask for Fast mode, requests that ended before OpenAI reported a tier, and other providers.
    /// </summary>
    [JsonPropertyName("serviceTier")]
    public string? ServiceTier { get; set; }

    /// <summary>
    /// This is the cost in USD of the usage at this tier, rounded to 8 decimal places.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    /// <summary>
    /// This is the number of prompt tokens used at this tier.
    /// </summary>
    [JsonPropertyName("promptTokens")]
    public required double PromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens generated at this tier.
    /// </summary>
    [JsonPropertyName("completionTokens")]
    public required double CompletionTokens { get; set; }

    /// <summary>
    /// This is the number of cached prompt tokens used at this tier. This is a subset of `promptTokens`, not an addition to it.
    /// </summary>
    [JsonPropertyName("cachedPromptTokens")]
    public double? CachedPromptTokens { get; set; }

    /// <summary>
    /// This is the number of reasoning tokens generated at this tier. This is a subset of `completionTokens`, not an addition to it.
    /// </summary>
    [JsonPropertyName("reasoningTokens")]
    public double? ReasoningTokens { get; set; }

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
