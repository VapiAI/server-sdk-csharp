using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record AnalyticsQueryDto
{
    /// <summary>
    /// This is the list of metric queries you want to perform.
    /// </summary>
    [JsonPropertyName("queries")]
    public IEnumerable<AnalyticsQuery> Queries { get; set; } = new List<AnalyticsQuery>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
