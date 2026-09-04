using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDraftDtoServerMessagesItemSerializer))]
public enum CreateAssistantDraftDtoServerMessagesItem
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

internal class CreateAssistantDraftDtoServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDraftDtoServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDraftDtoServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", CreateAssistantDraftDtoServerMessagesItem.AssistantStarted },
        {
            "assistant.speechStarted",
            CreateAssistantDraftDtoServerMessagesItem.AssistantSpeechStarted
        },
        { "conversation-update", CreateAssistantDraftDtoServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", CreateAssistantDraftDtoServerMessagesItem.EndOfCallReport },
        { "function-call", CreateAssistantDraftDtoServerMessagesItem.FunctionCall },
        { "hang", CreateAssistantDraftDtoServerMessagesItem.Hang },
        { "language-changed", CreateAssistantDraftDtoServerMessagesItem.LanguageChanged },
        {
            "language-change-detected",
            CreateAssistantDraftDtoServerMessagesItem.LanguageChangeDetected
        },
        { "model-output", CreateAssistantDraftDtoServerMessagesItem.ModelOutput },
        { "phone-call-control", CreateAssistantDraftDtoServerMessagesItem.PhoneCallControl },
        { "speech-update", CreateAssistantDraftDtoServerMessagesItem.SpeechUpdate },
        { "status-update", CreateAssistantDraftDtoServerMessagesItem.StatusUpdate },
        { "transcript", CreateAssistantDraftDtoServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            CreateAssistantDraftDtoServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", CreateAssistantDraftDtoServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            CreateAssistantDraftDtoServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            CreateAssistantDraftDtoServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", CreateAssistantDraftDtoServerMessagesItem.TransferUpdate },
        { "user-interrupted", CreateAssistantDraftDtoServerMessagesItem.UserInterrupted },
        { "voice-input", CreateAssistantDraftDtoServerMessagesItem.VoiceInput },
        { "chat.created", CreateAssistantDraftDtoServerMessagesItem.ChatCreated },
        { "chat.deleted", CreateAssistantDraftDtoServerMessagesItem.ChatDeleted },
        { "session.created", CreateAssistantDraftDtoServerMessagesItem.SessionCreated },
        { "session.updated", CreateAssistantDraftDtoServerMessagesItem.SessionUpdated },
        { "session.deleted", CreateAssistantDraftDtoServerMessagesItem.SessionDeleted },
        { "call.deleted", CreateAssistantDraftDtoServerMessagesItem.CallDeleted },
        { "call.delete.failed", CreateAssistantDraftDtoServerMessagesItem.CallDeleteFailed },
        { "call.artifact.upload", CreateAssistantDraftDtoServerMessagesItem.CallArtifactUpload },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDraftDtoServerMessagesItem,
        string
    > _enumToString = new()
    {
        { CreateAssistantDraftDtoServerMessagesItem.AssistantStarted, "assistant.started" },
        {
            CreateAssistantDraftDtoServerMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { CreateAssistantDraftDtoServerMessagesItem.ConversationUpdate, "conversation-update" },
        { CreateAssistantDraftDtoServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { CreateAssistantDraftDtoServerMessagesItem.FunctionCall, "function-call" },
        { CreateAssistantDraftDtoServerMessagesItem.Hang, "hang" },
        { CreateAssistantDraftDtoServerMessagesItem.LanguageChanged, "language-changed" },
        {
            CreateAssistantDraftDtoServerMessagesItem.LanguageChangeDetected,
            "language-change-detected"
        },
        { CreateAssistantDraftDtoServerMessagesItem.ModelOutput, "model-output" },
        { CreateAssistantDraftDtoServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { CreateAssistantDraftDtoServerMessagesItem.SpeechUpdate, "speech-update" },
        { CreateAssistantDraftDtoServerMessagesItem.StatusUpdate, "status-update" },
        { CreateAssistantDraftDtoServerMessagesItem.Transcript, "transcript" },
        {
            CreateAssistantDraftDtoServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { CreateAssistantDraftDtoServerMessagesItem.ToolCalls, "tool-calls" },
        {
            CreateAssistantDraftDtoServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            CreateAssistantDraftDtoServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { CreateAssistantDraftDtoServerMessagesItem.TransferUpdate, "transfer-update" },
        { CreateAssistantDraftDtoServerMessagesItem.UserInterrupted, "user-interrupted" },
        { CreateAssistantDraftDtoServerMessagesItem.VoiceInput, "voice-input" },
        { CreateAssistantDraftDtoServerMessagesItem.ChatCreated, "chat.created" },
        { CreateAssistantDraftDtoServerMessagesItem.ChatDeleted, "chat.deleted" },
        { CreateAssistantDraftDtoServerMessagesItem.SessionCreated, "session.created" },
        { CreateAssistantDraftDtoServerMessagesItem.SessionUpdated, "session.updated" },
        { CreateAssistantDraftDtoServerMessagesItem.SessionDeleted, "session.deleted" },
        { CreateAssistantDraftDtoServerMessagesItem.CallDeleted, "call.deleted" },
        { CreateAssistantDraftDtoServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
        { CreateAssistantDraftDtoServerMessagesItem.CallArtifactUpload, "call.artifact.upload" },
    };

    public override CreateAssistantDraftDtoServerMessagesItem Read(
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
        CreateAssistantDraftDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDraftDtoServerMessagesItem ReadAsPropertyName(
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
        CreateAssistantDraftDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
