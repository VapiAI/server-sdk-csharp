using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(KeypadInputPlanDelimitersSerializer))]
public enum KeypadInputPlanDelimiters
{
    [EnumMember(Value = "#")]
    Hash,

    [EnumMember(Value = "*")]
    Asterisk,

    [EnumMember(Value = "")]
    Empty,
}

internal class KeypadInputPlanDelimitersSerializer
    : global::System.Text.Json.Serialization.JsonConverter<KeypadInputPlanDelimiters>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        KeypadInputPlanDelimiters
    > _stringToEnum = new()
    {
        { "#", KeypadInputPlanDelimiters.Hash },
        { "*", KeypadInputPlanDelimiters.Asterisk },
        { "", KeypadInputPlanDelimiters.Empty },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        KeypadInputPlanDelimiters,
        string
    > _enumToString = new()
    {
        { KeypadInputPlanDelimiters.Hash, "#" },
        { KeypadInputPlanDelimiters.Asterisk, "*" },
        { KeypadInputPlanDelimiters.Empty, "" },
    };

    public override KeypadInputPlanDelimiters Read(
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
        KeypadInputPlanDelimiters value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override KeypadInputPlanDelimiters ReadAsPropertyName(
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
        KeypadInputPlanDelimiters value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
