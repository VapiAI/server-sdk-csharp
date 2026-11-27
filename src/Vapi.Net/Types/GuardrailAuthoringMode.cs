using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailAuthoringModeSerializer))]
public enum GuardrailAuthoringMode
{
    [EnumMember(Value = "always")]
    Always,

    [EnumMember(Value = "never")]
    Never,
}

internal class GuardrailAuthoringModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailAuthoringMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailAuthoringMode
    > _stringToEnum = new()
    {
        { "always", GuardrailAuthoringMode.Always },
        { "never", GuardrailAuthoringMode.Never },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailAuthoringMode,
        string
    > _enumToString = new()
    {
        { GuardrailAuthoringMode.Always, "always" },
        { GuardrailAuthoringMode.Never, "never" },
    };

    public override GuardrailAuthoringMode Read(
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
        GuardrailAuthoringMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailAuthoringMode ReadAsPropertyName(
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
        GuardrailAuthoringMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
