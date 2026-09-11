namespace Vapi.Net;

public partial interface IPhoneNumbersClient
{
    /// <summary>
    /// Returns phone numbers for the authenticated organization. Filter results by creation or update timestamps and limit the number returned.
    /// </summary>
    WithRawResponseTask<IEnumerable<object>> ListAsync(
        ListPhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a Vapi phone number or imports a phone number from a supported provider, including Twilio, Vonage, Telnyx, or a bring-your-own provider.
    /// </summary>
    WithRawResponseTask<object> CreateAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a paginated list of phone numbers for the authenticated organization. Search by name, number, or SIP URI using a partial, case-insensitive match, and filter by creation or update timestamps.
    /// </summary>
    WithRawResponseTask<PhoneNumberPaginatedResponse> PhoneNumberControllerFindAllPaginatedAsync(
        PhoneNumberControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the phone number resource identified by its ID.
    /// </summary>
    WithRawResponseTask<object> GetAsync(
        string id,
        GetPhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the phone number resource identified by its ID.
    /// </summary>
    WithRawResponseTask<object> DeleteAsync(
        string id,
        DeletePhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified fields of the phone number resource identified by its ID.
    /// </summary>
    WithRawResponseTask<object> UpdateAsync(
        string id,
        UpdatePhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
