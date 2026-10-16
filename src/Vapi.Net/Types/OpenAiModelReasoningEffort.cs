using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiModelReasoningEffortSerializer))]
public enum OpenAiModelReasoningEffort
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

internal class OpenAiModelReasoningEffortSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiModelReasoningEffort>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiModelReasoningEffort
    > _stringToEnum = new()
    {
        { "minimal", OpenAiModelReasoningEffort.Minimal },
        { "none", OpenAiModelReasoningEffort.None },
        { "low", OpenAiModelReasoningEffort.Low },
        { "medium", OpenAiModelReasoningEffort.Medium },
        { "high", OpenAiModelReasoningEffort.High },
        { "xhigh", OpenAiModelReasoningEffort.Xhigh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiModelReasoningEffort,
        string
    > _enumToString = new()
    {
        { OpenAiModelReasoningEffort.Minimal, "minimal" },
        { OpenAiModelReasoningEffort.None, "none" },
        { OpenAiModelReasoningEffort.Low, "low" },
        { OpenAiModelReasoningEffort.Medium, "medium" },
        { OpenAiModelReasoningEffort.High, "high" },
        { OpenAiModelReasoningEffort.Xhigh, "xhigh" },
    };

    public override OpenAiModelReasoningEffort Read(
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
        OpenAiModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiModelReasoningEffort ReadAsPropertyName(
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
        OpenAiModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
