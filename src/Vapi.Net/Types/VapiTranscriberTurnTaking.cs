using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiTranscriberTurnTakingSerializer))]
public enum VapiTranscriberTurnTaking
{
    [EnumMember(Value = "intelligent")]
    Intelligent,

    [EnumMember(Value = "manual")]
    Manual,
}

internal class VapiTranscriberTurnTakingSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiTranscriberTurnTaking>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiTranscriberTurnTaking
    > _stringToEnum = new()
    {
        { "intelligent", VapiTranscriberTurnTaking.Intelligent },
        { "manual", VapiTranscriberTurnTaking.Manual },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiTranscriberTurnTaking,
        string
    > _enumToString = new()
    {
        { VapiTranscriberTurnTaking.Intelligent, "intelligent" },
        { VapiTranscriberTurnTaking.Manual, "manual" },
    };

    public override VapiTranscriberTurnTaking Read(
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
        VapiTranscriberTurnTaking value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiTranscriberTurnTaking ReadAsPropertyName(
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
        VapiTranscriberTurnTaking value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
