namespace Vapi.Net;

public partial interface ISimulationScenariosClient
{
    /// <summary>
    /// Returns the scenarios for the authenticated organization.
    /// </summary>
    WithRawResponseTask<IEnumerable<Scenario>> ScenarioControllerFindAllAsync(
        ScenarioControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a scenario, the AI tester's intent plus the success criteria that score a run.
    /// </summary>
    WithRawResponseTask<Scenario> ScenarioControllerCreateAsync(
        CreateScenarioDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified scenario.
    /// </summary>
    WithRawResponseTask<Scenario> ScenarioControllerFindOneAsync(
        string id,
        ScenarioControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the specified scenario.
    /// </summary>
    WithRawResponseTask<Scenario> ScenarioControllerRemoveAsync(
        string id,
        ScenarioControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified scenario.
    /// </summary>
    WithRawResponseTask<Scenario> ScenarioControllerUpdateAsync(
        string id,
        UpdateScenarioDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
