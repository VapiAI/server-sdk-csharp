using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Metrics
{
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("rangeStart")]
    public required string RangeStart { get; set; }

    [JsonPropertyName("rangeEnd")]
    public required string RangeEnd { get; set; }

    [JsonPropertyName("bill")]
    public required double Bill { get; set; }

    [JsonPropertyName("billWithinBillingLimit")]
    public required bool BillWithinBillingLimit { get; set; }

    [JsonPropertyName("billDailyBreakdown")]
    public object BillDailyBreakdown { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("callActive")]
    public required double CallActive { get; set; }

    [JsonPropertyName("callActiveWithinConcurrencyLimit")]
    public required bool CallActiveWithinConcurrencyLimit { get; set; }

    [JsonPropertyName("callMinutes")]
    public required double CallMinutes { get; set; }

    [JsonPropertyName("callMinutesDailyBreakdown")]
    public object CallMinutesDailyBreakdown { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("callMinutesAverage")]
    public required double CallMinutesAverage { get; set; }

    [JsonPropertyName("callMinutesAverageDailyBreakdown")]
    public object CallMinutesAverageDailyBreakdown { get; set; } =
        new Dictionary<string, object?>();

    [JsonPropertyName("callCount")]
    public required double CallCount { get; set; }

    [JsonPropertyName("callCountDailyBreakdown")]
    public object CallCountDailyBreakdown { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
