using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PlayHtVoiceLanguageSerializer))]
public enum PlayHtVoiceLanguage
{
    [EnumMember(Value = "afrikaans")]
    Afrikaans,

    [EnumMember(Value = "albanian")]
    Albanian,

    [EnumMember(Value = "amharic")]
    Amharic,

    [EnumMember(Value = "arabic")]
    Arabic,

    [EnumMember(Value = "bengali")]
    Bengali,

    [EnumMember(Value = "bulgarian")]
    Bulgarian,

    [EnumMember(Value = "catalan")]
    Catalan,

    [EnumMember(Value = "croatian")]
    Croatian,

    [EnumMember(Value = "czech")]
    Czech,

    [EnumMember(Value = "danish")]
    Danish,

    [EnumMember(Value = "dutch")]
    Dutch,

    [EnumMember(Value = "english")]
    English,

    [EnumMember(Value = "french")]
    French,

    [EnumMember(Value = "galician")]
    Galician,

    [EnumMember(Value = "german")]
    German,

    [EnumMember(Value = "greek")]
    Greek,

    [EnumMember(Value = "hebrew")]
    Hebrew,

    [EnumMember(Value = "hindi")]
    Hindi,

    [EnumMember(Value = "hungarian")]
    Hungarian,

    [EnumMember(Value = "indonesian")]
    Indonesian,

    [EnumMember(Value = "italian")]
    Italian,

    [EnumMember(Value = "japanese")]
    Japanese,

    [EnumMember(Value = "korean")]
    Korean,

    [EnumMember(Value = "malay")]
    Malay,

    [EnumMember(Value = "mandarin")]
    Mandarin,

    [EnumMember(Value = "polish")]
    Polish,

    [EnumMember(Value = "portuguese")]
    Portuguese,

    [EnumMember(Value = "russian")]
    Russian,

    [EnumMember(Value = "serbian")]
    Serbian,

    [EnumMember(Value = "spanish")]
    Spanish,

    [EnumMember(Value = "swedish")]
    Swedish,

    [EnumMember(Value = "tagalog")]
    Tagalog,

    [EnumMember(Value = "thai")]
    Thai,

    [EnumMember(Value = "turkish")]
    Turkish,

    [EnumMember(Value = "ukrainian")]
    Ukrainian,

    [EnumMember(Value = "urdu")]
    Urdu,

    [EnumMember(Value = "xhosa")]
    Xhosa,
}

