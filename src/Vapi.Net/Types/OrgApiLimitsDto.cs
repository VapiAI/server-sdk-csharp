using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OrgApiLimitsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Approximate number of API requests counted against the rate limit in the current minute, in the region that served this request. The count lives in a tumbling one-minute window aligned to the UTC clock (unix seconds / 60), so it resets to zero at the top of every minute; there is no reset header — the next boundary is (floor(now / 60) + 1) * 60.
    /// </summary>
    [JsonPropertyName("rateLimitUsage")]
    public required double RateLimitUsage { get; set; }

    /// <summary>
    /// Maximum number of standard API requests allowed per minute, in the region that served this request. Live call media traffic is limited separately and is not reflected here.
    /// </summary>
    [JsonPropertyName("rateLimitMax")]
    public required double RateLimitMax { get; set; }

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
