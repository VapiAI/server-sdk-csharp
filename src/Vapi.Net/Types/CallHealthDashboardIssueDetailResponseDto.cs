using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueDetailResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("issue")]
    public required CallHealthDashboardIssueSummaryDto Issue { get; set; }

    [JsonPropertyName("seriesPage")]
    public required CallHealthDashboardSeriesPageDto SeriesPage { get; set; }

    [JsonPropertyName("definition")]
    public required CallHealthDashboardIssueDefinitionDto Definition { get; set; }

    [JsonPropertyName("coverage")]
    public required CallHealthDashboardCoverageDto Coverage { get; set; }

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
