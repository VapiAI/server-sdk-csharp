namespace Vapi.Net;

public partial interface ISessionsClient
{
    WithRawResponseTask<SessionPaginatedResponse> ListAsync(
        ListSessionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Session> CreateAsync(
        CreateSessionDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Session> GetAsync(
        string id,
        GetSessionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Session> DeleteAsync(
        string id,
        DeleteSessionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Session> UpdateAsync(
        string id,
        UpdateSessionDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
