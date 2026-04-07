namespace Vapi.Net;

public partial interface IEvalClient
{
    WithRawResponseTask<EvalPaginatedResponse> EvalControllerGetPaginatedAsync(
        EvalControllerGetPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Eval> EvalControllerCreateAsync(
        CreateEvalDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Eval> EvalControllerGetAsync(
        string id,
        EvalControllerGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Eval> EvalControllerRemoveAsync(
        string id,
        EvalControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Eval> EvalControllerUpdateAsync(
        string id,
        UpdateEvalDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EvalRun> EvalControllerGetRunAsync(
        string id,
        EvalControllerGetRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EvalRun> EvalControllerRemoveRunAsync(
        string id,
        EvalControllerRemoveRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EvalRunPaginatedResponse> EvalControllerGetRunsPaginatedAsync(
        EvalControllerGetRunsPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> EvalControllerRunAsync(
        CreateEvalRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
