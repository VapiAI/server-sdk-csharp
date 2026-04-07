using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantOverridesClientMessagesItemSerializer))]
public enum AssistantOverridesClientMessagesItem
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

internal class AssistantOverridesClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantOverridesClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantOverridesClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", AssistantOverridesClientMessagesItem.ConversationUpdate },
        { "assistant.speechStarted", AssistantOverridesClientMessagesItem.AssistantSpeechStarted },
        { "function-call", AssistantOverridesClientMessagesItem.FunctionCall },
        { "function-call-result", AssistantOverridesClientMessagesItem.FunctionCallResult },
        { "hang", AssistantOverridesClientMessagesItem.Hang },
        { "language-changed", AssistantOverridesClientMessagesItem.LanguageChanged },
        { "metadata", AssistantOverridesClientMessagesItem.Metadata },
        { "model-output", AssistantOverridesClientMessagesItem.ModelOutput },
        { "speech-update", AssistantOverridesClientMessagesItem.SpeechUpdate },
        { "status-update", AssistantOverridesClientMessagesItem.StatusUpdate },
        { "transcript", AssistantOverridesClientMessagesItem.Transcript },
        { "tool-calls", AssistantOverridesClientMessagesItem.ToolCalls },
        { "tool-calls-result", AssistantOverridesClientMessagesItem.ToolCallsResult },
        { "tool.completed", AssistantOverridesClientMessagesItem.ToolCompleted },
        { "transfer-update", AssistantOverridesClientMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantOverridesClientMessagesItem.UserInterrupted },
        { "voice-input", AssistantOverridesClientMessagesItem.VoiceInput },
        { "workflow.node.started", AssistantOverridesClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", AssistantOverridesClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantOverridesClientMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantOverridesClientMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantOverridesClientMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantOverridesClientMessagesItem.FunctionCall, "function-call" },
        { AssistantOverridesClientMessagesItem.FunctionCallResult, "function-call-result" },
        { AssistantOverridesClientMessagesItem.Hang, "hang" },
        { AssistantOverridesClientMessagesItem.LanguageChanged, "language-changed" },
        { AssistantOverridesClientMessagesItem.Metadata, "metadata" },
        { AssistantOverridesClientMessagesItem.ModelOutput, "model-output" },
        { AssistantOverridesClientMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantOverridesClientMessagesItem.StatusUpdate, "status-update" },
        { AssistantOverridesClientMessagesItem.Transcript, "transcript" },
        { AssistantOverridesClientMessagesItem.ToolCalls, "tool-calls" },
        { AssistantOverridesClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { AssistantOverridesClientMessagesItem.ToolCompleted, "tool.completed" },
        { AssistantOverridesClientMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantOverridesClientMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantOverridesClientMessagesItem.VoiceInput, "voice-input" },
        { AssistantOverridesClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { AssistantOverridesClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override AssistantOverridesClientMessagesItem Read(
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
        AssistantOverridesClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantOverridesClientMessagesItem ReadAsPropertyName(
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
        AssistantOverridesClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
