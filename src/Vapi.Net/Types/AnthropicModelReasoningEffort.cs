using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnthropicModelReasoningEffortSerializer))]
public enum AnthropicModelReasoningEffort
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

internal class AnthropicModelReasoningEffortSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnthropicModelReasoningEffort>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnthropicModelReasoningEffort
    > _stringToEnum = new()
    {
        { "none", AnthropicModelReasoningEffort.None },
        { "low", AnthropicModelReasoningEffort.Low },
        { "medium", AnthropicModelReasoningEffort.Medium },
        { "high", AnthropicModelReasoningEffort.High },
        { "xhigh", AnthropicModelReasoningEffort.Xhigh },
        { "max", AnthropicModelReasoningEffort.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnthropicModelReasoningEffort,
        string
    > _enumToString = new()
    {
        { AnthropicModelReasoningEffort.None, "none" },
        { AnthropicModelReasoningEffort.Low, "low" },
        { AnthropicModelReasoningEffort.Medium, "medium" },
        { AnthropicModelReasoningEffort.High, "high" },
        { AnthropicModelReasoningEffort.Xhigh, "xhigh" },
        { AnthropicModelReasoningEffort.Max, "max" },
    };

    public override AnthropicModelReasoningEffort Read(
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
        AnthropicModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnthropicModelReasoningEffort ReadAsPropertyName(
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
        AnthropicModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
