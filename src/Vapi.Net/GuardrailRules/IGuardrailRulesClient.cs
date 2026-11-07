namespace Vapi.Net;

public partial interface IGuardrailRulesClient
{
    WithRawResponseTask<IEnumerable<GuardrailRule>> GuardrailRulesControllerListAsync(
        GuardrailRulesControllerListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GuardrailRulesPage> GuardrailRulesControllerPaginatedAsync(
        GuardrailRulesControllerPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GuardrailRule> GuardrailRulesControllerFindAsync(
        string id,
        GuardrailRulesControllerFindRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
