using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AnalyticsQuery
{
    /// <summary>
    /// This is the table you want to query.
    /// </summary>
    [JsonPropertyName("table")]
    public required AnalyticsQueryTable Table { get; set; }

    /// <summary>
    /// This is the list of columns you want to group by.
    /// </summary>
    [JsonPropertyName("groupBy")]
    public IEnumerable<AnalyticsQueryGroupByItem>? GroupBy { get; set; }

    /// <summary>
    /// This is the name of the query. This will be used to identify the query in the response.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the time range for the query.
    /// </summary>
    [JsonPropertyName("timeRange")]
    public TimeRange? TimeRange { get; set; }

    /// <summary>
    /// This is the list of operations you want to perform.
    /// </summary>
    [JsonPropertyName("operations")]
    public IEnumerable<AnalyticsOperation> Operations { get; set; } =
        new List<AnalyticsOperation>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
