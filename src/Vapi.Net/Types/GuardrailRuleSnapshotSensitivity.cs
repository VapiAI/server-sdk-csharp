using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailRuleSnapshotSensitivitySerializer))]
public enum GuardrailRuleSnapshotSensitivity
{
    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "aggressive")]
    Aggressive,
}

internal class GuardrailRuleSnapshotSensitivitySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailRuleSnapshotSensitivity>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailRuleSnapshotSensitivity
    > _stringToEnum = new()
    {
        { "low", GuardrailRuleSnapshotSensitivity.Low },
        { "medium", GuardrailRuleSnapshotSensitivity.Medium },
        { "aggressive", GuardrailRuleSnapshotSensitivity.Aggressive },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailRuleSnapshotSensitivity,
        string
    > _enumToString = new()
    {
        { GuardrailRuleSnapshotSensitivity.Low, "low" },
        { GuardrailRuleSnapshotSensitivity.Medium, "medium" },
        { GuardrailRuleSnapshotSensitivity.Aggressive, "aggressive" },
    };

    public override GuardrailRuleSnapshotSensitivity Read(
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
        GuardrailRuleSnapshotSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailRuleSnapshotSensitivity ReadAsPropertyName(
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
        GuardrailRuleSnapshotSensitivity value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
