namespace Vapi.Net;

public partial interface ICampaignsClient
{
    WithRawResponseTask<CampaignPaginatedResponse> CampaignControllerFindAllAsync(
        CampaignControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerCreateAsync(
        CreateCampaignDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerFindOneAsync(
        string id,
        CampaignControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerRemoveAsync(
        string id,
        CampaignControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Campaign> CampaignControllerUpdateAsync(
        string id,
        UpdateCampaignDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
