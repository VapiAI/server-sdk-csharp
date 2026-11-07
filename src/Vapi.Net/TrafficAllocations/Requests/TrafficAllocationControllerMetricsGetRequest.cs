using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficAllocationControllerMetricsGetRequest
{
    /// <summary>
    /// The assistant whose per-version traffic metrics to return.
    /// </summary>
    [JsonIgnore]
    public required string AssistantId { get; set; }

    /// <summary>
    /// Start of the metrics window (inclusive), ISO 8601 datetime.
    /// </summary>
    [JsonIgnore]
    public required DateTime From { get; set; }

    /// <summary>
    /// End of the metrics window (exclusive), ISO 8601 datetime. Must be later than from, and the window may hold at most 2000 buckets of the requested width.
    /// </summary>
    [JsonIgnore]
    public required DateTime To { get; set; }

    /// <summary>
    /// Bucket size for the timeseries. Defaults to 'day'.
    /// </summary>
    [JsonIgnore]
    public TrafficAllocationControllerMetricsGetRequestBucket? Bucket { get; set; }

    /// <summary>
    /// Structured output ids to aggregate per version, as an array or a comma-separated string. At most 5.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> StructuredOutputIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
