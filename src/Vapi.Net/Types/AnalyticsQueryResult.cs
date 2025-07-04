using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AnalyticsQueryResult
{
    /// <summary>
    /// This is the unique key for the query.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the time range for the query.
    /// </summary>
    [JsonPropertyName("timeRange")]
    public required TimeRange TimeRange { get; set; }

    /// <summary>
    /// This is the result of the query, a list of unique groups with result of their aggregations.
    ///
    /// Example:
    /// "result": [
    ///   { "date": "2023-01-01", "assistantId": "123", "endedReason": "customer-ended-call", "sumDuration": 120, "avgCost": 10.5 },
    ///   { "date": "2023-01-02", "assistantId": "123", "endedReason": "customer-did-not-give-microphone-permission", "sumDuration": 0, "avgCost": 0 },
    ///   // Additional results
    /// ]
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<object> Result { get; set; } = new List<object>();

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
