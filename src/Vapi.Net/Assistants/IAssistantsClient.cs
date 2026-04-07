namespace Vapi.Net;

public partial interface IAssistantsClient
{
    WithRawResponseTask<IEnumerable<Assistant>> ListAsync(
        ListAssistantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Assistant> CreateAsync(
        CreateAssistantDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Assistant> GetAsync(
        string id,
        GetAssistantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Assistant> DeleteAsync(
        string id,
        DeleteAssistantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Assistant> UpdateAsync(
        string id,
        UpdateAssistantDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
