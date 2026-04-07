using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the unique identifier for the simulation run item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ID of the simulation this run belongs to.
    /// </summary>
    [JsonPropertyName("simulationId")]
    public required string SimulationId { get; set; }

    /// <summary>
    /// This is the current status of the run.
    /// </summary>
    [JsonPropertyName("status")]
    public required SimulationRunItemStatus Status { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run was queued.
    /// </summary>
    [JsonPropertyName("queuedAt")]
    public required DateTime QueuedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run started.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run completed.
    /// </summary>
    [JsonPropertyName("completedAt")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run failed.
    /// </summary>
    [JsonPropertyName("failedAt")]
    public DateTime? FailedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run was canceled.
    /// </summary>
    [JsonPropertyName("canceledAt")]
    public DateTime? CanceledAt { get; set; }

    /// <summary>
    /// This is the reason for failure.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// This is the ID of the target Vapi call (the assistant being tested).
    /// </summary>
    [JsonPropertyName("callId")]
    public string? CallId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run item was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the run item was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the ID of the parent run (batch/group).
    /// </summary>
    [JsonPropertyName("runId")]
    public string? RunId { get; set; }

    /// <summary>
    /// Hooks configured for this simulation run item
    /// </summary>
    [JsonPropertyName("hooks")]
    public IEnumerable<object>? Hooks { get; set; }

    /// <summary>
    /// This is the iteration number (1-indexed) when run with iterations &gt; 1.
    /// </summary>
    [JsonPropertyName("iterationNumber")]
    public double? IterationNumber { get; set; }

    /// <summary>
    /// This is the session ID for chat-based simulations (webchat transport).
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>
    /// This is the scenario ID at run creation time.
    /// </summary>
    [JsonPropertyName("scenarioId")]
    public string? ScenarioId { get; set; }

    /// <summary>
    /// This is the personality ID at run creation time.
    /// </summary>
    [JsonPropertyName("personalityId")]
    public string? PersonalityId { get; set; }

    /// <summary>
    /// This is the metadata containing snapshots and call data.
    /// </summary>
    [JsonPropertyName("metadata")]
    public SimulationRunItemMetadata? Metadata { get; set; }

    /// <summary>
    /// This is the results of the simulation run.
    /// </summary>
    [JsonPropertyName("results")]
    public SimulationRunItemResults? Results { get; set; }

    /// <summary>
    /// This is the AI-generated improvement suggestions for failed runs.
    /// </summary>
    [JsonPropertyName("improvementSuggestions")]
    public SimulationRunItemImprovements? ImprovementSuggestions { get; set; }

    /// <summary>
    /// This is the configuration for how this simulation run executes.
    /// </summary>
    [JsonPropertyName("configurations")]
    public SimulationRunConfiguration? Configurations { get; set; }

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
