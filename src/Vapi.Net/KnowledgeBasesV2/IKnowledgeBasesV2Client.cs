namespace Vapi.Net;

public partial interface IKnowledgeBasesV2Client
{
    WithRawResponseTask<IEnumerable<KnowledgeBaseV2>> KnowledgeBaseV2ControllerFindAllAsync(
        KnowledgeBaseV2ControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2> KnowledgeBaseV2ControllerCreateAsync(
        CreateKnowledgeBaseV2Dto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IEnumerable<KnowledgeBaseV2File>> KnowledgeBaseV2ControllerFilesGetAsync(
        string id,
        KnowledgeBaseV2ControllerFilesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2File> KnowledgeBaseV2ControllerFileAttachAsync(
        string id,
        AttachKnowledgeBaseV2FileDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2File> KnowledgeBaseV2ControllerFileDetachAsync(
        string id,
        string fileId,
        KnowledgeBaseV2ControllerFileDetachRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2File> KnowledgeBaseV2ControllerFileRetryAsync(
        string id,
        string fileId,
        KnowledgeBaseV2ControllerFileRetryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2WithFiles> KnowledgeBaseV2ControllerFindOneAsync(
        string id,
        KnowledgeBaseV2ControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2> KnowledgeBaseV2ControllerRemoveAsync(
        string id,
        KnowledgeBaseV2ControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<KnowledgeBaseV2> KnowledgeBaseV2ControllerUpdateAsync(
        string id,
        UpdateKnowledgeBaseV2Dto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
