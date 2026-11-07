using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueListResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("results")]
    public IEnumerable<CallHealthDashboardIssueSummaryDto> Results { get; set; } =
        new List<CallHealthDashboardIssueSummaryDto>();

    /// <summary>
    /// Every row's dailySeries represents this same date page.
    /// </summary>
    [JsonPropertyName("seriesPage")]
    public required CallHealthDashboardSeriesPageDto SeriesPage { get; set; }

    [JsonPropertyName("facets")]
    public required CallHealthDashboardFacetsDto Facets { get; set; }

    [JsonPropertyName("nextCursor")]
    public string? NextCursor { get; set; }

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
