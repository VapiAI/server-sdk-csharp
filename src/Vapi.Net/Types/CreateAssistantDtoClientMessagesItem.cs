using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDtoClientMessagesItemSerializer))]
public enum CreateAssistantDtoClientMessagesItem
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

internal class CreateAssistantDtoClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDtoClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDtoClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", CreateAssistantDtoClientMessagesItem.ConversationUpdate },
        { "assistant.speechStarted", CreateAssistantDtoClientMessagesItem.AssistantSpeechStarted },
        { "function-call", CreateAssistantDtoClientMessagesItem.FunctionCall },
        { "function-call-result", CreateAssistantDtoClientMessagesItem.FunctionCallResult },
        { "hang", CreateAssistantDtoClientMessagesItem.Hang },
        { "language-changed", CreateAssistantDtoClientMessagesItem.LanguageChanged },
        { "metadata", CreateAssistantDtoClientMessagesItem.Metadata },
        { "model-output", CreateAssistantDtoClientMessagesItem.ModelOutput },
        { "speech-update", CreateAssistantDtoClientMessagesItem.SpeechUpdate },
        { "status-update", CreateAssistantDtoClientMessagesItem.StatusUpdate },
        { "transcript", CreateAssistantDtoClientMessagesItem.Transcript },
        { "tool-calls", CreateAssistantDtoClientMessagesItem.ToolCalls },
        { "tool-calls-result", CreateAssistantDtoClientMessagesItem.ToolCallsResult },
        { "tool.completed", CreateAssistantDtoClientMessagesItem.ToolCompleted },
        { "transfer-update", CreateAssistantDtoClientMessagesItem.TransferUpdate },
        { "user-interrupted", CreateAssistantDtoClientMessagesItem.UserInterrupted },
        { "voice-input", CreateAssistantDtoClientMessagesItem.VoiceInput },
        { "workflow.node.started", CreateAssistantDtoClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", CreateAssistantDtoClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDtoClientMessagesItem,
        string
    > _enumToString = new()
    {
        { CreateAssistantDtoClientMessagesItem.ConversationUpdate, "conversation-update" },
        { CreateAssistantDtoClientMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { CreateAssistantDtoClientMessagesItem.FunctionCall, "function-call" },
        { CreateAssistantDtoClientMessagesItem.FunctionCallResult, "function-call-result" },
        { CreateAssistantDtoClientMessagesItem.Hang, "hang" },
        { CreateAssistantDtoClientMessagesItem.LanguageChanged, "language-changed" },
        { CreateAssistantDtoClientMessagesItem.Metadata, "metadata" },
        { CreateAssistantDtoClientMessagesItem.ModelOutput, "model-output" },
        { CreateAssistantDtoClientMessagesItem.SpeechUpdate, "speech-update" },
        { CreateAssistantDtoClientMessagesItem.StatusUpdate, "status-update" },
        { CreateAssistantDtoClientMessagesItem.Transcript, "transcript" },
        { CreateAssistantDtoClientMessagesItem.ToolCalls, "tool-calls" },
        { CreateAssistantDtoClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { CreateAssistantDtoClientMessagesItem.ToolCompleted, "tool.completed" },
        { CreateAssistantDtoClientMessagesItem.TransferUpdate, "transfer-update" },
        { CreateAssistantDtoClientMessagesItem.UserInterrupted, "user-interrupted" },
        { CreateAssistantDtoClientMessagesItem.VoiceInput, "voice-input" },
        { CreateAssistantDtoClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { CreateAssistantDtoClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override CreateAssistantDtoClientMessagesItem Read(
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
        CreateAssistantDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDtoClientMessagesItem ReadAsPropertyName(
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
        CreateAssistantDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
