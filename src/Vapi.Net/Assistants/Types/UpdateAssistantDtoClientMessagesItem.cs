using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDtoClientMessagesItemSerializer))]
public enum UpdateAssistantDtoClientMessagesItem
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

internal class UpdateAssistantDtoClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDtoClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDtoClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", UpdateAssistantDtoClientMessagesItem.ConversationUpdate },
        { "assistant.speechStarted", UpdateAssistantDtoClientMessagesItem.AssistantSpeechStarted },
        { "function-call", UpdateAssistantDtoClientMessagesItem.FunctionCall },
        { "function-call-result", UpdateAssistantDtoClientMessagesItem.FunctionCallResult },
        { "hang", UpdateAssistantDtoClientMessagesItem.Hang },
        { "language-changed", UpdateAssistantDtoClientMessagesItem.LanguageChanged },
        { "metadata", UpdateAssistantDtoClientMessagesItem.Metadata },
        { "model-output", UpdateAssistantDtoClientMessagesItem.ModelOutput },
        { "speech-update", UpdateAssistantDtoClientMessagesItem.SpeechUpdate },
        { "status-update", UpdateAssistantDtoClientMessagesItem.StatusUpdate },
        { "transcript", UpdateAssistantDtoClientMessagesItem.Transcript },
        { "tool-calls", UpdateAssistantDtoClientMessagesItem.ToolCalls },
        { "tool-calls-result", UpdateAssistantDtoClientMessagesItem.ToolCallsResult },
        { "tool.completed", UpdateAssistantDtoClientMessagesItem.ToolCompleted },
        { "transfer-update", UpdateAssistantDtoClientMessagesItem.TransferUpdate },
        { "user-interrupted", UpdateAssistantDtoClientMessagesItem.UserInterrupted },
        { "voice-input", UpdateAssistantDtoClientMessagesItem.VoiceInput },
        { "workflow.node.started", UpdateAssistantDtoClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", UpdateAssistantDtoClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDtoClientMessagesItem,
        string
    > _enumToString = new()
    {
        { UpdateAssistantDtoClientMessagesItem.ConversationUpdate, "conversation-update" },
        { UpdateAssistantDtoClientMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { UpdateAssistantDtoClientMessagesItem.FunctionCall, "function-call" },
        { UpdateAssistantDtoClientMessagesItem.FunctionCallResult, "function-call-result" },
        { UpdateAssistantDtoClientMessagesItem.Hang, "hang" },
        { UpdateAssistantDtoClientMessagesItem.LanguageChanged, "language-changed" },
        { UpdateAssistantDtoClientMessagesItem.Metadata, "metadata" },
        { UpdateAssistantDtoClientMessagesItem.ModelOutput, "model-output" },
        { UpdateAssistantDtoClientMessagesItem.SpeechUpdate, "speech-update" },
        { UpdateAssistantDtoClientMessagesItem.StatusUpdate, "status-update" },
        { UpdateAssistantDtoClientMessagesItem.Transcript, "transcript" },
        { UpdateAssistantDtoClientMessagesItem.ToolCalls, "tool-calls" },
        { UpdateAssistantDtoClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { UpdateAssistantDtoClientMessagesItem.ToolCompleted, "tool.completed" },
        { UpdateAssistantDtoClientMessagesItem.TransferUpdate, "transfer-update" },
        { UpdateAssistantDtoClientMessagesItem.UserInterrupted, "user-interrupted" },
        { UpdateAssistantDtoClientMessagesItem.VoiceInput, "voice-input" },
        { UpdateAssistantDtoClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { UpdateAssistantDtoClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override UpdateAssistantDtoClientMessagesItem Read(
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
        UpdateAssistantDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDtoClientMessagesItem ReadAsPropertyName(
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
        UpdateAssistantDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
