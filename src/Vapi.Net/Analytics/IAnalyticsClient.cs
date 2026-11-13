namespace Vapi.Net;

public partial interface IAnalyticsClient
{
    /// <summary>
    /// Runs one or more metric queries against call or subscription data using the requested time range, groupings, and aggregate operations.
    /// </summary>
    WithRawResponseTask<IEnumerable<AnalyticsQueryResult>> GetAsync(
        AnalyticsQueryDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
