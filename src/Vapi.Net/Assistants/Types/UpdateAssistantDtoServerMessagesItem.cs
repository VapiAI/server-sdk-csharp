using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDtoServerMessagesItemSerializer))]
public enum UpdateAssistantDtoServerMessagesItem
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
}

internal class UpdateAssistantDtoServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDtoServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDtoServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", UpdateAssistantDtoServerMessagesItem.AssistantStarted },
        { "assistant.speechStarted", UpdateAssistantDtoServerMessagesItem.AssistantSpeechStarted },
        { "conversation-update", UpdateAssistantDtoServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", UpdateAssistantDtoServerMessagesItem.EndOfCallReport },
        { "function-call", UpdateAssistantDtoServerMessagesItem.FunctionCall },
        { "hang", UpdateAssistantDtoServerMessagesItem.Hang },
        { "language-changed", UpdateAssistantDtoServerMessagesItem.LanguageChanged },
        { "language-change-detected", UpdateAssistantDtoServerMessagesItem.LanguageChangeDetected },
        { "model-output", UpdateAssistantDtoServerMessagesItem.ModelOutput },
        { "phone-call-control", UpdateAssistantDtoServerMessagesItem.PhoneCallControl },
        { "speech-update", UpdateAssistantDtoServerMessagesItem.SpeechUpdate },
        { "status-update", UpdateAssistantDtoServerMessagesItem.StatusUpdate },
        { "transcript", UpdateAssistantDtoServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            UpdateAssistantDtoServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", UpdateAssistantDtoServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            UpdateAssistantDtoServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            UpdateAssistantDtoServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", UpdateAssistantDtoServerMessagesItem.TransferUpdate },
        { "user-interrupted", UpdateAssistantDtoServerMessagesItem.UserInterrupted },
        { "voice-input", UpdateAssistantDtoServerMessagesItem.VoiceInput },
        { "chat.created", UpdateAssistantDtoServerMessagesItem.ChatCreated },
        { "chat.deleted", UpdateAssistantDtoServerMessagesItem.ChatDeleted },
        { "session.created", UpdateAssistantDtoServerMessagesItem.SessionCreated },
        { "session.updated", UpdateAssistantDtoServerMessagesItem.SessionUpdated },
        { "session.deleted", UpdateAssistantDtoServerMessagesItem.SessionDeleted },
        { "call.deleted", UpdateAssistantDtoServerMessagesItem.CallDeleted },
        { "call.delete.failed", UpdateAssistantDtoServerMessagesItem.CallDeleteFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDtoServerMessagesItem,
        string
    > _enumToString = new()
    {
        { UpdateAssistantDtoServerMessagesItem.AssistantStarted, "assistant.started" },
        { UpdateAssistantDtoServerMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { UpdateAssistantDtoServerMessagesItem.ConversationUpdate, "conversation-update" },
        { UpdateAssistantDtoServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { UpdateAssistantDtoServerMessagesItem.FunctionCall, "function-call" },
        { UpdateAssistantDtoServerMessagesItem.Hang, "hang" },
        { UpdateAssistantDtoServerMessagesItem.LanguageChanged, "language-changed" },
        { UpdateAssistantDtoServerMessagesItem.LanguageChangeDetected, "language-change-detected" },
        { UpdateAssistantDtoServerMessagesItem.ModelOutput, "model-output" },
        { UpdateAssistantDtoServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { UpdateAssistantDtoServerMessagesItem.SpeechUpdate, "speech-update" },
        { UpdateAssistantDtoServerMessagesItem.StatusUpdate, "status-update" },
        { UpdateAssistantDtoServerMessagesItem.Transcript, "transcript" },
        {
            UpdateAssistantDtoServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { UpdateAssistantDtoServerMessagesItem.ToolCalls, "tool-calls" },
        {
            UpdateAssistantDtoServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            UpdateAssistantDtoServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { UpdateAssistantDtoServerMessagesItem.TransferUpdate, "transfer-update" },
        { UpdateAssistantDtoServerMessagesItem.UserInterrupted, "user-interrupted" },
        { UpdateAssistantDtoServerMessagesItem.VoiceInput, "voice-input" },
        { UpdateAssistantDtoServerMessagesItem.ChatCreated, "chat.created" },
        { UpdateAssistantDtoServerMessagesItem.ChatDeleted, "chat.deleted" },
        { UpdateAssistantDtoServerMessagesItem.SessionCreated, "session.created" },
        { UpdateAssistantDtoServerMessagesItem.SessionUpdated, "session.updated" },
        { UpdateAssistantDtoServerMessagesItem.SessionDeleted, "session.deleted" },
        { UpdateAssistantDtoServerMessagesItem.CallDeleted, "call.deleted" },
        { UpdateAssistantDtoServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
    };

    public override UpdateAssistantDtoServerMessagesItem Read(
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
        UpdateAssistantDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDtoServerMessagesItem ReadAsPropertyName(
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
        UpdateAssistantDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
