using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantVersionServerMessagesItemSerializer))]
public enum AssistantVersionServerMessagesItem
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

internal class AssistantVersionServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantVersionServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantVersionServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", AssistantVersionServerMessagesItem.AssistantStarted },
        { "assistant.speechStarted", AssistantVersionServerMessagesItem.AssistantSpeechStarted },
        { "conversation-update", AssistantVersionServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", AssistantVersionServerMessagesItem.EndOfCallReport },
        { "function-call", AssistantVersionServerMessagesItem.FunctionCall },
        { "hang", AssistantVersionServerMessagesItem.Hang },
        { "language-changed", AssistantVersionServerMessagesItem.LanguageChanged },
        { "language-change-detected", AssistantVersionServerMessagesItem.LanguageChangeDetected },
        { "model-output", AssistantVersionServerMessagesItem.ModelOutput },
        { "phone-call-control", AssistantVersionServerMessagesItem.PhoneCallControl },
        { "speech-update", AssistantVersionServerMessagesItem.SpeechUpdate },
        { "status-update", AssistantVersionServerMessagesItem.StatusUpdate },
        { "transcript", AssistantVersionServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            AssistantVersionServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", AssistantVersionServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            AssistantVersionServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            AssistantVersionServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", AssistantVersionServerMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantVersionServerMessagesItem.UserInterrupted },
        { "voice-input", AssistantVersionServerMessagesItem.VoiceInput },
        { "chat.created", AssistantVersionServerMessagesItem.ChatCreated },
        { "chat.deleted", AssistantVersionServerMessagesItem.ChatDeleted },
        { "session.created", AssistantVersionServerMessagesItem.SessionCreated },
        { "session.updated", AssistantVersionServerMessagesItem.SessionUpdated },
        { "session.deleted", AssistantVersionServerMessagesItem.SessionDeleted },
        { "call.deleted", AssistantVersionServerMessagesItem.CallDeleted },
        { "call.delete.failed", AssistantVersionServerMessagesItem.CallDeleteFailed },
        { "call.artifact.upload", AssistantVersionServerMessagesItem.CallArtifactUpload },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantVersionServerMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantVersionServerMessagesItem.AssistantStarted, "assistant.started" },
        { AssistantVersionServerMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantVersionServerMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantVersionServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { AssistantVersionServerMessagesItem.FunctionCall, "function-call" },
        { AssistantVersionServerMessagesItem.Hang, "hang" },
        { AssistantVersionServerMessagesItem.LanguageChanged, "language-changed" },
        { AssistantVersionServerMessagesItem.LanguageChangeDetected, "language-change-detected" },
        { AssistantVersionServerMessagesItem.ModelOutput, "model-output" },
        { AssistantVersionServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { AssistantVersionServerMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantVersionServerMessagesItem.StatusUpdate, "status-update" },
        { AssistantVersionServerMessagesItem.Transcript, "transcript" },
        {
            AssistantVersionServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { AssistantVersionServerMessagesItem.ToolCalls, "tool-calls" },
        {
            AssistantVersionServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            AssistantVersionServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { AssistantVersionServerMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantVersionServerMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantVersionServerMessagesItem.VoiceInput, "voice-input" },
        { AssistantVersionServerMessagesItem.ChatCreated, "chat.created" },
        { AssistantVersionServerMessagesItem.ChatDeleted, "chat.deleted" },
        { AssistantVersionServerMessagesItem.SessionCreated, "session.created" },
        { AssistantVersionServerMessagesItem.SessionUpdated, "session.updated" },
        { AssistantVersionServerMessagesItem.SessionDeleted, "session.deleted" },
        { AssistantVersionServerMessagesItem.CallDeleted, "call.deleted" },
        { AssistantVersionServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
        { AssistantVersionServerMessagesItem.CallArtifactUpload, "call.artifact.upload" },
    };

    public override AssistantVersionServerMessagesItem Read(
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
        AssistantVersionServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantVersionServerMessagesItem ReadAsPropertyName(
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
        AssistantVersionServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
