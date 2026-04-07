using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallEndedReasonSerializer))]
public enum CallEndedReason
{
    [EnumMember(Value = "call-start-error-neither-assistant-nor-server-set")]
    CallStartErrorNeitherAssistantNorServerSet,

    [EnumMember(Value = "assistant-request-failed")]
    AssistantRequestFailed,

    [EnumMember(Value = "assistant-request-returned-error")]
    AssistantRequestReturnedError,

    [EnumMember(Value = "assistant-request-returned-unspeakable-error")]
    AssistantRequestReturnedUnspeakableError,

    [EnumMember(Value = "assistant-request-returned-invalid-assistant")]
    AssistantRequestReturnedInvalidAssistant,

    [EnumMember(Value = "assistant-request-returned-no-assistant")]
    AssistantRequestReturnedNoAssistant,

    [EnumMember(Value = "assistant-request-returned-forwarding-phone-number")]
    AssistantRequestReturnedForwardingPhoneNumber,

    [EnumMember(Value = "scheduled-call-deleted")]
    ScheduledCallDeleted,

    [EnumMember(Value = "call.start.error-vapifault-get-org")]
    CallStartErrorVapifaultGetOrg,

    [EnumMember(Value = "call.start.error-vapifault-get-subscription")]
    CallStartErrorVapifaultGetSubscription,

    [EnumMember(Value = "call.start.error-get-assistant")]
    CallStartErrorGetAssistant,

    [EnumMember(Value = "call.start.error-get-phone-number")]
    CallStartErrorGetPhoneNumber,

    [EnumMember(Value = "call.start.error-get-customer")]
    CallStartErrorGetCustomer,

    [EnumMember(Value = "call.start.error-get-resources-validation")]
    CallStartErrorGetResourcesValidation,

    [EnumMember(Value = "call.start.error-vapi-number-international")]
    CallStartErrorVapiNumberInternational,

    [EnumMember(Value = "call.start.error-vapi-number-outbound-daily-limit")]
    CallStartErrorVapiNumberOutboundDailyLimit,

    [EnumMember(Value = "call.start.error-get-transport")]
    CallStartErrorGetTransport,

    [EnumMember(Value = "call.start.error-subscription-wallet-does-not-exist")]
    CallStartErrorSubscriptionWalletDoesNotExist,

    [EnumMember(Value = "call.start.error-fraud-check-failed")]
    CallStartErrorFraudCheckFailed,

    [EnumMember(Value = "call.start.error-subscription-frozen")]
    CallStartErrorSubscriptionFrozen,

    [EnumMember(Value = "call.start.error-subscription-insufficient-credits")]
    CallStartErrorSubscriptionInsufficientCredits,

    [EnumMember(Value = "call.start.error-subscription-upgrade-failed")]
    CallStartErrorSubscriptionUpgradeFailed,

    [EnumMember(Value = "call.start.error-subscription-concurrency-limit-reached")]
    CallStartErrorSubscriptionConcurrencyLimitReached,

    [EnumMember(Value = "call.start.error-enterprise-feature-not-available-recording-consent")]
    CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,

    [EnumMember(Value = "assistant-not-valid")]
    AssistantNotValid,

    [EnumMember(Value = "call.start.error-vapifault-database-error")]
    CallStartErrorVapifaultDatabaseError,

    [EnumMember(Value = "assistant-not-found")]
    AssistantNotFound,

    [EnumMember(Value = "pipeline-error-openai-voice-failed")]
    PipelineErrorOpenaiVoiceFailed,

    [EnumMember(Value = "pipeline-error-cartesia-voice-failed")]
    PipelineErrorCartesiaVoiceFailed,

    [EnumMember(Value = "pipeline-error-deepgram-voice-failed")]
    PipelineErrorDeepgramVoiceFailed,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-failed")]
    PipelineErrorElevenLabsVoiceFailed,

    [EnumMember(Value = "pipeline-error-playht-voice-failed")]
    PipelineErrorPlayhtVoiceFailed,

    [EnumMember(Value = "pipeline-error-lmnt-voice-failed")]
    PipelineErrorLmntVoiceFailed,

    [EnumMember(Value = "pipeline-error-azure-voice-failed")]
    PipelineErrorAzureVoiceFailed,

    [EnumMember(Value = "pipeline-error-rime-ai-voice-failed")]
    PipelineErrorRimeAiVoiceFailed,

    [EnumMember(Value = "pipeline-error-smallest-ai-voice-failed")]
    PipelineErrorSmallestAiVoiceFailed,

    [EnumMember(Value = "pipeline-error-vapi-voice-failed")]
    PipelineErrorVapiVoiceFailed,

    [EnumMember(Value = "pipeline-error-neuphonic-voice-failed")]
    PipelineErrorNeuphonicVoiceFailed,

    [EnumMember(Value = "pipeline-error-hume-voice-failed")]
    PipelineErrorHumeVoiceFailed,

    [EnumMember(Value = "pipeline-error-sesame-voice-failed")]
    PipelineErrorSesameVoiceFailed,

    [EnumMember(Value = "pipeline-error-inworld-voice-failed")]
    PipelineErrorInworldVoiceFailed,

    [EnumMember(Value = "pipeline-error-minimax-voice-failed")]
    PipelineErrorMinimaxVoiceFailed,

    [EnumMember(Value = "pipeline-error-wellsaid-voice-failed")]
    PipelineErrorWellsaidVoiceFailed,

    [EnumMember(Value = "pipeline-error-tavus-video-failed")]
    PipelineErrorTavusVideoFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-voice-failed")]
    CallInProgressErrorVapifaultOpenaiVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-cartesia-voice-failed")]
    CallInProgressErrorVapifaultCartesiaVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-deepgram-voice-failed")]
    CallInProgressErrorVapifaultDeepgramVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-voice-failed")]
    CallInProgressErrorVapifaultElevenLabsVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-voice-failed")]
    CallInProgressErrorVapifaultPlayhtVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-lmnt-voice-failed")]
    CallInProgressErrorVapifaultLmntVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-azure-voice-failed")]
    CallInProgressErrorVapifaultAzureVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-rime-ai-voice-failed")]
    CallInProgressErrorVapifaultRimeAiVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-smallest-ai-voice-failed")]
    CallInProgressErrorVapifaultSmallestAiVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-vapi-voice-failed")]
    CallInProgressErrorVapifaultVapiVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-neuphonic-voice-failed")]
    CallInProgressErrorVapifaultNeuphonicVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-hume-voice-failed")]
    CallInProgressErrorVapifaultHumeVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-sesame-voice-failed")]
    CallInProgressErrorVapifaultSesameVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-inworld-voice-failed")]
    CallInProgressErrorVapifaultInworldVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-minimax-voice-failed")]
    CallInProgressErrorVapifaultMinimaxVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-wellsaid-voice-failed")]
    CallInProgressErrorVapifaultWellsaidVoiceFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-tavus-video-failed")]
    CallInProgressErrorVapifaultTavusVideoFailed,

    [EnumMember(Value = "pipeline-error-vapi-llm-failed")]
    PipelineErrorVapiLlmFailed,

    [EnumMember(Value = "pipeline-error-vapi-400-bad-request-validation-failed")]
    PipelineErrorVapi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-vapi-401-unauthorized")]
    PipelineErrorVapi401Unauthorized,

    [EnumMember(Value = "pipeline-error-vapi-403-model-access-denied")]
    PipelineErrorVapi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-vapi-429-exceeded-quota")]
    PipelineErrorVapi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-vapi-500-server-error")]
    PipelineErrorVapi500ServerError,

    [EnumMember(Value = "pipeline-error-vapi-503-server-overloaded-error")]
    PipelineErrorVapi503ServerOverloadedError,

    [EnumMember(Value = "call.in-progress.error-providerfault-vapi-llm-failed")]
    CallInProgressErrorProviderfaultVapiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed")]
    CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-vapi-401-unauthorized")]
    CallInProgressErrorVapifaultVapi401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-vapi-403-model-access-denied")]
    CallInProgressErrorVapifaultVapi403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-vapi-429-exceeded-quota")]
    CallInProgressErrorVapifaultVapi429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-vapi-500-server-error")]
    CallInProgressErrorProviderfaultVapi500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-vapi-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultVapi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-deepgram-transcriber-failed")]
    PipelineErrorDeepgramTranscriberFailed,

    [EnumMember(Value = "pipeline-error-deepgram-transcriber-api-key-missing")]
    PipelineErrorDeepgramTranscriberApiKeyMissing,

    [EnumMember(Value = "call.in-progress.error-vapifault-deepgram-transcriber-failed")]
    CallInProgressErrorVapifaultDeepgramTranscriberFailed,

    [EnumMember(Value = "pipeline-error-gladia-transcriber-failed")]
    PipelineErrorGladiaTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-gladia-transcriber-failed")]
    CallInProgressErrorVapifaultGladiaTranscriberFailed,

    [EnumMember(Value = "pipeline-error-speechmatics-transcriber-failed")]
    PipelineErrorSpeechmaticsTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-speechmatics-transcriber-failed")]
    CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,

    [EnumMember(Value = "pipeline-error-assembly-ai-transcriber-failed")]
    PipelineErrorAssemblyAiTranscriberFailed,

    [EnumMember(Value = "pipeline-error-assembly-ai-returning-400-insufficent-funds")]
    PipelineErrorAssemblyAiReturning400InsufficentFunds,

    [EnumMember(Value = "pipeline-error-assembly-ai-returning-400-paid-only-feature")]
    PipelineErrorAssemblyAiReturning400PaidOnlyFeature,

    [EnumMember(Value = "pipeline-error-assembly-ai-returning-401-invalid-credentials")]
    PipelineErrorAssemblyAiReturning401InvalidCredentials,

    [EnumMember(Value = "pipeline-error-assembly-ai-returning-500-invalid-schema")]
    PipelineErrorAssemblyAiReturning500InvalidSchema,

