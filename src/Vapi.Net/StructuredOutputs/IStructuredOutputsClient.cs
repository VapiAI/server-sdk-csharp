namespace Vapi.Net;

public partial interface IStructuredOutputsClient
{
    WithRawResponseTask<StructuredOutputPaginatedResponse> StructuredOutputControllerFindAllAsync(
        StructuredOutputControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StructuredOutput> StructuredOutputControllerCreateAsync(
        CreateStructuredOutputDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StructuredOutput> StructuredOutputControllerFindOneAsync(
        string id,
        StructuredOutputControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StructuredOutput> StructuredOutputControllerRemoveAsync(
        string id,
        StructuredOutputControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StructuredOutput> StructuredOutputControllerUpdateAsync(
        string id,
        UpdateStructuredOutputDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StructuredOutput> StructuredOutputControllerRunAsync(
        StructuredOutputRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
