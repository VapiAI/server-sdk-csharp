using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnthropicBedrockModelReasoningEffortSerializer))]
public enum AnthropicBedrockModelReasoningEffort
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

internal class AnthropicBedrockModelReasoningEffortSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnthropicBedrockModelReasoningEffort>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnthropicBedrockModelReasoningEffort
    > _stringToEnum = new()
    {
        { "none", AnthropicBedrockModelReasoningEffort.None },
        { "low", AnthropicBedrockModelReasoningEffort.Low },
        { "medium", AnthropicBedrockModelReasoningEffort.Medium },
        { "high", AnthropicBedrockModelReasoningEffort.High },
        { "xhigh", AnthropicBedrockModelReasoningEffort.Xhigh },
        { "max", AnthropicBedrockModelReasoningEffort.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnthropicBedrockModelReasoningEffort,
        string
    > _enumToString = new()
    {
        { AnthropicBedrockModelReasoningEffort.None, "none" },
        { AnthropicBedrockModelReasoningEffort.Low, "low" },
        { AnthropicBedrockModelReasoningEffort.Medium, "medium" },
        { AnthropicBedrockModelReasoningEffort.High, "high" },
        { AnthropicBedrockModelReasoningEffort.Xhigh, "xhigh" },
        { AnthropicBedrockModelReasoningEffort.Max, "max" },
    };

    public override AnthropicBedrockModelReasoningEffort Read(
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
        AnthropicBedrockModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnthropicBedrockModelReasoningEffort ReadAsPropertyName(
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
        AnthropicBedrockModelReasoningEffort value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
