namespace Vapi.Net;

public partial interface IFilesClient
{
    /// <summary>
    /// Returns files uploaded to the authenticated organization.
    /// </summary>
    WithRawResponseTask<IEnumerable<File>> ListAsync(
        ListFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Uploads a file for use with a Vapi knowledge base.
    /// </summary>
    WithRawResponseTask<File> CreateAsync(
        CreateFileDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the uploaded file identified by its ID.
    /// </summary>
    WithRawResponseTask<File> GetAsync(
        string id,
        GetFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the uploaded file identified by its ID.
    /// </summary>
    WithRawResponseTask<File> DeleteAsync(
        string id,
        DeleteFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the name of the uploaded file identified by its ID.
    /// </summary>
    WithRawResponseTask<File> UpdateAsync(
        string id,
        UpdateFileDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
