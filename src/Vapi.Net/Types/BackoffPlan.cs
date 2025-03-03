using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record BackoffPlan
{
    /// <summary>
    /// This is the maximum number of retries to attempt if the request fails. Defaults to 0 (no retries).
    ///
    /// @default 0
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public required double MaxRetries { get; set; }

    /// <summary>
    /// This is the type of backoff plan to use. Defaults to fixed.
    ///
    /// @default fixed
    /// </summary>
    [JsonPropertyName("type")]
    public object Type { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the base delay in seconds. For linear backoff, this is the delay between each retry. For exponential backoff, this is the initial delay.
    /// </summary>
    [JsonPropertyName("baseDelaySeconds")]
    public required double BaseDelaySeconds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
