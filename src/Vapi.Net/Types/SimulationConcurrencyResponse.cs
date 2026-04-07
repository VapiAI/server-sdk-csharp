using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationConcurrencyResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// Max call slots for simulations (each voice simulation uses 2 call slots: tester + target)
    /// </summary>
    [JsonPropertyName("concurrencyLimit")]
    public required double ConcurrencyLimit { get; set; }

    /// <summary>
    /// Number of call slots currently in use by running simulations
    /// </summary>
    [JsonPropertyName("activeSimulations")]
    public required double ActiveSimulations { get; set; }

    /// <summary>
    /// Number of voice simulations that can start now (available call slots / 2)
    /// </summary>
    [JsonPropertyName("availableToStart")]
    public required double AvailableToStart { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// True if org is using platform default concurrency limit
    /// </summary>
    [JsonPropertyName("isDefault")]
    public required bool IsDefault { get; set; }

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
