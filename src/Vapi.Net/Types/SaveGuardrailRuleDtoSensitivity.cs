using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SaveGuardrailRuleDtoSensitivitySerializer))]
public enum SaveGuardrailRuleDtoSensitivity
{
    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "aggressive")]
    Aggressive,
}

internal class SaveGuardrailRuleDtoSensitivitySerializer
    : global::System.Text.Json.Serialization.JsonConverter<SaveGuardrailRuleDtoSensitivity>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SaveGuardrailRuleDtoSensitivity
    > _stringToEnum = new()
    {
        { "low", SaveGuardrailRuleDtoSensitivity.Low },
        { "medium", SaveGuardrailRuleDtoSensitivity.Medium },
        { "aggressive", SaveGuardrailRuleDtoSensitivity.Aggressive },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SaveGuardrailRuleDtoSensitivity,
        string
    > _enumToString = new()
    {
        { SaveGuardrailRuleDtoSensitivity.Low, "low" },
        { SaveGuardrailRuleDtoSensitivity.Medium, "medium" },
        { SaveGuardrailRuleDtoSensitivity.Aggressive, "aggressive" },
    };

    public override SaveGuardrailRuleDtoSensitivity Read(
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
        SaveGuardrailRuleDtoSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SaveGuardrailRuleDtoSensitivity ReadAsPropertyName(
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
        SaveGuardrailRuleDtoSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
