using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantClientMessagesItemSerializer))]
public enum AssistantClientMessagesItem
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

internal class AssistantClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", AssistantClientMessagesItem.ConversationUpdate },
        { "assistant.speechStarted", AssistantClientMessagesItem.AssistantSpeechStarted },
        { "function-call", AssistantClientMessagesItem.FunctionCall },
        { "function-call-result", AssistantClientMessagesItem.FunctionCallResult },
        { "hang", AssistantClientMessagesItem.Hang },
        { "language-changed", AssistantClientMessagesItem.LanguageChanged },
        { "metadata", AssistantClientMessagesItem.Metadata },
        { "model-output", AssistantClientMessagesItem.ModelOutput },
        { "speech-update", AssistantClientMessagesItem.SpeechUpdate },
        { "status-update", AssistantClientMessagesItem.StatusUpdate },
        { "transcript", AssistantClientMessagesItem.Transcript },
        { "tool-calls", AssistantClientMessagesItem.ToolCalls },
        { "tool-calls-result", AssistantClientMessagesItem.ToolCallsResult },
        { "tool.completed", AssistantClientMessagesItem.ToolCompleted },
        { "transfer-update", AssistantClientMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantClientMessagesItem.UserInterrupted },
        { "voice-input", AssistantClientMessagesItem.VoiceInput },
        { "workflow.node.started", AssistantClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", AssistantClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantClientMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantClientMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantClientMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantClientMessagesItem.FunctionCall, "function-call" },
        { AssistantClientMessagesItem.FunctionCallResult, "function-call-result" },
        { AssistantClientMessagesItem.Hang, "hang" },
        { AssistantClientMessagesItem.LanguageChanged, "language-changed" },
        { AssistantClientMessagesItem.Metadata, "metadata" },
        { AssistantClientMessagesItem.ModelOutput, "model-output" },
        { AssistantClientMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantClientMessagesItem.StatusUpdate, "status-update" },
        { AssistantClientMessagesItem.Transcript, "transcript" },
        { AssistantClientMessagesItem.ToolCalls, "tool-calls" },
        { AssistantClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { AssistantClientMessagesItem.ToolCompleted, "tool.completed" },
        { AssistantClientMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantClientMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantClientMessagesItem.VoiceInput, "voice-input" },
        { AssistantClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { AssistantClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override AssistantClientMessagesItem Read(
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
        AssistantClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantClientMessagesItem ReadAsPropertyName(
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
        AssistantClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
