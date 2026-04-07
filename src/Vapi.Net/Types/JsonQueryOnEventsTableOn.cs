using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnEventsTableOnSerializer))]
public enum JsonQueryOnEventsTableOn
{
    [EnumMember(Value = "call.started")]
    CallStarted,

    [EnumMember(Value = "call.ended")]
    CallEnded,

    [EnumMember(Value = "call.inProgress")]
    CallInProgress,

    [EnumMember(Value = "call.queued")]
    CallQueued,

    [EnumMember(Value = "call.transportConnected")]
    CallTransportConnected,

    [EnumMember(Value = "call.transportDisconnected")]
    CallTransportDisconnected,

    [EnumMember(Value = "call.transportReconnected")]
    CallTransportReconnected,

    [EnumMember(Value = "call.transferInitiated")]
    CallTransferInitiated,

    [EnumMember(Value = "call.transferCompleted")]
    CallTransferCompleted,

    [EnumMember(Value = "call.transferFailed")]
    CallTransferFailed,

    [EnumMember(Value = "call.transferCancelled")]
    CallTransferCancelled,

    [EnumMember(Value = "call.handoffInitiated")]
    CallHandoffInitiated,

    [EnumMember(Value = "call.handoffCompleted")]
    CallHandoffCompleted,

    [EnumMember(Value = "call.handoffFailed")]
    CallHandoffFailed,

    [EnumMember(Value = "call.assistantSwapped")]
    CallAssistantSwapped,

    [EnumMember(Value = "call.assistantStarted")]
    CallAssistantStarted,

    [EnumMember(Value = "call.customerJoined")]
    CallCustomerJoined,

    [EnumMember(Value = "call.customerLeft")]
    CallCustomerLeft,

    [EnumMember(Value = "call.controlReceived")]
    CallControlReceived,

    [EnumMember(Value = "call.listenStarted")]
    CallListenStarted,

    [EnumMember(Value = "call.recordingStarted")]
    CallRecordingStarted,

    [EnumMember(Value = "call.recordingPaused")]
    CallRecordingPaused,

    [EnumMember(Value = "call.recordingResumed")]
    CallRecordingResumed,

    [EnumMember(Value = "call.voicemailDetected")]
    CallVoicemailDetected,

    [EnumMember(Value = "call.voicemailNotDetected")]
    CallVoicemailNotDetected,

    [EnumMember(Value = "call.dtmfReceived")]
    CallDtmfReceived,

    [EnumMember(Value = "call.dtmfSent")]
    CallDtmfSent,

    [EnumMember(Value = "call.amdDetected")]
    CallAmdDetected,

    [EnumMember(Value = "call.hookTriggered")]
    CallHookTriggered,

    [EnumMember(Value = "call.hookSucceeded")]
    CallHookSucceeded,

    [EnumMember(Value = "call.hookFailed")]
    CallHookFailed,

    [EnumMember(Value = "call.statusReceived")]
    CallStatusReceived,

    [EnumMember(Value = "call.silenceTimeout")]
    CallSilenceTimeout,

    [EnumMember(Value = "call.microphoneTimeout")]
    CallMicrophoneTimeout,

    [EnumMember(Value = "call.maxDurationReached")]
    CallMaxDurationReached,

    [EnumMember(Value = "assistant.voice.requestStarted")]
    AssistantVoiceRequestStarted,

    [EnumMember(Value = "assistant.voice.requestSucceeded")]
    AssistantVoiceRequestSucceeded,

    [EnumMember(Value = "assistant.voice.requestFailed")]
    AssistantVoiceRequestFailed,

    [EnumMember(Value = "assistant.voice.connectionOpened")]
    AssistantVoiceConnectionOpened,

    [EnumMember(Value = "assistant.voice.connectionClosed")]
    AssistantVoiceConnectionClosed,

    [EnumMember(Value = "assistant.voice.firstAudioReceived")]
    AssistantVoiceFirstAudioReceived,

