using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CampaignControllerGetCampaignV2ContactsRequest
{
    /// <summary>
    /// This is the status to filter contacts by. Pass once or multiple times to
    /// filter on any of the provided statuses.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<CampaignControllerGetCampaignV2ContactsRequestStatusItem> Status { get; set; } =
        new List<CampaignControllerGetCampaignV2ContactsRequestStatusItem>();

    /// <summary>
    /// This is the maximum number of contacts to return. Defaults to 50.
    /// </summary>
    [JsonIgnore]
    public double? Limit { get; set; }

    /// <summary>
    /// This is the column to sort by. Defaults to `position` — the order contacts
    /// were uploaded, which is also dial order.
    ///
    /// `status` sorts by the enum's declaration order rather than alphabetically,
    /// which means it reads as a lifecycle: pending, dispatched, completed,
    /// failed, skipped, predial-failed.
    ///
    /// Only columns on `campaign_contact` are sortable. Call-level values such as
    /// cost or duration live on the call and are attached after this query, so
    /// sorting by them here would only reorder the current page.
    /// </summary>
    [JsonIgnore]
    public CampaignControllerGetCampaignV2ContactsRequestSortBy? SortBy { get; set; }

    /// <summary>
    /// This is the page number to return. Defaults to 1.
    /// </summary>
    [JsonIgnore]
    public double? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
