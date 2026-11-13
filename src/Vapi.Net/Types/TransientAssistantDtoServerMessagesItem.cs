using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransientAssistantDtoServerMessagesItemSerializer))]
public enum TransientAssistantDtoServerMessagesItem
{
    [EnumMember(Value = "assistant.started")]
    AssistantStarted,

    [EnumMember(Value = "assistant.speechStarted")]
    AssistantSpeechStarted,

    [EnumMember(Value = "conversation-update")]
    ConversationUpdate,

    [EnumMember(Value = "end-of-call-report")]
    EndOfCallReport,

    [EnumMember(Value = "function-call")]
    FunctionCall,

    [EnumMember(Value = "hang")]
    Hang,

    [EnumMember(Value = "language-changed")]
    LanguageChanged,

    [EnumMember(Value = "language-change-detected")]
    LanguageChangeDetected,

    [EnumMember(Value = "model-output")]
    ModelOutput,

    [EnumMember(Value = "phone-call-control")]
    PhoneCallControl,

    [EnumMember(Value = "speech-update")]
    SpeechUpdate,

    [EnumMember(Value = "status-update")]
    StatusUpdate,

    [EnumMember(Value = "transcript")]
    Transcript,

    [EnumMember(Value = "transcript[transcriptType=\"final\"]")]
    TranscriptTranscriptTypeFinal,

    [EnumMember(Value = "tool-calls")]
    ToolCalls,

    [EnumMember(Value = "transfer-destination-request")]
    TransferDestinationRequest,

    [EnumMember(Value = "handoff-destination-request")]
    HandoffDestinationRequest,

    [EnumMember(Value = "transfer-update")]
    TransferUpdate,

    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,

    [EnumMember(Value = "voice-input")]
    VoiceInput,

    [EnumMember(Value = "chat.created")]
    ChatCreated,

    [EnumMember(Value = "chat.deleted")]
    ChatDeleted,

    [EnumMember(Value = "session.created")]
    SessionCreated,

    [EnumMember(Value = "session.updated")]
    SessionUpdated,

    [EnumMember(Value = "session.deleted")]
    SessionDeleted,

    [EnumMember(Value = "call.deleted")]
    CallDeleted,

    [EnumMember(Value = "call.delete.failed")]
    CallDeleteFailed,

    [EnumMember(Value = "call.artifact.upload")]
    CallArtifactUpload,
}

internal class TransientAssistantDtoServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransientAssistantDtoServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransientAssistantDtoServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", TransientAssistantDtoServerMessagesItem.AssistantStarted },
        {
            "assistant.speechStarted",
            TransientAssistantDtoServerMessagesItem.AssistantSpeechStarted
        },
        { "conversation-update", TransientAssistantDtoServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", TransientAssistantDtoServerMessagesItem.EndOfCallReport },
        { "function-call", TransientAssistantDtoServerMessagesItem.FunctionCall },
        { "hang", TransientAssistantDtoServerMessagesItem.Hang },
        { "language-changed", TransientAssistantDtoServerMessagesItem.LanguageChanged },
        {
            "language-change-detected",
            TransientAssistantDtoServerMessagesItem.LanguageChangeDetected
        },
        { "model-output", TransientAssistantDtoServerMessagesItem.ModelOutput },
        { "phone-call-control", TransientAssistantDtoServerMessagesItem.PhoneCallControl },
        { "speech-update", TransientAssistantDtoServerMessagesItem.SpeechUpdate },
        { "status-update", TransientAssistantDtoServerMessagesItem.StatusUpdate },
        { "transcript", TransientAssistantDtoServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            TransientAssistantDtoServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", TransientAssistantDtoServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            TransientAssistantDtoServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            TransientAssistantDtoServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", TransientAssistantDtoServerMessagesItem.TransferUpdate },
        { "user-interrupted", TransientAssistantDtoServerMessagesItem.UserInterrupted },
        { "voice-input", TransientAssistantDtoServerMessagesItem.VoiceInput },
        { "chat.created", TransientAssistantDtoServerMessagesItem.ChatCreated },
        { "chat.deleted", TransientAssistantDtoServerMessagesItem.ChatDeleted },
        { "session.created", TransientAssistantDtoServerMessagesItem.SessionCreated },
        { "session.updated", TransientAssistantDtoServerMessagesItem.SessionUpdated },
        { "session.deleted", TransientAssistantDtoServerMessagesItem.SessionDeleted },
        { "call.deleted", TransientAssistantDtoServerMessagesItem.CallDeleted },
        { "call.delete.failed", TransientAssistantDtoServerMessagesItem.CallDeleteFailed },
        { "call.artifact.upload", TransientAssistantDtoServerMessagesItem.CallArtifactUpload },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransientAssistantDtoServerMessagesItem,
        string
    > _enumToString = new()
    {
        { TransientAssistantDtoServerMessagesItem.AssistantStarted, "assistant.started" },
        {
            TransientAssistantDtoServerMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { TransientAssistantDtoServerMessagesItem.ConversationUpdate, "conversation-update" },
        { TransientAssistantDtoServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { TransientAssistantDtoServerMessagesItem.FunctionCall, "function-call" },
        { TransientAssistantDtoServerMessagesItem.Hang, "hang" },
        { TransientAssistantDtoServerMessagesItem.LanguageChanged, "language-changed" },
        {
            TransientAssistantDtoServerMessagesItem.LanguageChangeDetected,
            "language-change-detected"
        },
        { TransientAssistantDtoServerMessagesItem.ModelOutput, "model-output" },
        { TransientAssistantDtoServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { TransientAssistantDtoServerMessagesItem.SpeechUpdate, "speech-update" },
        { TransientAssistantDtoServerMessagesItem.StatusUpdate, "status-update" },
        { TransientAssistantDtoServerMessagesItem.Transcript, "transcript" },
        {
            TransientAssistantDtoServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { TransientAssistantDtoServerMessagesItem.ToolCalls, "tool-calls" },
        {
            TransientAssistantDtoServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            TransientAssistantDtoServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { TransientAssistantDtoServerMessagesItem.TransferUpdate, "transfer-update" },
        { TransientAssistantDtoServerMessagesItem.UserInterrupted, "user-interrupted" },
        { TransientAssistantDtoServerMessagesItem.VoiceInput, "voice-input" },
        { TransientAssistantDtoServerMessagesItem.ChatCreated, "chat.created" },
        { TransientAssistantDtoServerMessagesItem.ChatDeleted, "chat.deleted" },
        { TransientAssistantDtoServerMessagesItem.SessionCreated, "session.created" },
        { TransientAssistantDtoServerMessagesItem.SessionUpdated, "session.updated" },
        { TransientAssistantDtoServerMessagesItem.SessionDeleted, "session.deleted" },
        { TransientAssistantDtoServerMessagesItem.CallDeleted, "call.deleted" },
        { TransientAssistantDtoServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
        { TransientAssistantDtoServerMessagesItem.CallArtifactUpload, "call.artifact.upload" },
    };

    public override TransientAssistantDtoServerMessagesItem Read(
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
        TransientAssistantDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransientAssistantDtoServerMessagesItem ReadAsPropertyName(
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
        TransientAssistantDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
