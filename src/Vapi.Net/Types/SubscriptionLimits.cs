using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SubscriptionLimits : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
