namespace Vapi.Net;

public partial interface IToolsClient
{
    /// <summary>
    /// Returns reusable tools for the authenticated organization. Filter results by creation or update timestamps and limit the number returned.
    /// </summary>
    WithRawResponseTask<IEnumerable<object>> ListAsync(
        ListToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a reusable tool that assistants can invoke during conversations.
    /// </summary>
    WithRawResponseTask<object> CreateAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the tool identified by its ID.
    /// </summary>
    WithRawResponseTask<object> GetAsync(
        string id,
        GetToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the tool identified by its ID.
    /// </summary>
    WithRawResponseTask<object> DeleteAsync(
        string id,
        DeleteToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified fields of the tool identified by its ID.
    /// </summary>
    WithRawResponseTask<object> UpdateAsync(
        string id,
        UpdateToolsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
