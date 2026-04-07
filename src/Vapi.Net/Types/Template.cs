using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Template : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("details")]
    public object? Details { get; set; }

    [JsonPropertyName("providerDetails")]
    public object? ProviderDetails { get; set; }

    [JsonPropertyName("metadata")]
    public ToolTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("visibility")]
    public TemplateVisibility? Visibility { get; set; }

    [JsonPropertyName("type")]
    public required TemplateType Type { get; set; }

    /// <summary>
    /// The name of the template. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provider")]
    public TemplateProvider? Provider { get; set; }

    /// <summary>
    /// The unique identifier for the template.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The unique identifier for the organization that this template belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// The ISO 8601 date-time string of when the template was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The ISO 8601 date-time string of when the template was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
