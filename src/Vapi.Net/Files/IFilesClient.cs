namespace Vapi.Net;

public partial interface IFilesClient
{
    WithRawResponseTask<IEnumerable<File>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<File> CreateAsync(
        CreateFileDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<File> GetAsync(
        string id,
        GetFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<File> DeleteAsync(
        string id,
        DeleteFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<File> UpdateAsync(
        string id,
        UpdateFileDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
