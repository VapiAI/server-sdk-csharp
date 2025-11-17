using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallEndedReason>))]
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

    [EnumMember(Value = "call.in-progress.error-providerfault-inflection-ai-llm-failed")]
    CallInProgressErrorProviderfaultInflectionAiLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-cerebras-llm-failed")]
    CallInProgressErrorProviderfaultCerebrasLlmFailed,

    [EnumMember(Value = "call.in-progress.error-providerfault-deep-seek-llm-failed")]
    CallInProgressErrorProviderfaultDeepSeekLlmFailed,

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

    [EnumMember(Value = "pipeline-error-eleven-labs-transcriber-failed")]
    PipelineErrorElevenLabsTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-eleven-labs-transcriber-failed")]
    CallInProgressErrorVapifaultElevenLabsTranscriberFailed,

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

    [EnumMember(Value = "pipeline-error-google-transcriber-failed")]
    PipelineErrorGoogleTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-google-transcriber-failed")]
    CallInProgressErrorVapifaultGoogleTranscriberFailed,

    [EnumMember(Value = "pipeline-error-openai-transcriber-failed")]
    PipelineErrorOpenaiTranscriberFailed,

    [EnumMember(Value = "call.in-progress.error-vapifault-openai-transcriber-failed")]
    CallInProgressErrorVapifaultOpenaiTranscriberFailed,

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

    [EnumMember(Value = "call.in-progress.error-sip-inbound-call-failed-to-connect")]
    CallInProgressErrorSipInboundCallFailedToConnect,

    [EnumMember(Value = "call.in-progress.error-providerfault-outbound-sip-403-forbidden")]
    CallInProgressErrorProviderfaultOutboundSip403Forbidden,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required"
    )]
    CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable"
    )]
    CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,

    [EnumMember(
        Value = "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable"
    )]
    CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,

    [EnumMember(Value = "call.in-progress.error-sip-outbound-call-failed-to-connect")]
    CallInProgressErrorSipOutboundCallFailedToConnect,

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

    [EnumMember(Value = "call.ringing.error-sip-inbound-call-failed-to-connect")]
    CallRingingErrorSipInboundCallFailedToConnect,

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
