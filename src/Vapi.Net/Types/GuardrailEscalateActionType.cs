using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailEscalateActionTypeSerializer))]
public enum GuardrailEscalateActionType
{
    [EnumMember(Value = "escalate")]
    Escalate,
}

internal class GuardrailEscalateActionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailEscalateActionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailEscalateActionType
    > _stringToEnum = new() { { "escalate", GuardrailEscalateActionType.Escalate } };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailEscalateActionType,
        string
    > _enumToString = new() { { GuardrailEscalateActionType.Escalate, "escalate" } };

    public override GuardrailEscalateActionType Read(
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
        GuardrailEscalateActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailEscalateActionType ReadAsPropertyName(
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
        GuardrailEscalateActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
