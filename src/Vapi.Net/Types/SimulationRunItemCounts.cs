using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunItemCounts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The total number of run items.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; set; }

    /// <summary>
    /// The number of run items that passed all required evaluations.
    /// </summary>
    [JsonPropertyName("passed")]
    public required double Passed { get; set; }

    /// <summary>
    /// The number of run items that failed at least one required evaluation.
    /// </summary>
    [JsonPropertyName("failed")]
    public required double Failed { get; set; }

    /// <summary>
    /// The number of run items currently running or evaluating.
    /// </summary>
    [JsonPropertyName("running")]
    public required double Running { get; set; }

    /// <summary>
    /// The number of run items waiting to start.
    /// </summary>
    [JsonPropertyName("queued")]
    public required double Queued { get; set; }

    /// <summary>
    /// The number of run items that were canceled.
    /// </summary>
    [JsonPropertyName("canceled")]
    public required double Canceled { get; set; }

    /// <summary>
    /// Number of distinct simulations represented by the run items. Omitted when any item has no simulation ID.
    /// </summary>
    [JsonPropertyName("distinctSimulationTotal")]
    public double? DistinctSimulationTotal { get; set; }

    /// <summary>
    /// Number of distinct simulations with a failed or canceled item. Omitted when any item has no simulation ID.
    /// </summary>
    [JsonPropertyName("distinctSimulationFailed")]
    public double? DistinctSimulationFailed { get; set; }

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