    [EnumMember(Value = "assistant.voice.audioChunkReceived")]
    AssistantVoiceAudioChunkReceived,

    [EnumMember(Value = "assistant.voice.generationSucceeded")]
    AssistantVoiceGenerationSucceeded,

    [EnumMember(Value = "assistant.voice.generationFailed")]
    AssistantVoiceGenerationFailed,

    [EnumMember(Value = "assistant.voice.textPushed")]
    AssistantVoiceTextPushed,

    [EnumMember(Value = "assistant.voice.reconnecting")]
    AssistantVoiceReconnecting,

    [EnumMember(Value = "assistant.voice.cleanup")]
    AssistantVoiceCleanup,

    [EnumMember(Value = "assistant.voice.clearing")]
    AssistantVoiceClearing,

    [EnumMember(Value = "assistant.voice.voiceSwitched")]
    AssistantVoiceVoiceSwitched,

    [EnumMember(Value = "assistant.model.requestStarted")]
    AssistantModelRequestStarted,

    [EnumMember(Value = "assistant.model.requestSucceeded")]
    AssistantModelRequestSucceeded,

    [EnumMember(Value = "assistant.model.requestFailed")]
    AssistantModelRequestFailed,

    [EnumMember(Value = "assistant.model.requestAttemptStarted")]
    AssistantModelRequestAttemptStarted,

    [EnumMember(Value = "assistant.model.requestAttemptSucceeded")]
    AssistantModelRequestAttemptSucceeded,

    [EnumMember(Value = "assistant.model.requestAttemptFailed")]
    AssistantModelRequestAttemptFailed,

    [EnumMember(Value = "assistant.model.connectionOpened")]
    AssistantModelConnectionOpened,

    [EnumMember(Value = "assistant.model.connectionClosed")]
    AssistantModelConnectionClosed,

    [EnumMember(Value = "assistant.model.firstTokenReceived")]
    AssistantModelFirstTokenReceived,

    [EnumMember(Value = "assistant.model.tokenReceived")]
    AssistantModelTokenReceived,

    [EnumMember(Value = "assistant.model.responseSucceeded")]
    AssistantModelResponseSucceeded,

    [EnumMember(Value = "assistant.model.responseFailed")]
    AssistantModelResponseFailed,

    [EnumMember(Value = "assistant.model.toolCallsReceived")]
    AssistantModelToolCallsReceived,

    [EnumMember(Value = "assistant.model.reconnecting")]
    AssistantModelReconnecting,

    [EnumMember(Value = "assistant.model.cleanup")]
    AssistantModelCleanup,

    [EnumMember(Value = "assistant.model.clearing")]
    AssistantModelClearing,

    [EnumMember(Value = "assistant.tool.started")]
    AssistantToolStarted,

    [EnumMember(Value = "assistant.tool.completed")]
    AssistantToolCompleted,

    [EnumMember(Value = "assistant.tool.failed")]
    AssistantToolFailed,

    [EnumMember(Value = "assistant.tool.delayedMessageSent")]
    AssistantToolDelayedMessageSent,

    [EnumMember(Value = "assistant.tool.timeout")]
    AssistantToolTimeout,

    [EnumMember(Value = "assistant.tool.asyncCallbackReceived")]
    AssistantToolAsyncCallbackReceived,

    [EnumMember(Value = "assistant.transcriber.requestStarted")]
    AssistantTranscriberRequestStarted,

    [EnumMember(Value = "assistant.transcriber.requestSucceeded")]
    AssistantTranscriberRequestSucceeded,

    [EnumMember(Value = "assistant.transcriber.requestFailed")]
    AssistantTranscriberRequestFailed,

    [EnumMember(Value = "assistant.transcriber.connectionOpened")]
    AssistantTranscriberConnectionOpened,

    [EnumMember(Value = "assistant.transcriber.connectionClosed")]
    AssistantTranscriberConnectionClosed,

