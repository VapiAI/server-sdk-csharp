using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailRuleSensitivitySerializer))]
public enum GuardrailRuleSensitivity
{
    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "aggressive")]
    Aggressive,
}

internal class GuardrailRuleSensitivitySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailRuleSensitivity>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailRuleSensitivity
    > _stringToEnum = new()
    {
        { "low", GuardrailRuleSensitivity.Low },
        { "medium", GuardrailRuleSensitivity.Medium },
        { "aggressive", GuardrailRuleSensitivity.Aggressive },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailRuleSensitivity,
        string
    > _enumToString = new()
    {
        { GuardrailRuleSensitivity.Low, "low" },
        { GuardrailRuleSensitivity.Medium, "medium" },
        { GuardrailRuleSensitivity.Aggressive, "aggressive" },
    };

    public override GuardrailRuleSensitivity Read(
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
        GuardrailRuleSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailRuleSensitivity ReadAsPropertyName(
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
        GuardrailRuleSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
