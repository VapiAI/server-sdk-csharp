using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiReasonerReasoningEffortSerializer))]
public enum OpenAiReasonerReasoningEffort
{
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

    [EnumMember(Value = "max")]
    Max,
}

internal class OpenAiReasonerReasoningEffortSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiReasonerReasoningEffort>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiReasonerReasoningEffort
    > _stringToEnum = new()
    {
        { "none", OpenAiReasonerReasoningEffort.None },
        { "low", OpenAiReasonerReasoningEffort.Low },
        { "medium", OpenAiReasonerReasoningEffort.Medium },
        { "high", OpenAiReasonerReasoningEffort.High },
        { "xhigh", OpenAiReasonerReasoningEffort.Xhigh },
        { "max", OpenAiReasonerReasoningEffort.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiReasonerReasoningEffort,
        string
    > _enumToString = new()
    {
        { OpenAiReasonerReasoningEffort.None, "none" },
        { OpenAiReasonerReasoningEffort.Low, "low" },
        { OpenAiReasonerReasoningEffort.Medium, "medium" },
        { OpenAiReasonerReasoningEffort.High, "high" },
        { OpenAiReasonerReasoningEffort.Xhigh, "xhigh" },
        { OpenAiReasonerReasoningEffort.Max, "max" },
    };

    public override OpenAiReasonerReasoningEffort Read(
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
        OpenAiReasonerReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiReasonerReasoningEffort ReadAsPropertyName(
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
        OpenAiReasonerReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
