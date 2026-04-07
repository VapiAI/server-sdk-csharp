using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMinimaxVoiceSubtitleTypeSerializer))]
public enum FallbackMinimaxVoiceSubtitleType
{
    [EnumMember(Value = "word")]
    Word,

    [EnumMember(Value = "sentence")]
    Sentence,
}

internal class FallbackMinimaxVoiceSubtitleTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMinimaxVoiceSubtitleType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMinimaxVoiceSubtitleType
    > _stringToEnum = new()
    {
        { "word", FallbackMinimaxVoiceSubtitleType.Word },
        { "sentence", FallbackMinimaxVoiceSubtitleType.Sentence },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMinimaxVoiceSubtitleType,
        string
    > _enumToString = new()
    {
        { FallbackMinimaxVoiceSubtitleType.Word, "word" },
        { FallbackMinimaxVoiceSubtitleType.Sentence, "sentence" },
    };

    public override FallbackMinimaxVoiceSubtitleType Read(
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
        FallbackMinimaxVoiceSubtitleType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMinimaxVoiceSubtitleType ReadAsPropertyName(
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
        FallbackMinimaxVoiceSubtitleType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
