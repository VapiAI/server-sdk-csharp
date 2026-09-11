namespace Vapi.Net;

public partial interface ICampaignsClient
{
    /// <summary>
    /// Returns outbound calling campaigns for the authenticated organization. Filter results by campaign ID, status, or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<CampaignPaginatedResponse> CampaignControllerFindAllAsync(
        CampaignControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates an outbound calling campaign that calls a set of customers.
    /// </summary>
    WithRawResponseTask<Campaign> CampaignControllerCreateAsync(
        CreateCampaignDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CampaignSummaryPaginatedResponse> CampaignControllerFindAllV2Async(
        CampaignControllerFindAllV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerCreateV2Async(
        CreateCampaignDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CampaignSummary> CampaignControllerFindOneV2Async(
        string id,
        CampaignControllerFindOneV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerRemoveV2Async(
        string id,
        CampaignControllerRemoveV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerUpdateV2Async(
        string id,
        CampaignControllerUpdateV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the outbound calling campaign identified by its ID.
    /// </summary>
    WithRawResponseTask<Campaign> CampaignControllerFindOneAsync(
        string id,
        CampaignControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the outbound calling campaign identified by its ID.
    /// </summary>
    WithRawResponseTask<Campaign> CampaignControllerRemoveAsync(
        string id,
        CampaignControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the outbound calling campaign identified by its ID. Campaigns can be ended by updating their status to `ended`.
    /// </summary>
    WithRawResponseTask<Campaign> CampaignControllerUpdateAsync(
        string id,
        CampaignControllerUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CampaignContactPaginatedResponse> CampaignControllerGetCampaignV2ContactsAsync(
        string id,
        CampaignControllerGetCampaignV2ContactsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
