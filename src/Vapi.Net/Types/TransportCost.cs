using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TransportCost
{
    [JsonPropertyName("provider")]
    public TransportCostProvider? Provider { get; set; }

    /// <summary>
    /// This is the minutes of `transport` usage. This should match `call.endedAt` - `call.startedAt`.
    /// </summary>
    [JsonPropertyName("minutes")]
    public required double Minutes { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
