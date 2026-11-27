using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptMetricEvaluationResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the evaluation's position in the scenario's evaluations.
    /// </summary>
    [JsonPropertyName("index")]
    public required double Index { get; set; }

    /// <summary>
    /// This is the metric evaluated.
    /// </summary>
    [JsonPropertyName("metric")]
    public required TranscriptMetricEvaluationResultMetric Metric { get; set; }

    /// <summary>
    /// This is the comparison made: the metric's value on the left, `expectedValue` on the right.
    /// </summary>
    [JsonPropertyName("comparator")]
    public required TranscriptMetricEvaluationResultComparator Comparator { get; set; }

    /// <summary>
    /// This is the value the evaluation compares against.
    /// </summary>
    [JsonPropertyName("expectedValue")]
    public required double ExpectedValue { get; set; }

    /// <summary>
    /// This is the metric's value for this run. Null when it could not be measured, such as a word error rate for an
    /// answer key with no words; the evaluation then fails.
    /// </summary>
    [JsonPropertyName("actualValue")]
    public double? ActualValue { get; set; }

    /// <summary>
    /// This is whether the comparison held.
    /// </summary>
    [JsonPropertyName("passed")]
    public required bool Passed { get; set; }

    /// <summary>
    /// This is whether the evaluation decides pass or fail. When false it is informational only.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; set; }

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
