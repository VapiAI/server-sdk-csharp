using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record NumberComparatorScorecardMetricCondition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of the condition. Currently only 'comparator' is supported.
    /// </summary>
    [JsonPropertyName("type")]
    public required NumberComparatorScorecardMetricConditionType Type { get; set; }

    /// <summary>
    /// This is the comparator that will be used to compare the result of the structured output with the value specified.
    /// Only '=', '!=', '&gt;', '&lt;', '&gt;=', and '&lt;=' are supported for number conditions
    /// Only '=' is supported for boolean conditions.
    /// </summary>
    [JsonPropertyName("comparator")]
    public required NumberComparatorScorecardMetricConditionComparator Comparator { get; set; }

    /// <summary>
    /// This is the value that will be used to compare the result of the structured output with the comparator.
    /// If the result of the comparison is true, the points will be added to the overall score.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

    /// <summary>
    /// These are the points that will be added to the overall score if the condition is met.
    /// The points must be between 0 and 100.
    /// </summary>
    [JsonPropertyName("points")]
    public required double Points { get; set; }

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
