using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateGuardrailRuleDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Structured editor input. Supplied PATCH authoring replaces the complete object; advanced text writes clear it to null.
    /// </summary>
    [JsonPropertyName("authoring")]
    public GuardrailAuthoring? Authoring { get; set; }

    /// <summary>
    /// Advanced text input. Do not supply it together with structured authoring.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>
    /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
    /// </summary>
    [JsonPropertyName("sensitivity")]
    public required CreateGuardrailRuleDtoSensitivity Sensitivity { get; set; }

    /// <summary>
    /// Supplied PATCH actions replace the complete variant.
    /// </summary>
    [JsonPropertyName("action")]
    public required OneOf<object, GuardrailEscalateAction> Action { get; set; }

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
