using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackVapiVoiceVersionSerializer))]
public enum FallbackVapiVoiceVersion
{
    [EnumMember(Value = "1")]
    One,

    [EnumMember(Value = "2")]
    Two,

    [EnumMember(Value = "latest")]
    Latest,
}

internal class FallbackVapiVoiceVersionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackVapiVoiceVersion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackVapiVoiceVersion
    > _stringToEnum = new()
    {
        { "1", FallbackVapiVoiceVersion.One },
        { "2", FallbackVapiVoiceVersion.Two },
        { "latest", FallbackVapiVoiceVersion.Latest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackVapiVoiceVersion,
        string
    > _enumToString = new()
    {
        { FallbackVapiVoiceVersion.One, "1" },
        { FallbackVapiVoiceVersion.Two, "2" },
        { FallbackVapiVoiceVersion.Latest, "latest" },
    };

    public override FallbackVapiVoiceVersion Read(
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
        FallbackVapiVoiceVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackVapiVoiceVersion ReadAsPropertyName(
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
        FallbackVapiVoiceVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
