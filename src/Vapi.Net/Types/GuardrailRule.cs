using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GuardrailRule : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Structured editor input. Supplied PATCH authoring replaces the complete object; advanced text writes clear it to null.
    /// </summary>
    [JsonPropertyName("authoring")]
    public GuardrailAuthoring? Authoring { get; set; }

    /// <summary>
    /// Evaluated instructions, generated from authoring or supplied in advanced mode.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>
    /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
    /// </summary>
    [JsonPropertyName("sensitivity")]
    public required GuardrailRuleSensitivity Sensitivity { get; set; }

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
