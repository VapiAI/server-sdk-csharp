using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRun : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier for the run
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Organization ID
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// The run's current status. One of `queued`, `running`, or `ended`.
    /// </summary>
    [JsonPropertyName("status")]
    public required SimulationRunStatus Status { get; set; }

    /// <summary>
    /// When the run was queued
    /// </summary>
    [JsonPropertyName("queuedAt")]
    public required DateTime QueuedAt { get; set; }

    /// <summary>
    /// When the run started
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// When the run ended
    /// </summary>
    [JsonPropertyName("endedAt")]
    public DateTime? EndedAt { get; set; }

    /// <summary>
    /// Why the run ended, when applicable.
    /// </summary>
    [JsonPropertyName("endedReason")]
    public string? EndedReason { get; set; }

    /// <summary>
    /// ISO 8601 date-time when created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// ISO 8601 date-time when last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Aggregate counts of the run's items by status.
    /// </summary>
    [JsonPropertyName("itemCounts")]
    public SimulationRunItemCounts? ItemCounts { get; set; }

    /// <summary>
    /// The simulations and suites included in the run.
    /// </summary>
    [JsonPropertyName("simulations")]
    public IEnumerable<object> Simulations { get; set; } = new List<object>();

    /// <summary>
    /// The assistant or squad the run was tested against.
    /// </summary>
    [JsonPropertyName("target")]
    public required object Target { get; set; }

    /// <summary>
    /// The number of times each simulation was run. Defaults to 1.
    /// </summary>
    [JsonPropertyName("iterations")]
    public double? Iterations { get; set; }

    /// <summary>
    /// The transport used for the run, either voice or chat.
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
