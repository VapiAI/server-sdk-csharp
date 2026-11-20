using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardAssistantListResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Visible nondeleted assistants in ascending ID transport order; sort the exhausted result in the frontend.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<CallHealthDashboardAssistantOverviewDto> Results { get; set; } =
        new List<CallHealthDashboardAssistantOverviewDto>();

    /// <summary>
    /// Opaque ID continuation bound to tenant, completion window and filters.
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public string? NextCursor { get; set; }

    /// <summary>
    /// Received-work processing coverage, separate from analyzed goal results.
    /// </summary>
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