internal class PlayHtVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PlayHtVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PlayHtVoiceLanguage
    > _stringToEnum = new()
    {
        { "afrikaans", PlayHtVoiceLanguage.Afrikaans },
        { "albanian", PlayHtVoiceLanguage.Albanian },
        { "amharic", PlayHtVoiceLanguage.Amharic },
        { "arabic", PlayHtVoiceLanguage.Arabic },
        { "bengali", PlayHtVoiceLanguage.Bengali },
        { "bulgarian", PlayHtVoiceLanguage.Bulgarian },
        { "catalan", PlayHtVoiceLanguage.Catalan },
        { "croatian", PlayHtVoiceLanguage.Croatian },
        { "czech", PlayHtVoiceLanguage.Czech },
        { "danish", PlayHtVoiceLanguage.Danish },
        { "dutch", PlayHtVoiceLanguage.Dutch },
        { "english", PlayHtVoiceLanguage.English },
        { "french", PlayHtVoiceLanguage.French },
        { "galician", PlayHtVoiceLanguage.Galician },
        { "german", PlayHtVoiceLanguage.German },
        { "greek", PlayHtVoiceLanguage.Greek },
        { "hebrew", PlayHtVoiceLanguage.Hebrew },
        { "hindi", PlayHtVoiceLanguage.Hindi },
        { "hungarian", PlayHtVoiceLanguage.Hungarian },
        { "indonesian", PlayHtVoiceLanguage.Indonesian },
        { "italian", PlayHtVoiceLanguage.Italian },
        { "japanese", PlayHtVoiceLanguage.Japanese },
        { "korean", PlayHtVoiceLanguage.Korean },
        { "malay", PlayHtVoiceLanguage.Malay },
        { "mandarin", PlayHtVoiceLanguage.Mandarin },
        { "polish", PlayHtVoiceLanguage.Polish },
        { "portuguese", PlayHtVoiceLanguage.Portuguese },
        { "russian", PlayHtVoiceLanguage.Russian },
        { "serbian", PlayHtVoiceLanguage.Serbian },
        { "spanish", PlayHtVoiceLanguage.Spanish },
        { "swedish", PlayHtVoiceLanguage.Swedish },
        { "tagalog", PlayHtVoiceLanguage.Tagalog },
        { "thai", PlayHtVoiceLanguage.Thai },
        { "turkish", PlayHtVoiceLanguage.Turkish },
        { "ukrainian", PlayHtVoiceLanguage.Ukrainian },
        { "urdu", PlayHtVoiceLanguage.Urdu },
        { "xhosa", PlayHtVoiceLanguage.Xhosa },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PlayHtVoiceLanguage,
        string
    > _enumToString = new()
    {
        { PlayHtVoiceLanguage.Afrikaans, "afrikaans" },
        { PlayHtVoiceLanguage.Albanian, "albanian" },
        { PlayHtVoiceLanguage.Amharic, "amharic" },
        { PlayHtVoiceLanguage.Arabic, "arabic" },
        { PlayHtVoiceLanguage.Bengali, "bengali" },
        { PlayHtVoiceLanguage.Bulgarian, "bulgarian" },
        { PlayHtVoiceLanguage.Catalan, "catalan" },
        { PlayHtVoiceLanguage.Croatian, "croatian" },
        { PlayHtVoiceLanguage.Czech, "czech" },
        { PlayHtVoiceLanguage.Danish, "danish" },
        { PlayHtVoiceLanguage.Dutch, "dutch" },
        { PlayHtVoiceLanguage.English, "english" },
        { PlayHtVoiceLanguage.French, "french" },
        { PlayHtVoiceLanguage.Galician, "galician" },
        { PlayHtVoiceLanguage.German, "german" },
        { PlayHtVoiceLanguage.Greek, "greek" },
        { PlayHtVoiceLanguage.Hebrew, "hebrew" },
        { PlayHtVoiceLanguage.Hindi, "hindi" },
        { PlayHtVoiceLanguage.Hungarian, "hungarian" },
        { PlayHtVoiceLanguage.Indonesian, "indonesian" },
        { PlayHtVoiceLanguage.Italian, "italian" },
        { PlayHtVoiceLanguage.Japanese, "japanese" },
        { PlayHtVoiceLanguage.Korean, "korean" },
        { PlayHtVoiceLanguage.Malay, "malay" },
        { PlayHtVoiceLanguage.Mandarin, "mandarin" },
        { PlayHtVoiceLanguage.Polish, "polish" },
        { PlayHtVoiceLanguage.Portuguese, "portuguese" },
        { PlayHtVoiceLanguage.Russian, "russian" },
        { PlayHtVoiceLanguage.Serbian, "serbian" },
        { PlayHtVoiceLanguage.Spanish, "spanish" },
        { PlayHtVoiceLanguage.Swedish, "swedish" },
        { PlayHtVoiceLanguage.Tagalog, "tagalog" },
        { PlayHtVoiceLanguage.Thai, "thai" },
        { PlayHtVoiceLanguage.Turkish, "turkish" },
        { PlayHtVoiceLanguage.Ukrainian, "ukrainian" },
        { PlayHtVoiceLanguage.Urdu, "urdu" },
        { PlayHtVoiceLanguage.Xhosa, "xhosa" },
    };

    public override PlayHtVoiceLanguage Read(
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
        PlayHtVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PlayHtVoiceLanguage ReadAsPropertyName(
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
        PlayHtVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
