using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficTabMetricsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("window")]
    public required TrafficTabMetricsWindowDto Window { get; set; }

    /// <summary>
    /// All calls for the assistant in the window, every version.
    /// </summary>
    [JsonPropertyName("totalCalls")]
    public required double TotalCalls { get; set; }

    /// <summary>
    /// The allocation currently governing the assistant. Null when traffic splitting was never configured.
    /// </summary>
    [JsonPropertyName("currentAllocation")]
    public TrafficAllocation? CurrentAllocation { get; set; }

    /// <summary>
    /// One row per version with calls in the window, plus the unversioned row when it has any. Ordered by calls descending, then by version label (numeric-aware), the unversioned row last among equals.
    /// </summary>
    [JsonPropertyName("versions")]
    public IEnumerable<TrafficTabVersionMetricsDto> Versions { get; set; } =
        new List<TrafficTabVersionMetricsDto>();

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
