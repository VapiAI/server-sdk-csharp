using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailRuleConflictResponseDtoErrorSerializer))]
public enum GuardrailRuleConflictResponseDtoError
{
    [EnumMember(Value = "rule_changed")]
    RuleChanged,

    [EnumMember(Value = "impact_changed")]
    ImpactChanged,

    [EnumMember(Value = "global_assignment")]
    GlobalAssignment,
}

internal class GuardrailRuleConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailRuleConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailRuleConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "rule_changed", GuardrailRuleConflictResponseDtoError.RuleChanged },
        { "impact_changed", GuardrailRuleConflictResponseDtoError.ImpactChanged },
        { "global_assignment", GuardrailRuleConflictResponseDtoError.GlobalAssignment },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailRuleConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { GuardrailRuleConflictResponseDtoError.RuleChanged, "rule_changed" },
        { GuardrailRuleConflictResponseDtoError.ImpactChanged, "impact_changed" },
        { GuardrailRuleConflictResponseDtoError.GlobalAssignment, "global_assignment" },
    };

    public override GuardrailRuleConflictResponseDtoError Read(
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
        GuardrailRuleConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailRuleConflictResponseDtoError ReadAsPropertyName(
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
        GuardrailRuleConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
