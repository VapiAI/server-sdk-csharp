namespace Vapi.Net;

public partial interface IAnalyticsClient
{
    WithRawResponseTask<IEnumerable<AnalyticsQueryResult>> GetAsync(
        AnalyticsQueryDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
