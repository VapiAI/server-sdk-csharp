using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateScorecardDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
