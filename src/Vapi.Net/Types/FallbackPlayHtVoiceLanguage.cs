using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackPlayHtVoiceLanguageSerializer))]
public enum FallbackPlayHtVoiceLanguage
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

internal class FallbackPlayHtVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackPlayHtVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackPlayHtVoiceLanguage
    > _stringToEnum = new()
    {
        { "afrikaans", FallbackPlayHtVoiceLanguage.Afrikaans },
        { "albanian", FallbackPlayHtVoiceLanguage.Albanian },
        { "amharic", FallbackPlayHtVoiceLanguage.Amharic },
        { "arabic", FallbackPlayHtVoiceLanguage.Arabic },
        { "bengali", FallbackPlayHtVoiceLanguage.Bengali },
        { "bulgarian", FallbackPlayHtVoiceLanguage.Bulgarian },
        { "catalan", FallbackPlayHtVoiceLanguage.Catalan },
        { "croatian", FallbackPlayHtVoiceLanguage.Croatian },
        { "czech", FallbackPlayHtVoiceLanguage.Czech },
        { "danish", FallbackPlayHtVoiceLanguage.Danish },
        { "dutch", FallbackPlayHtVoiceLanguage.Dutch },
        { "english", FallbackPlayHtVoiceLanguage.English },
        { "french", FallbackPlayHtVoiceLanguage.French },
        { "galician", FallbackPlayHtVoiceLanguage.Galician },
        { "german", FallbackPlayHtVoiceLanguage.German },
        { "greek", FallbackPlayHtVoiceLanguage.Greek },
        { "hebrew", FallbackPlayHtVoiceLanguage.Hebrew },
        { "hindi", FallbackPlayHtVoiceLanguage.Hindi },
        { "hungarian", FallbackPlayHtVoiceLanguage.Hungarian },
        { "indonesian", FallbackPlayHtVoiceLanguage.Indonesian },
        { "italian", FallbackPlayHtVoiceLanguage.Italian },
        { "japanese", FallbackPlayHtVoiceLanguage.Japanese },
        { "korean", FallbackPlayHtVoiceLanguage.Korean },
        { "malay", FallbackPlayHtVoiceLanguage.Malay },
        { "mandarin", FallbackPlayHtVoiceLanguage.Mandarin },
        { "polish", FallbackPlayHtVoiceLanguage.Polish },
        { "portuguese", FallbackPlayHtVoiceLanguage.Portuguese },
        { "russian", FallbackPlayHtVoiceLanguage.Russian },
        { "serbian", FallbackPlayHtVoiceLanguage.Serbian },
        { "spanish", FallbackPlayHtVoiceLanguage.Spanish },
        { "swedish", FallbackPlayHtVoiceLanguage.Swedish },
        { "tagalog", FallbackPlayHtVoiceLanguage.Tagalog },
        { "thai", FallbackPlayHtVoiceLanguage.Thai },
        { "turkish", FallbackPlayHtVoiceLanguage.Turkish },
        { "ukrainian", FallbackPlayHtVoiceLanguage.Ukrainian },
        { "urdu", FallbackPlayHtVoiceLanguage.Urdu },
        { "xhosa", FallbackPlayHtVoiceLanguage.Xhosa },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackPlayHtVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackPlayHtVoiceLanguage.Afrikaans, "afrikaans" },
        { FallbackPlayHtVoiceLanguage.Albanian, "albanian" },
        { FallbackPlayHtVoiceLanguage.Amharic, "amharic" },
        { FallbackPlayHtVoiceLanguage.Arabic, "arabic" },
        { FallbackPlayHtVoiceLanguage.Bengali, "bengali" },
        { FallbackPlayHtVoiceLanguage.Bulgarian, "bulgarian" },
        { FallbackPlayHtVoiceLanguage.Catalan, "catalan" },
        { FallbackPlayHtVoiceLanguage.Croatian, "croatian" },
        { FallbackPlayHtVoiceLanguage.Czech, "czech" },
        { FallbackPlayHtVoiceLanguage.Danish, "danish" },
        { FallbackPlayHtVoiceLanguage.Dutch, "dutch" },
        { FallbackPlayHtVoiceLanguage.English, "english" },
        { FallbackPlayHtVoiceLanguage.French, "french" },
        { FallbackPlayHtVoiceLanguage.Galician, "galician" },
        { FallbackPlayHtVoiceLanguage.German, "german" },
        { FallbackPlayHtVoiceLanguage.Greek, "greek" },
        { FallbackPlayHtVoiceLanguage.Hebrew, "hebrew" },
        { FallbackPlayHtVoiceLanguage.Hindi, "hindi" },
        { FallbackPlayHtVoiceLanguage.Hungarian, "hungarian" },
        { FallbackPlayHtVoiceLanguage.Indonesian, "indonesian" },
        { FallbackPlayHtVoiceLanguage.Italian, "italian" },
        { FallbackPlayHtVoiceLanguage.Japanese, "japanese" },
        { FallbackPlayHtVoiceLanguage.Korean, "korean" },
        { FallbackPlayHtVoiceLanguage.Malay, "malay" },
        { FallbackPlayHtVoiceLanguage.Mandarin, "mandarin" },
        { FallbackPlayHtVoiceLanguage.Polish, "polish" },
        { FallbackPlayHtVoiceLanguage.Portuguese, "portuguese" },
        { FallbackPlayHtVoiceLanguage.Russian, "russian" },
        { FallbackPlayHtVoiceLanguage.Serbian, "serbian" },
        { FallbackPlayHtVoiceLanguage.Spanish, "spanish" },
        { FallbackPlayHtVoiceLanguage.Swedish, "swedish" },
        { FallbackPlayHtVoiceLanguage.Tagalog, "tagalog" },
        { FallbackPlayHtVoiceLanguage.Thai, "thai" },
        { FallbackPlayHtVoiceLanguage.Turkish, "turkish" },
        { FallbackPlayHtVoiceLanguage.Ukrainian, "ukrainian" },
        { FallbackPlayHtVoiceLanguage.Urdu, "urdu" },
        { FallbackPlayHtVoiceLanguage.Xhosa, "xhosa" },
    };

    public override FallbackPlayHtVoiceLanguage Read(
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
        FallbackPlayHtVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackPlayHtVoiceLanguage ReadAsPropertyName(
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
        FallbackPlayHtVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
