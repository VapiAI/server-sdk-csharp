using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantOverridesServerMessagesItemSerializer))]
public enum AssistantOverridesServerMessagesItem
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

internal class AssistantOverridesServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantOverridesServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantOverridesServerMessagesItem
    > _stringToEnum = new()
    {
        { "assistant.started", AssistantOverridesServerMessagesItem.AssistantStarted },
        { "assistant.speechStarted", AssistantOverridesServerMessagesItem.AssistantSpeechStarted },
        { "conversation-update", AssistantOverridesServerMessagesItem.ConversationUpdate },
        { "end-of-call-report", AssistantOverridesServerMessagesItem.EndOfCallReport },
        { "function-call", AssistantOverridesServerMessagesItem.FunctionCall },
        { "hang", AssistantOverridesServerMessagesItem.Hang },
        { "language-changed", AssistantOverridesServerMessagesItem.LanguageChanged },
        { "language-change-detected", AssistantOverridesServerMessagesItem.LanguageChangeDetected },
        { "model-output", AssistantOverridesServerMessagesItem.ModelOutput },
        { "phone-call-control", AssistantOverridesServerMessagesItem.PhoneCallControl },
        { "speech-update", AssistantOverridesServerMessagesItem.SpeechUpdate },
        { "status-update", AssistantOverridesServerMessagesItem.StatusUpdate },
        { "transcript", AssistantOverridesServerMessagesItem.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            AssistantOverridesServerMessagesItem.TranscriptTranscriptTypeFinal
        },
        { "tool-calls", AssistantOverridesServerMessagesItem.ToolCalls },
        {
            "transfer-destination-request",
            AssistantOverridesServerMessagesItem.TransferDestinationRequest
        },
        {
            "handoff-destination-request",
            AssistantOverridesServerMessagesItem.HandoffDestinationRequest
        },
        { "transfer-update", AssistantOverridesServerMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantOverridesServerMessagesItem.UserInterrupted },
        { "voice-input", AssistantOverridesServerMessagesItem.VoiceInput },
        { "chat.created", AssistantOverridesServerMessagesItem.ChatCreated },
        { "chat.deleted", AssistantOverridesServerMessagesItem.ChatDeleted },
        { "session.created", AssistantOverridesServerMessagesItem.SessionCreated },
        { "session.updated", AssistantOverridesServerMessagesItem.SessionUpdated },
        { "session.deleted", AssistantOverridesServerMessagesItem.SessionDeleted },
        { "call.deleted", AssistantOverridesServerMessagesItem.CallDeleted },
        { "call.delete.failed", AssistantOverridesServerMessagesItem.CallDeleteFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantOverridesServerMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantOverridesServerMessagesItem.AssistantStarted, "assistant.started" },
        { AssistantOverridesServerMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantOverridesServerMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantOverridesServerMessagesItem.EndOfCallReport, "end-of-call-report" },
        { AssistantOverridesServerMessagesItem.FunctionCall, "function-call" },
        { AssistantOverridesServerMessagesItem.Hang, "hang" },
        { AssistantOverridesServerMessagesItem.LanguageChanged, "language-changed" },
        { AssistantOverridesServerMessagesItem.LanguageChangeDetected, "language-change-detected" },
        { AssistantOverridesServerMessagesItem.ModelOutput, "model-output" },
        { AssistantOverridesServerMessagesItem.PhoneCallControl, "phone-call-control" },
        { AssistantOverridesServerMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantOverridesServerMessagesItem.StatusUpdate, "status-update" },
        { AssistantOverridesServerMessagesItem.Transcript, "transcript" },
        {
            AssistantOverridesServerMessagesItem.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
        { AssistantOverridesServerMessagesItem.ToolCalls, "tool-calls" },
        {
            AssistantOverridesServerMessagesItem.TransferDestinationRequest,
            "transfer-destination-request"
        },
        {
            AssistantOverridesServerMessagesItem.HandoffDestinationRequest,
            "handoff-destination-request"
        },
        { AssistantOverridesServerMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantOverridesServerMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantOverridesServerMessagesItem.VoiceInput, "voice-input" },
        { AssistantOverridesServerMessagesItem.ChatCreated, "chat.created" },
        { AssistantOverridesServerMessagesItem.ChatDeleted, "chat.deleted" },
        { AssistantOverridesServerMessagesItem.SessionCreated, "session.created" },
        { AssistantOverridesServerMessagesItem.SessionUpdated, "session.updated" },
        { AssistantOverridesServerMessagesItem.SessionDeleted, "session.deleted" },
        { AssistantOverridesServerMessagesItem.CallDeleted, "call.deleted" },
        { AssistantOverridesServerMessagesItem.CallDeleteFailed, "call.delete.failed" },
    };

    public override AssistantOverridesServerMessagesItem Read(
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
        AssistantOverridesServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantOverridesServerMessagesItem ReadAsPropertyName(
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
        AssistantOverridesServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
