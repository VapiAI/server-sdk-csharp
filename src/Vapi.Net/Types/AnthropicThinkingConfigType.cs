using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnthropicThinkingConfigTypeSerializer))]
public enum AnthropicThinkingConfigType
{
    [EnumMember(Value = "enabled")]
    Enabled,
}

internal class AnthropicThinkingConfigTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnthropicThinkingConfigType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnthropicThinkingConfigType
    > _stringToEnum = new() { { "enabled", AnthropicThinkingConfigType.Enabled } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnthropicThinkingConfigType,
        string
    > _enumToString = new() { { AnthropicThinkingConfigType.Enabled, "enabled" } };

    public override AnthropicThinkingConfigType Read(
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
        AnthropicThinkingConfigType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnthropicThinkingConfigType ReadAsPropertyName(
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
        AnthropicThinkingConfigType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
