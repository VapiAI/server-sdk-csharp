using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ModelDeprecationNotice : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Path of the slot that carries the model, relative to the response root,
    /// e.g. `model`, `model.fallbackModels[1]`, `transcriber`, `voice`, or
    /// `members[2].assistantOverrides.model` on a squad.
    /// </summary>
    [JsonPropertyName("slot")]
    public required string Slot { get; set; }

    /// <summary>
    /// Provider as stored on the slot.
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// Model name as stored on the slot.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; set; }

    /// <summary>
    /// Day the model became deprecated, `YYYY-MM-DD` in UTC.
    /// </summary>
    [JsonPropertyName("deprecationDate")]
    public required string DeprecationDate { get; set; }

    /// <summary>
    /// Day the model is or was retired, `YYYY-MM-DD` in UTC. On and after this
    /// day Vapi no longer runs the model as configured.
    /// </summary>
    [JsonPropertyName("retirementDate")]
    public required string RetirementDate { get; set; }

    /// <summary>
    /// Whether a replacement can be recommended for this configuration.
    /// </summary>
    [JsonPropertyName("replacementStatus")]
    public required ModelDeprecationNoticeReplacementStatus ReplacementStatus { get; set; }

    /// <summary>
    /// Recommended model when replacementStatus is available. Omitted when
    /// eligibility cannot be established or no eligible replacement exists.
    /// A recommendation reflects the response-time decision; it neither
    /// confirms a completed swap nor authorizes a future execution.
    /// </summary>
    [JsonPropertyName("replacementModel")]
    public string? ReplacementModel { get; set; }

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
