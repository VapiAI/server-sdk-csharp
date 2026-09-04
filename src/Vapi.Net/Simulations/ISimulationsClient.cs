namespace Vapi.Net;

public partial interface ISimulationsClient
{
    /// <summary>
    /// Generates scenarios for an assistant or squad by analyzing its configuration with AI.
    /// </summary>
    WithRawResponseTask<GenerateScenariosResponse> SimulationGenerateControllerGenerateAsync(
        GenerateScenariosDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the simulations for the authenticated organization.
    /// </summary>
    WithRawResponseTask<IEnumerable<Simulation>> SimulationControllerFindAllAsync(
        SimulationControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a simulation by pairing a scenario with a personality.
    /// </summary>
    WithRawResponseTask<Simulation> SimulationControllerCreateAsync(
        CreateSimulationDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified simulation.
    /// </summary>
    WithRawResponseTask<Simulation> SimulationControllerFindOneAsync(
        string id,
        SimulationControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the specified simulation.
    /// </summary>
    WithRawResponseTask<Simulation> SimulationControllerRemoveAsync(
        string id,
        SimulationControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified simulation.
    /// </summary>
    WithRawResponseTask<Simulation> SimulationControllerUpdateAsync(
        string id,
        UpdateSimulationDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the organization's simulation concurrency limit, the number of active simulations, and how many more can start.
    /// </summary>
    WithRawResponseTask<SimulationConcurrencyResponse> SimulationControllerGetConcurrencyAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
