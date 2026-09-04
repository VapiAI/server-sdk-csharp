namespace Vapi.Net;

public partial interface IInsightClient
{
    /// <summary>
    /// Returns saved reporting insights for the authenticated organization. Filter results by ID or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<InsightPaginatedResponse> InsightControllerFindAllAsync(
        InsightControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a saved reporting insight that queries call data and presents the results as a bar chart, pie chart, line chart, or text value.
    /// </summary>
    WithRawResponseTask<object> InsightControllerCreateAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the reporting insight identified by its ID.
    /// </summary>
    WithRawResponseTask<object> InsightControllerFindOneAsync(
        string id,
        InsightControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the reporting insight identified by its ID.
    /// </summary>
    WithRawResponseTask<object> InsightControllerRemoveAsync(
        string id,
        InsightControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the reporting insight identified by its ID.
    /// </summary>
    WithRawResponseTask<object> InsightControllerUpdateAsync(
        string id,
        InsightControllerUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs a saved reporting insight, optionally overriding its time range and response format.
    /// </summary>
    WithRawResponseTask<InsightRunResponse> InsightControllerRunAsync(
        string id,
        InsightRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs an insight definition without first saving it, returning a preview of the resulting chart or text value.
    /// </summary>
    WithRawResponseTask<InsightRunResponse> InsightControllerPreviewAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
