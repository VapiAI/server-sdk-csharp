using OneOf;

namespace Vapi.Net;

public partial interface ICallsClient
{
    /// <summary>
    /// Returns calls for the authenticated organization. Filter results by call ID, assistant ID, phone number ID, or creation and update timestamps.
    /// </summary>
    WithRawResponseTask<IEnumerable<Call>> ListAsync(
        ListCallsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a call using an assistant or squad. The request can reference saved resources or include transient configurations.
    /// </summary>
    WithRawResponseTask<OneOf<Call, CallBatchResponse>> CreateAsync(
        CreateCallDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the call identified by its ID, including its status, configuration, and available call data.
    /// </summary>
    WithRawResponseTask<Call> GetAsync(
        string id,
        GetCallsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the call identified by its ID.
    /// </summary>
    WithRawResponseTask<Call> DeleteAsync(
        string id,
        DeleteCallDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the call identified by its ID.
    /// </summary>
    WithRawResponseTask<Call> UpdateAsync(
        string id,
        UpdateCallDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerMonoRecordingDownloadAsync(
        string id,
        CallArtifactControllerMonoRecordingDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerStereoRecordingDownloadAsync(
        string id,
        CallArtifactControllerStereoRecordingDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerVideoRecordingDownloadAsync(
        string id,
        CallArtifactControllerVideoRecordingDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerCustomerRecordingDownloadAsync(
        string id,
        CallArtifactControllerCustomerRecordingDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerAssistantRecordingDownloadAsync(
        string id,
        CallArtifactControllerAssistantRecordingDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerPcapDownloadAsync(
        string id,
        CallArtifactControllerPcapDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task CallArtifactControllerCallLogsDownloadAsync(
        string id,
        CallArtifactControllerCallLogsDownloadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
