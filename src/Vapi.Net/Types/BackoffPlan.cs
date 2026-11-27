using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Controls retry behavior for failed server requests, including strategy, maximum retries, base delay, and status codes excluded from retries.
/// </summary>
[Serializable]
public record BackoffPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of backoff plan to use. Defaults to fixed.
    ///
    /// @default fixed
    /// </summary>
    [JsonPropertyName("type")]
    public object Type { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// Total number of attempts, including the first request. For example, `3` sends the request up to 3 times. Values of `0` and `1` both send it once, with no retries. Defaults to 0.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public required double MaxRetries { get; set; }

    /// <summary>
    /// Base delay in seconds. For fixed backoff, this is the delay between retries. For exponential backoff, this is the initial delay.
    /// </summary>
    [JsonPropertyName("baseDelaySeconds")]
    public required double BaseDelaySeconds { get; set; }

    /// <summary>
    /// HTTP status codes that should not trigger a retry. By default, any non-2xx status code not listed here can be retried.
    /// </summary>
    [JsonPropertyName("excludedStatusCodes")]
    public IEnumerable<object>? ExcludedStatusCodes { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
