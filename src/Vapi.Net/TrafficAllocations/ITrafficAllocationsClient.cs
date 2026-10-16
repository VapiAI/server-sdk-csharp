namespace Vapi.Net;

public partial interface ITrafficAllocationsClient
{
    /// <summary>
    /// The append-only history of an assistant's allocations, newest first. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
    /// </summary>
    WithRawResponseTask<TrafficAllocationPaginatedResponse> TrafficAllocationControllerFindAllPaginatedAsync(
        TrafficAllocationControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new traffic allocation for an assistant, replacing the one currently in effect. To start or adjust a split, send targets naming published versions (such as "v7") with percentages totaling 100; allocationIntent is inferred as 'explicit'. To stop splitting and send every call to the newest published version, send allocationIntent 'follow-latest' with no targets field; stopping always names its intent, so a dropped targets field can never end a split by accident. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
    /// </summary>
    WithRawResponseTask<TrafficAllocation> TrafficAllocationControllerCreateAsync(
        CreateTrafficAllocationDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The allocation currently in effect for the assistant, with its targets. The response carries no allocation field when traffic splitting has never been configured. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
    /// </summary>
    WithRawResponseTask<TrafficAllocationLatestResponseDto> TrafficAllocationControllerLatestGetAsync(
        TrafficAllocationControllerLatestGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single allocation by id, including its targets and actor attribution. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
    /// </summary>
    WithRawResponseTask<TrafficAllocation> TrafficAllocationControllerFindOneAsync(
        string id,
        TrafficAllocationControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
