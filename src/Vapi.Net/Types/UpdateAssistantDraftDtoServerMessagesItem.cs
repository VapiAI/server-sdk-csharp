using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDraftDtoServerMessagesItemSerializer))]
public enum UpdateAssistantDraftDtoServerMessagesItem
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

internal class UpdateAssistantDraftDtoServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDraftDtoServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDraftDtoServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", UpdateAssistantDraftDtoServerMessagesItem.AssistantStarted },
        {
            "assistant.speechStarted",
            UpdateAssistantDraftDtoServerMessagesItem.AssistantSpeechStarted
        },
        { "conversation-update", UpdateAssistantDraftDtoServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", UpdateAssistantDraftDtoServerMessagesItem.EndOfCallReport },
        { "function-call", UpdateAssistantDraftDtoServerMessagesItem.FunctionCall },
        { "hang", UpdateAssistantDraftDtoServerMessagesItem.Hang },
        { "language-changed", UpdateAssistantDraftDtoServerMessagesItem.LanguageChanged },
        {
            "language-change-detected",
            UpdateAssistantDraftDtoServerMessagesItem.LanguageChangeDetected
        },
        { "model-output", UpdateAssistantDraftDtoServerMessagesItem.ModelOutput },
        { "phone-call-control", UpdateAssistantDraftDtoServerMessagesItem.PhoneCallControl },
        { "speech-update", UpdateAssistantDraftDtoServerMessagesItem.SpeechUpdate },
        { "status-update", UpdateAssistantDraftDtoServerMessagesItem.StatusUpdate },
        { "transcript", UpdateAssistantDraftDtoServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            UpdateAssistantDraftDtoServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", UpdateAssistantDraftDtoServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            UpdateAssistantDraftDtoServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            UpdateAssistantDraftDtoServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", UpdateAssistantDraftDtoServerMessagesItem.TransferUpdate },
        { "user-interrupted", UpdateAssistantDraftDtoServerMessagesItem.UserInterrupted },
        { "voice-input", UpdateAssistantDraftDtoServerMessagesItem.VoiceInput },
        { "chat.created", UpdateAssistantDraftDtoServerMessagesItem.ChatCreated },
        { "chat.deleted", UpdateAssistantDraftDtoServerMessagesItem.ChatDeleted },
        { "session.created", UpdateAssistantDraftDtoServerMessagesItem.SessionCreated },
        { "session.updated", UpdateAssistantDraftDtoServerMessagesItem.SessionUpdated },
        { "session.deleted", UpdateAssistantDraftDtoServerMessagesItem.SessionDeleted },
        { "call.deleted", UpdateAssistantDraftDtoServerMessagesItem.CallDeleted },
        { "call.delete.failed", UpdateAssistantDraftDtoServerMessagesItem.CallDeleteFailed },
        { "call.artifact.upload", UpdateAssistantDraftDtoServerMessagesItem.CallArtifactUpload },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDraftDtoServerMessagesItem,
        string
    > _enumToString = new()
    {
        { UpdateAssistantDraftDtoServerMessagesItem.AssistantStarted, "assistant.started" },
        {
            UpdateAssistantDraftDtoServerMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { UpdateAssistantDraftDtoServerMessagesItem.ConversationUpdate, "conversation-update" },
        { UpdateAssistantDraftDtoServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { UpdateAssistantDraftDtoServerMessagesItem.FunctionCall, "function-call" },
        { UpdateAssistantDraftDtoServerMessagesItem.Hang, "hang" },
        { UpdateAssistantDraftDtoServerMessagesItem.LanguageChanged, "language-changed" },
        {
            UpdateAssistantDraftDtoServerMessagesItem.LanguageChangeDetected,
            "language-change-detected"
        },
        { UpdateAssistantDraftDtoServerMessagesItem.ModelOutput, "model-output" },
        { UpdateAssistantDraftDtoServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { UpdateAssistantDraftDtoServerMessagesItem.SpeechUpdate, "speech-update" },
        { UpdateAssistantDraftDtoServerMessagesItem.StatusUpdate, "status-update" },
        { UpdateAssistantDraftDtoServerMessagesItem.Transcript, "transcript" },
        {
            UpdateAssistantDraftDtoServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { UpdateAssistantDraftDtoServerMessagesItem.ToolCalls, "tool-calls" },
        {
            UpdateAssistantDraftDtoServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            UpdateAssistantDraftDtoServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { UpdateAssistantDraftDtoServerMessagesItem.TransferUpdate, "transfer-update" },
        { UpdateAssistantDraftDtoServerMessagesItem.UserInterrupted, "user-interrupted" },
        { UpdateAssistantDraftDtoServerMessagesItem.VoiceInput, "voice-input" },
        { UpdateAssistantDraftDtoServerMessagesItem.ChatCreated, "chat.created" },
        { UpdateAssistantDraftDtoServerMessagesItem.ChatDeleted, "chat.deleted" },
        { UpdateAssistantDraftDtoServerMessagesItem.SessionCreated, "session.created" },
        { UpdateAssistantDraftDtoServerMessagesItem.SessionUpdated, "session.updated" },
        { UpdateAssistantDraftDtoServerMessagesItem.SessionDeleted, "session.deleted" },
        { UpdateAssistantDraftDtoServerMessagesItem.CallDeleted, "call.deleted" },
        { UpdateAssistantDraftDtoServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
        { UpdateAssistantDraftDtoServerMessagesItem.CallArtifactUpload, "call.artifact.upload" },
    };

    public override UpdateAssistantDraftDtoServerMessagesItem Read(
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
        UpdateAssistantDraftDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDraftDtoServerMessagesItem ReadAsPropertyName(
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
        UpdateAssistantDraftDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
