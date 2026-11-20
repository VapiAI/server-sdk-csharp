using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SaveGuardrailRuleDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    public SaveGuardrailRuleDtoSensitivity? Sensitivity { get; set; }

    /// <summary>
    /// Supplied PATCH actions replace the complete variant.
    /// </summary>
    [JsonPropertyName("action")]
    public OneOf<object, GuardrailEscalateAction>? Action { get; set; }

    /// <summary>
    /// Last-read configuration; the complete snapshot prevents lost edits.
    /// </summary>
    [JsonPropertyName("expected")]
    public required GuardrailRuleSnapshot Expected { get; set; }

    /// <summary>
    /// Current deduplicated assistant impact acknowledged before a shared save.
    /// </summary>
    [JsonPropertyName("confirmedAssistantIds")]
    public IEnumerable<string>? ConfirmedAssistantIds { get; set; }

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
