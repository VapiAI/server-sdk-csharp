using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BooleanComparatorScorecardMetricCondition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of the condition. Currently only 'comparator' is supported.
    /// </summary>
    [JsonPropertyName("type")]
    public required BooleanComparatorScorecardMetricConditionType Type { get; set; }

    /// <summary>
    /// The comparator can only be '=' for boolean conditions.
    /// </summary>
    [JsonPropertyName("comparator")]
    public required BooleanComparatorScorecardMetricConditionComparator Comparator { get; set; }

    /// <summary>
    /// This is the value that will be used to compare the result of the structured output with the comparator.
    /// If the result of the comparison is true, the points will be added to the overall score.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; set; }

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
