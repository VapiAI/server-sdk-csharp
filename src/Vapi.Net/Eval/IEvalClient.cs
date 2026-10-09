namespace Vapi.Net;

public partial interface IEvalClient
{
    /// <summary>
    /// Returns eval definitions for the authenticated organization. Filter results by ID or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<EvalPaginatedResponse> EvalControllerGetPaginatedAsync(
        EvalControllerGetPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a reusable eval that defines a mock conversation and checkpoints for evaluating assistant responses and tool calls.
    /// </summary>
    WithRawResponseTask<Eval> EvalControllerCreateAsync(
        CreateEvalDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the eval definition identified by its ID.
    /// </summary>
    WithRawResponseTask<Eval> EvalControllerGetAsync(
        string id,
        EvalControllerGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the eval definition identified by its ID.
    /// </summary>
    WithRawResponseTask<Eval> EvalControllerRemoveAsync(
        string id,
        EvalControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the eval definition identified by its ID.
    /// </summary>
    WithRawResponseTask<Eval> EvalControllerUpdateAsync(
        string id,
        UpdateEvalDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the eval run identified by its ID.
    /// </summary>
    WithRawResponseTask<EvalRun> EvalControllerGetRunAsync(
        string id,
        EvalControllerGetRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the eval run identified by its ID.
    /// </summary>
    WithRawResponseTask<EvalRun> EvalControllerRemoveRunAsync(
        string id,
        EvalControllerRemoveRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns eval runs for the authenticated organization. Filter results by ID or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<EvalRunPaginatedResponse> EvalControllerGetRunsPaginatedAsync(
        EvalControllerGetRunsPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs a saved or transient eval against an assistant or squad and creates an eval-run record containing the results.
    /// </summary>
    WithRawResponseTask<object> EvalControllerRunAsync(
        CreateEvalRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
