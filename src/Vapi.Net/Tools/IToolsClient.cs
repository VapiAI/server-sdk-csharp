namespace Vapi.Net;

public partial interface IToolsClient
{
    WithRawResponseTask<IEnumerable<object>> ListAsync(
        ListToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> CreateAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> GetAsync(
        string id,
        GetToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> DeleteAsync(
        string id,
        DeleteToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> UpdateAsync(
        string id,
        UpdateToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
