using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalAnthropicModelReasoningEffortSerializer))]
public enum EvalAnthropicModelReasoningEffort
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

internal class EvalAnthropicModelReasoningEffortSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalAnthropicModelReasoningEffort>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalAnthropicModelReasoningEffort
    > _stringToEnum = new()
    {
        { "none", EvalAnthropicModelReasoningEffort.None },
        { "low", EvalAnthropicModelReasoningEffort.Low },
        { "medium", EvalAnthropicModelReasoningEffort.Medium },
        { "high", EvalAnthropicModelReasoningEffort.High },
        { "xhigh", EvalAnthropicModelReasoningEffort.Xhigh },
        { "max", EvalAnthropicModelReasoningEffort.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalAnthropicModelReasoningEffort,
        string
    > _enumToString = new()
    {
        { EvalAnthropicModelReasoningEffort.None, "none" },
        { EvalAnthropicModelReasoningEffort.Low, "low" },
        { EvalAnthropicModelReasoningEffort.Medium, "medium" },
        { EvalAnthropicModelReasoningEffort.High, "high" },
        { EvalAnthropicModelReasoningEffort.Xhigh, "xhigh" },
        { EvalAnthropicModelReasoningEffort.Max, "max" },
    };

    public override EvalAnthropicModelReasoningEffort Read(
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
        EvalAnthropicModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalAnthropicModelReasoningEffort ReadAsPropertyName(
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
        EvalAnthropicModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
