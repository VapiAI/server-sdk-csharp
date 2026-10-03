using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CampaignControllerFindOneV2Request
{
    /// <summary>
    /// When true, the response includes `contactCounters` and `callMetrics`.
    /// These are aggregate queries over the campaign's contacts and events, so
    /// they are opt-in rather than paid for on every read. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeCounters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
