using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MinimaxVoiceSubtitleTypeSerializer))]
public enum MinimaxVoiceSubtitleType
{
    [EnumMember(Value = "word")]
    Word,

    [EnumMember(Value = "sentence")]
    Sentence,
}

internal class MinimaxVoiceSubtitleTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MinimaxVoiceSubtitleType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MinimaxVoiceSubtitleType
    > _stringToEnum = new()
    {
        { "word", MinimaxVoiceSubtitleType.Word },
        { "sentence", MinimaxVoiceSubtitleType.Sentence },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MinimaxVoiceSubtitleType,
        string
    > _enumToString = new()
    {
        { MinimaxVoiceSubtitleType.Word, "word" },
        { MinimaxVoiceSubtitleType.Sentence, "sentence" },
    };

    public override MinimaxVoiceSubtitleType Read(
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
        MinimaxVoiceSubtitleType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MinimaxVoiceSubtitleType ReadAsPropertyName(
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
        MinimaxVoiceSubtitleType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
