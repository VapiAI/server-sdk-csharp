using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SubscriptionLimits
{
    /// <summary>
    /// True if this call was blocked by the Call Concurrency limit
    /// </summary>
    [JsonPropertyName("concurrencyBlocked")]
    public bool? ConcurrencyBlocked { get; set; }

    /// <summary>
    /// Account Call Concurrency limit
    /// </summary>
    [JsonPropertyName("concurrencyLimit")]
    public double? ConcurrencyLimit { get; set; }

    /// <summary>
    /// Incremental number of concurrent calls that will be allowed, including this call
    /// </summary>
    [JsonPropertyName("remainingConcurrentCalls")]
    public double? RemainingConcurrentCalls { get; set; }

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
