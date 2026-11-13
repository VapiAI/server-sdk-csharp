using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GetTrafficTabMetricsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The assistant whose per-version traffic metrics to return.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// Start of the metrics window (inclusive), ISO 8601 datetime.
    /// </summary>
    [JsonPropertyName("from")]
    public required DateTime From { get; set; }

    /// <summary>
    /// End of the metrics window (exclusive), ISO 8601 datetime. Must be later than from, and the window may hold at most 2000 buckets of the requested width.
    /// </summary>
    [JsonPropertyName("to")]
    public required DateTime To { get; set; }

    /// <summary>
    /// Bucket size for the timeseries. Defaults to 'day'.
    /// </summary>
    [JsonPropertyName("bucket")]
    public GetTrafficTabMetricsDtoBucket? Bucket { get; set; }

    /// <summary>
    /// Structured output ids to aggregate per version, as an array or a comma-separated string. At most 5.
    /// </summary>
    [JsonPropertyName("structuredOutputIds")]
    public IEnumerable<string>? StructuredOutputIds { get; set; }

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
