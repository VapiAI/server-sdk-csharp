using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AudioFormatFormatSerializer))]
public enum AudioFormatFormat
{
    [EnumMember(Value = "pcm_s16le")]
    PcmS16Le,

    [EnumMember(Value = "mulaw")]
    Mulaw,
}

internal class AudioFormatFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AudioFormatFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AudioFormatFormat
    > _stringToEnum = new()
    {
        { "pcm_s16le", AudioFormatFormat.PcmS16Le },
        { "mulaw", AudioFormatFormat.Mulaw },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AudioFormatFormat,
        string
    > _enumToString = new()
    {
        { AudioFormatFormat.PcmS16Le, "pcm_s16le" },
        { AudioFormatFormat.Mulaw, "mulaw" },
    };

    public override AudioFormatFormat Read(
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
        AudioFormatFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AudioFormatFormat ReadAsPropertyName(
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
        AudioFormatFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
