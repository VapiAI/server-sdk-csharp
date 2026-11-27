namespace Vapi.Net;

public partial interface ISquadsClient
{
    /// <summary>
    /// Returns squads for the authenticated organization. Filter results by creation or update timestamps and limit the number returned.
    /// </summary>
    WithRawResponseTask<IEnumerable<Squad>> ListAsync(
        ListSquadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a squad that coordinates multiple assistants and their handoffs during a conversation.
    /// </summary>
    WithRawResponseTask<Squad> CreateAsync(
        CreateSquadDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the squad identified by its ID.
    /// </summary>
    WithRawResponseTask<Squad> GetAsync(
        string id,
        GetSquadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the squad identified by its ID.
    /// </summary>
    WithRawResponseTask<Squad> DeleteAsync(
        string id,
        DeleteSquadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified fields of the squad identified by its ID.
    /// </summary>
    WithRawResponseTask<Squad> UpdateAsync(
        string id,
        UpdateSquadDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
