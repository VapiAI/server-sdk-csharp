using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDraftDtoClientMessagesItemSerializer))]
public enum UpdateAssistantDraftDtoClientMessagesItem
{
    [EnumMember(Value = "conversation-update")]
    ConversationUpdate,

    [EnumMember(Value = "assistant.speechStarted")]
    AssistantSpeechStarted,

    [EnumMember(Value = "function-call")]
    FunctionCall,

    [EnumMember(Value = "function-call-result")]
    FunctionCallResult,

    [EnumMember(Value = "hang")]
    Hang,

    [EnumMember(Value = "language-changed")]
    LanguageChanged,

    [EnumMember(Value = "metadata")]
    Metadata,

    [EnumMember(Value = "model-output")]
    ModelOutput,

    [EnumMember(Value = "speech-update")]
    SpeechUpdate,

    [EnumMember(Value = "status-update")]
    StatusUpdate,

    [EnumMember(Value = "transcript")]
    Transcript,

    [EnumMember(Value = "tool-calls")]
    ToolCalls,

    [EnumMember(Value = "tool-calls-result")]
    ToolCallsResult,

    [EnumMember(Value = "tool.completed")]
    ToolCompleted,

    [EnumMember(Value = "transfer-update")]
    TransferUpdate,

    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,

    [EnumMember(Value = "voice-input")]
    VoiceInput,

    [EnumMember(Value = "workflow.node.started")]
    WorkflowNodeStarted,

    [EnumMember(Value = "assistant.started")]
    AssistantStarted,
}

internal class UpdateAssistantDraftDtoClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDraftDtoClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDraftDtoClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", UpdateAssistantDraftDtoClientMessagesItem.ConversationUpdate },
        {
            "assistant.speechStarted",
            UpdateAssistantDraftDtoClientMessagesItem.AssistantSpeechStarted
        },
        { "function-call", UpdateAssistantDraftDtoClientMessagesItem.FunctionCall },
        { "function-call-result", UpdateAssistantDraftDtoClientMessagesItem.FunctionCallResult },
        { "hang", UpdateAssistantDraftDtoClientMessagesItem.Hang },
        { "language-changed", UpdateAssistantDraftDtoClientMessagesItem.LanguageChanged },
        { "metadata", UpdateAssistantDraftDtoClientMessagesItem.Metadata },
        { "model-output", UpdateAssistantDraftDtoClientMessagesItem.ModelOutput },
        { "speech-update", UpdateAssistantDraftDtoClientMessagesItem.SpeechUpdate },
        { "status-update", UpdateAssistantDraftDtoClientMessagesItem.StatusUpdate },
        { "transcript", UpdateAssistantDraftDtoClientMessagesItem.Transcript },
        { "tool-calls", UpdateAssistantDraftDtoClientMessagesItem.ToolCalls },
        { "tool-calls-result", UpdateAssistantDraftDtoClientMessagesItem.ToolCallsResult },
        { "tool.completed", UpdateAssistantDraftDtoClientMessagesItem.ToolCompleted },
        { "transfer-update", UpdateAssistantDraftDtoClientMessagesItem.TransferUpdate },
        { "user-interrupted", UpdateAssistantDraftDtoClientMessagesItem.UserInterrupted },
        { "voice-input", UpdateAssistantDraftDtoClientMessagesItem.VoiceInput },
        { "workflow.node.started", UpdateAssistantDraftDtoClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", UpdateAssistantDraftDtoClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDraftDtoClientMessagesItem,
        string
    > _enumToString = new()
    {
        { UpdateAssistantDraftDtoClientMessagesItem.ConversationUpdate, "conversation-update" },
        {
            UpdateAssistantDraftDtoClientMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { UpdateAssistantDraftDtoClientMessagesItem.FunctionCall, "function-call" },
        { UpdateAssistantDraftDtoClientMessagesItem.FunctionCallResult, "function-call-result" },
        { UpdateAssistantDraftDtoClientMessagesItem.Hang, "hang" },
        { UpdateAssistantDraftDtoClientMessagesItem.LanguageChanged, "language-changed" },
        { UpdateAssistantDraftDtoClientMessagesItem.Metadata, "metadata" },
        { UpdateAssistantDraftDtoClientMessagesItem.ModelOutput, "model-output" },
        { UpdateAssistantDraftDtoClientMessagesItem.SpeechUpdate, "speech-update" },
        { UpdateAssistantDraftDtoClientMessagesItem.StatusUpdate, "status-update" },
        { UpdateAssistantDraftDtoClientMessagesItem.Transcript, "transcript" },
        { UpdateAssistantDraftDtoClientMessagesItem.ToolCalls, "tool-calls" },
        { UpdateAssistantDraftDtoClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { UpdateAssistantDraftDtoClientMessagesItem.ToolCompleted, "tool.completed" },
        { UpdateAssistantDraftDtoClientMessagesItem.TransferUpdate, "transfer-update" },
        { UpdateAssistantDraftDtoClientMessagesItem.UserInterrupted, "user-interrupted" },
        { UpdateAssistantDraftDtoClientMessagesItem.VoiceInput, "voice-input" },
        { UpdateAssistantDraftDtoClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { UpdateAssistantDraftDtoClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override UpdateAssistantDraftDtoClientMessagesItem Read(
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
        UpdateAssistantDraftDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDraftDtoClientMessagesItem ReadAsPropertyName(
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
        UpdateAssistantDraftDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
