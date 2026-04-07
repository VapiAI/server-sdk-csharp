namespace Vapi.Net;

public partial interface IPhoneNumbersClient
{
    WithRawResponseTask<IEnumerable<object>> ListAsync(
        ListPhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> CreateAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PhoneNumberPaginatedResponse> PhoneNumberControllerFindAllPaginatedAsync(
        PhoneNumberControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> GetAsync(
        string id,
        GetPhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> DeleteAsync(
        string id,
        DeletePhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<object> UpdateAsync(
        string id,
        UpdatePhoneNumbersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
