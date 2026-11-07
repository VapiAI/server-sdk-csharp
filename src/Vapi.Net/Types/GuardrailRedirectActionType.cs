using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailRedirectActionTypeSerializer))]
public enum GuardrailRedirectActionType
{
    [EnumMember(Value = "auto-response")]
    AutoResponse,
}

internal class GuardrailRedirectActionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailRedirectActionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailRedirectActionType
    > _stringToEnum = new() { { "auto-response", GuardrailRedirectActionType.AutoResponse } };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailRedirectActionType,
        string
    > _enumToString = new() { { GuardrailRedirectActionType.AutoResponse, "auto-response" } };

    public override GuardrailRedirectActionType Read(
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
        GuardrailRedirectActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailRedirectActionType ReadAsPropertyName(
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
        GuardrailRedirectActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
