using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SchedulePlan
{
    /// <summary>
    /// This is the ISO 8601 date-time string of the earliest time the call can be scheduled.
    /// </summary>
    [JsonPropertyName("earliestAt")]
    public required DateTime EarliestAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of the latest time the call can be scheduled.
    /// </summary>
    [JsonPropertyName("latestAt")]
    public DateTime? LatestAt { get; set; }

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
