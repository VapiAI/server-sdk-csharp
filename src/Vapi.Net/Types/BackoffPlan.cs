using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

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
    /// This is the maximum number of retries to attempt if the request fails. Defaults to 0 (no retries).
    ///
    /// @default 0
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public required double MaxRetries { get; set; }

    /// <summary>
    /// This is the base delay in seconds. For linear backoff, this is the delay between each retry. For exponential backoff, this is the initial delay.
    /// </summary>
    [JsonPropertyName("baseDelaySeconds")]
    public required double BaseDelaySeconds { get; set; }

    /// <summary>
    /// This is the excluded status codes. If the response status code is in this list, the request will not be retried.
    /// By default, the request will be retried for any non-2xx status code.
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
