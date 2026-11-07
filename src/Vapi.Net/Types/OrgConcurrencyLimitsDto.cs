using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OrgConcurrencyLimitsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// True when the org is at or over its concurrency limit at the time of the read. This is a status read, not an admission decision: no call was evaluated and no slot is reserved.
    /// </summary>
    [JsonPropertyName("concurrencyBlocked")]
    public required bool ConcurrencyBlocked { get; set; }

    /// <summary>
    /// Maximum number of concurrent calls the subscription allows, at the time of the read. Computed as the subscription's included plus purchased concurrency, defaulting to the initial allowance when either is unset; call create derives its own figure and can differ for subscriptions with an unset allowance.
    /// </summary>
    [JsonPropertyName("concurrencyLimit")]
    public required double ConcurrencyLimit { get; set; }

    /// <summary>
    /// Plain concurrent-call headroom at the time of the read, floored at zero. Unlike the call create response, this does not include or reserve a slot for a new call.
    /// </summary>
    [JsonPropertyName("remainingConcurrentCalls")]
    public required double RemainingConcurrentCalls { get; set; }

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
