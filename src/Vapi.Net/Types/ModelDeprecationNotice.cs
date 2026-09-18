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
    /// The recommended migration target for the slot's model: the registry's
    /// replacement, followed through any further retirements as of the response
    /// date, so it names a model that is alive on that day. A `&lt;model&gt;:&lt;region&gt;`
    /// pin on the slot's model is kept on the target.
    /// </summary>
    [JsonPropertyName("replacementModel")]
    public required string ReplacementModel { get; set; }

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
