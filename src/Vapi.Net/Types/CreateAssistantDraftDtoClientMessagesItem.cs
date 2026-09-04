using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDraftDtoClientMessagesItemSerializer))]
public enum CreateAssistantDraftDtoClientMessagesItem
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

internal class CreateAssistantDraftDtoClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDraftDtoClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDraftDtoClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", CreateAssistantDraftDtoClientMessagesItem.ConversationUpdate },
        {
            "assistant.speechStarted",
            CreateAssistantDraftDtoClientMessagesItem.AssistantSpeechStarted
        },
        { "function-call", CreateAssistantDraftDtoClientMessagesItem.FunctionCall },
        { "function-call-result", CreateAssistantDraftDtoClientMessagesItem.FunctionCallResult },
        { "hang", CreateAssistantDraftDtoClientMessagesItem.Hang },
        { "language-changed", CreateAssistantDraftDtoClientMessagesItem.LanguageChanged },
        { "metadata", CreateAssistantDraftDtoClientMessagesItem.Metadata },
        { "model-output", CreateAssistantDraftDtoClientMessagesItem.ModelOutput },
        { "speech-update", CreateAssistantDraftDtoClientMessagesItem.SpeechUpdate },
        { "status-update", CreateAssistantDraftDtoClientMessagesItem.StatusUpdate },
        { "transcript", CreateAssistantDraftDtoClientMessagesItem.Transcript },
        { "tool-calls", CreateAssistantDraftDtoClientMessagesItem.ToolCalls },
        { "tool-calls-result", CreateAssistantDraftDtoClientMessagesItem.ToolCallsResult },
        { "tool.completed", CreateAssistantDraftDtoClientMessagesItem.ToolCompleted },
        { "transfer-update", CreateAssistantDraftDtoClientMessagesItem.TransferUpdate },
        { "user-interrupted", CreateAssistantDraftDtoClientMessagesItem.UserInterrupted },
        { "voice-input", CreateAssistantDraftDtoClientMessagesItem.VoiceInput },
        { "workflow.node.started", CreateAssistantDraftDtoClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", CreateAssistantDraftDtoClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDraftDtoClientMessagesItem,
        string
    > _enumToString = new()
    {
        { CreateAssistantDraftDtoClientMessagesItem.ConversationUpdate, "conversation-update" },
        {
            CreateAssistantDraftDtoClientMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { CreateAssistantDraftDtoClientMessagesItem.FunctionCall, "function-call" },
        { CreateAssistantDraftDtoClientMessagesItem.FunctionCallResult, "function-call-result" },
        { CreateAssistantDraftDtoClientMessagesItem.Hang, "hang" },
        { CreateAssistantDraftDtoClientMessagesItem.LanguageChanged, "language-changed" },
        { CreateAssistantDraftDtoClientMessagesItem.Metadata, "metadata" },
        { CreateAssistantDraftDtoClientMessagesItem.ModelOutput, "model-output" },
        { CreateAssistantDraftDtoClientMessagesItem.SpeechUpdate, "speech-update" },
        { CreateAssistantDraftDtoClientMessagesItem.StatusUpdate, "status-update" },
        { CreateAssistantDraftDtoClientMessagesItem.Transcript, "transcript" },
        { CreateAssistantDraftDtoClientMessagesItem.ToolCalls, "tool-calls" },
        { CreateAssistantDraftDtoClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { CreateAssistantDraftDtoClientMessagesItem.ToolCompleted, "tool.completed" },
        { CreateAssistantDraftDtoClientMessagesItem.TransferUpdate, "transfer-update" },
        { CreateAssistantDraftDtoClientMessagesItem.UserInterrupted, "user-interrupted" },
        { CreateAssistantDraftDtoClientMessagesItem.VoiceInput, "voice-input" },
        { CreateAssistantDraftDtoClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { CreateAssistantDraftDtoClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override CreateAssistantDraftDtoClientMessagesItem Read(
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
        CreateAssistantDraftDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDraftDtoClientMessagesItem ReadAsPropertyName(
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
        CreateAssistantDraftDtoClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
