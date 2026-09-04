using OneOf;

namespace Vapi.Net;

public partial interface ISimulationRunsClient
{
    /// <summary>
    /// Returns the simulation runs for the authenticated organization.
    /// </summary>
    WithRawResponseTask<
        OneOf<IEnumerable<SimulationRun>, SimulationRunsPaginatedResponse>
    > SimulationRunControllerFindAllAsync(
        SimulationRunControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Starts a simulation run against a target assistant or squad.
    /// </summary>
    WithRawResponseTask<CreateSimulationRunResponse> SimulationRunControllerCreateAsync(
        CreateSimulationRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified simulation run, including its status and item counts.
    /// </summary>
    WithRawResponseTask<SimulationRun> SimulationRunControllerFindOneAsync(
        string id,
        SimulationRunControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels the specified simulation run.
    /// </summary>
    WithRawResponseTask<SimulationRun> SimulationRunControllerCancelGroupAsync(
        string id,
        SimulationRunControllerCancelGroupRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the run items for the specified simulation run.
    /// </summary>
    WithRawResponseTask<IEnumerable<SimulationRunItem>> SimulationRunControllerFindItemsAsync(
        string id,
        SimulationRunControllerFindItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified run item, including its evaluation results and the ID of the call that ran it.
    /// </summary>
    WithRawResponseTask<SimulationRunItem> SimulationRunControllerFindItemAsync(
        string id,
        string itemId,
        SimulationRunControllerFindItemRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels the specified run item.
    /// </summary>
    WithRawResponseTask<SimulationRunItem> SimulationRunControllerCancelItemAsync(
        string id,
        string itemId,
        SimulationRunControllerCancelItemRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generates AI suggestions for improving the assistant or squad's system prompt, tools, and scenarios, based on the specified run item.
    /// </summary>
    Task SimulationRunControllerGenerateSuggestionsAsync(
        string id,
        string itemId,
        SimulationRunControllerGenerateSuggestionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
