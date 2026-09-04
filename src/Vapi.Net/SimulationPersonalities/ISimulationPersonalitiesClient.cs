namespace Vapi.Net;

public partial interface ISimulationPersonalitiesClient
{
    /// <summary>
    /// Returns the personalities for the authenticated organization.
    /// </summary>
    WithRawResponseTask<IEnumerable<Personality>> PersonalityControllerFindAllAsync(
        PersonalityControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a personality, the AI tester's configuration used in simulations.
    /// </summary>
    WithRawResponseTask<Personality> PersonalityControllerCreateAsync(
        CreatePersonalityDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified personality.
    /// </summary>
    WithRawResponseTask<Personality> PersonalityControllerFindOneAsync(
        string id,
        PersonalityControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the specified personality.
    /// </summary>
    WithRawResponseTask<Personality> PersonalityControllerRemoveAsync(
        string id,
        PersonalityControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified personality. Changes apply to future runs.
    /// </summary>
    WithRawResponseTask<Personality> PersonalityControllerUpdateAsync(
        string id,
        UpdatePersonalityDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
