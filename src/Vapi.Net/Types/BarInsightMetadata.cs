using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Display settings for a bar insight, including chart name, axis labels, and optional y-axis bounds.
/// </summary>
[Serializable]
public record BarInsightMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Label displayed on the chart's x-axis.
    /// </summary>
    [JsonPropertyName("xAxisLabel")]
    public string? XAxisLabel { get; set; }

    /// <summary>
    /// Label displayed on the chart's y-axis.
    /// </summary>
    [JsonPropertyName("yAxisLabel")]
    public string? YAxisLabel { get; set; }

    /// <summary>
    /// Minimum value displayed on the chart's y-axis.
    /// </summary>
    [JsonPropertyName("yAxisMin")]
    public double? YAxisMin { get; set; }

    /// <summary>
    /// Maximum value displayed on the chart's y-axis.
    /// </summary>
    [JsonPropertyName("yAxisMax")]
    public double? YAxisMax { get; set; }

    /// <summary>
    /// Display name for the insight chart.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
