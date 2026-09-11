using OneOf;

namespace Vapi.Net;

public partial interface IStructuredOutputsClient
{
    /// <summary>
    /// Returns structured-output definitions for the authenticated organization. Filter results by ID, name, or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<StructuredOutputPaginatedResponse> StructuredOutputControllerFindAllAsync(
        StructuredOutputControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a reusable definition for extracting validated data from conversations using an AI model or regular expression.
    /// </summary>
    WithRawResponseTask<StructuredOutput> StructuredOutputControllerCreateAsync(
        CreateStructuredOutputDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the structured-output definition identified by its ID.
    /// </summary>
    WithRawResponseTask<StructuredOutput> StructuredOutputControllerFindOneAsync(
        string id,
        StructuredOutputControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the structured-output definition identified by its ID.
    /// </summary>
    WithRawResponseTask<StructuredOutput> StructuredOutputControllerRemoveAsync(
        string id,
        StructuredOutputControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the structured-output definition identified by its ID.
    /// </summary>
    WithRawResponseTask<StructuredOutput> StructuredOutputControllerUpdateAsync(
        string id,
        UpdateStructuredOutputDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs a saved or transient structured-output definition against one or more calls, optionally returning a preview without updating call artifacts.
    /// </summary>
    WithRawResponseTask<
        OneOf<StructuredOutputControllerRunResponseZero, StructuredOutputRerunResponse>
    > StructuredOutputControllerRunAsync(
        StructuredOutputRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
