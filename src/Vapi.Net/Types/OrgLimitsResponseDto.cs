using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OrgLimitsResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Call concurrency limits for the subscription. Unlike the call create response, remainingConcurrentCalls does not reserve a slot for a new call: it is the plain headroom at the time of the read. Covers the concurrency gate only — credits, frozen subscriptions, included minutes, and the billing limit are not reflected here, so call create can still refuse. Omitted when the limits could not be computed, and for an org with no subscription at all (legacy ungated orgs), which has no concurrency ceiling.
    /// </summary>
    [JsonPropertyName("subscriptionLimits")]
    public OrgConcurrencyLimitsDto? SubscriptionLimits { get; set; }

    /// <summary>
    /// API rate limit usage for the org. Approximate, per region, and scoped to the current minute. Omitted when the limit information is unavailable.
    /// </summary>
    [JsonPropertyName("apiLimits")]
    public OrgApiLimitsDto? ApiLimits { get; set; }

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
