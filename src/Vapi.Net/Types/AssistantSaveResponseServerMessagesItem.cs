using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantSaveResponseServerMessagesItemSerializer))]
public enum AssistantSaveResponseServerMessagesItem
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

internal class AssistantSaveResponseServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantSaveResponseServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantSaveResponseServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", AssistantSaveResponseServerMessagesItem.AssistantStarted },
        {
            "assistant.speechStarted",
            AssistantSaveResponseServerMessagesItem.AssistantSpeechStarted
        },
        { "conversation-update", AssistantSaveResponseServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", AssistantSaveResponseServerMessagesItem.EndOfCallReport },
        { "function-call", AssistantSaveResponseServerMessagesItem.FunctionCall },
        { "hang", AssistantSaveResponseServerMessagesItem.Hang },
        { "language-changed", AssistantSaveResponseServerMessagesItem.LanguageChanged },
        {
            "language-change-detected",
            AssistantSaveResponseServerMessagesItem.LanguageChangeDetected
        },
        { "model-output", AssistantSaveResponseServerMessagesItem.ModelOutput },
        { "phone-call-control", AssistantSaveResponseServerMessagesItem.PhoneCallControl },
        { "speech-update", AssistantSaveResponseServerMessagesItem.SpeechUpdate },
        { "status-update", AssistantSaveResponseServerMessagesItem.StatusUpdate },
        { "transcript", AssistantSaveResponseServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            AssistantSaveResponseServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", AssistantSaveResponseServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            AssistantSaveResponseServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            AssistantSaveResponseServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", AssistantSaveResponseServerMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantSaveResponseServerMessagesItem.UserInterrupted },
        { "voice-input", AssistantSaveResponseServerMessagesItem.VoiceInput },
        { "chat.created", AssistantSaveResponseServerMessagesItem.ChatCreated },
        { "chat.deleted", AssistantSaveResponseServerMessagesItem.ChatDeleted },
        { "session.created", AssistantSaveResponseServerMessagesItem.SessionCreated },
        { "session.updated", AssistantSaveResponseServerMessagesItem.SessionUpdated },
        { "session.deleted", AssistantSaveResponseServerMessagesItem.SessionDeleted },
        { "call.deleted", AssistantSaveResponseServerMessagesItem.CallDeleted },
        { "call.delete.failed", AssistantSaveResponseServerMessagesItem.CallDeleteFailed },
        { "call.artifact.upload", AssistantSaveResponseServerMessagesItem.CallArtifactUpload },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantSaveResponseServerMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantSaveResponseServerMessagesItem.AssistantStarted, "assistant.started" },
        {
            AssistantSaveResponseServerMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { AssistantSaveResponseServerMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantSaveResponseServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { AssistantSaveResponseServerMessagesItem.FunctionCall, "function-call" },
        { AssistantSaveResponseServerMessagesItem.Hang, "hang" },
        { AssistantSaveResponseServerMessagesItem.LanguageChanged, "language-changed" },
        {
            AssistantSaveResponseServerMessagesItem.LanguageChangeDetected,
            "language-change-detected"
        },
        { AssistantSaveResponseServerMessagesItem.ModelOutput, "model-output" },
        { AssistantSaveResponseServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { AssistantSaveResponseServerMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantSaveResponseServerMessagesItem.StatusUpdate, "status-update" },
        { AssistantSaveResponseServerMessagesItem.Transcript, "transcript" },
        {
            AssistantSaveResponseServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { AssistantSaveResponseServerMessagesItem.ToolCalls, "tool-calls" },
        {
            AssistantSaveResponseServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            AssistantSaveResponseServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { AssistantSaveResponseServerMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantSaveResponseServerMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantSaveResponseServerMessagesItem.VoiceInput, "voice-input" },
        { AssistantSaveResponseServerMessagesItem.ChatCreated, "chat.created" },
        { AssistantSaveResponseServerMessagesItem.ChatDeleted, "chat.deleted" },
        { AssistantSaveResponseServerMessagesItem.SessionCreated, "session.created" },
        { AssistantSaveResponseServerMessagesItem.SessionUpdated, "session.updated" },
        { AssistantSaveResponseServerMessagesItem.SessionDeleted, "session.deleted" },
        { AssistantSaveResponseServerMessagesItem.CallDeleted, "call.deleted" },
        { AssistantSaveResponseServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
        { AssistantSaveResponseServerMessagesItem.CallArtifactUpload, "call.artifact.upload" },
    };

    public override AssistantSaveResponseServerMessagesItem Read(
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
        AssistantSaveResponseServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantSaveResponseServerMessagesItem ReadAsPropertyName(
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
        AssistantSaveResponseServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