    [EnumMember(Value = "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed")]
    PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-assembly-ai-transcriber-failed")]
    CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds"
    )]
    CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature"
    )]
    CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials"
    )]
    CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema"
    )]
    CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed"
    )]
    CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,

    [EnumMember(Value = "pipeline-error-talkscriber-transcriber-failed")]
    PipelineErrorTalkscriberTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-talkscriber-transcriber-failed")]
    CallInProgressErrorVapifaultTalkscriberTranscriberFailed,

    [EnumMember(Value = "pipeline-error-azure-speech-transcriber-failed")]
    PipelineErrorAzureSpeechTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-azure-speech-transcriber-failed")]
    CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,

    [EnumMember(Value = "pipeline-error-eleven-labs-transcriber-failed")]
    PipelineErrorElevenLabsTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-transcriber-failed")]
    CallInProgressErrorVapifaultElevenLabsTranscriberFailed,

    [EnumMember(Value = "pipeline-error-google-transcriber-failed")]
    PipelineErrorGoogleTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-google-transcriber-failed")]
    CallInProgressErrorVapifaultGoogleTranscriberFailed,

    [EnumMember(Value = "pipeline-error-openai-transcriber-failed")]
    PipelineErrorOpenaiTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-transcriber-failed")]
    CallInProgressErrorVapifaultOpenaiTranscriberFailed,

    [EnumMember(Value = "pipeline-error-soniox-transcriber-auth-failed")]
    PipelineErrorSonioxTranscriberAuthFailed,

    [EnumMember(Value = "pipeline-error-soniox-transcriber-rate-limited")]
    PipelineErrorSonioxTranscriberRateLimited,

    [EnumMember(Value = "pipeline-error-soniox-transcriber-invalid-config")]
    PipelineErrorSonioxTranscriberInvalidConfig,

    [EnumMember(Value = "pipeline-error-soniox-transcriber-server-error")]
    PipelineErrorSonioxTranscriberServerError,

    [EnumMember(Value = "pipeline-error-soniox-transcriber-failed")]
    PipelineErrorSonioxTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-soniox-transcriber-auth-failed")]
    CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-soniox-transcriber-rate-limited")]
    CallInProgressErrorVapifaultSonioxTranscriberRateLimited,

    [EnumMember(Value = "call.in-progress.error-vapifault-soniox-transcriber-invalid-config")]
    CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,

    [EnumMember(Value = "call.in-progress.error-vapifault-soniox-transcriber-server-error")]
    CallInProgressErrorVapifaultSonioxTranscriberServerError,

    [EnumMember(Value = "call.in-progress.error-vapifault-soniox-transcriber-failed")]
    CallInProgressErrorVapifaultSonioxTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-pipeline-no-available-llm-model")]
    CallInProgressErrorPipelineNoAvailableLlmModel,

    [EnumMember(Value = "worker-shutdown")]
    WorkerShutdown,

    [EnumMember(Value = "vonage-disconnected")]
    VonageDisconnected,

    [EnumMember(Value = "vonage-failed-to-connect-call")]
    VonageFailedToConnectCall,

    [EnumMember(Value = "vonage-completed")]
    VonageCompleted,

    [EnumMember(Value = "phone-call-provider-bypass-enabled-but-no-call-received")]
    PhoneCallProviderBypassEnabledButNoCallReceived,

    [EnumMember(Value = "call.in-progress.error-providerfault-transport-never-connected")]
    CallInProgressErrorProviderfaultTransportNeverConnected,

    [EnumMember(Value = "call.in-progress.error-vapifault-worker-not-available")]
    CallInProgressErrorVapifaultWorkerNotAvailable,

    [EnumMember(Value = "call.in-progress.error-vapifault-transport-never-connected")]
    CallInProgressErrorVapifaultTransportNeverConnected,

    [EnumMember(Value = "call.in-progress.error-vapifault-transport-connected-but-call-not-active")]
    CallInProgressErrorVapifaultTransportConnectedButCallNotActive,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing"
    )]
    CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,

    [EnumMember(Value = "call.in-progress.error-vapifault-worker-died")]
    CallInProgressErrorVapifaultWorkerDied,

    [EnumMember(Value = "call.in-progress.twilio-completed-call")]
    CallInProgressTwilioCompletedCall,

    [EnumMember(Value = "call.in-progress.sip-completed-call")]
    CallInProgressSipCompletedCall,

    [EnumMember(Value = "call.in-progress.error-sip-inbound-call-failed-to-connect")]
    CallInProgressErrorSipInboundCallFailedToConnect,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable"
    )]
    CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,

    [EnumMember(Value = "call.in-progress.error-sip-outbound-call-failed-to-connect")]
    CallInProgressErrorSipOutboundCallFailedToConnect,

    [EnumMember(Value = "call.ringing.error-sip-inbound-call-failed-to-connect")]
    CallRingingErrorSipInboundCallFailedToConnect,

    [EnumMember(Value = "call.in-progress.error-providerfault-openai-llm-failed")]
    CallInProgressErrorProviderfaultOpenaiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-azure-openai-llm-failed")]
    CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-groq-llm-failed")]
    CallInProgressErrorProviderfaultGroqLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-google-llm-failed")]
    CallInProgressErrorProviderfaultGoogleLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-xai-llm-failed")]
    CallInProgressErrorProviderfaultXaiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-mistral-llm-failed")]
    CallInProgressErrorProviderfaultMistralLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-minimax-llm-failed")]
    CallInProgressErrorProviderfaultMinimaxLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-inflection-ai-llm-failed")]
    CallInProgressErrorProviderfaultInflectionAiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-cerebras-llm-failed")]
    CallInProgressErrorProviderfaultCerebrasLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-deep-seek-llm-failed")]
    CallInProgressErrorProviderfaultDeepSeekLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-baseten-llm-failed")]
    CallInProgressErrorProviderfaultBasetenLlmFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-chat-pipeline-failed-to-start")]
    CallInProgressErrorVapifaultChatPipelineFailedToStart,

    [EnumMember(Value = "pipeline-error-openai-400-bad-request-validation-failed")]
    PipelineErrorOpenai400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-openai-401-unauthorized")]
    PipelineErrorOpenai401Unauthorized,

    [EnumMember(Value = "pipeline-error-openai-401-incorrect-api-key")]
    PipelineErrorOpenai401IncorrectApiKey,

    [EnumMember(Value = "pipeline-error-openai-401-account-not-in-organization")]
    PipelineErrorOpenai401AccountNotInOrganization,

    [EnumMember(Value = "pipeline-error-openai-403-model-access-denied")]
    PipelineErrorOpenai403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-openai-429-exceeded-quota")]
    PipelineErrorOpenai429ExceededQuota,

    [EnumMember(Value = "pipeline-error-openai-429-rate-limit-reached")]
    PipelineErrorOpenai429RateLimitReached,

    [EnumMember(Value = "pipeline-error-openai-500-server-error")]
    PipelineErrorOpenai500ServerError,

    [EnumMember(Value = "pipeline-error-openai-503-server-overloaded-error")]
    PipelineErrorOpenai503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-openai-llm-failed")]
    PipelineErrorOpenaiLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-401-unauthorized")]
    CallInProgressErrorVapifaultOpenai401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-401-incorrect-api-key")]
    CallInProgressErrorVapifaultOpenai401IncorrectApiKey,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-401-account-not-in-organization")]
    CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-403-model-access-denied")]
    CallInProgressErrorVapifaultOpenai403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-429-exceeded-quota")]
    CallInProgressErrorVapifaultOpenai429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-429-rate-limit-reached")]
    CallInProgressErrorVapifaultOpenai429RateLimitReached,

    [EnumMember(Value = "call.in-progress.error-providerfault-openai-500-server-error")]
    CallInProgressErrorProviderfaultOpenai500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-openai-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-azure-openai-400-bad-request-validation-failed")]
    PipelineErrorAzureOpenai400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-azure-openai-401-unauthorized")]
    PipelineErrorAzureOpenai401Unauthorized,

    [EnumMember(Value = "pipeline-error-azure-openai-403-model-access-denied")]
    PipelineErrorAzureOpenai403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-azure-openai-429-exceeded-quota")]
    PipelineErrorAzureOpenai429ExceededQuota,

    [EnumMember(Value = "pipeline-error-azure-openai-500-server-error")]
    PipelineErrorAzureOpenai500ServerError,

    [EnumMember(Value = "pipeline-error-azure-openai-503-server-overloaded-error")]
    PipelineErrorAzureOpenai503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-azure-openai-llm-failed")]
    PipelineErrorAzureOpenaiLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-azure-openai-401-unauthorized")]
    CallInProgressErrorVapifaultAzureOpenai401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-azure-openai-403-model-access-denied")]
    CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota")]
    CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-azure-openai-500-server-error")]
    CallInProgressErrorProviderfaultAzureOpenai500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-google-400-bad-request-validation-failed")]
    PipelineErrorGoogle400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-google-401-unauthorized")]
    PipelineErrorGoogle401Unauthorized,

    [EnumMember(Value = "pipeline-error-google-403-model-access-denied")]
    PipelineErrorGoogle403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-google-429-exceeded-quota")]
    PipelineErrorGoogle429ExceededQuota,

    [EnumMember(Value = "pipeline-error-google-500-server-error")]
    PipelineErrorGoogle500ServerError,

    [EnumMember(Value = "pipeline-error-google-503-server-overloaded-error")]
    PipelineErrorGoogle503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-google-llm-failed")]
    PipelineErrorGoogleLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-google-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-google-401-unauthorized")]
    CallInProgressErrorVapifaultGoogle401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-google-403-model-access-denied")]
    CallInProgressErrorVapifaultGoogle403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-google-429-exceeded-quota")]
    CallInProgressErrorVapifaultGoogle429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-google-500-server-error")]
    CallInProgressErrorProviderfaultGoogle500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-google-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-xai-400-bad-request-validation-failed")]
    PipelineErrorXai400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-xai-401-unauthorized")]
    PipelineErrorXai401Unauthorized,

    [EnumMember(Value = "pipeline-error-xai-403-model-access-denied")]
    PipelineErrorXai403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-xai-429-exceeded-quota")]
    PipelineErrorXai429ExceededQuota,

    [EnumMember(Value = "pipeline-error-xai-500-server-error")]
    PipelineErrorXai500ServerError,

    [EnumMember(Value = "pipeline-error-xai-503-server-overloaded-error")]
    PipelineErrorXai503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-xai-llm-failed")]
    PipelineErrorXaiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed")]
    CallInProgressErrorVapifaultXai400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-xai-401-unauthorized")]
    CallInProgressErrorVapifaultXai401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-xai-403-model-access-denied")]
    CallInProgressErrorVapifaultXai403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-xai-429-exceeded-quota")]
    CallInProgressErrorVapifaultXai429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-xai-500-server-error")]
    CallInProgressErrorProviderfaultXai500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-xai-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultXai503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-baseten-400-bad-request-validation-failed")]
    PipelineErrorBaseten400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-baseten-401-unauthorized")]
    PipelineErrorBaseten401Unauthorized,

    [EnumMember(Value = "pipeline-error-baseten-403-model-access-denied")]
    PipelineErrorBaseten403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-baseten-429-exceeded-quota")]
    PipelineErrorBaseten429ExceededQuota,

    [EnumMember(Value = "pipeline-error-baseten-500-server-error")]
    PipelineErrorBaseten500ServerError,

    [EnumMember(Value = "pipeline-error-baseten-503-server-overloaded-error")]
    PipelineErrorBaseten503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-baseten-llm-failed")]
    PipelineErrorBasetenLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-baseten-401-unauthorized")]
    CallInProgressErrorVapifaultBaseten401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-baseten-403-model-access-denied")]
    CallInProgressErrorVapifaultBaseten403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-baseten-429-exceeded-quota")]
    CallInProgressErrorVapifaultBaseten429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-baseten-500-server-error")]
    CallInProgressErrorProviderfaultBaseten500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-baseten-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-mistral-400-bad-request-validation-failed")]
    PipelineErrorMistral400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-mistral-401-unauthorized")]
    PipelineErrorMistral401Unauthorized,

    [EnumMember(Value = "pipeline-error-mistral-403-model-access-denied")]
    PipelineErrorMistral403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-mistral-429-exceeded-quota")]
    PipelineErrorMistral429ExceededQuota,

    [EnumMember(Value = "pipeline-error-mistral-500-server-error")]
    PipelineErrorMistral500ServerError,

    [EnumMember(Value = "pipeline-error-mistral-503-server-overloaded-error")]
    PipelineErrorMistral503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-mistral-llm-failed")]
    PipelineErrorMistralLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-mistral-401-unauthorized")]
    CallInProgressErrorVapifaultMistral401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-mistral-403-model-access-denied")]
    CallInProgressErrorVapifaultMistral403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-mistral-429-exceeded-quota")]
    CallInProgressErrorVapifaultMistral429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-mistral-500-server-error")]
    CallInProgressErrorProviderfaultMistral500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-mistral-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultMistral503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-minimax-400-bad-request-validation-failed")]
    PipelineErrorMinimax400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-minimax-401-unauthorized")]
    PipelineErrorMinimax401Unauthorized,

    [EnumMember(Value = "pipeline-error-minimax-403-model-access-denied")]
    PipelineErrorMinimax403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-minimax-429-exceeded-quota")]
    PipelineErrorMinimax429ExceededQuota,

    [EnumMember(Value = "pipeline-error-minimax-500-server-error")]
    PipelineErrorMinimax500ServerError,

    [EnumMember(Value = "pipeline-error-minimax-503-server-overloaded-error")]
    PipelineErrorMinimax503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-minimax-llm-failed")]
    PipelineErrorMinimaxLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-minimax-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultMinimax400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-minimax-401-unauthorized")]
    CallInProgressErrorVapifaultMinimax401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-minimax-403-model-access-denied")]
    CallInProgressErrorVapifaultMinimax403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-minimax-429-exceeded-quota")]
    CallInProgressErrorVapifaultMinimax429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-minimax-500-server-error")]
    CallInProgressErrorProviderfaultMinimax500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-minimax-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultMinimax503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-inflection-ai-400-bad-request-validation-failed")]
    PipelineErrorInflectionAi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-inflection-ai-401-unauthorized")]
    PipelineErrorInflectionAi401Unauthorized,

    [EnumMember(Value = "pipeline-error-inflection-ai-403-model-access-denied")]
    PipelineErrorInflectionAi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-inflection-ai-429-exceeded-quota")]
    PipelineErrorInflectionAi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-inflection-ai-500-server-error")]
    PipelineErrorInflectionAi500ServerError,

    [EnumMember(Value = "pipeline-error-inflection-ai-503-server-overloaded-error")]
    PipelineErrorInflectionAi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-inflection-ai-llm-failed")]
    PipelineErrorInflectionAiLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-inflection-ai-401-unauthorized")]
    CallInProgressErrorVapifaultInflectionAi401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied")]
    CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota")]
    CallInProgressErrorVapifaultInflectionAi429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-inflection-ai-500-server-error")]
    CallInProgressErrorProviderfaultInflectionAi500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-deep-seek-400-bad-request-validation-failed")]
    PipelineErrorDeepSeek400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-deep-seek-401-unauthorized")]
    PipelineErrorDeepSeek401Unauthorized,

    [EnumMember(Value = "pipeline-error-deep-seek-403-model-access-denied")]
    PipelineErrorDeepSeek403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-deep-seek-429-exceeded-quota")]
    PipelineErrorDeepSeek429ExceededQuota,

    [EnumMember(Value = "pipeline-error-deep-seek-500-server-error")]
    PipelineErrorDeepSeek500ServerError,

    [EnumMember(Value = "pipeline-error-deep-seek-503-server-overloaded-error")]
    PipelineErrorDeepSeek503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-deep-seek-llm-failed")]
    PipelineErrorDeepSeekLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-deep-seek-401-unauthorized")]
    CallInProgressErrorVapifaultDeepSeek401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-deep-seek-403-model-access-denied")]
    CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota")]
    CallInProgressErrorVapifaultDeepSeek429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-deep-seek-500-server-error")]
    CallInProgressErrorProviderfaultDeepSeek500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-groq-400-bad-request-validation-failed")]
    PipelineErrorGroq400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-groq-401-unauthorized")]
    PipelineErrorGroq401Unauthorized,

    [EnumMember(Value = "pipeline-error-groq-403-model-access-denied")]
    PipelineErrorGroq403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-groq-429-exceeded-quota")]
    PipelineErrorGroq429ExceededQuota,

    [EnumMember(Value = "pipeline-error-groq-500-server-error")]
    PipelineErrorGroq500ServerError,

    [EnumMember(Value = "pipeline-error-groq-503-server-overloaded-error")]
    PipelineErrorGroq503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-groq-llm-failed")]
    PipelineErrorGroqLlmFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed")]
    CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-groq-401-unauthorized")]
    CallInProgressErrorVapifaultGroq401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-groq-403-model-access-denied")]
    CallInProgressErrorVapifaultGroq403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-groq-429-exceeded-quota")]
    CallInProgressErrorVapifaultGroq429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-groq-500-server-error")]
    CallInProgressErrorProviderfaultGroq500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-groq-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultGroq503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-cerebras-400-bad-request-validation-failed")]
    PipelineErrorCerebras400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-cerebras-401-unauthorized")]
    PipelineErrorCerebras401Unauthorized,

    [EnumMember(Value = "pipeline-error-cerebras-403-model-access-denied")]
    PipelineErrorCerebras403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-cerebras-429-exceeded-quota")]
    PipelineErrorCerebras429ExceededQuota,

    [EnumMember(Value = "pipeline-error-cerebras-500-server-error")]
    PipelineErrorCerebras500ServerError,

    [EnumMember(Value = "pipeline-error-cerebras-503-server-overloaded-error")]
    PipelineErrorCerebras503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-cerebras-llm-failed")]
    PipelineErrorCerebrasLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-cerebras-401-unauthorized")]
    CallInProgressErrorVapifaultCerebras401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-cerebras-403-model-access-denied")]
    CallInProgressErrorVapifaultCerebras403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-cerebras-429-exceeded-quota")]
    CallInProgressErrorVapifaultCerebras429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-cerebras-500-server-error")]
    CallInProgressErrorProviderfaultCerebras500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anthropic-400-bad-request-validation-failed")]
    PipelineErrorAnthropic400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-anthropic-401-unauthorized")]
    PipelineErrorAnthropic401Unauthorized,

    [EnumMember(Value = "pipeline-error-anthropic-403-model-access-denied")]
    PipelineErrorAnthropic403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-anthropic-429-exceeded-quota")]
    PipelineErrorAnthropic429ExceededQuota,

    [EnumMember(Value = "pipeline-error-anthropic-500-server-error")]
    PipelineErrorAnthropic500ServerError,

    [EnumMember(Value = "pipeline-error-anthropic-503-server-overloaded-error")]
    PipelineErrorAnthropic503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anthropic-llm-failed")]
    PipelineErrorAnthropicLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-anthropic-llm-failed")]
    CallInProgressErrorProviderfaultAnthropicLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-401-unauthorized")]
    CallInProgressErrorVapifaultAnthropic401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-403-model-access-denied")]
    CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-429-exceeded-quota")]
    CallInProgressErrorVapifaultAnthropic429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-anthropic-500-server-error")]
    CallInProgressErrorProviderfaultAnthropic500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed")]
    PipelineErrorAnthropicBedrock400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-401-unauthorized")]
    PipelineErrorAnthropicBedrock401Unauthorized,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-403-model-access-denied")]
    PipelineErrorAnthropicBedrock403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-429-exceeded-quota")]
    PipelineErrorAnthropicBedrock429ExceededQuota,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-500-server-error")]
    PipelineErrorAnthropicBedrock500ServerError,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-503-server-overloaded-error")]
    PipelineErrorAnthropicBedrock503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anthropic-bedrock-llm-failed")]
    PipelineErrorAnthropicBedrockLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed")]
    CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized")]
    CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied"
    )]
    CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota")]
    CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error")]
    CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-400-bad-request-validation-failed")]
    PipelineErrorAnthropicVertex400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-401-unauthorized")]
    PipelineErrorAnthropicVertex401Unauthorized,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-403-model-access-denied")]
    PipelineErrorAnthropicVertex403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-429-exceeded-quota")]
    PipelineErrorAnthropicVertex429ExceededQuota,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-500-server-error")]
    PipelineErrorAnthropicVertex500ServerError,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-503-server-overloaded-error")]
    PipelineErrorAnthropicVertex503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anthropic-vertex-llm-failed")]
    PipelineErrorAnthropicVertexLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-anthropic-vertex-llm-failed")]
    CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized")]
    CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied"
    )]
    CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota")]
    CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-anthropic-vertex-500-server-error")]
    CallInProgressErrorProviderfaultAnthropicVertex500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-together-ai-400-bad-request-validation-failed")]
    PipelineErrorTogetherAi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-together-ai-401-unauthorized")]
    PipelineErrorTogetherAi401Unauthorized,

    [EnumMember(Value = "pipeline-error-together-ai-403-model-access-denied")]
    PipelineErrorTogetherAi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-together-ai-429-exceeded-quota")]
    PipelineErrorTogetherAi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-together-ai-500-server-error")]
    PipelineErrorTogetherAi500ServerError,

    [EnumMember(Value = "pipeline-error-together-ai-503-server-overloaded-error")]
    PipelineErrorTogetherAi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-together-ai-llm-failed")]
    PipelineErrorTogetherAiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-together-ai-llm-failed")]
    CallInProgressErrorProviderfaultTogetherAiLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-together-ai-401-unauthorized")]
    CallInProgressErrorVapifaultTogetherAi401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-together-ai-403-model-access-denied")]
    CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-together-ai-429-exceeded-quota")]
    CallInProgressErrorVapifaultTogetherAi429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-together-ai-500-server-error")]
    CallInProgressErrorProviderfaultTogetherAi500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anyscale-400-bad-request-validation-failed")]
    PipelineErrorAnyscale400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-anyscale-401-unauthorized")]
    PipelineErrorAnyscale401Unauthorized,

    [EnumMember(Value = "pipeline-error-anyscale-403-model-access-denied")]
    PipelineErrorAnyscale403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-anyscale-429-exceeded-quota")]
    PipelineErrorAnyscale429ExceededQuota,

    [EnumMember(Value = "pipeline-error-anyscale-500-server-error")]
    PipelineErrorAnyscale500ServerError,

    [EnumMember(Value = "pipeline-error-anyscale-503-server-overloaded-error")]
    PipelineErrorAnyscale503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-anyscale-llm-failed")]
    PipelineErrorAnyscaleLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-anyscale-llm-failed")]
    CallInProgressErrorProviderfaultAnyscaleLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-anyscale-401-unauthorized")]
    CallInProgressErrorVapifaultAnyscale401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-anyscale-403-model-access-denied")]
    CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-anyscale-429-exceeded-quota")]
    CallInProgressErrorVapifaultAnyscale429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-anyscale-500-server-error")]
    CallInProgressErrorProviderfaultAnyscale500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-openrouter-400-bad-request-validation-failed")]
    PipelineErrorOpenrouter400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-openrouter-401-unauthorized")]
    PipelineErrorOpenrouter401Unauthorized,

    [EnumMember(Value = "pipeline-error-openrouter-403-model-access-denied")]
    PipelineErrorOpenrouter403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-openrouter-429-exceeded-quota")]
    PipelineErrorOpenrouter429ExceededQuota,

    [EnumMember(Value = "pipeline-error-openrouter-500-server-error")]
    PipelineErrorOpenrouter500ServerError,

    [EnumMember(Value = "pipeline-error-openrouter-503-server-overloaded-error")]
    PipelineErrorOpenrouter503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-openrouter-llm-failed")]
    PipelineErrorOpenrouterLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-openrouter-llm-failed")]
    CallInProgressErrorProviderfaultOpenrouterLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-openrouter-401-unauthorized")]
    CallInProgressErrorVapifaultOpenrouter401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-openrouter-403-model-access-denied")]
    CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-openrouter-429-exceeded-quota")]
    CallInProgressErrorVapifaultOpenrouter429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-openrouter-500-server-error")]
    CallInProgressErrorProviderfaultOpenrouter500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-perplexity-ai-400-bad-request-validation-failed")]
    PipelineErrorPerplexityAi400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-perplexity-ai-401-unauthorized")]
    PipelineErrorPerplexityAi401Unauthorized,

    [EnumMember(Value = "pipeline-error-perplexity-ai-403-model-access-denied")]
    PipelineErrorPerplexityAi403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-perplexity-ai-429-exceeded-quota")]
    PipelineErrorPerplexityAi429ExceededQuota,

    [EnumMember(Value = "pipeline-error-perplexity-ai-500-server-error")]
    PipelineErrorPerplexityAi500ServerError,

    [EnumMember(Value = "pipeline-error-perplexity-ai-503-server-overloaded-error")]
    PipelineErrorPerplexityAi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-perplexity-ai-llm-failed")]
    PipelineErrorPerplexityAiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-perplexity-ai-llm-failed")]
    CallInProgressErrorProviderfaultPerplexityAiLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized")]
    CallInProgressErrorVapifaultPerplexityAi401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied")]
    CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota")]
    CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-perplexity-ai-500-server-error")]
    CallInProgressErrorProviderfaultPerplexityAi500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-deepinfra-400-bad-request-validation-failed")]
    PipelineErrorDeepinfra400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-deepinfra-401-unauthorized")]
    PipelineErrorDeepinfra401Unauthorized,

    [EnumMember(Value = "pipeline-error-deepinfra-403-model-access-denied")]
    PipelineErrorDeepinfra403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-deepinfra-429-exceeded-quota")]
    PipelineErrorDeepinfra429ExceededQuota,

    [EnumMember(Value = "pipeline-error-deepinfra-500-server-error")]
    PipelineErrorDeepinfra500ServerError,

    [EnumMember(Value = "pipeline-error-deepinfra-503-server-overloaded-error")]
    PipelineErrorDeepinfra503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-deepinfra-llm-failed")]
    PipelineErrorDeepinfraLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-deepinfra-llm-failed")]
    CallInProgressErrorProviderfaultDeepinfraLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-deepinfra-401-unauthorized")]
    CallInProgressErrorVapifaultDeepinfra401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-deepinfra-403-model-access-denied")]
    CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota")]
    CallInProgressErrorVapifaultDeepinfra429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-deepinfra-500-server-error")]
    CallInProgressErrorProviderfaultDeepinfra500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-runpod-400-bad-request-validation-failed")]
    PipelineErrorRunpod400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-runpod-401-unauthorized")]
    PipelineErrorRunpod401Unauthorized,

    [EnumMember(Value = "pipeline-error-runpod-403-model-access-denied")]
    PipelineErrorRunpod403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-runpod-429-exceeded-quota")]
    PipelineErrorRunpod429ExceededQuota,

    [EnumMember(Value = "pipeline-error-runpod-500-server-error")]
    PipelineErrorRunpod500ServerError,

    [EnumMember(Value = "pipeline-error-runpod-503-server-overloaded-error")]
    PipelineErrorRunpod503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-runpod-llm-failed")]
    PipelineErrorRunpodLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-runpod-llm-failed")]
    CallInProgressErrorProviderfaultRunpodLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-runpod-401-unauthorized")]
    CallInProgressErrorVapifaultRunpod401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-runpod-403-model-access-denied")]
    CallInProgressErrorVapifaultRunpod403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-runpod-429-exceeded-quota")]
    CallInProgressErrorVapifaultRunpod429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-runpod-500-server-error")]
    CallInProgressErrorProviderfaultRunpod500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-runpod-503-server-overloaded-error")]
    CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-custom-llm-400-bad-request-validation-failed")]
    PipelineErrorCustomLlm400BadRequestValidationFailed,

    [EnumMember(Value = "pipeline-error-custom-llm-401-unauthorized")]
    PipelineErrorCustomLlm401Unauthorized,

    [EnumMember(Value = "pipeline-error-custom-llm-403-model-access-denied")]
    PipelineErrorCustomLlm403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-custom-llm-429-exceeded-quota")]
    PipelineErrorCustomLlm429ExceededQuota,

    [EnumMember(Value = "pipeline-error-custom-llm-500-server-error")]
    PipelineErrorCustomLlm500ServerError,

    [EnumMember(Value = "pipeline-error-custom-llm-503-server-overloaded-error")]
    PipelineErrorCustomLlm503ServerOverloadedError,

    [EnumMember(Value = "pipeline-error-custom-llm-llm-failed")]
    PipelineErrorCustomLlmLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-custom-llm-llm-failed")]
    CallInProgressErrorProviderfaultCustomLlmLlmFailed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed"
    )]
    CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-custom-llm-401-unauthorized")]
    CallInProgressErrorVapifaultCustomLlm401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-custom-llm-403-model-access-denied")]
    CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota")]
    CallInProgressErrorVapifaultCustomLlm429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-custom-llm-500-server-error")]
    CallInProgressErrorProviderfaultCustomLlm500ServerError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error"
    )]
    CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,

    [EnumMember(Value = "call.in-progress.error-pipeline-ws-model-connection-failed")]
    CallInProgressErrorPipelineWsModelConnectionFailed,

    [EnumMember(Value = "pipeline-error-custom-voice-failed")]
    PipelineErrorCustomVoiceFailed,

    [EnumMember(Value = "pipeline-error-cartesia-socket-hang-up")]
    PipelineErrorCartesiaSocketHangUp,

    [EnumMember(Value = "pipeline-error-cartesia-requested-payment")]
    PipelineErrorCartesiaRequestedPayment,

    [EnumMember(Value = "pipeline-error-cartesia-500-server-error")]
    PipelineErrorCartesia500ServerError,

    [EnumMember(Value = "pipeline-error-cartesia-502-server-error")]
    PipelineErrorCartesia502ServerError,

    [EnumMember(Value = "pipeline-error-cartesia-503-server-error")]
    PipelineErrorCartesia503ServerError,

    [EnumMember(Value = "pipeline-error-cartesia-522-server-error")]
    PipelineErrorCartesia522ServerError,

    [EnumMember(Value = "call.in-progress.error-vapifault-cartesia-socket-hang-up")]
    CallInProgressErrorVapifaultCartesiaSocketHangUp,

    [EnumMember(Value = "call.in-progress.error-vapifault-cartesia-requested-payment")]
    CallInProgressErrorVapifaultCartesiaRequestedPayment,

    [EnumMember(Value = "call.in-progress.error-providerfault-cartesia-500-server-error")]
    CallInProgressErrorProviderfaultCartesia500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-cartesia-503-server-error")]
    CallInProgressErrorProviderfaultCartesia503ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-cartesia-522-server-error")]
    CallInProgressErrorProviderfaultCartesia522ServerError,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-found")]
    PipelineErrorElevenLabsVoiceNotFound,

    [EnumMember(Value = "pipeline-error-eleven-labs-quota-exceeded")]
    PipelineErrorElevenLabsQuotaExceeded,

    [EnumMember(Value = "pipeline-error-eleven-labs-unauthorized-access")]
    PipelineErrorElevenLabsUnauthorizedAccess,

    [EnumMember(Value = "pipeline-error-eleven-labs-unauthorized-to-access-model")]
    PipelineErrorElevenLabsUnauthorizedToAccessModel,

    [EnumMember(Value = "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus")]
    PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,

    [EnumMember(Value = "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade")]
    PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,

    [EnumMember(
        Value = "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade"
    )]
    PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,

    [EnumMember(
        Value = "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade"
    )]
    PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,

    [EnumMember(Value = "pipeline-error-eleven-labs-system-busy-and-requested-upgrade")]
    PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-fine-tuned")]
    PipelineErrorElevenLabsVoiceNotFineTuned,

    [EnumMember(Value = "pipeline-error-eleven-labs-invalid-api-key")]
    PipelineErrorElevenLabsInvalidApiKey,

    [EnumMember(Value = "pipeline-error-eleven-labs-invalid-voice-samples")]
    PipelineErrorElevenLabsInvalidVoiceSamples,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-disabled-by-owner")]
    PipelineErrorElevenLabsVoiceDisabledByOwner,

    [EnumMember(Value = "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner")]
    PipelineErrorElevenLabsVapiVoiceDisabledByOwner,

    [EnumMember(Value = "pipeline-error-eleven-labs-blocked-account-in-probation")]
    PipelineErrorElevenLabsBlockedAccountInProbation,

    [EnumMember(Value = "pipeline-error-eleven-labs-blocked-content-against-their-policy")]
    PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,

    [EnumMember(Value = "pipeline-error-eleven-labs-missing-samples-for-voice-clone")]
    PipelineErrorElevenLabsMissingSamplesForVoiceClone,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used")]
    PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,

    [EnumMember(Value = "pipeline-error-eleven-labs-voice-not-allowed-for-free-users")]
    PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,

    [EnumMember(Value = "pipeline-error-eleven-labs-max-character-limit-exceeded")]
    PipelineErrorElevenLabsMaxCharacterLimitExceeded,

    [EnumMember(
        Value = "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification"
    )]
    PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,

    [EnumMember(Value = "pipeline-error-eleven-labs-500-server-error")]
    PipelineErrorElevenLabs500ServerError,

    [EnumMember(Value = "pipeline-error-eleven-labs-503-server-error")]
    PipelineErrorElevenLabs503ServerError,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-voice-not-found")]
    CallInProgressErrorVapifaultElevenLabsVoiceNotFound,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-quota-exceeded")]
    CallInProgressErrorVapifaultElevenLabsQuotaExceeded,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-unauthorized-access")]
    CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model"
    )]
    CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus"
    )]
    CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade"
    )]
    CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade"
    )]
    CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade"
    )]
    CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade"
    )]
    CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned")]
    CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-invalid-api-key")]
    CallInProgressErrorVapifaultElevenLabsInvalidApiKey,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples")]
    CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner")]
    CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation"
    )]
    CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy"
    )]
    CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone"
    )]
    CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used"
    )]
    CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users"
    )]
    CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded"
    )]
    CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification"
    )]
    CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade"
    )]
    CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,

    [EnumMember(Value = "call.in-progress.error-providerfault-eleven-labs-500-server-error")]
    CallInProgressErrorProviderfaultElevenLabs500ServerError,

    [EnumMember(Value = "call.in-progress.error-providerfault-eleven-labs-503-server-error")]
    CallInProgressErrorProviderfaultElevenLabs503ServerError,

    [EnumMember(Value = "pipeline-error-playht-request-timed-out")]
    PipelineErrorPlayhtRequestTimedOut,

    [EnumMember(Value = "pipeline-error-playht-invalid-voice")]
    PipelineErrorPlayhtInvalidVoice,

    [EnumMember(Value = "pipeline-error-playht-unexpected-error")]
    PipelineErrorPlayhtUnexpectedError,

    [EnumMember(Value = "pipeline-error-playht-out-of-credits")]
    PipelineErrorPlayhtOutOfCredits,

    [EnumMember(Value = "pipeline-error-playht-invalid-emotion")]
    PipelineErrorPlayhtInvalidEmotion,

    [EnumMember(Value = "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri")]
    PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,

    [EnumMember(Value = "pipeline-error-playht-401-unauthorized")]
    PipelineErrorPlayht401Unauthorized,

    [EnumMember(Value = "pipeline-error-playht-403-forbidden-out-of-characters")]
    PipelineErrorPlayht403ForbiddenOutOfCharacters,

    [EnumMember(Value = "pipeline-error-playht-403-forbidden-api-access-not-available")]
    PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,

    [EnumMember(Value = "pipeline-error-playht-429-exceeded-quota")]
    PipelineErrorPlayht429ExceededQuota,

    [EnumMember(Value = "pipeline-error-playht-502-gateway-error")]
    PipelineErrorPlayht502GatewayError,

    [EnumMember(Value = "pipeline-error-playht-504-gateway-error")]
    PipelineErrorPlayht504GatewayError,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-request-timed-out")]
    CallInProgressErrorVapifaultPlayhtRequestTimedOut,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-invalid-voice")]
    CallInProgressErrorVapifaultPlayhtInvalidVoice,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-unexpected-error")]
    CallInProgressErrorVapifaultPlayhtUnexpectedError,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-out-of-credits")]
    CallInProgressErrorVapifaultPlayhtOutOfCredits,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-invalid-emotion")]
    CallInProgressErrorVapifaultPlayhtInvalidEmotion,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri"
    )]
    CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-401-unauthorized")]
    CallInProgressErrorVapifaultPlayht401Unauthorized,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters")]
    CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available"
    )]
    CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,

    [EnumMember(Value = "call.in-progress.error-vapifault-playht-429-exceeded-quota")]
    CallInProgressErrorVapifaultPlayht429ExceededQuota,

    [EnumMember(Value = "call.in-progress.error-providerfault-playht-502-gateway-error")]
    CallInProgressErrorProviderfaultPlayht502GatewayError,

    [EnumMember(Value = "call.in-progress.error-providerfault-playht-504-gateway-error")]
    CallInProgressErrorProviderfaultPlayht504GatewayError,

    [EnumMember(Value = "pipeline-error-custom-transcriber-failed")]
    PipelineErrorCustomTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-custom-transcriber-failed")]
    CallInProgressErrorVapifaultCustomTranscriberFailed,

    [EnumMember(
        Value = "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination"
    )]
    PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,

    [EnumMember(Value = "pipeline-error-deepgram-returning-401-invalid-credentials")]
    PipelineErrorDeepgramReturning401InvalidCredentials,

    [EnumMember(Value = "pipeline-error-deepgram-returning-403-model-access-denied")]
    PipelineErrorDeepgramReturning403ModelAccessDenied,

    [EnumMember(Value = "pipeline-error-deepgram-returning-404-not-found")]
    PipelineErrorDeepgramReturning404NotFound,

    [EnumMember(Value = "pipeline-error-deepgram-returning-500-invalid-json")]
    PipelineErrorDeepgramReturning500InvalidJson,

    [EnumMember(Value = "pipeline-error-deepgram-returning-502-network-error")]
    PipelineErrorDeepgramReturning502NetworkError,

    [EnumMember(Value = "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach")]
    PipelineErrorDeepgramReturning502BadGatewayEhostunreach,

    [EnumMember(Value = "pipeline-error-deepgram-returning-econnreset")]
    PipelineErrorDeepgramReturningEconnreset,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination"
    )]
    CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials"
    )]
    CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,

    [EnumMember(Value = "call.in-progress.error-vapifault-deepgram-returning-404-not-found")]
    CallInProgressErrorVapifaultDeepgramReturning404NotFound,

    [EnumMember(
        Value = "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied"
    )]
    CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,

    [EnumMember(Value = "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json")]
    CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-deepgram-returning-502-network-error"
    )]
    CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach"
    )]
    CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,

    [EnumMember(Value = "call.in-progress.error-warm-transfer-max-duration")]
    CallInProgressErrorWarmTransferMaxDuration,

    [EnumMember(Value = "call.in-progress.error-warm-transfer-assistant-cancelled")]
    CallInProgressErrorWarmTransferAssistantCancelled,

    [EnumMember(Value = "call.in-progress.error-warm-transfer-silence-timeout")]
    CallInProgressErrorWarmTransferSilenceTimeout,

    [EnumMember(Value = "call.in-progress.error-warm-transfer-microphone-timeout")]
    CallInProgressErrorWarmTransferMicrophoneTimeout,

    [EnumMember(Value = "assistant-ended-call")]
    AssistantEndedCall,

    [EnumMember(Value = "assistant-said-end-call-phrase")]
    AssistantSaidEndCallPhrase,

    [EnumMember(Value = "assistant-ended-call-with-hangup-task")]
    AssistantEndedCallWithHangupTask,

    [EnumMember(Value = "assistant-ended-call-after-message-spoken")]
    AssistantEndedCallAfterMessageSpoken,

    [EnumMember(Value = "assistant-forwarded-call")]
    AssistantForwardedCall,

    [EnumMember(Value = "assistant-join-timed-out")]
    AssistantJoinTimedOut,

    [EnumMember(Value = "call.in-progress.error-assistant-did-not-receive-customer-audio")]
    CallInProgressErrorAssistantDidNotReceiveCustomerAudio,

    [EnumMember(Value = "call.in-progress.error-transfer-failed")]
    CallInProgressErrorTransferFailed,

    [EnumMember(Value = "customer-busy")]
    CustomerBusy,

    [EnumMember(Value = "customer-ended-call")]
    CustomerEndedCall,

    [EnumMember(Value = "customer-ended-call-before-warm-transfer")]
    CustomerEndedCallBeforeWarmTransfer,

    [EnumMember(Value = "customer-ended-call-after-warm-transfer-attempt")]
    CustomerEndedCallAfterWarmTransferAttempt,

    [EnumMember(Value = "customer-ended-call-during-transfer")]
    CustomerEndedCallDuringTransfer,

    [EnumMember(Value = "customer-did-not-answer")]
    CustomerDidNotAnswer,

    [EnumMember(Value = "customer-did-not-give-microphone-permission")]
    CustomerDidNotGiveMicrophonePermission,

    [EnumMember(Value = "exceeded-max-duration")]
    ExceededMaxDuration,

    [EnumMember(Value = "manually-canceled")]
    ManuallyCanceled,

    [EnumMember(Value = "phone-call-provider-closed-websocket")]
    PhoneCallProviderClosedWebsocket,

    [EnumMember(Value = "call.forwarding.operator-busy")]
    CallForwardingOperatorBusy,

    [EnumMember(Value = "silence-timed-out")]
    SilenceTimedOut,

    [EnumMember(Value = "call.in-progress.error-providerfault-outbound-sip-403-forbidden")]
    CallInProgressErrorProviderfaultOutboundSip403Forbidden,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required"
    )]
    CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,

    [EnumMember(Value = "call.in-progress.error-providerfault-outbound-sip-408-request-timeout")]
    CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable"
    )]
    CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,

    [EnumMember(Value = "call.ringing.hook-executed-say")]
    CallRingingHookExecutedSay,

    [EnumMember(Value = "call.ringing.hook-executed-transfer")]
    CallRingingHookExecutedTransfer,

    [EnumMember(Value = "call.ending.hook-executed-say")]
    CallEndingHookExecutedSay,

    [EnumMember(Value = "call.ending.hook-executed-transfer")]
    CallEndingHookExecutedTransfer,

    [EnumMember(Value = "call.ringing.sip-inbound-caller-hungup-before-call-connect")]
    CallRingingSipInboundCallerHungupBeforeCallConnect,

    [EnumMember(Value = "twilio-failed-to-connect-call")]
    TwilioFailedToConnectCall,

    [EnumMember(Value = "twilio-reported-customer-misdialed")]
    TwilioReportedCustomerMisdialed,

    [EnumMember(Value = "vonage-rejected")]
    VonageRejected,

    [EnumMember(Value = "voicemail")]
    Voicemail,

    [EnumMember(Value = "call-deleted")]
    CallDeleted,
}

