using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSimulationRunDto
{
    /// <summary>
    /// Makes the request safe to retry. A retry with the same key and the same body returns the run the first request created, with `reused: true`, instead of starting another. Reusing a key with a different body returns 409. Up to 255 printable ASCII characters, scoped to your organization; a key stays bound to its run while the run exists.
    /// </summary>
    [JsonIgnore]
    public string? IdempotencyKey { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
