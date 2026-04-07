namespace Vapi.Net;

public partial interface IObservabilityScorecardClient
{
    WithRawResponseTask<Scorecard> ScorecardControllerGetAsync(
        string id,
        ScorecardControllerGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Scorecard> ScorecardControllerRemoveAsync(
        string id,
        ScorecardControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Scorecard> ScorecardControllerUpdateAsync(
        string id,
        UpdateScorecardDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ScorecardPaginatedResponse> ScorecardControllerGetPaginatedAsync(
        ScorecardControllerGetPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Scorecard> ScorecardControllerCreateAsync(
        CreateScorecardDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
