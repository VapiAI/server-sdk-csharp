using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardGoalSummaryDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("registeredCallCount")]
    public required int RegisteredCallCount { get; set; }

    /// <summary>
    /// Calls with an accepted semantic eligibility decision and binary goal outcome.
    /// </summary>
    [JsonPropertyName("eligibleCallCount")]
    public required int EligibleCallCount { get; set; }

    /// <summary>
    /// Accepted semantic exclusions; absent from the goal denominator.
    /// </summary>
    [JsonPropertyName("ineligibleCallCount")]
    public required int IneligibleCallCount { get; set; }

    /// <summary>
    /// No accepted eligibility decision, including technical or privacy exclusions.
    /// </summary>
    [JsonPropertyName("unassessedCallCount")]
    public required int UnassessedCallCount { get; set; }

    [JsonPropertyName("goalMetCount")]
    public required int GoalMetCount { get; set; }

    [JsonPropertyName("goalNotMetCount")]
    public required int GoalNotMetCount { get; set; }

    [JsonPropertyName("evaluatedCallCount")]
    public required int EvaluatedCallCount { get; set; }

    /// <summary>
    /// Accepted current-goal results, including ineligible; independent of issue processing.
    /// </summary>
    [JsonPropertyName("analyzedCallCount")]
    public required int AnalyzedCallCount { get; set; }

    /// <summary>
    /// Goal-met / evaluatedCallCount; omitted when there are no binary outcomes.
    /// </summary>
    [JsonPropertyName("goalMetRate")]
    public double? GoalMetRate { get; set; }

    [JsonPropertyName("goalNotMetRate")]
    public double? GoalNotMetRate { get; set; }

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
