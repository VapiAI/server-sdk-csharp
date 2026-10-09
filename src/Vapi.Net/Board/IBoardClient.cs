namespace Vapi.Net;

public partial interface IBoardClient
{
    WithRawResponseTask<BoardPaginatedResponse> BoardControllerFindAllAsync(
        BoardControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Board> BoardControllerCreateAsync(
        CreateBoardDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Board> BoardControllerMetricsOverviewEnsureAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Board> BoardControllerFindOneAsync(
        string id,
        BoardControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Board> BoardControllerRemoveAsync(
        string id,
        BoardControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Board> BoardControllerUpdateAsync(
        string id,
        UpdateBoardDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
