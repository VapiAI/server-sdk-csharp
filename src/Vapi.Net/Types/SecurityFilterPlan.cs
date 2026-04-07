using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SecurityFilterPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the security filter is enabled.
    /// @default false
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Array of security filter types to apply.
    /// If array is not empty, only those security filters are run.
    /// </summary>
    [JsonPropertyName("filters")]
    public IEnumerable<SecurityFilterBase>? Filters { get; set; }

    /// <summary>
    /// Mode of operation when a security threat is detected.
    /// - 'sanitize': Remove or replace the threatening content
    /// - 'reject': Replace the entire transcript with replacement text
    /// - 'replace': Replace threatening patterns with replacement text
    /// @default 'sanitize'
    /// </summary>
    [JsonPropertyName("mode")]
    public SecurityFilterPlanMode? Mode { get; set; }

    /// <summary>
    /// Text to use when replacing filtered content.
    /// @default '[FILTERED]'
    /// </summary>
    [JsonPropertyName("replacementText")]
    public string? ReplacementText { get; set; }

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
