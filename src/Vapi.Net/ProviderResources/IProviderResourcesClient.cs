namespace Vapi.Net;

public partial interface IProviderResourcesClient
{
    /// <summary>
    /// Returns a paginated list of provider resources for the authenticated organization. Filter pronunciation dictionaries by provider, resource ID, or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<ProviderResourcePaginatedResponse> ProviderResourceControllerGetProviderResourcesPaginatedAsync(
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider provider,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestResourceName resourceName,
        ProviderResourceControllerGetProviderResourcesPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a pronunciation-dictionary resource for a supported provider, currently Cartesia or ElevenLabs.
    /// </summary>
    WithRawResponseTask<ProviderResource> ProviderResourceControllerCreateProviderResourceAsync(
        ProviderResourceControllerCreateProviderResourceRequestProvider provider,
        ProviderResourceControllerCreateProviderResourceRequestResourceName resourceName,
        ProviderResourceControllerCreateProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the provider resource identified by its Vapi resource ID.
    /// </summary>
    WithRawResponseTask<ProviderResource> ProviderResourceControllerGetProviderResourceAsync(
        ProviderResourceControllerGetProviderResourceRequestProvider provider,
        ProviderResourceControllerGetProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerGetProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the provider resource identified by its Vapi resource ID.
    /// </summary>
    WithRawResponseTask<ProviderResource> ProviderResourceControllerDeleteProviderResourceAsync(
        ProviderResourceControllerDeleteProviderResourceRequestProvider provider,
        ProviderResourceControllerDeleteProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerDeleteProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the provider resource identified by its Vapi resource ID.
    /// </summary>
    WithRawResponseTask<ProviderResource> ProviderResourceControllerUpdateProviderResourceAsync(
        ProviderResourceControllerUpdateProviderResourceRequestProvider provider,
        ProviderResourceControllerUpdateProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerUpdateProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
