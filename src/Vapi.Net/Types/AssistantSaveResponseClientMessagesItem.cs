using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantSaveResponseClientMessagesItemSerializer))]
public enum AssistantSaveResponseClientMessagesItem
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

internal class AssistantSaveResponseClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantSaveResponseClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantSaveResponseClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", AssistantSaveResponseClientMessagesItem.ConversationUpdate },
        {
            "assistant.speechStarted",
            AssistantSaveResponseClientMessagesItem.AssistantSpeechStarted
        },
        { "function-call", AssistantSaveResponseClientMessagesItem.FunctionCall },
        { "function-call-result", AssistantSaveResponseClientMessagesItem.FunctionCallResult },
        { "hang", AssistantSaveResponseClientMessagesItem.Hang },
        { "language-changed", AssistantSaveResponseClientMessagesItem.LanguageChanged },
        { "metadata", AssistantSaveResponseClientMessagesItem.Metadata },
        { "model-output", AssistantSaveResponseClientMessagesItem.ModelOutput },
        { "speech-update", AssistantSaveResponseClientMessagesItem.SpeechUpdate },
        { "status-update", AssistantSaveResponseClientMessagesItem.StatusUpdate },
        { "transcript", AssistantSaveResponseClientMessagesItem.Transcript },
        { "tool-calls", AssistantSaveResponseClientMessagesItem.ToolCalls },
        { "tool-calls-result", AssistantSaveResponseClientMessagesItem.ToolCallsResult },
        { "tool.completed", AssistantSaveResponseClientMessagesItem.ToolCompleted },
        { "transfer-update", AssistantSaveResponseClientMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantSaveResponseClientMessagesItem.UserInterrupted },
        { "voice-input", AssistantSaveResponseClientMessagesItem.VoiceInput },
        { "workflow.node.started", AssistantSaveResponseClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", AssistantSaveResponseClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantSaveResponseClientMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantSaveResponseClientMessagesItem.ConversationUpdate, "conversation-update" },
        {
            AssistantSaveResponseClientMessagesItem.AssistantSpeechStarted,
            "assistant.speechStarted"
        },
        { AssistantSaveResponseClientMessagesItem.FunctionCall, "function-call" },
        { AssistantSaveResponseClientMessagesItem.FunctionCallResult, "function-call-result" },
        { AssistantSaveResponseClientMessagesItem.Hang, "hang" },
        { AssistantSaveResponseClientMessagesItem.LanguageChanged, "language-changed" },
        { AssistantSaveResponseClientMessagesItem.Metadata, "metadata" },
        { AssistantSaveResponseClientMessagesItem.ModelOutput, "model-output" },
        { AssistantSaveResponseClientMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantSaveResponseClientMessagesItem.StatusUpdate, "status-update" },
        { AssistantSaveResponseClientMessagesItem.Transcript, "transcript" },
        { AssistantSaveResponseClientMessagesItem.ToolCalls, "tool-calls" },
        { AssistantSaveResponseClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { AssistantSaveResponseClientMessagesItem.ToolCompleted, "tool.completed" },
        { AssistantSaveResponseClientMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantSaveResponseClientMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantSaveResponseClientMessagesItem.VoiceInput, "voice-input" },
        { AssistantSaveResponseClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { AssistantSaveResponseClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override AssistantSaveResponseClientMessagesItem Read(
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
        AssistantSaveResponseClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantSaveResponseClientMessagesItem ReadAsPropertyName(
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
        AssistantSaveResponseClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
