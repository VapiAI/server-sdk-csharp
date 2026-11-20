using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransientAssistantDtoClientMessagesItemSerializer))]
public enum TransientAssistantDtoClientMessagesItem
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

internal class TransientAssistantDtoClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransientAssistantDtoClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransientAssistantDtoClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", TransientAssistantDtoClientMessagesItem.ConversationUpdate },
        {
            "assistant.speechStarted",
            TransientAssistantDtoClientMessagesItem.AssistantSpeechStarted
        },
        { "function-call", TransientAssistantDtoClientMessagesItem.FunctionCall },
        { "function-call-result", TransientAssistantDtoClientMessagesItem.FunctionCallResult },
        { "hang", TransientAssistantDtoClientMessagesItem.Hang },
        { "language-changed", TransientAssistantDtoClientMessagesItem.LanguageChanged },
        { "metadata", TransientAssistantDtoClientMessagesItem.Metadata },
        { "model-output", TransientAssistantDtoClientMessagesItem.ModelOutput },
        { "speech-update", TransientAssistantDtoClientMessagesItem.SpeechUpdate },
        { "status-update", TransientAssistantDtoClientMessagesItem.StatusUpdate },
        { "transcript", TransientAssistantDtoClientMessagesItem.Transcript },
        { "tool-calls", TransientAssistantDtoClientMessagesItem.ToolCalls },
        { "tool-calls-result", TransientAssistantDtoClientMessagesItem.ToolCallsResult },
        { "tool.completed", TransientAssistantDtoClientMessagesItem.ToolCompleted },
        { "transfer-update", TransientAssistantDtoClientMessagesItem.TransferUpdate },
        { "user-interrupted", TransientAssistantDtoClientMessagesItem.UserInterrupted },
        { "voice-input", TransientAssistantDtoClientMessagesItem.VoiceInput },
        { "workflow.node.started", TransientAssistantDtoClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", TransientAssistantDtoClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransientAssistantDtoClientMessagesItem,
        string
    > _enumToString = new()
    {
        { TransientAssistantDtoClientMessagesItem.ConversationUpdate, "conversation-update" },
        {
            TransientAssistantDtoClientMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { TransientAssistantDtoClientMessagesItem.FunctionCall, "function-call" },
        { TransientAssistantDtoClientMessagesItem.FunctionCallResult, "function-call-result" },
        { TransientAssistantDtoClientMessagesItem.Hang, "hang" },
        { TransientAssistantDtoClientMessagesItem.LanguageChanged, "language-changed" },
        { TransientAssistantDtoClientMessagesItem.Metadata, "metadata" },
        { TransientAssistantDtoClientMessagesItem.ModelOutput, "model-output" },
        { TransientAssistantDtoClientMessagesItem.SpeechUpdate, "speech-update" },
        { TransientAssistantDtoClientMessagesItem.StatusUpdate, "status-update" },
        { TransientAssistantDtoClientMessagesItem.Transcript, "transcript" },
        { TransientAssistantDtoClientMessagesItem.ToolCalls, "tool-calls" },
        { TransientAssistantDtoClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { TransientAssistantDtoClientMessagesItem.ToolCompleted, "tool.completed" },
        { TransientAssistantDtoClientMessagesItem.TransferUpdate, "transfer-update" },
        { TransientAssistantDtoClientMessagesItem.UserInterrupted, "user-interrupted" },
        { TransientAssistantDtoClientMessagesItem.VoiceInput, "voice-input" },
        { TransientAssistantDtoClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { TransientAssistantDtoClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override TransientAssistantDtoClientMessagesItem Read(
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
        TransientAssistantDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransientAssistantDtoClientMessagesItem ReadAsPropertyName(
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
        TransientAssistantDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
