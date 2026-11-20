using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardCoverageDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asOf")]
    public required DateTime AsOf { get; set; }

    [JsonPropertyName("intake")]
    public required CallHealthDashboardIntakeCoverageDto Intake { get; set; }

    [JsonPropertyName("goal")]
    public required CallHealthDashboardGoalGapsDto Goal { get; set; }

    [JsonPropertyName("classification")]
    public required CallHealthDashboardClassificationCoverageDto Classification { get; set; }

    [JsonPropertyName("assignment")]
    public required CallHealthDashboardAssignmentCoverageDto Assignment { get; set; }

    [JsonPropertyName("discovery")]
    public required CallHealthDashboardDiscoveryCoverageDto Discovery { get; set; }

    [JsonPropertyName("sweep")]
    public required CallHealthDashboardSweepCoverageDto Sweep { get; set; }

    /// <summary>
    /// Completeness of received authorized work only; never source delivery coverage.
    /// </summary>
    [JsonPropertyName("countsComplete")]
    public required bool CountsComplete { get; set; }

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
