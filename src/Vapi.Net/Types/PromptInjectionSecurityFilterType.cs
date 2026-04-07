using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PromptInjectionSecurityFilterTypeSerializer))]
public enum PromptInjectionSecurityFilterType
{
    [EnumMember(Value = "prompt-injection")]
    PromptInjection,
}

internal class PromptInjectionSecurityFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PromptInjectionSecurityFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PromptInjectionSecurityFilterType
    > _stringToEnum = new()
    {
        { "prompt-injection", PromptInjectionSecurityFilterType.PromptInjection },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PromptInjectionSecurityFilterType,
        string
    > _enumToString = new()
    {
        { PromptInjectionSecurityFilterType.PromptInjection, "prompt-injection" },
    };

    public override PromptInjectionSecurityFilterType Read(
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
        PromptInjectionSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PromptInjectionSecurityFilterType ReadAsPropertyName(
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
        PromptInjectionSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
