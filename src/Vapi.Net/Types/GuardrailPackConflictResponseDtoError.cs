using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailPackConflictResponseDtoErrorSerializer))]
public enum GuardrailPackConflictResponseDtoError
{
    [EnumMember(Value = "pack_changed")]
    PackChanged,

    [EnumMember(Value = "impact_changed")]
    ImpactChanged,

    [EnumMember(Value = "global_assignment")]
    GlobalAssignment,
}

internal class GuardrailPackConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailPackConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailPackConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "pack_changed", GuardrailPackConflictResponseDtoError.PackChanged },
        { "impact_changed", GuardrailPackConflictResponseDtoError.ImpactChanged },
        { "global_assignment", GuardrailPackConflictResponseDtoError.GlobalAssignment },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailPackConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { GuardrailPackConflictResponseDtoError.PackChanged, "pack_changed" },
        { GuardrailPackConflictResponseDtoError.ImpactChanged, "impact_changed" },
        { GuardrailPackConflictResponseDtoError.GlobalAssignment, "global_assignment" },
    };

    public override GuardrailPackConflictResponseDtoError Read(
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
        GuardrailPackConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailPackConflictResponseDtoError ReadAsPropertyName(
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
        GuardrailPackConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
