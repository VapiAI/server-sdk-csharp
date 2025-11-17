using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ScorecardMetric
{
    /// <summary>
    /// This is the unique identifier for the structured output that will be used to evaluate the scorecard.
    /// The structured output must be of type number or boolean only for now.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public required string StructuredOutputId { get; set; }

    /// <summary>
    /// These are the conditions that will be used to evaluate the scorecard.
    /// Each condition will have a comparator, value, and points that will be used to calculate the final score.
    /// The points will be added to the overall score if the condition is met.
    /// The overall score will be normalized to a 100 point scale to ensure uniformity across different scorecards.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<object> Conditions { get; set; } = new List<object>();

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
