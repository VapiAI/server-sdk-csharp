using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Scorecard
{
    /// <summary>
    /// This is the unique identifier for the scorecard.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this scorecard belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the scorecard was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the scorecard was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the name of the scorecard. It is only for user reference and will not be used for any evaluation.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the description of the scorecard. It is only for user reference and will not be used for any evaluation.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// These are the metrics that will be used to evaluate the scorecard.
    /// Each metric will have a set of conditions and points that will be used to generate the score.
    /// </summary>
    [JsonPropertyName("metrics")]
    public IEnumerable<ScorecardMetric> Metrics { get; set; } = new List<ScorecardMetric>();

    /// <summary>
    /// These are the assistant IDs that this scorecard is linked to.
    /// When linked to assistants, this scorecard will be available for evaluation during those assistants' calls.
    /// </summary>
    [JsonPropertyName("assistantIds")]
    public IEnumerable<string>? AssistantIds { get; set; }

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
