namespace Vapi.Net;

public partial interface IAssistantsClient
{
    /// <summary>
    /// Returns assistants for the authenticated organization. Filter results by creation or update timestamps and limit the number returned.
    /// </summary>
    WithRawResponseTask<IEnumerable<Assistant>> ListAsync(
        ListAssistantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a reusable assistant configuration containing the model, voice, transcriber, tools, prompts, and call behavior.
    /// </summary>
    WithRawResponseTask<Assistant> CreateAsync(
        CreateAssistantDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BackgroundSoundUrlValidationResult> AssistantControllerValidateBackgroundSoundUrlAsync(
        ValidateBackgroundSoundUrlDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the assistant identified by its ID.
    /// </summary>
    WithRawResponseTask<Assistant> GetAsync(
        string id,
        GetAssistantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the assistant identified by its ID.
    /// </summary>
    WithRawResponseTask<Assistant> DeleteAsync(
        string id,
        DeleteAssistantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified fields of the assistant identified by its ID.
    /// </summary>
    WithRawResponseTask<Assistant> UpdateAsync(
        string id,
        UpdateAssistantDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
