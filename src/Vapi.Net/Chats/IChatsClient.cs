using OneOf;

namespace Vapi.Net;

public partial interface IChatsClient
{
    WithRawResponseTask<ChatPaginatedResponse> ListAsync(
        ListChatsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new chat with optional SMS delivery via transport field. Requires at least one of: assistantId/assistant, sessionId, or previousChatId. Note: sessionId and previousChatId are mutually exclusive. Transport field enables SMS delivery with two modes: (1) New conversation - provide transport.phoneNumberId and transport.customer to create a new session, (2) Existing conversation - provide sessionId to use existing session data. Cannot specify both sessionId and transport fields together. The transport.useLLMGeneratedMessageForOutbound flag controls whether input is processed by LLM (true, default) or forwarded directly as SMS (false).
    /// </summary>
    WithRawResponseTask<OneOf<Chat, CreateChatStreamResponse>> CreateAsync(
        CreateChatDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Chat> GetAsync(
        string id,
        GetChatsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Chat> DeleteAsync(
        string id,
        DeleteChatsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<
        OneOf<
            ResponseObject,
            ResponseTextDeltaEvent,
            ResponseTextDoneEvent,
            ResponseCompletedEvent,
            ResponseErrorEvent
        >
    > CreateResponseAsync(
        OpenAiResponsesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
