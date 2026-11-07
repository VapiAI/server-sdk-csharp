using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailFixedResponseActionTypeSerializer))]
public enum GuardrailFixedResponseActionType
{
    [EnumMember(Value = "auto-response")]
    AutoResponse,
}

internal class GuardrailFixedResponseActionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailFixedResponseActionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailFixedResponseActionType
    > _stringToEnum = new() { { "auto-response", GuardrailFixedResponseActionType.AutoResponse } };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailFixedResponseActionType,
        string
    > _enumToString = new() { { GuardrailFixedResponseActionType.AutoResponse, "auto-response" } };

    public override GuardrailFixedResponseActionType Read(
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
        GuardrailFixedResponseActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailFixedResponseActionType ReadAsPropertyName(
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
        GuardrailFixedResponseActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
