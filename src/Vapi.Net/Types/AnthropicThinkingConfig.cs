using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AnthropicThinkingConfig
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "enabled";

    /// <summary>
    /// The maximum number of tokens to allocate for thinking.
    /// Must be between 1024 and 100000 tokens.
    /// </summary>
    [JsonPropertyName("budgetTokens")]
    public required double BudgetTokens { get; set; }

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
