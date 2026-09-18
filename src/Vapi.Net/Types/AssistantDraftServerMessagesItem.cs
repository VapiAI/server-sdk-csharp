using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantDraftServerMessagesItemSerializer))]
public enum AssistantDraftServerMessagesItem
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

internal class AssistantDraftServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantDraftServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantDraftServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", AssistantDraftServerMessagesItem.AssistantStarted },
        { "assistant.speechStarted", AssistantDraftServerMessagesItem.AssistantSpeechStarted },
        { "conversation-update", AssistantDraftServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", AssistantDraftServerMessagesItem.EndOfCallReport },
        { "function-call", AssistantDraftServerMessagesItem.FunctionCall },
        { "hang", AssistantDraftServerMessagesItem.Hang },
        { "language-changed", AssistantDraftServerMessagesItem.LanguageChanged },
        { "language-change-detected", AssistantDraftServerMessagesItem.LanguageChangeDetected },
        { "model-output", AssistantDraftServerMessagesItem.ModelOutput },
        { "phone-call-control", AssistantDraftServerMessagesItem.PhoneCallControl },
        { "speech-update", AssistantDraftServerMessagesItem.SpeechUpdate },
        { "status-update", AssistantDraftServerMessagesItem.StatusUpdate },
        { "transcript", AssistantDraftServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            AssistantDraftServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", AssistantDraftServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            AssistantDraftServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            AssistantDraftServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", AssistantDraftServerMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantDraftServerMessagesItem.UserInterrupted },
        { "voice-input", AssistantDraftServerMessagesItem.VoiceInput },
        { "chat.created", AssistantDraftServerMessagesItem.ChatCreated },
        { "chat.deleted", AssistantDraftServerMessagesItem.ChatDeleted },
        { "session.created", AssistantDraftServerMessagesItem.SessionCreated },
        { "session.updated", AssistantDraftServerMessagesItem.SessionUpdated },
        { "session.deleted", AssistantDraftServerMessagesItem.SessionDeleted },
        { "call.deleted", AssistantDraftServerMessagesItem.CallDeleted },
        { "call.delete.failed", AssistantDraftServerMessagesItem.CallDeleteFailed },
        { "call.artifact.upload", AssistantDraftServerMessagesItem.CallArtifactUpload },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantDraftServerMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantDraftServerMessagesItem.AssistantStarted, "assistant.started" },
        { AssistantDraftServerMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantDraftServerMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantDraftServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { AssistantDraftServerMessagesItem.FunctionCall, "function-call" },
        { AssistantDraftServerMessagesItem.Hang, "hang" },
        { AssistantDraftServerMessagesItem.LanguageChanged, "language-changed" },
        { AssistantDraftServerMessagesItem.LanguageChangeDetected, "language-change-detected" },
        { AssistantDraftServerMessagesItem.ModelOutput, "model-output" },
        { AssistantDraftServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { AssistantDraftServerMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantDraftServerMessagesItem.StatusUpdate, "status-update" },
        { AssistantDraftServerMessagesItem.Transcript, "transcript" },
        {
            AssistantDraftServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { AssistantDraftServerMessagesItem.ToolCalls, "tool-calls" },
        {
            AssistantDraftServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            AssistantDraftServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { AssistantDraftServerMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantDraftServerMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantDraftServerMessagesItem.VoiceInput, "voice-input" },
        { AssistantDraftServerMessagesItem.ChatCreated, "chat.created" },
        { AssistantDraftServerMessagesItem.ChatDeleted, "chat.deleted" },
        { AssistantDraftServerMessagesItem.SessionCreated, "session.created" },
        { AssistantDraftServerMessagesItem.SessionUpdated, "session.updated" },
        { AssistantDraftServerMessagesItem.SessionDeleted, "session.deleted" },
        { AssistantDraftServerMessagesItem.CallDeleted, "call.deleted" },
        { AssistantDraftServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
        { AssistantDraftServerMessagesItem.CallArtifactUpload, "call.artifact.upload" },
    };

    public override AssistantDraftServerMessagesItem Read(
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
        AssistantDraftServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantDraftServerMessagesItem ReadAsPropertyName(
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
        AssistantDraftServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
