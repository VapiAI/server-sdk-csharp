using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A scorecard metric that awards points when a structured output meets its configured conditions.
/// </summary>
[Serializable]
public record ScorecardMetric : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// These are the conditions that will be used to evaluate the scorecard.
    /// Each condition will have a comparator, value, and points that will be used to calculate the final score.
    /// The points will be added to the overall score if the condition is met.
    /// The overall score will be normalized to a 100 point scale to ensure uniformity across different scorecards.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<
        OneOf<NumberComparatorScorecardMetricCondition, BooleanComparatorScorecardMetricCondition>
    > Conditions { get; set; } =
        new List<
            OneOf<
                NumberComparatorScorecardMetricCondition,
                BooleanComparatorScorecardMetricCondition
            >
        >();

    /// <summary>
    /// This is the unique identifier for the structured output that will be used to evaluate the scorecard.
    /// The structured output must be of type number or boolean only for now.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public required string StructuredOutputId { get; set; }

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
