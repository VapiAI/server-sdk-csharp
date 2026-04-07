using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDtoServerMessagesItemSerializer))]
public enum CreateAssistantDtoServerMessagesItem
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

internal class CreateAssistantDtoServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDtoServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDtoServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", CreateAssistantDtoServerMessagesItem.AssistantStarted },
        { "assistant.speechStarted", CreateAssistantDtoServerMessagesItem.AssistantSpeechStarted },
        { "conversation-update", CreateAssistantDtoServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", CreateAssistantDtoServerMessagesItem.EndOfCallReport },
        { "function-call", CreateAssistantDtoServerMessagesItem.FunctionCall },
        { "hang", CreateAssistantDtoServerMessagesItem.Hang },
        { "language-changed", CreateAssistantDtoServerMessagesItem.LanguageChanged },
        { "language-change-detected", CreateAssistantDtoServerMessagesItem.LanguageChangeDetected },
        { "model-output", CreateAssistantDtoServerMessagesItem.ModelOutput },
        { "phone-call-control", CreateAssistantDtoServerMessagesItem.PhoneCallControl },
        { "speech-update", CreateAssistantDtoServerMessagesItem.SpeechUpdate },
        { "status-update", CreateAssistantDtoServerMessagesItem.StatusUpdate },
        { "transcript", CreateAssistantDtoServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            CreateAssistantDtoServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", CreateAssistantDtoServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            CreateAssistantDtoServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            CreateAssistantDtoServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", CreateAssistantDtoServerMessagesItem.TransferUpdate },
        { "user-interrupted", CreateAssistantDtoServerMessagesItem.UserInterrupted },
        { "voice-input", CreateAssistantDtoServerMessagesItem.VoiceInput },
        { "chat.created", CreateAssistantDtoServerMessagesItem.ChatCreated },
        { "chat.deleted", CreateAssistantDtoServerMessagesItem.ChatDeleted },
        { "session.created", CreateAssistantDtoServerMessagesItem.SessionCreated },
        { "session.updated", CreateAssistantDtoServerMessagesItem.SessionUpdated },
        { "session.deleted", CreateAssistantDtoServerMessagesItem.SessionDeleted },
        { "call.deleted", CreateAssistantDtoServerMessagesItem.CallDeleted },
        { "call.delete.failed", CreateAssistantDtoServerMessagesItem.CallDeleteFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDtoServerMessagesItem,
        string
    > _enumToString = new()
    {
        { CreateAssistantDtoServerMessagesItem.AssistantStarted, "assistant.started" },
        { CreateAssistantDtoServerMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { CreateAssistantDtoServerMessagesItem.ConversationUpdate, "conversation-update" },
        { CreateAssistantDtoServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { CreateAssistantDtoServerMessagesItem.FunctionCall, "function-call" },
        { CreateAssistantDtoServerMessagesItem.Hang, "hang" },
        { CreateAssistantDtoServerMessagesItem.LanguageChanged, "language-changed" },
        { CreateAssistantDtoServerMessagesItem.LanguageChangeDetected, "language-change-detected" },
        { CreateAssistantDtoServerMessagesItem.ModelOutput, "model-output" },
        { CreateAssistantDtoServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { CreateAssistantDtoServerMessagesItem.SpeechUpdate, "speech-update" },
        { CreateAssistantDtoServerMessagesItem.StatusUpdate, "status-update" },
        { CreateAssistantDtoServerMessagesItem.Transcript, "transcript" },
        {
            CreateAssistantDtoServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { CreateAssistantDtoServerMessagesItem.ToolCalls, "tool-calls" },
        {
            CreateAssistantDtoServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            CreateAssistantDtoServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { CreateAssistantDtoServerMessagesItem.TransferUpdate, "transfer-update" },
        { CreateAssistantDtoServerMessagesItem.UserInterrupted, "user-interrupted" },
        { CreateAssistantDtoServerMessagesItem.VoiceInput, "voice-input" },
        { CreateAssistantDtoServerMessagesItem.ChatCreated, "chat.created" },
        { CreateAssistantDtoServerMessagesItem.ChatDeleted, "chat.deleted" },
        { CreateAssistantDtoServerMessagesItem.SessionCreated, "session.created" },
        { CreateAssistantDtoServerMessagesItem.SessionUpdated, "session.updated" },
        { CreateAssistantDtoServerMessagesItem.SessionDeleted, "session.deleted" },
        { CreateAssistantDtoServerMessagesItem.CallDeleted, "call.deleted" },
        { CreateAssistantDtoServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
    };

    public override CreateAssistantDtoServerMessagesItem Read(
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
        CreateAssistantDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDtoServerMessagesItem ReadAsPropertyName(
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
        CreateAssistantDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
