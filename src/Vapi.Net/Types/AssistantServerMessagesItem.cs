using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantServerMessagesItemSerializer))]
public enum AssistantServerMessagesItem
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

internal class AssistantServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", AssistantServerMessagesItem.AssistantStarted },
        { "assistant.speechStarted", AssistantServerMessagesItem.AssistantSpeechStarted },
        { "conversation-update", AssistantServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", AssistantServerMessagesItem.EndOfCallReport },
        { "function-call", AssistantServerMessagesItem.FunctionCall },
        { "hang", AssistantServerMessagesItem.Hang },
        { "language-changed", AssistantServerMessagesItem.LanguageChanged },
        { "language-change-detected", AssistantServerMessagesItem.LanguageChangeDetected },
        { "model-output", AssistantServerMessagesItem.ModelOutput },
        { "phone-call-control", AssistantServerMessagesItem.PhoneCallControl },
        { "speech-update", AssistantServerMessagesItem.SpeechUpdate },
        { "status-update", AssistantServerMessagesItem.StatusUpdate },
        { "transcript", AssistantServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            AssistantServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", AssistantServerMessagesItem.ToolCalls },
        { "transfer-destination-request", AssistantServerMessagesItem.TransferDestinationRequest },
        { "handoff-destination-request", AssistantServerMessagesItem.HandoffDestinationRequest },
        { "transfer-update", AssistantServerMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantServerMessagesItem.UserInterrupted },
        { "voice-input", AssistantServerMessagesItem.VoiceInput },
        { "chat.created", AssistantServerMessagesItem.ChatCreated },
        { "chat.deleted", AssistantServerMessagesItem.ChatDeleted },
        { "session.created", AssistantServerMessagesItem.SessionCreated },
        { "session.updated", AssistantServerMessagesItem.SessionUpdated },
        { "session.deleted", AssistantServerMessagesItem.SessionDeleted },
        { "call.deleted", AssistantServerMessagesItem.CallDeleted },
        { "call.delete.failed", AssistantServerMessagesItem.CallDeleteFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantServerMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantServerMessagesItem.AssistantStarted, "assistant.started" },
        { AssistantServerMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantServerMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { AssistantServerMessagesItem.FunctionCall, "function-call" },
        { AssistantServerMessagesItem.Hang, "hang" },
        { AssistantServerMessagesItem.LanguageChanged, "language-changed" },
        { AssistantServerMessagesItem.LanguageChangeDetected, "language-change-detected" },
        { AssistantServerMessagesItem.ModelOutput, "model-output" },
        { AssistantServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { AssistantServerMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantServerMessagesItem.StatusUpdate, "status-update" },
        { AssistantServerMessagesItem.Transcript, "transcript" },
        {
            AssistantServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { AssistantServerMessagesItem.ToolCalls, "tool-calls" },
        { AssistantServerMessagesItem.TransferDestinationRequest, "transfer-destination-request" },
        { AssistantServerMessagesItem.HandoffDestinationRequest, "handoff-destination-request" },
        { AssistantServerMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantServerMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantServerMessagesItem.VoiceInput, "voice-input" },
        { AssistantServerMessagesItem.ChatCreated, "chat.created" },
        { AssistantServerMessagesItem.ChatDeleted, "chat.deleted" },
        { AssistantServerMessagesItem.SessionCreated, "session.created" },
        { AssistantServerMessagesItem.SessionUpdated, "session.updated" },
        { AssistantServerMessagesItem.SessionDeleted, "session.deleted" },
        { AssistantServerMessagesItem.CallDeleted, "call.deleted" },
        { AssistantServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
    };

    public override AssistantServerMessagesItem Read(
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
        AssistantServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantServerMessagesItem ReadAsPropertyName(
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
        AssistantServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
