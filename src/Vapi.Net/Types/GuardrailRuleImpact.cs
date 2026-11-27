using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GuardrailRuleImpact : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Distinct assistants affected across direct, pack, draft, and version selections.
    /// </summary>
    [JsonPropertyName("assistantIds")]
    public IEnumerable<string> AssistantIds { get; set; } = new List<string>();

    /// <summary>
    /// Packs currently containing the rule.
    /// </summary>
    [JsonPropertyName("packIds")]
    public IEnumerable<string> PackIds { get; set; } = new List<string>();

    /// <summary>
    /// Names for the same distinct assistant identities.
    /// </summary>
    [JsonPropertyName("assistants")]
    public IEnumerable<GuardrailRuleUsage> Assistants { get; set; } =
        new List<GuardrailRuleUsage>();

    /// <summary>
    /// Names for the containing pack identities.
    /// </summary>
    [JsonPropertyName("packs")]
    public IEnumerable<GuardrailRuleUsage> Packs { get; set; } = new List<GuardrailRuleUsage>();

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
