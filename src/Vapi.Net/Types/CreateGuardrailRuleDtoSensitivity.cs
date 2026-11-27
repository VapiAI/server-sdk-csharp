using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateGuardrailRuleDtoSensitivitySerializer))]
public enum CreateGuardrailRuleDtoSensitivity
{
    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "aggressive")]
    Aggressive,
}

internal class CreateGuardrailRuleDtoSensitivitySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateGuardrailRuleDtoSensitivity>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateGuardrailRuleDtoSensitivity
    > _stringToEnum = new()
    {
        { "low", CreateGuardrailRuleDtoSensitivity.Low },
        { "medium", CreateGuardrailRuleDtoSensitivity.Medium },
        { "aggressive", CreateGuardrailRuleDtoSensitivity.Aggressive },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateGuardrailRuleDtoSensitivity,
        string
    > _enumToString = new()
    {
        { CreateGuardrailRuleDtoSensitivity.Low, "low" },
        { CreateGuardrailRuleDtoSensitivity.Medium, "medium" },
        { CreateGuardrailRuleDtoSensitivity.Aggressive, "aggressive" },
    };

    public override CreateGuardrailRuleDtoSensitivity Read(
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
        CreateGuardrailRuleDtoSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateGuardrailRuleDtoSensitivity ReadAsPropertyName(
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
        CreateGuardrailRuleDtoSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
