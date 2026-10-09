namespace Vapi.Net;

public partial interface ISimulationSuitesClient
{
    /// <summary>
    /// Returns the simulation suites for the authenticated organization.
    /// </summary>
    WithRawResponseTask<IEnumerable<SimulationSuite>> SimulationSuiteControllerFindAllAsync(
        SimulationSuiteControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a simulation suite, a group of simulations that run together.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerCreateAsync(
        CreateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerDuplicateAsync(
        string id,
        SimulationSuiteControllerDuplicateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified simulation suite.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerFindOneAsync(
        string id,
        SimulationSuiteControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the specified simulation suite.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerRemoveAsync(
        string id,
        SimulationSuiteControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified simulation suite.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerUpdateAsync(
        string id,
        UpdateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
