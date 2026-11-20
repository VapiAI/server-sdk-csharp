using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WorkflowOpenAiModelReasoningEffortSerializer))]
public enum WorkflowOpenAiModelReasoningEffort
{
    [EnumMember(Value = "minimal")]
    Minimal,

    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "high")]
    High,

    [EnumMember(Value = "xhigh")]
    Xhigh,
}

internal class WorkflowOpenAiModelReasoningEffortSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WorkflowOpenAiModelReasoningEffort>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WorkflowOpenAiModelReasoningEffort
    > _stringToEnum = new()
    {
        { "minimal", WorkflowOpenAiModelReasoningEffort.Minimal },
        { "none", WorkflowOpenAiModelReasoningEffort.None },
        { "low", WorkflowOpenAiModelReasoningEffort.Low },
        { "medium", WorkflowOpenAiModelReasoningEffort.Medium },
        { "high", WorkflowOpenAiModelReasoningEffort.High },
        { "xhigh", WorkflowOpenAiModelReasoningEffort.Xhigh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        WorkflowOpenAiModelReasoningEffort,
        string
    > _enumToString = new()
    {
        { WorkflowOpenAiModelReasoningEffort.Minimal, "minimal" },
        { WorkflowOpenAiModelReasoningEffort.None, "none" },
        { WorkflowOpenAiModelReasoningEffort.Low, "low" },
        { WorkflowOpenAiModelReasoningEffort.Medium, "medium" },
        { WorkflowOpenAiModelReasoningEffort.High, "high" },
        { WorkflowOpenAiModelReasoningEffort.Xhigh, "xhigh" },
    };

    public override WorkflowOpenAiModelReasoningEffort Read(
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
        WorkflowOpenAiModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WorkflowOpenAiModelReasoningEffort ReadAsPropertyName(
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
        WorkflowOpenAiModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
