using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EvalRun
{
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

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("startedAt")]
    public required DateTime StartedAt { get; set; }

    [JsonPropertyName("endedAt")]
    public required DateTime EndedAt { get; set; }

    /// <summary>
    /// This is the ended message when the eval run ended for any reason apart from mockConversation.done
    /// </summary>
    [JsonPropertyName("endedMessage")]
    public string? EndedMessage { get; set; }

    /// <summary>
    /// This is the results of the eval or suite run.
    /// The array will have a single item for an eval run, and multiple items each corresponding to the an eval in a suite run in the same order as the evals in the suite.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<EvalRunResult> Results { get; set; } = new List<EvalRunResult>();

    /// <summary>
    /// This is the type of the run.
    /// Currently it is fixed to `eval`.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "eval";

    /// <summary>
    /// This is the id of the eval that will be run.
    /// </summary>
    [JsonPropertyName("evalId")]
    public string? EvalId { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