    [EnumMember(Value = "assistant.transcriber.partialTranscript")]
    AssistantTranscriberPartialTranscript,

    [EnumMember(Value = "assistant.transcriber.finalTranscript")]
    AssistantTranscriberFinalTranscript,

    [EnumMember(Value = "assistant.transcriber.keepAlive")]
    AssistantTranscriberKeepAlive,

    [EnumMember(Value = "assistant.transcriber.reconnecting")]
    AssistantTranscriberReconnecting,

    [EnumMember(Value = "assistant.transcriber.cleanup")]
    AssistantTranscriberCleanup,

    [EnumMember(Value = "assistant.transcriber.clearing")]
    AssistantTranscriberClearing,

    [EnumMember(Value = "assistant.transcriber.transcriptIgnored")]
    AssistantTranscriberTranscriptIgnored,

    [EnumMember(Value = "assistant.transcriber.languageSwitched")]
    AssistantTranscriberLanguageSwitched,

    [EnumMember(Value = "assistant.analysis.structuredOutputGenerated")]
    AssistantAnalysisStructuredOutputGenerated,

    [EnumMember(Value = "pipeline.turnStarted")]
    PipelineTurnStarted,

    [EnumMember(Value = "pipeline.cleared")]
    PipelineCleared,

    [EnumMember(Value = "pipeline.botSpeechStarted")]
    PipelineBotSpeechStarted,

    [EnumMember(Value = "pipeline.botSpeechStopped")]
    PipelineBotSpeechStopped,

    [EnumMember(Value = "pipeline.userSpeechStarted")]
    PipelineUserSpeechStarted,

    [EnumMember(Value = "pipeline.userSpeechStopped")]
    PipelineUserSpeechStopped,

    [EnumMember(Value = "pipeline.endpointingTriggered")]
    PipelineEndpointingTriggered,

    [EnumMember(Value = "pipeline.firstMessageStarted")]
    PipelineFirstMessageStarted,

    [EnumMember(Value = "pipeline.firstMessageCompleted")]
    PipelineFirstMessageCompleted,
}

internal class JsonQueryOnEventsTableOnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnEventsTableOn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnEventsTableOn
    > _stringToEnum = new()
    {
        { "call.started", JsonQueryOnEventsTableOn.CallStarted },
        { "call.ended", JsonQueryOnEventsTableOn.CallEnded },
        { "call.inProgress", JsonQueryOnEventsTableOn.CallInProgress },
        { "call.queued", JsonQueryOnEventsTableOn.CallQueued },
        { "call.transportConnected", JsonQueryOnEventsTableOn.CallTransportConnected },
        { "call.transportDisconnected", JsonQueryOnEventsTableOn.CallTransportDisconnected },
        { "call.transportReconnected", JsonQueryOnEventsTableOn.CallTransportReconnected },
        { "call.transferInitiated", JsonQueryOnEventsTableOn.CallTransferInitiated },
        { "call.transferCompleted", JsonQueryOnEventsTableOn.CallTransferCompleted },
        { "call.transferFailed", JsonQueryOnEventsTableOn.CallTransferFailed },
        { "call.transferCancelled", JsonQueryOnEventsTableOn.CallTransferCancelled },
        { "call.handoffInitiated", JsonQueryOnEventsTableOn.CallHandoffInitiated },
        { "call.handoffCompleted", JsonQueryOnEventsTableOn.CallHandoffCompleted },
        { "call.handoffFailed", JsonQueryOnEventsTableOn.CallHandoffFailed },
        { "call.assistantSwapped", JsonQueryOnEventsTableOn.CallAssistantSwapped },
        { "call.assistantStarted", JsonQueryOnEventsTableOn.CallAssistantStarted },
        { "call.customerJoined", JsonQueryOnEventsTableOn.CallCustomerJoined },
        { "call.customerLeft", JsonQueryOnEventsTableOn.CallCustomerLeft },
        { "call.controlReceived", JsonQueryOnEventsTableOn.CallControlReceived },
        { "call.listenStarted", JsonQueryOnEventsTableOn.CallListenStarted },
        { "call.recordingStarted", JsonQueryOnEventsTableOn.CallRecordingStarted },
        { "call.recordingPaused", JsonQueryOnEventsTableOn.CallRecordingPaused },
        { "call.recordingResumed", JsonQueryOnEventsTableOn.CallRecordingResumed },
        { "call.voicemailDetected", JsonQueryOnEventsTableOn.CallVoicemailDetected },
        { "call.voicemailNotDetected", JsonQueryOnEventsTableOn.CallVoicemailNotDetected },
        { "call.dtmfReceived", JsonQueryOnEventsTableOn.CallDtmfReceived },
        { "call.dtmfSent", JsonQueryOnEventsTableOn.CallDtmfSent },
        { "call.amdDetected", JsonQueryOnEventsTableOn.CallAmdDetected },
        { "call.hookTriggered", JsonQueryOnEventsTableOn.CallHookTriggered },
        { "call.hookSucceeded", JsonQueryOnEventsTableOn.CallHookSucceeded },
        { "call.hookFailed", JsonQueryOnEventsTableOn.CallHookFailed },
        { "call.statusReceived", JsonQueryOnEventsTableOn.CallStatusReceived },
        { "call.silenceTimeout", JsonQueryOnEventsTableOn.CallSilenceTimeout },
        { "call.microphoneTimeout", JsonQueryOnEventsTableOn.CallMicrophoneTimeout },
        { "call.maxDurationReached", JsonQueryOnEventsTableOn.CallMaxDurationReached },
        { "assistant.voice.requestStarted", JsonQueryOnEventsTableOn.AssistantVoiceRequestStarted },
        {
            "assistant.voice.requestSucceeded",
            JsonQueryOnEventsTableOn.AssistantVoiceRequestSucceeded
        },
        { "assistant.voice.requestFailed", JsonQueryOnEventsTableOn.AssistantVoiceRequestFailed },
        {
            "assistant.voice.connectionOpened",
            JsonQueryOnEventsTableOn.AssistantVoiceConnectionOpened
        },
        {
            "assistant.voice.connectionClosed",
            JsonQueryOnEventsTableOn.AssistantVoiceConnectionClosed
        },
        {
            "assistant.voice.firstAudioReceived",
            JsonQueryOnEventsTableOn.AssistantVoiceFirstAudioReceived
        },
        {
            "assistant.voice.audioChunkReceived",
            JsonQueryOnEventsTableOn.AssistantVoiceAudioChunkReceived
        },
        {
            "assistant.voice.generationSucceeded",
            JsonQueryOnEventsTableOn.AssistantVoiceGenerationSucceeded
        },
        {
            "assistant.voice.generationFailed",
            JsonQueryOnEventsTableOn.AssistantVoiceGenerationFailed
        },
        { "assistant.voice.textPushed", JsonQueryOnEventsTableOn.AssistantVoiceTextPushed },
        { "assistant.voice.reconnecting", JsonQueryOnEventsTableOn.AssistantVoiceReconnecting },
        { "assistant.voice.cleanup", JsonQueryOnEventsTableOn.AssistantVoiceCleanup },
        { "assistant.voice.clearing", JsonQueryOnEventsTableOn.AssistantVoiceClearing },
        { "assistant.voice.voiceSwitched", JsonQueryOnEventsTableOn.AssistantVoiceVoiceSwitched },
        { "assistant.model.requestStarted", JsonQueryOnEventsTableOn.AssistantModelRequestStarted },
        {
            "assistant.model.requestSucceeded",
            JsonQueryOnEventsTableOn.AssistantModelRequestSucceeded
        },
        { "assistant.model.requestFailed", JsonQueryOnEventsTableOn.AssistantModelRequestFailed },
        {
            "assistant.model.requestAttemptStarted",
            JsonQueryOnEventsTableOn.AssistantModelRequestAttemptStarted
        },
        {
            "assistant.model.requestAttemptSucceeded",
            JsonQueryOnEventsTableOn.AssistantModelRequestAttemptSucceeded
        },
        {
            "assistant.model.requestAttemptFailed",
            JsonQueryOnEventsTableOn.AssistantModelRequestAttemptFailed
        },
        {
            "assistant.model.connectionOpened",
            JsonQueryOnEventsTableOn.AssistantModelConnectionOpened
        },
        {
            "assistant.model.connectionClosed",
            JsonQueryOnEventsTableOn.AssistantModelConnectionClosed
        },
        {
            "assistant.model.firstTokenReceived",
            JsonQueryOnEventsTableOn.AssistantModelFirstTokenReceived
        },
        { "assistant.model.tokenReceived", JsonQueryOnEventsTableOn.AssistantModelTokenReceived },
        {
            "assistant.model.responseSucceeded",
            JsonQueryOnEventsTableOn.AssistantModelResponseSucceeded
        },
        { "assistant.model.responseFailed", JsonQueryOnEventsTableOn.AssistantModelResponseFailed },
        {
            "assistant.model.toolCallsReceived",
            JsonQueryOnEventsTableOn.AssistantModelToolCallsReceived
        },
        { "assistant.model.reconnecting", JsonQueryOnEventsTableOn.AssistantModelReconnecting },
        { "assistant.model.cleanup", JsonQueryOnEventsTableOn.AssistantModelCleanup },
        { "assistant.model.clearing", JsonQueryOnEventsTableOn.AssistantModelClearing },
        { "assistant.tool.started", JsonQueryOnEventsTableOn.AssistantToolStarted },
        { "assistant.tool.completed", JsonQueryOnEventsTableOn.AssistantToolCompleted },
        { "assistant.tool.failed", JsonQueryOnEventsTableOn.AssistantToolFailed },
        {
            "assistant.tool.delayedMessageSent",
            JsonQueryOnEventsTableOn.AssistantToolDelayedMessageSent
        },
        { "assistant.tool.timeout", JsonQueryOnEventsTableOn.AssistantToolTimeout },
        {
            "assistant.tool.asyncCallbackReceived",
            JsonQueryOnEventsTableOn.AssistantToolAsyncCallbackReceived
        },
        {
            "assistant.transcriber.requestStarted",
            JsonQueryOnEventsTableOn.AssistantTranscriberRequestStarted
        },
        {
            "assistant.transcriber.requestSucceeded",
            JsonQueryOnEventsTableOn.AssistantTranscriberRequestSucceeded
        },
        {
            "assistant.transcriber.requestFailed",
            JsonQueryOnEventsTableOn.AssistantTranscriberRequestFailed
        },
        {
            "assistant.transcriber.connectionOpened",
            JsonQueryOnEventsTableOn.AssistantTranscriberConnectionOpened
        },
        {
            "assistant.transcriber.connectionClosed",
            JsonQueryOnEventsTableOn.AssistantTranscriberConnectionClosed
        },
        {
            "assistant.transcriber.partialTranscript",
            JsonQueryOnEventsTableOn.AssistantTranscriberPartialTranscript
        },
        {
            "assistant.transcriber.finalTranscript",
            JsonQueryOnEventsTableOn.AssistantTranscriberFinalTranscript
        },
        {
            "assistant.transcriber.keepAlive",
            JsonQueryOnEventsTableOn.AssistantTranscriberKeepAlive
        },
        {
            "assistant.transcriber.reconnecting",
            JsonQueryOnEventsTableOn.AssistantTranscriberReconnecting
        },
        { "assistant.transcriber.cleanup", JsonQueryOnEventsTableOn.AssistantTranscriberCleanup },
        { "assistant.transcriber.clearing", JsonQueryOnEventsTableOn.AssistantTranscriberClearing },
        {
            "assistant.transcriber.transcriptIgnored",
            JsonQueryOnEventsTableOn.AssistantTranscriberTranscriptIgnored
        },
        {
            "assistant.transcriber.languageSwitched",
            JsonQueryOnEventsTableOn.AssistantTranscriberLanguageSwitched
        },
        {
            "assistant.analysis.structuredOutputGenerated",
            JsonQueryOnEventsTableOn.AssistantAnalysisStructuredOutputGenerated
        },
        { "pipeline.turnStarted", JsonQueryOnEventsTableOn.PipelineTurnStarted },
        { "pipeline.cleared", JsonQueryOnEventsTableOn.PipelineCleared },
        { "pipeline.botSpeechStarted", JsonQueryOnEventsTableOn.PipelineBotSpeechStarted },
        { "pipeline.botSpeechStopped", JsonQueryOnEventsTableOn.PipelineBotSpeechStopped },
        { "pipeline.userSpeechStarted", JsonQueryOnEventsTableOn.PipelineUserSpeechStarted },
        { "pipeline.userSpeechStopped", JsonQueryOnEventsTableOn.PipelineUserSpeechStopped },
        { "pipeline.endpointingTriggered", JsonQueryOnEventsTableOn.PipelineEndpointingTriggered },
        { "pipeline.firstMessageStarted", JsonQueryOnEventsTableOn.PipelineFirstMessageStarted },
        {
            "pipeline.firstMessageCompleted",
            JsonQueryOnEventsTableOn.PipelineFirstMessageCompleted
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnEventsTableOn,
        string
    > _enumToString = new()
    {
        { JsonQueryOnEventsTableOn.CallStarted, "call.started" },
        { JsonQueryOnEventsTableOn.CallEnded, "call.ended" },
        { JsonQueryOnEventsTableOn.CallInProgress, "call.inProgress" },
        { JsonQueryOnEventsTableOn.CallQueued, "call.queued" },
        { JsonQueryOnEventsTableOn.CallTransportConnected, "call.transportConnected" },
        { JsonQueryOnEventsTableOn.CallTransportDisconnected, "call.transportDisconnected" },
        { JsonQueryOnEventsTableOn.CallTransportReconnected, "call.transportReconnected" },
        { JsonQueryOnEventsTableOn.CallTransferInitiated, "call.transferInitiated" },
        { JsonQueryOnEventsTableOn.CallTransferCompleted, "call.transferCompleted" },
        { JsonQueryOnEventsTableOn.CallTransferFailed, "call.transferFailed" },
        { JsonQueryOnEventsTableOn.CallTransferCancelled, "call.transferCancelled" },
        { JsonQueryOnEventsTableOn.CallHandoffInitiated, "call.handoffInitiated" },
        { JsonQueryOnEventsTableOn.CallHandoffCompleted, "call.handoffCompleted" },
        { JsonQueryOnEventsTableOn.CallHandoffFailed, "call.handoffFailed" },
        { JsonQueryOnEventsTableOn.CallAssistantSwapped, "call.assistantSwapped" },
        { JsonQueryOnEventsTableOn.CallAssistantStarted, "call.assistantStarted" },
        { JsonQueryOnEventsTableOn.CallCustomerJoined, "call.customerJoined" },
        { JsonQueryOnEventsTableOn.CallCustomerLeft, "call.customerLeft" },
        { JsonQueryOnEventsTableOn.CallControlReceived, "call.controlReceived" },
        { JsonQueryOnEventsTableOn.CallListenStarted, "call.listenStarted" },
        { JsonQueryOnEventsTableOn.CallRecordingStarted, "call.recordingStarted" },
        { JsonQueryOnEventsTableOn.CallRecordingPaused, "call.recordingPaused" },
        { JsonQueryOnEventsTableOn.CallRecordingResumed, "call.recordingResumed" },
        { JsonQueryOnEventsTableOn.CallVoicemailDetected, "call.voicemailDetected" },
        { JsonQueryOnEventsTableOn.CallVoicemailNotDetected, "call.voicemailNotDetected" },
        { JsonQueryOnEventsTableOn.CallDtmfReceived, "call.dtmfReceived" },
        { JsonQueryOnEventsTableOn.CallDtmfSent, "call.dtmfSent" },
        { JsonQueryOnEventsTableOn.CallAmdDetected, "call.amdDetected" },
        { JsonQueryOnEventsTableOn.CallHookTriggered, "call.hookTriggered" },
        { JsonQueryOnEventsTableOn.CallHookSucceeded, "call.hookSucceeded" },
        { JsonQueryOnEventsTableOn.CallHookFailed, "call.hookFailed" },
        { JsonQueryOnEventsTableOn.CallStatusReceived, "call.statusReceived" },
        { JsonQueryOnEventsTableOn.CallSilenceTimeout, "call.silenceTimeout" },
        { JsonQueryOnEventsTableOn.CallMicrophoneTimeout, "call.microphoneTimeout" },
        { JsonQueryOnEventsTableOn.CallMaxDurationReached, "call.maxDurationReached" },
        { JsonQueryOnEventsTableOn.AssistantVoiceRequestStarted, "assistant.voice.requestStarted" },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceRequestSucceeded,
            "assistant.voice.requestSucceeded"
        },
        { JsonQueryOnEventsTableOn.AssistantVoiceRequestFailed, "assistant.voice.requestFailed" },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceConnectionOpened,
            "assistant.voice.connectionOpened"
        },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceConnectionClosed,
            "assistant.voice.connectionClosed"
        },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceFirstAudioReceived,
            "assistant.voice.firstAudioReceived"
        },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceAudioChunkReceived,
            "assistant.voice.audioChunkReceived"
        },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceGenerationSucceeded,
            "assistant.voice.generationSucceeded"
        },
        {
            JsonQueryOnEventsTableOn.AssistantVoiceGenerationFailed,
            "assistant.voice.generationFailed"
        },
        { JsonQueryOnEventsTableOn.AssistantVoiceTextPushed, "assistant.voice.textPushed" },
        { JsonQueryOnEventsTableOn.AssistantVoiceReconnecting, "assistant.voice.reconnecting" },
        { JsonQueryOnEventsTableOn.AssistantVoiceCleanup, "assistant.voice.cleanup" },
        { JsonQueryOnEventsTableOn.AssistantVoiceClearing, "assistant.voice.clearing" },
        { JsonQueryOnEventsTableOn.AssistantVoiceVoiceSwitched, "assistant.voice.voiceSwitched" },
        { JsonQueryOnEventsTableOn.AssistantModelRequestStarted, "assistant.model.requestStarted" },
        {
            JsonQueryOnEventsTableOn.AssistantModelRequestSucceeded,
            "assistant.model.requestSucceeded"
        },
        { JsonQueryOnEventsTableOn.AssistantModelRequestFailed, "assistant.model.requestFailed" },
        {
            JsonQueryOnEventsTableOn.AssistantModelRequestAttemptStarted,
            "assistant.model.requestAttemptStarted"
        },
        {
            JsonQueryOnEventsTableOn.AssistantModelRequestAttemptSucceeded,
            "assistant.model.requestAttemptSucceeded"
        },
        {
            JsonQueryOnEventsTableOn.AssistantModelRequestAttemptFailed,
            "assistant.model.requestAttemptFailed"
        },
        {
            JsonQueryOnEventsTableOn.AssistantModelConnectionOpened,
            "assistant.model.connectionOpened"
        },
        {
            JsonQueryOnEventsTableOn.AssistantModelConnectionClosed,
            "assistant.model.connectionClosed"
        },
        {
            JsonQueryOnEventsTableOn.AssistantModelFirstTokenReceived,
            "assistant.model.firstTokenReceived"
        },
        { JsonQueryOnEventsTableOn.AssistantModelTokenReceived, "assistant.model.tokenReceived" },
        {
            JsonQueryOnEventsTableOn.AssistantModelResponseSucceeded,
            "assistant.model.responseSucceeded"
        },
        { JsonQueryOnEventsTableOn.AssistantModelResponseFailed, "assistant.model.responseFailed" },
        {
            JsonQueryOnEventsTableOn.AssistantModelToolCallsReceived,
            "assistant.model.toolCallsReceived"
        },
        { JsonQueryOnEventsTableOn.AssistantModelReconnecting, "assistant.model.reconnecting" },
        { JsonQueryOnEventsTableOn.AssistantModelCleanup, "assistant.model.cleanup" },
        { JsonQueryOnEventsTableOn.AssistantModelClearing, "assistant.model.clearing" },
        { JsonQueryOnEventsTableOn.AssistantToolStarted, "assistant.tool.started" },
        { JsonQueryOnEventsTableOn.AssistantToolCompleted, "assistant.tool.completed" },
        { JsonQueryOnEventsTableOn.AssistantToolFailed, "assistant.tool.failed" },
        {
            JsonQueryOnEventsTableOn.AssistantToolDelayedMessageSent,
            "assistant.tool.delayedMessageSent"
        },
        { JsonQueryOnEventsTableOn.AssistantToolTimeout, "assistant.tool.timeout" },
        {
            JsonQueryOnEventsTableOn.AssistantToolAsyncCallbackReceived,
            "assistant.tool.asyncCallbackReceived"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberRequestStarted,
            "assistant.transcriber.requestStarted"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberRequestSucceeded,
            "assistant.transcriber.requestSucceeded"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberRequestFailed,
            "assistant.transcriber.requestFailed"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberConnectionOpened,
            "assistant.transcriber.connectionOpened"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberConnectionClosed,
            "assistant.transcriber.connectionClosed"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberPartialTranscript,
            "assistant.transcriber.partialTranscript"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberFinalTranscript,
            "assistant.transcriber.finalTranscript"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberKeepAlive,
            "assistant.transcriber.keepAlive"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberReconnecting,
            "assistant.transcriber.reconnecting"
        },
        { JsonQueryOnEventsTableOn.AssistantTranscriberCleanup, "assistant.transcriber.cleanup" },
        { JsonQueryOnEventsTableOn.AssistantTranscriberClearing, "assistant.transcriber.clearing" },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberTranscriptIgnored,
            "assistant.transcriber.transcriptIgnored"
        },
        {
            JsonQueryOnEventsTableOn.AssistantTranscriberLanguageSwitched,
            "assistant.transcriber.languageSwitched"
        },
        {
            JsonQueryOnEventsTableOn.AssistantAnalysisStructuredOutputGenerated,
            "assistant.analysis.structuredOutputGenerated"
        },
        { JsonQueryOnEventsTableOn.PipelineTurnStarted, "pipeline.turnStarted" },
        { JsonQueryOnEventsTableOn.PipelineCleared, "pipeline.cleared" },
        { JsonQueryOnEventsTableOn.PipelineBotSpeechStarted, "pipeline.botSpeechStarted" },
        { JsonQueryOnEventsTableOn.PipelineBotSpeechStopped, "pipeline.botSpeechStopped" },
        { JsonQueryOnEventsTableOn.PipelineUserSpeechStarted, "pipeline.userSpeechStarted" },
        { JsonQueryOnEventsTableOn.PipelineUserSpeechStopped, "pipeline.userSpeechStopped" },
        { JsonQueryOnEventsTableOn.PipelineEndpointingTriggered, "pipeline.endpointingTriggered" },
        { JsonQueryOnEventsTableOn.PipelineFirstMessageStarted, "pipeline.firstMessageStarted" },
        {
            JsonQueryOnEventsTableOn.PipelineFirstMessageCompleted,
            "pipeline.firstMessageCompleted"
        },
    };

    public override JsonQueryOnEventsTableOn Read(
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
        JsonQueryOnEventsTableOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnEventsTableOn ReadAsPropertyName(
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
        JsonQueryOnEventsTableOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
