using OneOf;

namespace Vapi.Net;

public partial interface ICallsClient
{
    WithRawResponseTask<IEnumerable<Call>> ListAsync(
        ListCallsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OneOf<Call, CallBatchResponse>> CreateAsync(
        CreateCallDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Call> GetAsync(
        string id,
        GetCallsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Call> DeleteAsync(
        string id,
        DeleteCallDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Call> UpdateAsync(
        string id,
        UpdateCallDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
