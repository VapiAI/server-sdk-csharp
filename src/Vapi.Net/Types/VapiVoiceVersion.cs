using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiVoiceVersionSerializer))]
public enum VapiVoiceVersion
{
    [EnumMember(Value = "1")]
    One,

    [EnumMember(Value = "2")]
    Two,

    [EnumMember(Value = "latest")]
    Latest,
}

internal class VapiVoiceVersionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiVoiceVersion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiVoiceVersion
    > _stringToEnum = new()
    {
        { "1", VapiVoiceVersion.One },
        { "2", VapiVoiceVersion.Two },
        { "latest", VapiVoiceVersion.Latest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiVoiceVersion,
        string
    > _enumToString = new()
    {
        { VapiVoiceVersion.One, "1" },
        { VapiVoiceVersion.Two, "2" },
        { VapiVoiceVersion.Latest, "latest" },
    };

    public override VapiVoiceVersion Read(
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
        VapiVoiceVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiVoiceVersion ReadAsPropertyName(
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
        VapiVoiceVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
