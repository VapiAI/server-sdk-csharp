using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A record of an eval execution, including its target, status, results, costs, completion details, and lifecycle timestamps.
/// </summary>
[Serializable]
public record EvalRun : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the status of the eval run. When an eval run is created, the status is 'running'.
    /// When the eval run is completed, the status is 'ended'.
    /// </summary>
    [JsonPropertyName("status")]
    public required EvalRunStatus Status { get; set; }

    /// <summary>
    /// This is the reason for the eval run to end.
    /// When the eval run is completed normally i.e end of mock conversation, the status is 'mockConversation.done'.
    /// When the eval fails due to an error like Chat error or incorrect configuration, the status is 'error'.
    /// When the eval runs for too long, due to model issues or tool call issues, the status is 'timeout'.
    /// When the eval run is cancelled by the user, the status is 'cancelled'.
    /// When the eval run is cancelled by Vapi for any reason, the status is 'aborted'.
    /// </summary>
    [JsonPropertyName("endedReason")]
    public required EvalRunEndedReason EndedReason { get; set; }

    /// <summary>
    /// This is the transient eval that will be run
    /// </summary>
    [JsonPropertyName("eval")]
    public CreateEvalDto? Eval { get; set; }

    /// <summary>
    /// This is the target that will be run against the eval
    /// </summary>
    [JsonPropertyName("target")]
    public required object Target { get; set; }

    /// <summary>
    /// The unique identifier for the eval run.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The unique identifier for the organization that owns the run.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when the eval run was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when the eval run started.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public required DateTime StartedAt { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when the eval run ended.
    /// </summary>
    [JsonPropertyName("endedAt")]
    public required DateTime EndedAt { get; set; }

    /// <summary>
    /// This is the ended message when the eval run ended for any reason apart from mockConversation.done
    /// </summary>
    [JsonPropertyName("endedMessage")]
    public string? EndedMessage { get; set; }

    /// <summary>
    /// Results for this individual Eval. Check them after status is ended. An Eval that finishes normally contains one result; it passes only when all judged checkpoints pass. Grouping multiple Evals requires your own orchestration, not an Eval suite.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<EvalRunResult> Results { get; set; } = new List<EvalRunResult>();

    /// <summary>
    /// The cost of this Eval run in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    /// <summary>
    /// The cost breakdown for this Eval run.
    /// </summary>
    [JsonPropertyName("costs")]
    public IEnumerable<object> Costs { get; set; } = new List<object>();

    /// <summary>
    /// This is the type of the run.
    /// Currently it is fixed to `eval`.
    /// </summary>
    [JsonPropertyName("type")]
    public required EvalRunType Type { get; set; }

    /// <summary>
    /// This is the id of the eval that will be run.
    /// </summary>
    [JsonPropertyName("evalId")]
    public string? EvalId { get; set; }

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
