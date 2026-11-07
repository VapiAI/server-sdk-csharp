namespace Vapi.Net;

public partial interface IObservabilityScorecardClient
{
    /// <summary>
    /// Returns the scorecard identified by its ID.
    /// </summary>
    WithRawResponseTask<Scorecard> ScorecardControllerGetAsync(
        string id,
        ScorecardControllerGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the scorecard identified by its ID.
    /// </summary>
    WithRawResponseTask<Scorecard> ScorecardControllerRemoveAsync(
        string id,
        ScorecardControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the scorecard identified by its ID.
    /// </summary>
    WithRawResponseTask<Scorecard> ScorecardControllerUpdateAsync(
        string id,
        UpdateScorecardDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns scorecards for the authenticated organization. Filter results by ID or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<ScorecardPaginatedResponse> ScorecardControllerGetPaginatedAsync(
        ScorecardControllerGetPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a scorecard containing metrics, scoring conditions, and optional links to assistants whose calls should be evaluated.
    /// </summary>
    WithRawResponseTask<Scorecard> ScorecardControllerCreateAsync(
        CreateScorecardDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
