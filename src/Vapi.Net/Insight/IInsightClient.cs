namespace Vapi.Net;

public partial interface IInsightClient
{
    WithRawResponseTask<InsightPaginatedResponse> InsightControllerFindAllAsync(
        InsightControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> InsightControllerCreateAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> InsightControllerFindOneAsync(
        string id,
        InsightControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> InsightControllerRemoveAsync(
        string id,
        InsightControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> InsightControllerUpdateAsync(
        string id,
        InsightControllerUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InsightRunResponse> InsightControllerRunAsync(
        string id,
        InsightRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InsightRunResponse> InsightControllerPreviewAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
