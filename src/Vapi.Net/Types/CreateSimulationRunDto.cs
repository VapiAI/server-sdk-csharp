using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSimulationRunDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Array of simulations and/or suites to run
    /// </summary>
    [JsonPropertyName("simulations")]
    public IEnumerable<object> Simulations { get; set; } = new List<object>();

    /// <summary>
    /// Target to test against
    /// </summary>
    [JsonPropertyName("target")]
    public required object Target { get; set; }

    /// <summary>
    /// Number of times to run each simulation (default: 1)
    /// </summary>
    [JsonPropertyName("iterations")]
    public double? Iterations { get; set; }

    /// <summary>
    /// Transport configuration for the simulation runs
    /// </summary>
    [JsonPropertyName("transport")]
    public SimulationRunTransportConfiguration? Transport { get; set; }

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
