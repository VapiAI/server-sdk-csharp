using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SaveGuardrailPackDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Projected from membership rows; a supplied array replaces membership.
    /// </summary>
    [JsonPropertyName("ruleIds")]
    public IEnumerable<string>? RuleIds { get; set; }

    /// <summary>
    /// The complete last-read snapshot prevents silently replacing another editor’s changes.
    /// </summary>
    [JsonPropertyName("expected")]
    public required GuardrailPackSnapshot Expected { get; set; }

    /// <summary>
    /// Exact deduplicated impact acknowledged by the user; rechecked while the pack is locked.
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
