using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAzureVoiceIdZeroSerializer))]
public enum FallbackAzureVoiceIdZero
{
    [EnumMember(Value = "andrew")]
    Andrew,

    [EnumMember(Value = "brian")]
    Brian,

    [EnumMember(Value = "emma")]
    Emma,
}

internal class FallbackAzureVoiceIdZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAzureVoiceIdZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAzureVoiceIdZero
    > _stringToEnum = new()
    {
        { "andrew", FallbackAzureVoiceIdZero.Andrew },
        { "brian", FallbackAzureVoiceIdZero.Brian },
        { "emma", FallbackAzureVoiceIdZero.Emma },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAzureVoiceIdZero,
        string
    > _enumToString = new()
    {
        { FallbackAzureVoiceIdZero.Andrew, "andrew" },
        { FallbackAzureVoiceIdZero.Brian, "brian" },
        { FallbackAzureVoiceIdZero.Emma, "emma" },
    };

    public override FallbackAzureVoiceIdZero Read(
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
        FallbackAzureVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAzureVoiceIdZero ReadAsPropertyName(
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
        FallbackAzureVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
