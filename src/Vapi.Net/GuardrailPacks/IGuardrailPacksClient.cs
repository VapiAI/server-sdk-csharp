namespace Vapi.Net;

public partial interface IGuardrailPacksClient
{
    WithRawResponseTask<IEnumerable<GuardrailPack>> GuardrailPacksControllerListAsync(
        GuardrailPacksControllerListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GuardrailPacksPage> GuardrailPacksControllerPaginatedAsync(
        GuardrailPacksControllerPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GuardrailPack> GuardrailPacksControllerFindAsync(
        string id,
        GuardrailPacksControllerFindRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
