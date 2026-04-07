namespace Vapi.Net;

public partial interface ISquadsClient
{
    WithRawResponseTask<IEnumerable<Squad>> ListAsync(
        ListSquadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Squad> CreateAsync(
        CreateSquadDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Squad> GetAsync(
        string id,
        GetSquadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Squad> DeleteAsync(
        string id,
        DeleteSquadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Squad> UpdateAsync(
        string id,
        UpdateSquadDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
