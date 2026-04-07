namespace Vapi.Net;

public partial interface IProviderResourcesClient
{
    WithRawResponseTask<ProviderResourcePaginatedResponse> ProviderResourceControllerGetProviderResourcesPaginatedAsync(
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider provider,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestResourceName resourceName,
        ProviderResourceControllerGetProviderResourcesPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderResource> ProviderResourceControllerCreateProviderResourceAsync(
        ProviderResourceControllerCreateProviderResourceRequestProvider provider,
        ProviderResourceControllerCreateProviderResourceRequestResourceName resourceName,
        ProviderResourceControllerCreateProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderResource> ProviderResourceControllerGetProviderResourceAsync(
        ProviderResourceControllerGetProviderResourceRequestProvider provider,
        ProviderResourceControllerGetProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerGetProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderResource> ProviderResourceControllerDeleteProviderResourceAsync(
        ProviderResourceControllerDeleteProviderResourceRequestProvider provider,
        ProviderResourceControllerDeleteProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerDeleteProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderResource> ProviderResourceControllerUpdateProviderResourceAsync(
        ProviderResourceControllerUpdateProviderResourceRequestProvider provider,
        ProviderResourceControllerUpdateProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerUpdateProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
