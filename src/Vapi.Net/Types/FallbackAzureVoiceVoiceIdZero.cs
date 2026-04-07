using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAzureVoiceVoiceIdZeroSerializer))]
public enum FallbackAzureVoiceVoiceIdZero
{
    [EnumMember(Value = "andrew")]
    Andrew,

    [EnumMember(Value = "brian")]
    Brian,

    [EnumMember(Value = "emma")]
    Emma,
}

internal class FallbackAzureVoiceVoiceIdZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAzureVoiceVoiceIdZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAzureVoiceVoiceIdZero
    > _stringToEnum = new()
    {
        { "andrew", FallbackAzureVoiceVoiceIdZero.Andrew },
        { "brian", FallbackAzureVoiceVoiceIdZero.Brian },
        { "emma", FallbackAzureVoiceVoiceIdZero.Emma },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAzureVoiceVoiceIdZero,
        string
    > _enumToString = new()
    {
        { FallbackAzureVoiceVoiceIdZero.Andrew, "andrew" },
        { FallbackAzureVoiceVoiceIdZero.Brian, "brian" },
        { FallbackAzureVoiceVoiceIdZero.Emma, "emma" },
    };

    public override FallbackAzureVoiceVoiceIdZero Read(
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
        FallbackAzureVoiceVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAzureVoiceVoiceIdZero ReadAsPropertyName(
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
        FallbackAzureVoiceVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