internal class CallEndedReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallEndedReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallEndedReason
    > _stringToEnum = new()
    {
        {
            "call-start-error-neither-assistant-nor-server-set",
            CallEndedReason.CallStartErrorNeitherAssistantNorServerSet
        },
        { "assistant-request-failed", CallEndedReason.AssistantRequestFailed },
        { "assistant-request-returned-error", CallEndedReason.AssistantRequestReturnedError },
        {
            "assistant-request-returned-unspeakable-error",
            CallEndedReason.AssistantRequestReturnedUnspeakableError
        },
        {
            "assistant-request-returned-invalid-assistant",
            CallEndedReason.AssistantRequestReturnedInvalidAssistant
        },
        {
            "assistant-request-returned-no-assistant",
            CallEndedReason.AssistantRequestReturnedNoAssistant
        },
        {
            "assistant-request-returned-forwarding-phone-number",
            CallEndedReason.AssistantRequestReturnedForwardingPhoneNumber
        },
        { "scheduled-call-deleted", CallEndedReason.ScheduledCallDeleted },
        { "call.start.error-vapifault-get-org", CallEndedReason.CallStartErrorVapifaultGetOrg },
        {
            "call.start.error-vapifault-get-subscription",
            CallEndedReason.CallStartErrorVapifaultGetSubscription
        },
        { "call.start.error-get-assistant", CallEndedReason.CallStartErrorGetAssistant },
        { "call.start.error-get-phone-number", CallEndedReason.CallStartErrorGetPhoneNumber },
        { "call.start.error-get-customer", CallEndedReason.CallStartErrorGetCustomer },
        {
            "call.start.error-get-resources-validation",
            CallEndedReason.CallStartErrorGetResourcesValidation
        },
        {
            "call.start.error-vapi-number-international",
            CallEndedReason.CallStartErrorVapiNumberInternational
        },
        {
            "call.start.error-vapi-number-outbound-daily-limit",
            CallEndedReason.CallStartErrorVapiNumberOutboundDailyLimit
        },
        { "call.start.error-get-transport", CallEndedReason.CallStartErrorGetTransport },
        {
            "call.start.error-subscription-wallet-does-not-exist",
            CallEndedReason.CallStartErrorSubscriptionWalletDoesNotExist
        },
        { "call.start.error-fraud-check-failed", CallEndedReason.CallStartErrorFraudCheckFailed },
        {
            "call.start.error-subscription-frozen",
            CallEndedReason.CallStartErrorSubscriptionFrozen
        },
        {
            "call.start.error-subscription-insufficient-credits",
            CallEndedReason.CallStartErrorSubscriptionInsufficientCredits
        },
        {
            "call.start.error-subscription-upgrade-failed",
            CallEndedReason.CallStartErrorSubscriptionUpgradeFailed
        },
        {
            "call.start.error-subscription-concurrency-limit-reached",
            CallEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached
        },
        {
            "call.start.error-enterprise-feature-not-available-recording-consent",
            CallEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent
        },
        { "assistant-not-valid", CallEndedReason.AssistantNotValid },
        {
            "call.start.error-vapifault-database-error",
            CallEndedReason.CallStartErrorVapifaultDatabaseError
        },
        { "assistant-not-found", CallEndedReason.AssistantNotFound },
        { "pipeline-error-openai-voice-failed", CallEndedReason.PipelineErrorOpenaiVoiceFailed },
        {
            "pipeline-error-cartesia-voice-failed",
            CallEndedReason.PipelineErrorCartesiaVoiceFailed
        },
        {
            "pipeline-error-deepgram-voice-failed",
            CallEndedReason.PipelineErrorDeepgramVoiceFailed
        },
        {
            "pipeline-error-eleven-labs-voice-failed",
            CallEndedReason.PipelineErrorElevenLabsVoiceFailed
        },
        { "pipeline-error-playht-voice-failed", CallEndedReason.PipelineErrorPlayhtVoiceFailed },
        { "pipeline-error-lmnt-voice-failed", CallEndedReason.PipelineErrorLmntVoiceFailed },
        { "pipeline-error-azure-voice-failed", CallEndedReason.PipelineErrorAzureVoiceFailed },
        { "pipeline-error-rime-ai-voice-failed", CallEndedReason.PipelineErrorRimeAiVoiceFailed },
        {
            "pipeline-error-smallest-ai-voice-failed",
            CallEndedReason.PipelineErrorSmallestAiVoiceFailed
        },
        { "pipeline-error-vapi-voice-failed", CallEndedReason.PipelineErrorVapiVoiceFailed },
        {
            "pipeline-error-neuphonic-voice-failed",
            CallEndedReason.PipelineErrorNeuphonicVoiceFailed
        },
        { "pipeline-error-hume-voice-failed", CallEndedReason.PipelineErrorHumeVoiceFailed },
        { "pipeline-error-sesame-voice-failed", CallEndedReason.PipelineErrorSesameVoiceFailed },
        { "pipeline-error-inworld-voice-failed", CallEndedReason.PipelineErrorInworldVoiceFailed },
        { "pipeline-error-minimax-voice-failed", CallEndedReason.PipelineErrorMinimaxVoiceFailed },
        {
            "pipeline-error-wellsaid-voice-failed",
            CallEndedReason.PipelineErrorWellsaidVoiceFailed
        },
        { "pipeline-error-tavus-video-failed", CallEndedReason.PipelineErrorTavusVideoFailed },
        {
            "call.in-progress.error-vapifault-openai-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-cartesia-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-deepgram-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-playht-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-lmnt-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-azure-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-rime-ai-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-smallest-ai-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-vapi-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-neuphonic-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-hume-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-sesame-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-inworld-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-minimax-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-wellsaid-voice-failed",
            CallEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed
        },
        {
            "call.in-progress.error-vapifault-tavus-video-failed",
            CallEndedReason.CallInProgressErrorVapifaultTavusVideoFailed
        },
        { "pipeline-error-vapi-llm-failed", CallEndedReason.PipelineErrorVapiLlmFailed },
        {
            "pipeline-error-vapi-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorVapi400BadRequestValidationFailed
        },
        {
            "pipeline-error-vapi-401-unauthorized",
            CallEndedReason.PipelineErrorVapi401Unauthorized
        },
        {
            "pipeline-error-vapi-403-model-access-denied",
            CallEndedReason.PipelineErrorVapi403ModelAccessDenied
        },
        {
            "pipeline-error-vapi-429-exceeded-quota",
            CallEndedReason.PipelineErrorVapi429ExceededQuota
        },
        { "pipeline-error-vapi-500-server-error", CallEndedReason.PipelineErrorVapi500ServerError },
        {
            "pipeline-error-vapi-503-server-overloaded-error",
            CallEndedReason.PipelineErrorVapi503ServerOverloadedError
        },
        {
            "call.in-progress.error-providerfault-vapi-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed
        },
        {
            "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-vapi-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-vapi-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-vapi-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-vapi-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultVapi500ServerError
        },
        {
            "call.in-progress.error-providerfault-vapi-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError
        },
        {
            "pipeline-error-deepgram-transcriber-failed",
            CallEndedReason.PipelineErrorDeepgramTranscriberFailed
        },
        {
            "pipeline-error-deepgram-transcriber-api-key-missing",
            CallEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing
        },
        {
            "call.in-progress.error-vapifault-deepgram-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed
        },
        {
            "pipeline-error-gladia-transcriber-failed",
            CallEndedReason.PipelineErrorGladiaTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-gladia-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed
        },
        {
            "pipeline-error-speechmatics-transcriber-failed",
            CallEndedReason.PipelineErrorSpeechmaticsTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-speechmatics-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed
        },
        {
            "pipeline-error-assembly-ai-transcriber-failed",
            CallEndedReason.PipelineErrorAssemblyAiTranscriberFailed
        },
        {
            "pipeline-error-assembly-ai-returning-400-insufficent-funds",
            CallEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds
        },
        {
            "pipeline-error-assembly-ai-returning-400-paid-only-feature",
            CallEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature
        },
        {
            "pipeline-error-assembly-ai-returning-401-invalid-credentials",
            CallEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials
        },
        {
            "pipeline-error-assembly-ai-returning-500-invalid-schema",
            CallEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema
        },
        {
            "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed",
            CallEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed
        },
        {
            "call.in-progress.error-vapifault-assembly-ai-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds",
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds
        },
        {
            "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature",
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature
        },
        {
            "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials",
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials
        },
        {
            "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema",
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema
        },
        {
            "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed",
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed
        },
        {
            "pipeline-error-talkscriber-transcriber-failed",
            CallEndedReason.PipelineErrorTalkscriberTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-talkscriber-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed
        },
        {
            "pipeline-error-azure-speech-transcriber-failed",
            CallEndedReason.PipelineErrorAzureSpeechTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-azure-speech-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed
        },
        {
            "pipeline-error-eleven-labs-transcriber-failed",
            CallEndedReason.PipelineErrorElevenLabsTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed
        },
        {
            "pipeline-error-google-transcriber-failed",
            CallEndedReason.PipelineErrorGoogleTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-google-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed
        },
        {
            "pipeline-error-openai-transcriber-failed",
            CallEndedReason.PipelineErrorOpenaiTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-openai-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed
        },
        {
            "pipeline-error-soniox-transcriber-auth-failed",
            CallEndedReason.PipelineErrorSonioxTranscriberAuthFailed
        },
        {
            "pipeline-error-soniox-transcriber-rate-limited",
            CallEndedReason.PipelineErrorSonioxTranscriberRateLimited
        },
        {
            "pipeline-error-soniox-transcriber-invalid-config",
            CallEndedReason.PipelineErrorSonioxTranscriberInvalidConfig
        },
        {
            "pipeline-error-soniox-transcriber-server-error",
            CallEndedReason.PipelineErrorSonioxTranscriberServerError
        },
        {
            "pipeline-error-soniox-transcriber-failed",
            CallEndedReason.PipelineErrorSonioxTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-soniox-transcriber-auth-failed",
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed
        },
        {
            "call.in-progress.error-vapifault-soniox-transcriber-rate-limited",
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited
        },
        {
            "call.in-progress.error-vapifault-soniox-transcriber-invalid-config",
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig
        },
        {
            "call.in-progress.error-vapifault-soniox-transcriber-server-error",
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError
        },
        {
            "call.in-progress.error-vapifault-soniox-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed
        },
        {
            "call.in-progress.error-pipeline-no-available-llm-model",
            CallEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel
        },
        { "worker-shutdown", CallEndedReason.WorkerShutdown },
        { "vonage-disconnected", CallEndedReason.VonageDisconnected },
        { "vonage-failed-to-connect-call", CallEndedReason.VonageFailedToConnectCall },
        { "vonage-completed", CallEndedReason.VonageCompleted },
        {
            "phone-call-provider-bypass-enabled-but-no-call-received",
            CallEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived
        },
        {
            "call.in-progress.error-providerfault-transport-never-connected",
            CallEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected
        },
        {
            "call.in-progress.error-vapifault-worker-not-available",
            CallEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable
        },
        {
            "call.in-progress.error-vapifault-transport-never-connected",
            CallEndedReason.CallInProgressErrorVapifaultTransportNeverConnected
        },
        {
            "call.in-progress.error-vapifault-transport-connected-but-call-not-active",
            CallEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive
        },
        {
            "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing",
            CallEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing
        },
        {
            "call.in-progress.error-vapifault-worker-died",
            CallEndedReason.CallInProgressErrorVapifaultWorkerDied
        },
        {
            "call.in-progress.twilio-completed-call",
            CallEndedReason.CallInProgressTwilioCompletedCall
        },
        { "call.in-progress.sip-completed-call", CallEndedReason.CallInProgressSipCompletedCall },
        {
            "call.in-progress.error-sip-inbound-call-failed-to-connect",
            CallEndedReason.CallInProgressErrorSipInboundCallFailedToConnect
        },
        {
            "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable",
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable
        },
        {
            "call.in-progress.error-sip-outbound-call-failed-to-connect",
            CallEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect
        },
        {
            "call.ringing.error-sip-inbound-call-failed-to-connect",
            CallEndedReason.CallRingingErrorSipInboundCallFailedToConnect
        },
        {
            "call.in-progress.error-providerfault-openai-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed
        },
        {
            "call.in-progress.error-providerfault-azure-openai-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed
        },
        {
            "call.in-progress.error-providerfault-groq-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed
        },
        {
            "call.in-progress.error-providerfault-google-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed
        },
        {
            "call.in-progress.error-providerfault-xai-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed
        },
        {
            "call.in-progress.error-providerfault-mistral-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed
        },
        {
            "call.in-progress.error-providerfault-minimax-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultMinimaxLlmFailed
        },
        {
            "call.in-progress.error-providerfault-inflection-ai-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed
        },
        {
            "call.in-progress.error-providerfault-cerebras-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed
        },
        {
            "call.in-progress.error-providerfault-deep-seek-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed
        },
        {
            "call.in-progress.error-providerfault-baseten-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed
        },
        {
            "call.in-progress.error-vapifault-chat-pipeline-failed-to-start",
            CallEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart
        },
        {
            "pipeline-error-openai-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorOpenai400BadRequestValidationFailed
        },
        {
            "pipeline-error-openai-401-unauthorized",
            CallEndedReason.PipelineErrorOpenai401Unauthorized
        },
        {
            "pipeline-error-openai-401-incorrect-api-key",
            CallEndedReason.PipelineErrorOpenai401IncorrectApiKey
        },
        {
            "pipeline-error-openai-401-account-not-in-organization",
            CallEndedReason.PipelineErrorOpenai401AccountNotInOrganization
        },
        {
            "pipeline-error-openai-403-model-access-denied",
            CallEndedReason.PipelineErrorOpenai403ModelAccessDenied
        },
        {
            "pipeline-error-openai-429-exceeded-quota",
            CallEndedReason.PipelineErrorOpenai429ExceededQuota
        },
        {
            "pipeline-error-openai-429-rate-limit-reached",
            CallEndedReason.PipelineErrorOpenai429RateLimitReached
        },
        {
            "pipeline-error-openai-500-server-error",
            CallEndedReason.PipelineErrorOpenai500ServerError
        },
        {
            "pipeline-error-openai-503-server-overloaded-error",
            CallEndedReason.PipelineErrorOpenai503ServerOverloadedError
        },
        { "pipeline-error-openai-llm-failed", CallEndedReason.PipelineErrorOpenaiLlmFailed },
        {
            "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-openai-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-openai-401-incorrect-api-key",
            CallEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey
        },
        {
            "call.in-progress.error-vapifault-openai-401-account-not-in-organization",
            CallEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization
        },
        {
            "call.in-progress.error-vapifault-openai-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-openai-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota
        },
        {
            "call.in-progress.error-vapifault-openai-429-rate-limit-reached",
            CallEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached
        },
        {
            "call.in-progress.error-providerfault-openai-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError
        },
        {
            "call.in-progress.error-providerfault-openai-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError
        },
        {
            "pipeline-error-azure-openai-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed
        },
        {
            "pipeline-error-azure-openai-401-unauthorized",
            CallEndedReason.PipelineErrorAzureOpenai401Unauthorized
        },
        {
            "pipeline-error-azure-openai-403-model-access-denied",
            CallEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied
        },
        {
            "pipeline-error-azure-openai-429-exceeded-quota",
            CallEndedReason.PipelineErrorAzureOpenai429ExceededQuota
        },
        {
            "pipeline-error-azure-openai-500-server-error",
            CallEndedReason.PipelineErrorAzureOpenai500ServerError
        },
        {
            "pipeline-error-azure-openai-503-server-overloaded-error",
            CallEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError
        },
        {
            "pipeline-error-azure-openai-llm-failed",
            CallEndedReason.PipelineErrorAzureOpenaiLlmFailed
        },
        {
            "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-azure-openai-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-azure-openai-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-azure-openai-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError
        },
        {
            "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError
        },
        {
            "pipeline-error-google-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorGoogle400BadRequestValidationFailed
        },
        {
            "pipeline-error-google-401-unauthorized",
            CallEndedReason.PipelineErrorGoogle401Unauthorized
        },
        {
            "pipeline-error-google-403-model-access-denied",
            CallEndedReason.PipelineErrorGoogle403ModelAccessDenied
        },
        {
            "pipeline-error-google-429-exceeded-quota",
            CallEndedReason.PipelineErrorGoogle429ExceededQuota
        },
        {
            "pipeline-error-google-500-server-error",
            CallEndedReason.PipelineErrorGoogle500ServerError
        },
        {
            "pipeline-error-google-503-server-overloaded-error",
            CallEndedReason.PipelineErrorGoogle503ServerOverloadedError
        },
        { "pipeline-error-google-llm-failed", CallEndedReason.PipelineErrorGoogleLlmFailed },
        {
            "call.in-progress.error-vapifault-google-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-google-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-google-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-google-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-google-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError
        },
        {
            "call.in-progress.error-providerfault-google-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError
        },
        {
            "pipeline-error-xai-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorXai400BadRequestValidationFailed
        },
        { "pipeline-error-xai-401-unauthorized", CallEndedReason.PipelineErrorXai401Unauthorized },
        {
            "pipeline-error-xai-403-model-access-denied",
            CallEndedReason.PipelineErrorXai403ModelAccessDenied
        },
        {
            "pipeline-error-xai-429-exceeded-quota",
            CallEndedReason.PipelineErrorXai429ExceededQuota
        },
        { "pipeline-error-xai-500-server-error", CallEndedReason.PipelineErrorXai500ServerError },
        {
            "pipeline-error-xai-503-server-overloaded-error",
            CallEndedReason.PipelineErrorXai503ServerOverloadedError
        },
        { "pipeline-error-xai-llm-failed", CallEndedReason.PipelineErrorXaiLlmFailed },
        {
            "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-xai-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultXai401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-xai-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-xai-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-xai-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultXai500ServerError
        },
        {
            "call.in-progress.error-providerfault-xai-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError
        },
        {
            "pipeline-error-baseten-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorBaseten400BadRequestValidationFailed
        },
        {
            "pipeline-error-baseten-401-unauthorized",
            CallEndedReason.PipelineErrorBaseten401Unauthorized
        },
        {
            "pipeline-error-baseten-403-model-access-denied",
            CallEndedReason.PipelineErrorBaseten403ModelAccessDenied
        },
        {
            "pipeline-error-baseten-429-exceeded-quota",
            CallEndedReason.PipelineErrorBaseten429ExceededQuota
        },
        {
            "pipeline-error-baseten-500-server-error",
            CallEndedReason.PipelineErrorBaseten500ServerError
        },
        {
            "pipeline-error-baseten-503-server-overloaded-error",
            CallEndedReason.PipelineErrorBaseten503ServerOverloadedError
        },
        { "pipeline-error-baseten-llm-failed", CallEndedReason.PipelineErrorBasetenLlmFailed },
        {
            "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-baseten-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-baseten-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-baseten-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-baseten-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError
        },
        {
            "call.in-progress.error-providerfault-baseten-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError
        },
        {
            "pipeline-error-mistral-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorMistral400BadRequestValidationFailed
        },
        {
            "pipeline-error-mistral-401-unauthorized",
            CallEndedReason.PipelineErrorMistral401Unauthorized
        },
        {
            "pipeline-error-mistral-403-model-access-denied",
            CallEndedReason.PipelineErrorMistral403ModelAccessDenied
        },
        {
            "pipeline-error-mistral-429-exceeded-quota",
            CallEndedReason.PipelineErrorMistral429ExceededQuota
        },
        {
            "pipeline-error-mistral-500-server-error",
            CallEndedReason.PipelineErrorMistral500ServerError
        },
        {
            "pipeline-error-mistral-503-server-overloaded-error",
            CallEndedReason.PipelineErrorMistral503ServerOverloadedError
        },
        { "pipeline-error-mistral-llm-failed", CallEndedReason.PipelineErrorMistralLlmFailed },
        {
            "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-mistral-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-mistral-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-mistral-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-mistral-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultMistral500ServerError
        },
        {
            "call.in-progress.error-providerfault-mistral-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError
        },
        {
            "pipeline-error-minimax-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorMinimax400BadRequestValidationFailed
        },
        {
            "pipeline-error-minimax-401-unauthorized",
            CallEndedReason.PipelineErrorMinimax401Unauthorized
        },
        {
            "pipeline-error-minimax-403-model-access-denied",
            CallEndedReason.PipelineErrorMinimax403ModelAccessDenied
        },
        {
            "pipeline-error-minimax-429-exceeded-quota",
            CallEndedReason.PipelineErrorMinimax429ExceededQuota
        },
        {
            "pipeline-error-minimax-500-server-error",
            CallEndedReason.PipelineErrorMinimax500ServerError
        },
        {
            "pipeline-error-minimax-503-server-overloaded-error",
            CallEndedReason.PipelineErrorMinimax503ServerOverloadedError
        },
        { "pipeline-error-minimax-llm-failed", CallEndedReason.PipelineErrorMinimaxLlmFailed },
        {
            "call.in-progress.error-vapifault-minimax-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultMinimax400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-minimax-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultMinimax401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-minimax-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultMinimax403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-minimax-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultMinimax429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-minimax-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultMinimax500ServerError
        },
        {
            "call.in-progress.error-providerfault-minimax-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultMinimax503ServerOverloadedError
        },
        {
            "pipeline-error-inflection-ai-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed
        },
        {
            "pipeline-error-inflection-ai-401-unauthorized",
            CallEndedReason.PipelineErrorInflectionAi401Unauthorized
        },
        {
            "pipeline-error-inflection-ai-403-model-access-denied",
            CallEndedReason.PipelineErrorInflectionAi403ModelAccessDenied
        },
        {
            "pipeline-error-inflection-ai-429-exceeded-quota",
            CallEndedReason.PipelineErrorInflectionAi429ExceededQuota
        },
        {
            "pipeline-error-inflection-ai-500-server-error",
            CallEndedReason.PipelineErrorInflectionAi500ServerError
        },
        {
            "pipeline-error-inflection-ai-503-server-overloaded-error",
            CallEndedReason.PipelineErrorInflectionAi503ServerOverloadedError
        },
        {
            "pipeline-error-inflection-ai-llm-failed",
            CallEndedReason.PipelineErrorInflectionAiLlmFailed
        },
        {
            "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-inflection-ai-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-inflection-ai-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError
        },
        {
            "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError
        },
        {
            "pipeline-error-deep-seek-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed
        },
        {
            "pipeline-error-deep-seek-401-unauthorized",
            CallEndedReason.PipelineErrorDeepSeek401Unauthorized
        },
        {
            "pipeline-error-deep-seek-403-model-access-denied",
            CallEndedReason.PipelineErrorDeepSeek403ModelAccessDenied
        },
        {
            "pipeline-error-deep-seek-429-exceeded-quota",
            CallEndedReason.PipelineErrorDeepSeek429ExceededQuota
        },
        {
            "pipeline-error-deep-seek-500-server-error",
            CallEndedReason.PipelineErrorDeepSeek500ServerError
        },
        {
            "pipeline-error-deep-seek-503-server-overloaded-error",
            CallEndedReason.PipelineErrorDeepSeek503ServerOverloadedError
        },
        { "pipeline-error-deep-seek-llm-failed", CallEndedReason.PipelineErrorDeepSeekLlmFailed },
        {
            "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-deep-seek-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-deep-seek-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-deep-seek-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError
        },
        {
            "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError
        },
        {
            "pipeline-error-groq-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorGroq400BadRequestValidationFailed
        },
        {
            "pipeline-error-groq-401-unauthorized",
            CallEndedReason.PipelineErrorGroq401Unauthorized
        },
        {
            "pipeline-error-groq-403-model-access-denied",
            CallEndedReason.PipelineErrorGroq403ModelAccessDenied
        },
        {
            "pipeline-error-groq-429-exceeded-quota",
            CallEndedReason.PipelineErrorGroq429ExceededQuota
        },
        { "pipeline-error-groq-500-server-error", CallEndedReason.PipelineErrorGroq500ServerError },
        {
            "pipeline-error-groq-503-server-overloaded-error",
            CallEndedReason.PipelineErrorGroq503ServerOverloadedError
        },
        { "pipeline-error-groq-llm-failed", CallEndedReason.PipelineErrorGroqLlmFailed },
        {
            "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-groq-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-groq-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-groq-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-groq-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultGroq500ServerError
        },
        {
            "call.in-progress.error-providerfault-groq-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError
        },
        {
            "pipeline-error-cerebras-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorCerebras400BadRequestValidationFailed
        },
        {
            "pipeline-error-cerebras-401-unauthorized",
            CallEndedReason.PipelineErrorCerebras401Unauthorized
        },
        {
            "pipeline-error-cerebras-403-model-access-denied",
            CallEndedReason.PipelineErrorCerebras403ModelAccessDenied
        },
        {
            "pipeline-error-cerebras-429-exceeded-quota",
            CallEndedReason.PipelineErrorCerebras429ExceededQuota
        },
        {
            "pipeline-error-cerebras-500-server-error",
            CallEndedReason.PipelineErrorCerebras500ServerError
        },
        {
            "pipeline-error-cerebras-503-server-overloaded-error",
            CallEndedReason.PipelineErrorCerebras503ServerOverloadedError
        },
        { "pipeline-error-cerebras-llm-failed", CallEndedReason.PipelineErrorCerebrasLlmFailed },
        {
            "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-cerebras-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-cerebras-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-cerebras-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-cerebras-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError
        },
        {
            "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError
        },
        {
            "pipeline-error-anthropic-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed
        },
        {
            "pipeline-error-anthropic-401-unauthorized",
            CallEndedReason.PipelineErrorAnthropic401Unauthorized
        },
        {
            "pipeline-error-anthropic-403-model-access-denied",
            CallEndedReason.PipelineErrorAnthropic403ModelAccessDenied
        },
        {
            "pipeline-error-anthropic-429-exceeded-quota",
            CallEndedReason.PipelineErrorAnthropic429ExceededQuota
        },
        {
            "pipeline-error-anthropic-500-server-error",
            CallEndedReason.PipelineErrorAnthropic500ServerError
        },
        {
            "pipeline-error-anthropic-503-server-overloaded-error",
            CallEndedReason.PipelineErrorAnthropic503ServerOverloadedError
        },
        { "pipeline-error-anthropic-llm-failed", CallEndedReason.PipelineErrorAnthropicLlmFailed },
        {
            "call.in-progress.error-providerfault-anthropic-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed
        },
        {
            "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-anthropic-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-anthropic-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-anthropic-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-anthropic-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError
        },
        {
            "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError
        },
        {
            "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed
        },
        {
            "pipeline-error-anthropic-bedrock-401-unauthorized",
            CallEndedReason.PipelineErrorAnthropicBedrock401Unauthorized
        },
        {
            "pipeline-error-anthropic-bedrock-403-model-access-denied",
            CallEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied
        },
        {
            "pipeline-error-anthropic-bedrock-429-exceeded-quota",
            CallEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota
        },
        {
            "pipeline-error-anthropic-bedrock-500-server-error",
            CallEndedReason.PipelineErrorAnthropicBedrock500ServerError
        },
        {
            "pipeline-error-anthropic-bedrock-503-server-overloaded-error",
            CallEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError
        },
        {
            "pipeline-error-anthropic-bedrock-llm-failed",
            CallEndedReason.PipelineErrorAnthropicBedrockLlmFailed
        },
        {
            "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed
        },
        {
            "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError
        },
        {
            "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError
        },
        {
            "pipeline-error-anthropic-vertex-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed
        },
        {
            "pipeline-error-anthropic-vertex-401-unauthorized",
            CallEndedReason.PipelineErrorAnthropicVertex401Unauthorized
        },
        {
            "pipeline-error-anthropic-vertex-403-model-access-denied",
            CallEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied
        },
        {
            "pipeline-error-anthropic-vertex-429-exceeded-quota",
            CallEndedReason.PipelineErrorAnthropicVertex429ExceededQuota
        },
        {
            "pipeline-error-anthropic-vertex-500-server-error",
            CallEndedReason.PipelineErrorAnthropicVertex500ServerError
        },
        {
            "pipeline-error-anthropic-vertex-503-server-overloaded-error",
            CallEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError
        },
        {
            "pipeline-error-anthropic-vertex-llm-failed",
            CallEndedReason.PipelineErrorAnthropicVertexLlmFailed
        },
        {
            "call.in-progress.error-providerfault-anthropic-vertex-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed
        },
        {
            "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-anthropic-vertex-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError
        },
        {
            "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError
        },
        {
            "pipeline-error-together-ai-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed
        },
        {
            "pipeline-error-together-ai-401-unauthorized",
            CallEndedReason.PipelineErrorTogetherAi401Unauthorized
        },
        {
            "pipeline-error-together-ai-403-model-access-denied",
            CallEndedReason.PipelineErrorTogetherAi403ModelAccessDenied
        },
        {
            "pipeline-error-together-ai-429-exceeded-quota",
            CallEndedReason.PipelineErrorTogetherAi429ExceededQuota
        },
        {
            "pipeline-error-together-ai-500-server-error",
            CallEndedReason.PipelineErrorTogetherAi500ServerError
        },
        {
            "pipeline-error-together-ai-503-server-overloaded-error",
            CallEndedReason.PipelineErrorTogetherAi503ServerOverloadedError
        },
        {
            "pipeline-error-together-ai-llm-failed",
            CallEndedReason.PipelineErrorTogetherAiLlmFailed
        },
        {
            "call.in-progress.error-providerfault-together-ai-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed
        },
        {
            "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-together-ai-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-together-ai-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-together-ai-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-together-ai-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError
        },
        {
            "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError
        },
        {
            "pipeline-error-anyscale-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed
        },
        {
            "pipeline-error-anyscale-401-unauthorized",
            CallEndedReason.PipelineErrorAnyscale401Unauthorized
        },
        {
            "pipeline-error-anyscale-403-model-access-denied",
            CallEndedReason.PipelineErrorAnyscale403ModelAccessDenied
        },
        {
            "pipeline-error-anyscale-429-exceeded-quota",
            CallEndedReason.PipelineErrorAnyscale429ExceededQuota
        },
        {
            "pipeline-error-anyscale-500-server-error",
            CallEndedReason.PipelineErrorAnyscale500ServerError
        },
        {
            "pipeline-error-anyscale-503-server-overloaded-error",
            CallEndedReason.PipelineErrorAnyscale503ServerOverloadedError
        },
        { "pipeline-error-anyscale-llm-failed", CallEndedReason.PipelineErrorAnyscaleLlmFailed },
        {
            "call.in-progress.error-providerfault-anyscale-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed
        },
        {
            "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-anyscale-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-anyscale-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-anyscale-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-anyscale-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError
        },
        {
            "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError
        },
        {
            "pipeline-error-openrouter-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed
        },
        {
            "pipeline-error-openrouter-401-unauthorized",
            CallEndedReason.PipelineErrorOpenrouter401Unauthorized
        },
        {
            "pipeline-error-openrouter-403-model-access-denied",
            CallEndedReason.PipelineErrorOpenrouter403ModelAccessDenied
        },
        {
            "pipeline-error-openrouter-429-exceeded-quota",
            CallEndedReason.PipelineErrorOpenrouter429ExceededQuota
        },
        {
            "pipeline-error-openrouter-500-server-error",
            CallEndedReason.PipelineErrorOpenrouter500ServerError
        },
        {
            "pipeline-error-openrouter-503-server-overloaded-error",
            CallEndedReason.PipelineErrorOpenrouter503ServerOverloadedError
        },
        {
            "pipeline-error-openrouter-llm-failed",
            CallEndedReason.PipelineErrorOpenrouterLlmFailed
        },
        {
            "call.in-progress.error-providerfault-openrouter-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed
        },
        {
            "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-openrouter-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-openrouter-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-openrouter-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-openrouter-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError
        },
        {
            "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError
        },
        {
            "pipeline-error-perplexity-ai-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed
        },
        {
            "pipeline-error-perplexity-ai-401-unauthorized",
            CallEndedReason.PipelineErrorPerplexityAi401Unauthorized
        },
        {
            "pipeline-error-perplexity-ai-403-model-access-denied",
            CallEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied
        },
        {
            "pipeline-error-perplexity-ai-429-exceeded-quota",
            CallEndedReason.PipelineErrorPerplexityAi429ExceededQuota
        },
        {
            "pipeline-error-perplexity-ai-500-server-error",
            CallEndedReason.PipelineErrorPerplexityAi500ServerError
        },
        {
            "pipeline-error-perplexity-ai-503-server-overloaded-error",
            CallEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError
        },
        {
            "pipeline-error-perplexity-ai-llm-failed",
            CallEndedReason.PipelineErrorPerplexityAiLlmFailed
        },
        {
            "call.in-progress.error-providerfault-perplexity-ai-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed
        },
        {
            "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-perplexity-ai-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError
        },
        {
            "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError
        },
        {
            "pipeline-error-deepinfra-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed
        },
        {
            "pipeline-error-deepinfra-401-unauthorized",
            CallEndedReason.PipelineErrorDeepinfra401Unauthorized
        },
        {
            "pipeline-error-deepinfra-403-model-access-denied",
            CallEndedReason.PipelineErrorDeepinfra403ModelAccessDenied
        },
        {
            "pipeline-error-deepinfra-429-exceeded-quota",
            CallEndedReason.PipelineErrorDeepinfra429ExceededQuota
        },
        {
            "pipeline-error-deepinfra-500-server-error",
            CallEndedReason.PipelineErrorDeepinfra500ServerError
        },
        {
            "pipeline-error-deepinfra-503-server-overloaded-error",
            CallEndedReason.PipelineErrorDeepinfra503ServerOverloadedError
        },
        { "pipeline-error-deepinfra-llm-failed", CallEndedReason.PipelineErrorDeepinfraLlmFailed },
        {
            "call.in-progress.error-providerfault-deepinfra-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed
        },
        {
            "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-deepinfra-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-deepinfra-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-deepinfra-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError
        },
        {
            "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError
        },
        {
            "pipeline-error-runpod-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorRunpod400BadRequestValidationFailed
        },
        {
            "pipeline-error-runpod-401-unauthorized",
            CallEndedReason.PipelineErrorRunpod401Unauthorized
        },
        {
            "pipeline-error-runpod-403-model-access-denied",
            CallEndedReason.PipelineErrorRunpod403ModelAccessDenied
        },
        {
            "pipeline-error-runpod-429-exceeded-quota",
            CallEndedReason.PipelineErrorRunpod429ExceededQuota
        },
        {
            "pipeline-error-runpod-500-server-error",
            CallEndedReason.PipelineErrorRunpod500ServerError
        },
        {
            "pipeline-error-runpod-503-server-overloaded-error",
            CallEndedReason.PipelineErrorRunpod503ServerOverloadedError
        },
        { "pipeline-error-runpod-llm-failed", CallEndedReason.PipelineErrorRunpodLlmFailed },
        {
            "call.in-progress.error-providerfault-runpod-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed
        },
        {
            "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-runpod-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-runpod-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-runpod-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-runpod-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError
        },
        {
            "call.in-progress.error-providerfault-runpod-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError
        },
        {
            "pipeline-error-custom-llm-400-bad-request-validation-failed",
            CallEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed
        },
        {
            "pipeline-error-custom-llm-401-unauthorized",
            CallEndedReason.PipelineErrorCustomLlm401Unauthorized
        },
        {
            "pipeline-error-custom-llm-403-model-access-denied",
            CallEndedReason.PipelineErrorCustomLlm403ModelAccessDenied
        },
        {
            "pipeline-error-custom-llm-429-exceeded-quota",
            CallEndedReason.PipelineErrorCustomLlm429ExceededQuota
        },
        {
            "pipeline-error-custom-llm-500-server-error",
            CallEndedReason.PipelineErrorCustomLlm500ServerError
        },
        {
            "pipeline-error-custom-llm-503-server-overloaded-error",
            CallEndedReason.PipelineErrorCustomLlm503ServerOverloadedError
        },
        { "pipeline-error-custom-llm-llm-failed", CallEndedReason.PipelineErrorCustomLlmLlmFailed },
        {
            "call.in-progress.error-providerfault-custom-llm-llm-failed",
            CallEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed
        },
        {
            "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed",
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed
        },
        {
            "call.in-progress.error-vapifault-custom-llm-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-custom-llm-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied
        },
        {
            "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-custom-llm-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError
        },
        {
            "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error",
            CallEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError
        },
        {
            "call.in-progress.error-pipeline-ws-model-connection-failed",
            CallEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed
        },
        { "pipeline-error-custom-voice-failed", CallEndedReason.PipelineErrorCustomVoiceFailed },
        {
            "pipeline-error-cartesia-socket-hang-up",
            CallEndedReason.PipelineErrorCartesiaSocketHangUp
        },
        {
            "pipeline-error-cartesia-requested-payment",
            CallEndedReason.PipelineErrorCartesiaRequestedPayment
        },
        {
            "pipeline-error-cartesia-500-server-error",
            CallEndedReason.PipelineErrorCartesia500ServerError
        },
        {
            "pipeline-error-cartesia-502-server-error",
            CallEndedReason.PipelineErrorCartesia502ServerError
        },
        {
            "pipeline-error-cartesia-503-server-error",
            CallEndedReason.PipelineErrorCartesia503ServerError
        },
        {
            "pipeline-error-cartesia-522-server-error",
            CallEndedReason.PipelineErrorCartesia522ServerError
        },
        {
            "call.in-progress.error-vapifault-cartesia-socket-hang-up",
            CallEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp
        },
        {
            "call.in-progress.error-vapifault-cartesia-requested-payment",
            CallEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment
        },
        {
            "call.in-progress.error-providerfault-cartesia-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError
        },
        {
            "call.in-progress.error-providerfault-cartesia-503-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError
        },
        {
            "call.in-progress.error-providerfault-cartesia-522-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError
        },
        {
            "pipeline-error-eleven-labs-voice-not-found",
            CallEndedReason.PipelineErrorElevenLabsVoiceNotFound
        },
        {
            "pipeline-error-eleven-labs-quota-exceeded",
            CallEndedReason.PipelineErrorElevenLabsQuotaExceeded
        },
        {
            "pipeline-error-eleven-labs-unauthorized-access",
            CallEndedReason.PipelineErrorElevenLabsUnauthorizedAccess
        },
        {
            "pipeline-error-eleven-labs-unauthorized-to-access-model",
            CallEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel
        },
        {
            "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus",
            CallEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus
        },
        {
            "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade",
            CallEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade
        },
        {
            "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
            CallEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade
        },
        {
            "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
            CallEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade
        },
        {
            "pipeline-error-eleven-labs-system-busy-and-requested-upgrade",
            CallEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade
        },
        {
            "pipeline-error-eleven-labs-voice-not-fine-tuned",
            CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned
        },
        {
            "pipeline-error-eleven-labs-invalid-api-key",
            CallEndedReason.PipelineErrorElevenLabsInvalidApiKey
        },
        {
            "pipeline-error-eleven-labs-invalid-voice-samples",
            CallEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples
        },
        {
            "pipeline-error-eleven-labs-voice-disabled-by-owner",
            CallEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner
        },
        {
            "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner",
            CallEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner
        },
        {
            "pipeline-error-eleven-labs-blocked-account-in-probation",
            CallEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation
        },
        {
            "pipeline-error-eleven-labs-blocked-content-against-their-policy",
            CallEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy
        },
        {
            "pipeline-error-eleven-labs-missing-samples-for-voice-clone",
            CallEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone
        },
        {
            "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
            CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed
        },
        {
            "pipeline-error-eleven-labs-voice-not-allowed-for-free-users",
            CallEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers
        },
        {
            "pipeline-error-eleven-labs-max-character-limit-exceeded",
            CallEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded
        },
        {
            "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
            CallEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification
        },
        {
            "pipeline-error-eleven-labs-500-server-error",
            CallEndedReason.PipelineErrorElevenLabs500ServerError
        },
        {
            "pipeline-error-eleven-labs-503-server-error",
            CallEndedReason.PipelineErrorElevenLabs503ServerError
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-voice-not-found",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-quota-exceeded",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-unauthorized-access",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-invalid-api-key",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded
        },
        {
            "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification
        },
        {
            "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade",
            CallEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade
        },
        {
            "call.in-progress.error-providerfault-eleven-labs-500-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError
        },
        {
            "call.in-progress.error-providerfault-eleven-labs-503-server-error",
            CallEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError
        },
        {
            "pipeline-error-playht-request-timed-out",
            CallEndedReason.PipelineErrorPlayhtRequestTimedOut
        },
        { "pipeline-error-playht-invalid-voice", CallEndedReason.PipelineErrorPlayhtInvalidVoice },
        {
            "pipeline-error-playht-unexpected-error",
            CallEndedReason.PipelineErrorPlayhtUnexpectedError
        },
        { "pipeline-error-playht-out-of-credits", CallEndedReason.PipelineErrorPlayhtOutOfCredits },
        {
            "pipeline-error-playht-invalid-emotion",
            CallEndedReason.PipelineErrorPlayhtInvalidEmotion
        },
        {
            "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri",
            CallEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri
        },
        {
            "pipeline-error-playht-401-unauthorized",
            CallEndedReason.PipelineErrorPlayht401Unauthorized
        },
        {
            "pipeline-error-playht-403-forbidden-out-of-characters",
            CallEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters
        },
        {
            "pipeline-error-playht-403-forbidden-api-access-not-available",
            CallEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable
        },
        {
            "pipeline-error-playht-429-exceeded-quota",
            CallEndedReason.PipelineErrorPlayht429ExceededQuota
        },
        {
            "pipeline-error-playht-502-gateway-error",
            CallEndedReason.PipelineErrorPlayht502GatewayError
        },
        {
            "pipeline-error-playht-504-gateway-error",
            CallEndedReason.PipelineErrorPlayht504GatewayError
        },
        {
            "call.in-progress.error-vapifault-playht-request-timed-out",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut
        },
        {
            "call.in-progress.error-vapifault-playht-invalid-voice",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice
        },
        {
            "call.in-progress.error-vapifault-playht-unexpected-error",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError
        },
        {
            "call.in-progress.error-vapifault-playht-out-of-credits",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits
        },
        {
            "call.in-progress.error-vapifault-playht-invalid-emotion",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion
        },
        {
            "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri",
            CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri
        },
        {
            "call.in-progress.error-vapifault-playht-401-unauthorized",
            CallEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized
        },
        {
            "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters",
            CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters
        },
        {
            "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available",
            CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable
        },
        {
            "call.in-progress.error-vapifault-playht-429-exceeded-quota",
            CallEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota
        },
        {
            "call.in-progress.error-providerfault-playht-502-gateway-error",
            CallEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError
        },
        {
            "call.in-progress.error-providerfault-playht-504-gateway-error",
            CallEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError
        },
        {
            "pipeline-error-custom-transcriber-failed",
            CallEndedReason.PipelineErrorCustomTranscriberFailed
        },
        {
            "call.in-progress.error-vapifault-custom-transcriber-failed",
            CallEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed
        },
        {
            "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination",
            CallEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination
        },
        {
            "pipeline-error-deepgram-returning-401-invalid-credentials",
            CallEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials
        },
        {
            "pipeline-error-deepgram-returning-403-model-access-denied",
            CallEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied
        },
        {
            "pipeline-error-deepgram-returning-404-not-found",
            CallEndedReason.PipelineErrorDeepgramReturning404NotFound
        },
        {
            "pipeline-error-deepgram-returning-500-invalid-json",
            CallEndedReason.PipelineErrorDeepgramReturning500InvalidJson
        },
        {
            "pipeline-error-deepgram-returning-502-network-error",
            CallEndedReason.PipelineErrorDeepgramReturning502NetworkError
        },
        {
            "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach",
            CallEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach
        },
        {
            "pipeline-error-deepgram-returning-econnreset",
            CallEndedReason.PipelineErrorDeepgramReturningEconnreset
        },
        {
            "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination",
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination
        },
        {
            "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials",
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials
        },
        {
            "call.in-progress.error-vapifault-deepgram-returning-404-not-found",
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound
        },
        {
            "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied",
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied
        },
        {
            "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json",
            CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson
        },
        {
            "call.in-progress.error-providerfault-deepgram-returning-502-network-error",
            CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError
        },
        {
            "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach",
            CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach
        },
        {
            "call.in-progress.error-warm-transfer-max-duration",
            CallEndedReason.CallInProgressErrorWarmTransferMaxDuration
        },
        {
            "call.in-progress.error-warm-transfer-assistant-cancelled",
            CallEndedReason.CallInProgressErrorWarmTransferAssistantCancelled
        },
        {
            "call.in-progress.error-warm-transfer-silence-timeout",
            CallEndedReason.CallInProgressErrorWarmTransferSilenceTimeout
        },
        {
            "call.in-progress.error-warm-transfer-microphone-timeout",
            CallEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout
        },
        { "assistant-ended-call", CallEndedReason.AssistantEndedCall },
        { "assistant-said-end-call-phrase", CallEndedReason.AssistantSaidEndCallPhrase },
        {
            "assistant-ended-call-with-hangup-task",
            CallEndedReason.AssistantEndedCallWithHangupTask
        },
        {
            "assistant-ended-call-after-message-spoken",
            CallEndedReason.AssistantEndedCallAfterMessageSpoken
        },
        { "assistant-forwarded-call", CallEndedReason.AssistantForwardedCall },
        { "assistant-join-timed-out", CallEndedReason.AssistantJoinTimedOut },
        {
            "call.in-progress.error-assistant-did-not-receive-customer-audio",
            CallEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio
        },
        {
            "call.in-progress.error-transfer-failed",
            CallEndedReason.CallInProgressErrorTransferFailed
        },
        { "customer-busy", CallEndedReason.CustomerBusy },
        { "customer-ended-call", CallEndedReason.CustomerEndedCall },
        {
            "customer-ended-call-before-warm-transfer",
            CallEndedReason.CustomerEndedCallBeforeWarmTransfer
        },
        {
            "customer-ended-call-after-warm-transfer-attempt",
            CallEndedReason.CustomerEndedCallAfterWarmTransferAttempt
        },
        { "customer-ended-call-during-transfer", CallEndedReason.CustomerEndedCallDuringTransfer },
        { "customer-did-not-answer", CallEndedReason.CustomerDidNotAnswer },
        {
            "customer-did-not-give-microphone-permission",
            CallEndedReason.CustomerDidNotGiveMicrophonePermission
        },
        { "exceeded-max-duration", CallEndedReason.ExceededMaxDuration },
        { "manually-canceled", CallEndedReason.ManuallyCanceled },
        {
            "phone-call-provider-closed-websocket",
            CallEndedReason.PhoneCallProviderClosedWebsocket
        },
        { "call.forwarding.operator-busy", CallEndedReason.CallForwardingOperatorBusy },
        { "silence-timed-out", CallEndedReason.SilenceTimedOut },
        {
            "call.in-progress.error-providerfault-outbound-sip-403-forbidden",
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden
        },
        {
            "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required",
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired
        },
        {
            "call.in-progress.error-providerfault-outbound-sip-408-request-timeout",
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout
        },
        {
            "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable",
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable
        },
        { "call.ringing.hook-executed-say", CallEndedReason.CallRingingHookExecutedSay },
        { "call.ringing.hook-executed-transfer", CallEndedReason.CallRingingHookExecutedTransfer },
        { "call.ending.hook-executed-say", CallEndedReason.CallEndingHookExecutedSay },
        { "call.ending.hook-executed-transfer", CallEndedReason.CallEndingHookExecutedTransfer },
        {
            "call.ringing.sip-inbound-caller-hungup-before-call-connect",
            CallEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect
        },
        { "twilio-failed-to-connect-call", CallEndedReason.TwilioFailedToConnectCall },
        { "twilio-reported-customer-misdialed", CallEndedReason.TwilioReportedCustomerMisdialed },
        { "vonage-rejected", CallEndedReason.VonageRejected },
        { "voicemail", CallEndedReason.Voicemail },
        { "call-deleted", CallEndedReason.CallDeleted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallEndedReason,
        string
    > _enumToString = new()
    {
        {
            CallEndedReason.CallStartErrorNeitherAssistantNorServerSet,
            "call-start-error-neither-assistant-nor-server-set"
        },
        { CallEndedReason.AssistantRequestFailed, "assistant-request-failed" },
        { CallEndedReason.AssistantRequestReturnedError, "assistant-request-returned-error" },
        {
            CallEndedReason.AssistantRequestReturnedUnspeakableError,
            "assistant-request-returned-unspeakable-error"
        },
        {
            CallEndedReason.AssistantRequestReturnedInvalidAssistant,
            "assistant-request-returned-invalid-assistant"
        },
        {
            CallEndedReason.AssistantRequestReturnedNoAssistant,
            "assistant-request-returned-no-assistant"
        },
        {
            CallEndedReason.AssistantRequestReturnedForwardingPhoneNumber,
            "assistant-request-returned-forwarding-phone-number"
        },
        { CallEndedReason.ScheduledCallDeleted, "scheduled-call-deleted" },
        { CallEndedReason.CallStartErrorVapifaultGetOrg, "call.start.error-vapifault-get-org" },
        {
            CallEndedReason.CallStartErrorVapifaultGetSubscription,
            "call.start.error-vapifault-get-subscription"
        },
        { CallEndedReason.CallStartErrorGetAssistant, "call.start.error-get-assistant" },
        { CallEndedReason.CallStartErrorGetPhoneNumber, "call.start.error-get-phone-number" },
        { CallEndedReason.CallStartErrorGetCustomer, "call.start.error-get-customer" },
        {
            CallEndedReason.CallStartErrorGetResourcesValidation,
            "call.start.error-get-resources-validation"
        },
        {
            CallEndedReason.CallStartErrorVapiNumberInternational,
            "call.start.error-vapi-number-international"
        },
        {
            CallEndedReason.CallStartErrorVapiNumberOutboundDailyLimit,
            "call.start.error-vapi-number-outbound-daily-limit"
        },
        { CallEndedReason.CallStartErrorGetTransport, "call.start.error-get-transport" },
        {
            CallEndedReason.CallStartErrorSubscriptionWalletDoesNotExist,
            "call.start.error-subscription-wallet-does-not-exist"
        },
        { CallEndedReason.CallStartErrorFraudCheckFailed, "call.start.error-fraud-check-failed" },
        {
            CallEndedReason.CallStartErrorSubscriptionFrozen,
            "call.start.error-subscription-frozen"
        },
        {
            CallEndedReason.CallStartErrorSubscriptionInsufficientCredits,
            "call.start.error-subscription-insufficient-credits"
        },
        {
            CallEndedReason.CallStartErrorSubscriptionUpgradeFailed,
            "call.start.error-subscription-upgrade-failed"
        },
        {
            CallEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached,
            "call.start.error-subscription-concurrency-limit-reached"
        },
        {
            CallEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,
            "call.start.error-enterprise-feature-not-available-recording-consent"
        },
        { CallEndedReason.AssistantNotValid, "assistant-not-valid" },
        {
            CallEndedReason.CallStartErrorVapifaultDatabaseError,
            "call.start.error-vapifault-database-error"
        },
        { CallEndedReason.AssistantNotFound, "assistant-not-found" },
        { CallEndedReason.PipelineErrorOpenaiVoiceFailed, "pipeline-error-openai-voice-failed" },
        {
            CallEndedReason.PipelineErrorCartesiaVoiceFailed,
            "pipeline-error-cartesia-voice-failed"
        },
        {
            CallEndedReason.PipelineErrorDeepgramVoiceFailed,
            "pipeline-error-deepgram-voice-failed"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVoiceFailed,
            "pipeline-error-eleven-labs-voice-failed"
        },
        { CallEndedReason.PipelineErrorPlayhtVoiceFailed, "pipeline-error-playht-voice-failed" },
        { CallEndedReason.PipelineErrorLmntVoiceFailed, "pipeline-error-lmnt-voice-failed" },
        { CallEndedReason.PipelineErrorAzureVoiceFailed, "pipeline-error-azure-voice-failed" },
        { CallEndedReason.PipelineErrorRimeAiVoiceFailed, "pipeline-error-rime-ai-voice-failed" },
        {
            CallEndedReason.PipelineErrorSmallestAiVoiceFailed,
            "pipeline-error-smallest-ai-voice-failed"
        },
        { CallEndedReason.PipelineErrorVapiVoiceFailed, "pipeline-error-vapi-voice-failed" },
        {
            CallEndedReason.PipelineErrorNeuphonicVoiceFailed,
            "pipeline-error-neuphonic-voice-failed"
        },
        { CallEndedReason.PipelineErrorHumeVoiceFailed, "pipeline-error-hume-voice-failed" },
        { CallEndedReason.PipelineErrorSesameVoiceFailed, "pipeline-error-sesame-voice-failed" },
        { CallEndedReason.PipelineErrorInworldVoiceFailed, "pipeline-error-inworld-voice-failed" },
        { CallEndedReason.PipelineErrorMinimaxVoiceFailed, "pipeline-error-minimax-voice-failed" },
        {
            CallEndedReason.PipelineErrorWellsaidVoiceFailed,
            "pipeline-error-wellsaid-voice-failed"
        },
        { CallEndedReason.PipelineErrorTavusVideoFailed, "pipeline-error-tavus-video-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed,
            "call.in-progress.error-vapifault-openai-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed,
            "call.in-progress.error-vapifault-cartesia-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed,
            "call.in-progress.error-vapifault-deepgram-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed,
            "call.in-progress.error-vapifault-eleven-labs-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed,
            "call.in-progress.error-vapifault-playht-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed,
            "call.in-progress.error-vapifault-lmnt-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed,
            "call.in-progress.error-vapifault-azure-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed,
            "call.in-progress.error-vapifault-rime-ai-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed,
            "call.in-progress.error-vapifault-smallest-ai-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed,
            "call.in-progress.error-vapifault-vapi-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed,
            "call.in-progress.error-vapifault-neuphonic-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed,
            "call.in-progress.error-vapifault-hume-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed,
            "call.in-progress.error-vapifault-sesame-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed,
            "call.in-progress.error-vapifault-inworld-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed,
            "call.in-progress.error-vapifault-minimax-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed,
            "call.in-progress.error-vapifault-wellsaid-voice-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTavusVideoFailed,
            "call.in-progress.error-vapifault-tavus-video-failed"
        },
        { CallEndedReason.PipelineErrorVapiLlmFailed, "pipeline-error-vapi-llm-failed" },
        {
            CallEndedReason.PipelineErrorVapi400BadRequestValidationFailed,
            "pipeline-error-vapi-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorVapi401Unauthorized,
            "pipeline-error-vapi-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorVapi403ModelAccessDenied,
            "pipeline-error-vapi-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorVapi429ExceededQuota,
            "pipeline-error-vapi-429-exceeded-quota"
        },
        { CallEndedReason.PipelineErrorVapi500ServerError, "pipeline-error-vapi-500-server-error" },
        {
            CallEndedReason.PipelineErrorVapi503ServerOverloadedError,
            "pipeline-error-vapi-503-server-overloaded-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed,
            "call.in-progress.error-providerfault-vapi-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized,
            "call.in-progress.error-vapifault-vapi-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied,
            "call.in-progress.error-vapifault-vapi-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota,
            "call.in-progress.error-vapifault-vapi-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultVapi500ServerError,
            "call.in-progress.error-providerfault-vapi-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError,
            "call.in-progress.error-providerfault-vapi-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorDeepgramTranscriberFailed,
            "pipeline-error-deepgram-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing,
            "pipeline-error-deepgram-transcriber-api-key-missing"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed,
            "call.in-progress.error-vapifault-deepgram-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorGladiaTranscriberFailed,
            "pipeline-error-gladia-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed,
            "call.in-progress.error-vapifault-gladia-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorSpeechmaticsTranscriberFailed,
            "pipeline-error-speechmatics-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,
            "call.in-progress.error-vapifault-speechmatics-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorAssemblyAiTranscriberFailed,
            "pipeline-error-assembly-ai-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds,
            "pipeline-error-assembly-ai-returning-400-insufficent-funds"
        },
        {
            CallEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature,
            "pipeline-error-assembly-ai-returning-400-paid-only-feature"
        },
        {
            CallEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials,
            "pipeline-error-assembly-ai-returning-401-invalid-credentials"
        },
        {
            CallEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema,
            "pipeline-error-assembly-ai-returning-500-invalid-schema"
        },
        {
            CallEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,
            "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,
            "call.in-progress.error-vapifault-assembly-ai-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,
            "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,
            "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,
            "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,
            "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,
            "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed"
        },
        {
            CallEndedReason.PipelineErrorTalkscriberTranscriberFailed,
            "pipeline-error-talkscriber-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed,
            "call.in-progress.error-vapifault-talkscriber-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorAzureSpeechTranscriberFailed,
            "pipeline-error-azure-speech-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,
            "call.in-progress.error-vapifault-azure-speech-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsTranscriberFailed,
            "pipeline-error-eleven-labs-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed,
            "call.in-progress.error-vapifault-eleven-labs-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorGoogleTranscriberFailed,
            "pipeline-error-google-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed,
            "call.in-progress.error-vapifault-google-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorOpenaiTranscriberFailed,
            "pipeline-error-openai-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed,
            "call.in-progress.error-vapifault-openai-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorSonioxTranscriberAuthFailed,
            "pipeline-error-soniox-transcriber-auth-failed"
        },
        {
            CallEndedReason.PipelineErrorSonioxTranscriberRateLimited,
            "pipeline-error-soniox-transcriber-rate-limited"
        },
        {
            CallEndedReason.PipelineErrorSonioxTranscriberInvalidConfig,
            "pipeline-error-soniox-transcriber-invalid-config"
        },
        {
            CallEndedReason.PipelineErrorSonioxTranscriberServerError,
            "pipeline-error-soniox-transcriber-server-error"
        },
        {
            CallEndedReason.PipelineErrorSonioxTranscriberFailed,
            "pipeline-error-soniox-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,
            "call.in-progress.error-vapifault-soniox-transcriber-auth-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited,
            "call.in-progress.error-vapifault-soniox-transcriber-rate-limited"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,
            "call.in-progress.error-vapifault-soniox-transcriber-invalid-config"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError,
            "call.in-progress.error-vapifault-soniox-transcriber-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed,
            "call.in-progress.error-vapifault-soniox-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel,
            "call.in-progress.error-pipeline-no-available-llm-model"
        },
        { CallEndedReason.WorkerShutdown, "worker-shutdown" },
        { CallEndedReason.VonageDisconnected, "vonage-disconnected" },
        { CallEndedReason.VonageFailedToConnectCall, "vonage-failed-to-connect-call" },
        { CallEndedReason.VonageCompleted, "vonage-completed" },
        {
            CallEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived,
            "phone-call-provider-bypass-enabled-but-no-call-received"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected,
            "call.in-progress.error-providerfault-transport-never-connected"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable,
            "call.in-progress.error-vapifault-worker-not-available"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTransportNeverConnected,
            "call.in-progress.error-vapifault-transport-never-connected"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive,
            "call.in-progress.error-vapifault-transport-connected-but-call-not-active"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,
            "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultWorkerDied,
            "call.in-progress.error-vapifault-worker-died"
        },
        {
            CallEndedReason.CallInProgressTwilioCompletedCall,
            "call.in-progress.twilio-completed-call"
        },
        { CallEndedReason.CallInProgressSipCompletedCall, "call.in-progress.sip-completed-call" },
        {
            CallEndedReason.CallInProgressErrorSipInboundCallFailedToConnect,
            "call.in-progress.error-sip-inbound-call-failed-to-connect"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,
            "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable"
        },
        {
            CallEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect,
            "call.in-progress.error-sip-outbound-call-failed-to-connect"
        },
        {
            CallEndedReason.CallRingingErrorSipInboundCallFailedToConnect,
            "call.ringing.error-sip-inbound-call-failed-to-connect"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed,
            "call.in-progress.error-providerfault-openai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,
            "call.in-progress.error-providerfault-azure-openai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed,
            "call.in-progress.error-providerfault-groq-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed,
            "call.in-progress.error-providerfault-google-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed,
            "call.in-progress.error-providerfault-xai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed,
            "call.in-progress.error-providerfault-mistral-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultMinimaxLlmFailed,
            "call.in-progress.error-providerfault-minimax-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed,
            "call.in-progress.error-providerfault-inflection-ai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed,
            "call.in-progress.error-providerfault-cerebras-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed,
            "call.in-progress.error-providerfault-deep-seek-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed,
            "call.in-progress.error-providerfault-baseten-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart,
            "call.in-progress.error-vapifault-chat-pipeline-failed-to-start"
        },
        {
            CallEndedReason.PipelineErrorOpenai400BadRequestValidationFailed,
            "pipeline-error-openai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorOpenai401Unauthorized,
            "pipeline-error-openai-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorOpenai401IncorrectApiKey,
            "pipeline-error-openai-401-incorrect-api-key"
        },
        {
            CallEndedReason.PipelineErrorOpenai401AccountNotInOrganization,
            "pipeline-error-openai-401-account-not-in-organization"
        },
        {
            CallEndedReason.PipelineErrorOpenai403ModelAccessDenied,
            "pipeline-error-openai-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorOpenai429ExceededQuota,
            "pipeline-error-openai-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorOpenai429RateLimitReached,
            "pipeline-error-openai-429-rate-limit-reached"
        },
        {
            CallEndedReason.PipelineErrorOpenai500ServerError,
            "pipeline-error-openai-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorOpenai503ServerOverloadedError,
            "pipeline-error-openai-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorOpenaiLlmFailed, "pipeline-error-openai-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized,
            "call.in-progress.error-vapifault-openai-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey,
            "call.in-progress.error-vapifault-openai-401-incorrect-api-key"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,
            "call.in-progress.error-vapifault-openai-401-account-not-in-organization"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied,
            "call.in-progress.error-vapifault-openai-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota,
            "call.in-progress.error-vapifault-openai-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached,
            "call.in-progress.error-vapifault-openai-429-rate-limit-reached"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError,
            "call.in-progress.error-providerfault-openai-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,
            "call.in-progress.error-providerfault-openai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed,
            "pipeline-error-azure-openai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenai401Unauthorized,
            "pipeline-error-azure-openai-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied,
            "pipeline-error-azure-openai-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenai429ExceededQuota,
            "pipeline-error-azure-openai-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenai500ServerError,
            "pipeline-error-azure-openai-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError,
            "pipeline-error-azure-openai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAzureOpenaiLlmFailed,
            "pipeline-error-azure-openai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized,
            "call.in-progress.error-vapifault-azure-openai-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,
            "call.in-progress.error-vapifault-azure-openai-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,
            "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError,
            "call.in-progress.error-providerfault-azure-openai-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,
            "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorGoogle400BadRequestValidationFailed,
            "pipeline-error-google-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorGoogle401Unauthorized,
            "pipeline-error-google-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorGoogle403ModelAccessDenied,
            "pipeline-error-google-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorGoogle429ExceededQuota,
            "pipeline-error-google-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorGoogle500ServerError,
            "pipeline-error-google-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorGoogle503ServerOverloadedError,
            "pipeline-error-google-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorGoogleLlmFailed, "pipeline-error-google-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-google-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized,
            "call.in-progress.error-vapifault-google-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied,
            "call.in-progress.error-vapifault-google-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota,
            "call.in-progress.error-vapifault-google-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError,
            "call.in-progress.error-providerfault-google-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,
            "call.in-progress.error-providerfault-google-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorXai400BadRequestValidationFailed,
            "pipeline-error-xai-400-bad-request-validation-failed"
        },
        { CallEndedReason.PipelineErrorXai401Unauthorized, "pipeline-error-xai-401-unauthorized" },
        {
            CallEndedReason.PipelineErrorXai403ModelAccessDenied,
            "pipeline-error-xai-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorXai429ExceededQuota,
            "pipeline-error-xai-429-exceeded-quota"
        },
        { CallEndedReason.PipelineErrorXai500ServerError, "pipeline-error-xai-500-server-error" },
        {
            CallEndedReason.PipelineErrorXai503ServerOverloadedError,
            "pipeline-error-xai-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorXaiLlmFailed, "pipeline-error-xai-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultXai401Unauthorized,
            "call.in-progress.error-vapifault-xai-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied,
            "call.in-progress.error-vapifault-xai-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota,
            "call.in-progress.error-vapifault-xai-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultXai500ServerError,
            "call.in-progress.error-providerfault-xai-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError,
            "call.in-progress.error-providerfault-xai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorBaseten400BadRequestValidationFailed,
            "pipeline-error-baseten-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorBaseten401Unauthorized,
            "pipeline-error-baseten-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorBaseten403ModelAccessDenied,
            "pipeline-error-baseten-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorBaseten429ExceededQuota,
            "pipeline-error-baseten-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorBaseten500ServerError,
            "pipeline-error-baseten-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorBaseten503ServerOverloadedError,
            "pipeline-error-baseten-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorBasetenLlmFailed, "pipeline-error-baseten-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized,
            "call.in-progress.error-vapifault-baseten-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied,
            "call.in-progress.error-vapifault-baseten-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota,
            "call.in-progress.error-vapifault-baseten-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError,
            "call.in-progress.error-providerfault-baseten-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,
            "call.in-progress.error-providerfault-baseten-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorMistral400BadRequestValidationFailed,
            "pipeline-error-mistral-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorMistral401Unauthorized,
            "pipeline-error-mistral-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorMistral403ModelAccessDenied,
            "pipeline-error-mistral-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorMistral429ExceededQuota,
            "pipeline-error-mistral-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorMistral500ServerError,
            "pipeline-error-mistral-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorMistral503ServerOverloadedError,
            "pipeline-error-mistral-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorMistralLlmFailed, "pipeline-error-mistral-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized,
            "call.in-progress.error-vapifault-mistral-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied,
            "call.in-progress.error-vapifault-mistral-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota,
            "call.in-progress.error-vapifault-mistral-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultMistral500ServerError,
            "call.in-progress.error-providerfault-mistral-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError,
            "call.in-progress.error-providerfault-mistral-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorMinimax400BadRequestValidationFailed,
            "pipeline-error-minimax-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorMinimax401Unauthorized,
            "pipeline-error-minimax-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorMinimax403ModelAccessDenied,
            "pipeline-error-minimax-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorMinimax429ExceededQuota,
            "pipeline-error-minimax-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorMinimax500ServerError,
            "pipeline-error-minimax-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorMinimax503ServerOverloadedError,
            "pipeline-error-minimax-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorMinimaxLlmFailed, "pipeline-error-minimax-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultMinimax400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-minimax-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMinimax401Unauthorized,
            "call.in-progress.error-vapifault-minimax-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMinimax403ModelAccessDenied,
            "call.in-progress.error-vapifault-minimax-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultMinimax429ExceededQuota,
            "call.in-progress.error-vapifault-minimax-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultMinimax500ServerError,
            "call.in-progress.error-providerfault-minimax-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultMinimax503ServerOverloadedError,
            "call.in-progress.error-providerfault-minimax-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed,
            "pipeline-error-inflection-ai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorInflectionAi401Unauthorized,
            "pipeline-error-inflection-ai-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorInflectionAi403ModelAccessDenied,
            "pipeline-error-inflection-ai-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorInflectionAi429ExceededQuota,
            "pipeline-error-inflection-ai-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorInflectionAi500ServerError,
            "pipeline-error-inflection-ai-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorInflectionAi503ServerOverloadedError,
            "pipeline-error-inflection-ai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorInflectionAiLlmFailed,
            "pipeline-error-inflection-ai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized,
            "call.in-progress.error-vapifault-inflection-ai-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,
            "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota,
            "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError,
            "call.in-progress.error-providerfault-inflection-ai-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,
            "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed,
            "pipeline-error-deep-seek-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorDeepSeek401Unauthorized,
            "pipeline-error-deep-seek-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorDeepSeek403ModelAccessDenied,
            "pipeline-error-deep-seek-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorDeepSeek429ExceededQuota,
            "pipeline-error-deep-seek-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorDeepSeek500ServerError,
            "pipeline-error-deep-seek-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorDeepSeek503ServerOverloadedError,
            "pipeline-error-deep-seek-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorDeepSeekLlmFailed, "pipeline-error-deep-seek-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized,
            "call.in-progress.error-vapifault-deep-seek-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,
            "call.in-progress.error-vapifault-deep-seek-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota,
            "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError,
            "call.in-progress.error-providerfault-deep-seek-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,
            "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorGroq400BadRequestValidationFailed,
            "pipeline-error-groq-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorGroq401Unauthorized,
            "pipeline-error-groq-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorGroq403ModelAccessDenied,
            "pipeline-error-groq-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorGroq429ExceededQuota,
            "pipeline-error-groq-429-exceeded-quota"
        },
        { CallEndedReason.PipelineErrorGroq500ServerError, "pipeline-error-groq-500-server-error" },
        {
            CallEndedReason.PipelineErrorGroq503ServerOverloadedError,
            "pipeline-error-groq-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorGroqLlmFailed, "pipeline-error-groq-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized,
            "call.in-progress.error-vapifault-groq-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied,
            "call.in-progress.error-vapifault-groq-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota,
            "call.in-progress.error-vapifault-groq-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultGroq500ServerError,
            "call.in-progress.error-providerfault-groq-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError,
            "call.in-progress.error-providerfault-groq-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorCerebras400BadRequestValidationFailed,
            "pipeline-error-cerebras-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorCerebras401Unauthorized,
            "pipeline-error-cerebras-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorCerebras403ModelAccessDenied,
            "pipeline-error-cerebras-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorCerebras429ExceededQuota,
            "pipeline-error-cerebras-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorCerebras500ServerError,
            "pipeline-error-cerebras-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorCerebras503ServerOverloadedError,
            "pipeline-error-cerebras-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorCerebrasLlmFailed, "pipeline-error-cerebras-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized,
            "call.in-progress.error-vapifault-cerebras-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied,
            "call.in-progress.error-vapifault-cerebras-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota,
            "call.in-progress.error-vapifault-cerebras-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError,
            "call.in-progress.error-providerfault-cerebras-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,
            "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed,
            "pipeline-error-anthropic-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorAnthropic401Unauthorized,
            "pipeline-error-anthropic-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorAnthropic403ModelAccessDenied,
            "pipeline-error-anthropic-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorAnthropic429ExceededQuota,
            "pipeline-error-anthropic-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorAnthropic500ServerError,
            "pipeline-error-anthropic-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropic503ServerOverloadedError,
            "pipeline-error-anthropic-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorAnthropicLlmFailed, "pipeline-error-anthropic-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed,
            "call.in-progress.error-providerfault-anthropic-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized,
            "call.in-progress.error-vapifault-anthropic-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,
            "call.in-progress.error-vapifault-anthropic-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota,
            "call.in-progress.error-vapifault-anthropic-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError,
            "call.in-progress.error-providerfault-anthropic-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,
            "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed,
            "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrock401Unauthorized,
            "pipeline-error-anthropic-bedrock-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied,
            "pipeline-error-anthropic-bedrock-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota,
            "pipeline-error-anthropic-bedrock-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrock500ServerError,
            "pipeline-error-anthropic-bedrock-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError,
            "pipeline-error-anthropic-bedrock-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropicBedrockLlmFailed,
            "pipeline-error-anthropic-bedrock-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,
            "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,
            "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,
            "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,
            "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,
            "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,
            "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed,
            "pipeline-error-anthropic-vertex-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertex401Unauthorized,
            "pipeline-error-anthropic-vertex-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied,
            "pipeline-error-anthropic-vertex-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertex429ExceededQuota,
            "pipeline-error-anthropic-vertex-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertex500ServerError,
            "pipeline-error-anthropic-vertex-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError,
            "pipeline-error-anthropic-vertex-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAnthropicVertexLlmFailed,
            "pipeline-error-anthropic-vertex-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,
            "call.in-progress.error-providerfault-anthropic-vertex-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,
            "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,
            "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,
            "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError,
            "call.in-progress.error-providerfault-anthropic-vertex-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,
            "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed,
            "pipeline-error-together-ai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorTogetherAi401Unauthorized,
            "pipeline-error-together-ai-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorTogetherAi403ModelAccessDenied,
            "pipeline-error-together-ai-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorTogetherAi429ExceededQuota,
            "pipeline-error-together-ai-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorTogetherAi500ServerError,
            "pipeline-error-together-ai-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorTogetherAi503ServerOverloadedError,
            "pipeline-error-together-ai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorTogetherAiLlmFailed,
            "pipeline-error-together-ai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed,
            "call.in-progress.error-providerfault-together-ai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized,
            "call.in-progress.error-vapifault-together-ai-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,
            "call.in-progress.error-vapifault-together-ai-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota,
            "call.in-progress.error-vapifault-together-ai-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError,
            "call.in-progress.error-providerfault-together-ai-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,
            "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed,
            "pipeline-error-anyscale-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorAnyscale401Unauthorized,
            "pipeline-error-anyscale-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorAnyscale403ModelAccessDenied,
            "pipeline-error-anyscale-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorAnyscale429ExceededQuota,
            "pipeline-error-anyscale-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorAnyscale500ServerError,
            "pipeline-error-anyscale-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorAnyscale503ServerOverloadedError,
            "pipeline-error-anyscale-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorAnyscaleLlmFailed, "pipeline-error-anyscale-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed,
            "call.in-progress.error-providerfault-anyscale-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized,
            "call.in-progress.error-vapifault-anyscale-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,
            "call.in-progress.error-vapifault-anyscale-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota,
            "call.in-progress.error-vapifault-anyscale-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError,
            "call.in-progress.error-providerfault-anyscale-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,
            "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed,
            "pipeline-error-openrouter-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorOpenrouter401Unauthorized,
            "pipeline-error-openrouter-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorOpenrouter403ModelAccessDenied,
            "pipeline-error-openrouter-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorOpenrouter429ExceededQuota,
            "pipeline-error-openrouter-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorOpenrouter500ServerError,
            "pipeline-error-openrouter-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorOpenrouter503ServerOverloadedError,
            "pipeline-error-openrouter-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorOpenrouterLlmFailed,
            "pipeline-error-openrouter-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed,
            "call.in-progress.error-providerfault-openrouter-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized,
            "call.in-progress.error-vapifault-openrouter-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,
            "call.in-progress.error-vapifault-openrouter-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota,
            "call.in-progress.error-vapifault-openrouter-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError,
            "call.in-progress.error-providerfault-openrouter-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,
            "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed,
            "pipeline-error-perplexity-ai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAi401Unauthorized,
            "pipeline-error-perplexity-ai-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied,
            "pipeline-error-perplexity-ai-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAi429ExceededQuota,
            "pipeline-error-perplexity-ai-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAi500ServerError,
            "pipeline-error-perplexity-ai-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError,
            "pipeline-error-perplexity-ai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorPerplexityAiLlmFailed,
            "pipeline-error-perplexity-ai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed,
            "call.in-progress.error-providerfault-perplexity-ai-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized,
            "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,
            "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,
            "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError,
            "call.in-progress.error-providerfault-perplexity-ai-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,
            "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed,
            "pipeline-error-deepinfra-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorDeepinfra401Unauthorized,
            "pipeline-error-deepinfra-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorDeepinfra403ModelAccessDenied,
            "pipeline-error-deepinfra-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorDeepinfra429ExceededQuota,
            "pipeline-error-deepinfra-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorDeepinfra500ServerError,
            "pipeline-error-deepinfra-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorDeepinfra503ServerOverloadedError,
            "pipeline-error-deepinfra-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorDeepinfraLlmFailed, "pipeline-error-deepinfra-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed,
            "call.in-progress.error-providerfault-deepinfra-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized,
            "call.in-progress.error-vapifault-deepinfra-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,
            "call.in-progress.error-vapifault-deepinfra-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota,
            "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError,
            "call.in-progress.error-providerfault-deepinfra-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,
            "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorRunpod400BadRequestValidationFailed,
            "pipeline-error-runpod-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorRunpod401Unauthorized,
            "pipeline-error-runpod-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorRunpod403ModelAccessDenied,
            "pipeline-error-runpod-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorRunpod429ExceededQuota,
            "pipeline-error-runpod-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorRunpod500ServerError,
            "pipeline-error-runpod-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorRunpod503ServerOverloadedError,
            "pipeline-error-runpod-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorRunpodLlmFailed, "pipeline-error-runpod-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed,
            "call.in-progress.error-providerfault-runpod-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized,
            "call.in-progress.error-vapifault-runpod-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied,
            "call.in-progress.error-vapifault-runpod-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota,
            "call.in-progress.error-vapifault-runpod-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError,
            "call.in-progress.error-providerfault-runpod-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,
            "call.in-progress.error-providerfault-runpod-503-server-overloaded-error"
        },
        {
            CallEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed,
            "pipeline-error-custom-llm-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.PipelineErrorCustomLlm401Unauthorized,
            "pipeline-error-custom-llm-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorCustomLlm403ModelAccessDenied,
            "pipeline-error-custom-llm-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorCustomLlm429ExceededQuota,
            "pipeline-error-custom-llm-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorCustomLlm500ServerError,
            "pipeline-error-custom-llm-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorCustomLlm503ServerOverloadedError,
            "pipeline-error-custom-llm-503-server-overloaded-error"
        },
        { CallEndedReason.PipelineErrorCustomLlmLlmFailed, "pipeline-error-custom-llm-llm-failed" },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed,
            "call.in-progress.error-providerfault-custom-llm-llm-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,
            "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized,
            "call.in-progress.error-vapifault-custom-llm-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,
            "call.in-progress.error-vapifault-custom-llm-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota,
            "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError,
            "call.in-progress.error-providerfault-custom-llm-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,
            "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error"
        },
        {
            CallEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed,
            "call.in-progress.error-pipeline-ws-model-connection-failed"
        },
        { CallEndedReason.PipelineErrorCustomVoiceFailed, "pipeline-error-custom-voice-failed" },
        {
            CallEndedReason.PipelineErrorCartesiaSocketHangUp,
            "pipeline-error-cartesia-socket-hang-up"
        },
        {
            CallEndedReason.PipelineErrorCartesiaRequestedPayment,
            "pipeline-error-cartesia-requested-payment"
        },
        {
            CallEndedReason.PipelineErrorCartesia500ServerError,
            "pipeline-error-cartesia-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorCartesia502ServerError,
            "pipeline-error-cartesia-502-server-error"
        },
        {
            CallEndedReason.PipelineErrorCartesia503ServerError,
            "pipeline-error-cartesia-503-server-error"
        },
        {
            CallEndedReason.PipelineErrorCartesia522ServerError,
            "pipeline-error-cartesia-522-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp,
            "call.in-progress.error-vapifault-cartesia-socket-hang-up"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment,
            "call.in-progress.error-vapifault-cartesia-requested-payment"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError,
            "call.in-progress.error-providerfault-cartesia-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError,
            "call.in-progress.error-providerfault-cartesia-503-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError,
            "call.in-progress.error-providerfault-cartesia-522-server-error"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVoiceNotFound,
            "pipeline-error-eleven-labs-voice-not-found"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsQuotaExceeded,
            "pipeline-error-eleven-labs-quota-exceeded"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsUnauthorizedAccess,
            "pipeline-error-eleven-labs-unauthorized-access"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel,
            "pipeline-error-eleven-labs-unauthorized-to-access-model"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,
            "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,
            "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
            "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
            "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,
            "pipeline-error-eleven-labs-system-busy-and-requested-upgrade"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned,
            "pipeline-error-eleven-labs-voice-not-fine-tuned"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsInvalidApiKey,
            "pipeline-error-eleven-labs-invalid-api-key"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples,
            "pipeline-error-eleven-labs-invalid-voice-samples"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner,
            "pipeline-error-eleven-labs-voice-disabled-by-owner"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner,
            "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation,
            "pipeline-error-eleven-labs-blocked-account-in-probation"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,
            "pipeline-error-eleven-labs-blocked-content-against-their-policy"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone,
            "pipeline-error-eleven-labs-missing-samples-for-voice-clone"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,
            "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,
            "pipeline-error-eleven-labs-voice-not-allowed-for-free-users"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded,
            "pipeline-error-eleven-labs-max-character-limit-exceeded"
        },
        {
            CallEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
            "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification"
        },
        {
            CallEndedReason.PipelineErrorElevenLabs500ServerError,
            "pipeline-error-eleven-labs-500-server-error"
        },
        {
            CallEndedReason.PipelineErrorElevenLabs503ServerError,
            "pipeline-error-eleven-labs-503-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound,
            "call.in-progress.error-vapifault-eleven-labs-voice-not-found"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded,
            "call.in-progress.error-vapifault-eleven-labs-quota-exceeded"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,
            "call.in-progress.error-vapifault-eleven-labs-unauthorized-access"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,
            "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,
            "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,
            "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
            "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
            "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,
            "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,
            "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey,
            "call.in-progress.error-vapifault-eleven-labs-invalid-api-key"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,
            "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,
            "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,
            "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,
            "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,
            "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,
            "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,
            "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,
            "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
            "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,
            "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError,
            "call.in-progress.error-providerfault-eleven-labs-500-server-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError,
            "call.in-progress.error-providerfault-eleven-labs-503-server-error"
        },
        {
            CallEndedReason.PipelineErrorPlayhtRequestTimedOut,
            "pipeline-error-playht-request-timed-out"
        },
        { CallEndedReason.PipelineErrorPlayhtInvalidVoice, "pipeline-error-playht-invalid-voice" },
        {
            CallEndedReason.PipelineErrorPlayhtUnexpectedError,
            "pipeline-error-playht-unexpected-error"
        },
        { CallEndedReason.PipelineErrorPlayhtOutOfCredits, "pipeline-error-playht-out-of-credits" },
        {
            CallEndedReason.PipelineErrorPlayhtInvalidEmotion,
            "pipeline-error-playht-invalid-emotion"
        },
        {
            CallEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,
            "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri"
        },
        {
            CallEndedReason.PipelineErrorPlayht401Unauthorized,
            "pipeline-error-playht-401-unauthorized"
        },
        {
            CallEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters,
            "pipeline-error-playht-403-forbidden-out-of-characters"
        },
        {
            CallEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,
            "pipeline-error-playht-403-forbidden-api-access-not-available"
        },
        {
            CallEndedReason.PipelineErrorPlayht429ExceededQuota,
            "pipeline-error-playht-429-exceeded-quota"
        },
        {
            CallEndedReason.PipelineErrorPlayht502GatewayError,
            "pipeline-error-playht-502-gateway-error"
        },
        {
            CallEndedReason.PipelineErrorPlayht504GatewayError,
            "pipeline-error-playht-504-gateway-error"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut,
            "call.in-progress.error-vapifault-playht-request-timed-out"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice,
            "call.in-progress.error-vapifault-playht-invalid-voice"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError,
            "call.in-progress.error-vapifault-playht-unexpected-error"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits,
            "call.in-progress.error-vapifault-playht-out-of-credits"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion,
            "call.in-progress.error-vapifault-playht-invalid-emotion"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,
            "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized,
            "call.in-progress.error-vapifault-playht-401-unauthorized"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,
            "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,
            "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota,
            "call.in-progress.error-vapifault-playht-429-exceeded-quota"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError,
            "call.in-progress.error-providerfault-playht-502-gateway-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError,
            "call.in-progress.error-providerfault-playht-504-gateway-error"
        },
        {
            CallEndedReason.PipelineErrorCustomTranscriberFailed,
            "pipeline-error-custom-transcriber-failed"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed,
            "call.in-progress.error-vapifault-custom-transcriber-failed"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,
            "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials,
            "pipeline-error-deepgram-returning-401-invalid-credentials"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied,
            "pipeline-error-deepgram-returning-403-model-access-denied"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning404NotFound,
            "pipeline-error-deepgram-returning-404-not-found"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning500InvalidJson,
            "pipeline-error-deepgram-returning-500-invalid-json"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning502NetworkError,
            "pipeline-error-deepgram-returning-502-network-error"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach,
            "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach"
        },
        {
            CallEndedReason.PipelineErrorDeepgramReturningEconnreset,
            "pipeline-error-deepgram-returning-econnreset"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,
            "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,
            "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound,
            "call.in-progress.error-vapifault-deepgram-returning-404-not-found"
        },
        {
            CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,
            "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,
            "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,
            "call.in-progress.error-providerfault-deepgram-returning-502-network-error"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,
            "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach"
        },
        {
            CallEndedReason.CallInProgressErrorWarmTransferMaxDuration,
            "call.in-progress.error-warm-transfer-max-duration"
        },
        {
            CallEndedReason.CallInProgressErrorWarmTransferAssistantCancelled,
            "call.in-progress.error-warm-transfer-assistant-cancelled"
        },
        {
            CallEndedReason.CallInProgressErrorWarmTransferSilenceTimeout,
            "call.in-progress.error-warm-transfer-silence-timeout"
        },
        {
            CallEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout,
            "call.in-progress.error-warm-transfer-microphone-timeout"
        },
        { CallEndedReason.AssistantEndedCall, "assistant-ended-call" },
        { CallEndedReason.AssistantSaidEndCallPhrase, "assistant-said-end-call-phrase" },
        {
            CallEndedReason.AssistantEndedCallWithHangupTask,
            "assistant-ended-call-with-hangup-task"
        },
        {
            CallEndedReason.AssistantEndedCallAfterMessageSpoken,
            "assistant-ended-call-after-message-spoken"
        },
        { CallEndedReason.AssistantForwardedCall, "assistant-forwarded-call" },
        { CallEndedReason.AssistantJoinTimedOut, "assistant-join-timed-out" },
        {
            CallEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio,
            "call.in-progress.error-assistant-did-not-receive-customer-audio"
        },
        {
            CallEndedReason.CallInProgressErrorTransferFailed,
            "call.in-progress.error-transfer-failed"
        },
        { CallEndedReason.CustomerBusy, "customer-busy" },
        { CallEndedReason.CustomerEndedCall, "customer-ended-call" },
        {
            CallEndedReason.CustomerEndedCallBeforeWarmTransfer,
            "customer-ended-call-before-warm-transfer"
        },
        {
            CallEndedReason.CustomerEndedCallAfterWarmTransferAttempt,
            "customer-ended-call-after-warm-transfer-attempt"
        },
        { CallEndedReason.CustomerEndedCallDuringTransfer, "customer-ended-call-during-transfer" },
        { CallEndedReason.CustomerDidNotAnswer, "customer-did-not-answer" },
        {
            CallEndedReason.CustomerDidNotGiveMicrophonePermission,
            "customer-did-not-give-microphone-permission"
        },
        { CallEndedReason.ExceededMaxDuration, "exceeded-max-duration" },
        { CallEndedReason.ManuallyCanceled, "manually-canceled" },
        {
            CallEndedReason.PhoneCallProviderClosedWebsocket,
            "phone-call-provider-closed-websocket"
        },
        { CallEndedReason.CallForwardingOperatorBusy, "call.forwarding.operator-busy" },
        { CallEndedReason.SilenceTimedOut, "silence-timed-out" },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden,
            "call.in-progress.error-providerfault-outbound-sip-403-forbidden"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,
            "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,
            "call.in-progress.error-providerfault-outbound-sip-408-request-timeout"
        },
        {
            CallEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,
            "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable"
        },
        { CallEndedReason.CallRingingHookExecutedSay, "call.ringing.hook-executed-say" },
        { CallEndedReason.CallRingingHookExecutedTransfer, "call.ringing.hook-executed-transfer" },
        { CallEndedReason.CallEndingHookExecutedSay, "call.ending.hook-executed-say" },
        { CallEndedReason.CallEndingHookExecutedTransfer, "call.ending.hook-executed-transfer" },
        {
            CallEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect,
            "call.ringing.sip-inbound-caller-hungup-before-call-connect"
        },
        { CallEndedReason.TwilioFailedToConnectCall, "twilio-failed-to-connect-call" },
        { CallEndedReason.TwilioReportedCustomerMisdialed, "twilio-reported-customer-misdialed" },
        { CallEndedReason.VonageRejected, "vonage-rejected" },
        { CallEndedReason.Voicemail, "voicemail" },
        { CallEndedReason.CallDeleted, "call-deleted" },
    };

    public override CallEndedReason Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        CallEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallEndedReason ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        CallEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
