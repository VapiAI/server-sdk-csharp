using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantVersionClientMessagesItemSerializer))]
public enum AssistantVersionClientMessagesItem
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

internal class AssistantVersionClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantVersionClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantVersionClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", AssistantVersionClientMessagesItem.ConversationUpdate },
        { "assistant.speechStarted", AssistantVersionClientMessagesItem.AssistantSpeechStarted },
        { "function-call", AssistantVersionClientMessagesItem.FunctionCall },
        { "function-call-result", AssistantVersionClientMessagesItem.FunctionCallResult },
        { "hang", AssistantVersionClientMessagesItem.Hang },
        { "language-changed", AssistantVersionClientMessagesItem.LanguageChanged },
        { "metadata", AssistantVersionClientMessagesItem.Metadata },
        { "model-output", AssistantVersionClientMessagesItem.ModelOutput },
        { "speech-update", AssistantVersionClientMessagesItem.SpeechUpdate },
        { "status-update", AssistantVersionClientMessagesItem.StatusUpdate },
        { "transcript", AssistantVersionClientMessagesItem.Transcript },
        { "tool-calls", AssistantVersionClientMessagesItem.ToolCalls },
        { "tool-calls-result", AssistantVersionClientMessagesItem.ToolCallsResult },
        { "tool.completed", AssistantVersionClientMessagesItem.ToolCompleted },
        { "transfer-update", AssistantVersionClientMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantVersionClientMessagesItem.UserInterrupted },
        { "voice-input", AssistantVersionClientMessagesItem.VoiceInput },
        { "workflow.node.started", AssistantVersionClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", AssistantVersionClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantVersionClientMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantVersionClientMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantVersionClientMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantVersionClientMessagesItem.FunctionCall, "function-call" },
        { AssistantVersionClientMessagesItem.FunctionCallResult, "function-call-result" },
        { AssistantVersionClientMessagesItem.Hang, "hang" },
        { AssistantVersionClientMessagesItem.LanguageChanged, "language-changed" },
        { AssistantVersionClientMessagesItem.Metadata, "metadata" },
        { AssistantVersionClientMessagesItem.ModelOutput, "model-output" },
        { AssistantVersionClientMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantVersionClientMessagesItem.StatusUpdate, "status-update" },
        { AssistantVersionClientMessagesItem.Transcript, "transcript" },
        { AssistantVersionClientMessagesItem.ToolCalls, "tool-calls" },
        { AssistantVersionClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { AssistantVersionClientMessagesItem.ToolCompleted, "tool.completed" },
        { AssistantVersionClientMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantVersionClientMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantVersionClientMessagesItem.VoiceInput, "voice-input" },
        { AssistantVersionClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { AssistantVersionClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override AssistantVersionClientMessagesItem Read(
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
        AssistantVersionClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantVersionClientMessagesItem ReadAsPropertyName(
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
        AssistantVersionClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
