using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantDraftClientMessagesItemSerializer))]
public enum AssistantDraftClientMessagesItem
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

internal class AssistantDraftClientMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantDraftClientMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantDraftClientMessagesItem
    > _stringToEnum = new()
    {
        { "conversation-update", AssistantDraftClientMessagesItem.ConversationUpdate },
        { "assistant.speechStarted", AssistantDraftClientMessagesItem.AssistantSpeechStarted },
        { "function-call", AssistantDraftClientMessagesItem.FunctionCall },
        { "function-call-result", AssistantDraftClientMessagesItem.FunctionCallResult },
        { "hang", AssistantDraftClientMessagesItem.Hang },
        { "language-changed", AssistantDraftClientMessagesItem.LanguageChanged },
        { "metadata", AssistantDraftClientMessagesItem.Metadata },
        { "model-output", AssistantDraftClientMessagesItem.ModelOutput },
        { "speech-update", AssistantDraftClientMessagesItem.SpeechUpdate },
        { "status-update", AssistantDraftClientMessagesItem.StatusUpdate },
        { "transcript", AssistantDraftClientMessagesItem.Transcript },
        { "tool-calls", AssistantDraftClientMessagesItem.ToolCalls },
        { "tool-calls-result", AssistantDraftClientMessagesItem.ToolCallsResult },
        { "tool.completed", AssistantDraftClientMessagesItem.ToolCompleted },
        { "transfer-update", AssistantDraftClientMessagesItem.TransferUpdate },
        { "user-interrupted", AssistantDraftClientMessagesItem.UserInterrupted },
        { "voice-input", AssistantDraftClientMessagesItem.VoiceInput },
        { "workflow.node.started", AssistantDraftClientMessagesItem.WorkflowNodeStarted },
        { "assistant.started", AssistantDraftClientMessagesItem.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantDraftClientMessagesItem,
        string
    > _enumToString = new()
    {
        { AssistantDraftClientMessagesItem.ConversationUpdate, "conversation-update" },
        { AssistantDraftClientMessagesItem.AssistantSpeechStarted, "assistant.speechStarted" },
        { AssistantDraftClientMessagesItem.FunctionCall, "function-call" },
        { AssistantDraftClientMessagesItem.FunctionCallResult, "function-call-result" },
        { AssistantDraftClientMessagesItem.Hang, "hang" },
        { AssistantDraftClientMessagesItem.LanguageChanged, "language-changed" },
        { AssistantDraftClientMessagesItem.Metadata, "metadata" },
        { AssistantDraftClientMessagesItem.ModelOutput, "model-output" },
        { AssistantDraftClientMessagesItem.SpeechUpdate, "speech-update" },
        { AssistantDraftClientMessagesItem.StatusUpdate, "status-update" },
        { AssistantDraftClientMessagesItem.Transcript, "transcript" },
        { AssistantDraftClientMessagesItem.ToolCalls, "tool-calls" },
        { AssistantDraftClientMessagesItem.ToolCallsResult, "tool-calls-result" },
        { AssistantDraftClientMessagesItem.ToolCompleted, "tool.completed" },
        { AssistantDraftClientMessagesItem.TransferUpdate, "transfer-update" },
        { AssistantDraftClientMessagesItem.UserInterrupted, "user-interrupted" },
        { AssistantDraftClientMessagesItem.VoiceInput, "voice-input" },
        { AssistantDraftClientMessagesItem.WorkflowNodeStarted, "workflow.node.started" },
        { AssistantDraftClientMessagesItem.AssistantStarted, "assistant.started" },
    };

    public override AssistantDraftClientMessagesItem Read(
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
        AssistantDraftClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantDraftClientMessagesItem ReadAsPropertyName(
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
        AssistantDraftClientMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
