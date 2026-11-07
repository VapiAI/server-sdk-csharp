namespace Vapi.Net;

public partial interface ITrafficAllocationsClient
{
    /// <summary>
    /// The append-only history of an assistant's allocations, newest first.
    /// </summary>
    WithRawResponseTask<TrafficAllocationPaginatedResponse> TrafficAllocationControllerFindAllPaginatedAsync(
        TrafficAllocationControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new traffic allocation for an assistant, replacing the one currently in effect. To start or adjust a split, send targets naming published versions (such as "v7") with percentages totaling 100; allocationIntent is inferred as 'explicit'. To stop splitting and send every call to the newest published version, send allocationIntent 'follow-latest' with no targets field; stopping always names its intent, so a dropped targets field can never end a split by accident.
    /// </summary>
    WithRawResponseTask<TrafficAllocation> TrafficAllocationControllerCreateAsync(
        CreateTrafficAllocationDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The allocation currently in effect for the assistant, with its targets. The response carries no allocation field when traffic splitting has never been configured.
    /// </summary>
    WithRawResponseTask<TrafficAllocationLatestResponseDto> TrafficAllocationControllerLatestGetAsync(
        TrafficAllocationControllerLatestGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Per-assistant-version call metrics over a time window: call counts, configured vs actual traffic share, duration, cost per minute, latency, ended reasons, a bucketed timeseries, and optional structured output aggregations. Calls with no assistant version are reported as an 'unversioned' row.
    /// </summary>
    WithRawResponseTask<TrafficTabMetricsDto> TrafficAllocationControllerMetricsGetAsync(
        TrafficAllocationControllerMetricsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single allocation by id, including its targets and actor attribution.
    /// </summary>
    WithRawResponseTask<TrafficAllocation> TrafficAllocationControllerFindOneAsync(
        string id,
        TrafficAllocationControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
