using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TimeRange
{
    /// <summary>
    /// This is the time step for aggregations.
    ///
    /// If not provided, defaults to returning for the entire time range.
    /// </summary>
    [JsonPropertyName("step")]
    public TimeRangeStep? Step { get; set; }

    /// <summary>
    /// This is the start date for the time range.
    ///
    /// If not provided, defaults to the 7 days ago.
    /// </summary>
    [JsonPropertyName("start")]
    public DateTime? Start { get; set; }

    /// <summary>
    /// This is the end date for the time range.
    ///
    /// If not provided, defaults to now.
    /// </summary>
    [JsonPropertyName("end")]
    public DateTime? End { get; set; }

    /// <summary>
    /// This is the timezone you want to set for the query.
    ///
    /// If not provided, defaults to UTC.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

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
