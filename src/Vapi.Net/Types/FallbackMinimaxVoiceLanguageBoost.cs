using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMinimaxVoiceLanguageBoostSerializer))]
public enum FallbackMinimaxVoiceLanguageBoost
{
    [EnumMember(Value = "Chinese")]
    Chinese,

    [EnumMember(Value = "Chinese,Yue")]
    ChineseYue,

    [EnumMember(Value = "English")]
    English,

    [EnumMember(Value = "Arabic")]
    Arabic,

    [EnumMember(Value = "Russian")]
    Russian,

    [EnumMember(Value = "Spanish")]
    Spanish,

    [EnumMember(Value = "French")]
    French,

    [EnumMember(Value = "Portuguese")]
    Portuguese,

    [EnumMember(Value = "German")]
    German,

    [EnumMember(Value = "Turkish")]
    Turkish,

    [EnumMember(Value = "Dutch")]
    Dutch,

    [EnumMember(Value = "Ukrainian")]
    Ukrainian,

    [EnumMember(Value = "Vietnamese")]
    Vietnamese,

    [EnumMember(Value = "Indonesian")]
    Indonesian,

    [EnumMember(Value = "Japanese")]
    Japanese,

    [EnumMember(Value = "Italian")]
    Italian,

    [EnumMember(Value = "Korean")]
    Korean,

    [EnumMember(Value = "Thai")]
    Thai,

    [EnumMember(Value = "Polish")]
    Polish,

    [EnumMember(Value = "Romanian")]
    Romanian,

    [EnumMember(Value = "Greek")]
    Greek,

    [EnumMember(Value = "Czech")]
    Czech,

    [EnumMember(Value = "Finnish")]
    Finnish,

    [EnumMember(Value = "Hindi")]
    Hindi,

    [EnumMember(Value = "Bulgarian")]
    Bulgarian,

    [EnumMember(Value = "Danish")]
    Danish,

    [EnumMember(Value = "Hebrew")]
    Hebrew,

    [EnumMember(Value = "Malay")]
    Malay,

    [EnumMember(Value = "Persian")]
    Persian,

    [EnumMember(Value = "Slovak")]
    Slovak,

    [EnumMember(Value = "Swedish")]
    Swedish,

    [EnumMember(Value = "Croatian")]
    Croatian,

    [EnumMember(Value = "Filipino")]
    Filipino,

    [EnumMember(Value = "Hungarian")]
    Hungarian,

    [EnumMember(Value = "Norwegian")]
    Norwegian,

    [EnumMember(Value = "Slovenian")]
    Slovenian,

    [EnumMember(Value = "Catalan")]
    Catalan,

    [EnumMember(Value = "Nynorsk")]
    Nynorsk,

    [EnumMember(Value = "Tamil")]
    Tamil,

    [EnumMember(Value = "Afrikaans")]
    Afrikaans,

    [EnumMember(Value = "auto")]
    Auto,
}

internal class FallbackMinimaxVoiceLanguageBoostSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMinimaxVoiceLanguageBoost>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMinimaxVoiceLanguageBoost
    > _stringToEnum = new()
    {
        { "Chinese", FallbackMinimaxVoiceLanguageBoost.Chinese },
        { "Chinese,Yue", FallbackMinimaxVoiceLanguageBoost.ChineseYue },
        { "English", FallbackMinimaxVoiceLanguageBoost.English },
        { "Arabic", FallbackMinimaxVoiceLanguageBoost.Arabic },
        { "Russian", FallbackMinimaxVoiceLanguageBoost.Russian },
        { "Spanish", FallbackMinimaxVoiceLanguageBoost.Spanish },
        { "French", FallbackMinimaxVoiceLanguageBoost.French },
        { "Portuguese", FallbackMinimaxVoiceLanguageBoost.Portuguese },
        { "German", FallbackMinimaxVoiceLanguageBoost.German },
        { "Turkish", FallbackMinimaxVoiceLanguageBoost.Turkish },
        { "Dutch", FallbackMinimaxVoiceLanguageBoost.Dutch },
        { "Ukrainian", FallbackMinimaxVoiceLanguageBoost.Ukrainian },
        { "Vietnamese", FallbackMinimaxVoiceLanguageBoost.Vietnamese },
        { "Indonesian", FallbackMinimaxVoiceLanguageBoost.Indonesian },
        { "Japanese", FallbackMinimaxVoiceLanguageBoost.Japanese },
        { "Italian", FallbackMinimaxVoiceLanguageBoost.Italian },
        { "Korean", FallbackMinimaxVoiceLanguageBoost.Korean },
        { "Thai", FallbackMinimaxVoiceLanguageBoost.Thai },
        { "Polish", FallbackMinimaxVoiceLanguageBoost.Polish },
        { "Romanian", FallbackMinimaxVoiceLanguageBoost.Romanian },
        { "Greek", FallbackMinimaxVoiceLanguageBoost.Greek },
        { "Czech", FallbackMinimaxVoiceLanguageBoost.Czech },
        { "Finnish", FallbackMinimaxVoiceLanguageBoost.Finnish },
        { "Hindi", FallbackMinimaxVoiceLanguageBoost.Hindi },
        { "Bulgarian", FallbackMinimaxVoiceLanguageBoost.Bulgarian },
        { "Danish", FallbackMinimaxVoiceLanguageBoost.Danish },
        { "Hebrew", FallbackMinimaxVoiceLanguageBoost.Hebrew },
        { "Malay", FallbackMinimaxVoiceLanguageBoost.Malay },
        { "Persian", FallbackMinimaxVoiceLanguageBoost.Persian },
        { "Slovak", FallbackMinimaxVoiceLanguageBoost.Slovak },
        { "Swedish", FallbackMinimaxVoiceLanguageBoost.Swedish },
        { "Croatian", FallbackMinimaxVoiceLanguageBoost.Croatian },
        { "Filipino", FallbackMinimaxVoiceLanguageBoost.Filipino },
        { "Hungarian", FallbackMinimaxVoiceLanguageBoost.Hungarian },
        { "Norwegian", FallbackMinimaxVoiceLanguageBoost.Norwegian },
        { "Slovenian", FallbackMinimaxVoiceLanguageBoost.Slovenian },
        { "Catalan", FallbackMinimaxVoiceLanguageBoost.Catalan },
        { "Nynorsk", FallbackMinimaxVoiceLanguageBoost.Nynorsk },
        { "Tamil", FallbackMinimaxVoiceLanguageBoost.Tamil },
        { "Afrikaans", FallbackMinimaxVoiceLanguageBoost.Afrikaans },
        { "auto", FallbackMinimaxVoiceLanguageBoost.Auto },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMinimaxVoiceLanguageBoost,
        string
    > _enumToString = new()
    {
        { FallbackMinimaxVoiceLanguageBoost.Chinese, "Chinese" },
        { FallbackMinimaxVoiceLanguageBoost.ChineseYue, "Chinese,Yue" },
        { FallbackMinimaxVoiceLanguageBoost.English, "English" },
        { FallbackMinimaxVoiceLanguageBoost.Arabic, "Arabic" },
        { FallbackMinimaxVoiceLanguageBoost.Russian, "Russian" },
        { FallbackMinimaxVoiceLanguageBoost.Spanish, "Spanish" },
        { FallbackMinimaxVoiceLanguageBoost.French, "French" },
        { FallbackMinimaxVoiceLanguageBoost.Portuguese, "Portuguese" },
        { FallbackMinimaxVoiceLanguageBoost.German, "German" },
        { FallbackMinimaxVoiceLanguageBoost.Turkish, "Turkish" },
        { FallbackMinimaxVoiceLanguageBoost.Dutch, "Dutch" },
        { FallbackMinimaxVoiceLanguageBoost.Ukrainian, "Ukrainian" },
        { FallbackMinimaxVoiceLanguageBoost.Vietnamese, "Vietnamese" },
        { FallbackMinimaxVoiceLanguageBoost.Indonesian, "Indonesian" },
        { FallbackMinimaxVoiceLanguageBoost.Japanese, "Japanese" },
        { FallbackMinimaxVoiceLanguageBoost.Italian, "Italian" },
        { FallbackMinimaxVoiceLanguageBoost.Korean, "Korean" },
        { FallbackMinimaxVoiceLanguageBoost.Thai, "Thai" },
        { FallbackMinimaxVoiceLanguageBoost.Polish, "Polish" },
        { FallbackMinimaxVoiceLanguageBoost.Romanian, "Romanian" },
        { FallbackMinimaxVoiceLanguageBoost.Greek, "Greek" },
        { FallbackMinimaxVoiceLanguageBoost.Czech, "Czech" },
        { FallbackMinimaxVoiceLanguageBoost.Finnish, "Finnish" },
        { FallbackMinimaxVoiceLanguageBoost.Hindi, "Hindi" },
        { FallbackMinimaxVoiceLanguageBoost.Bulgarian, "Bulgarian" },
        { FallbackMinimaxVoiceLanguageBoost.Danish, "Danish" },
        { FallbackMinimaxVoiceLanguageBoost.Hebrew, "Hebrew" },
        { FallbackMinimaxVoiceLanguageBoost.Malay, "Malay" },
        { FallbackMinimaxVoiceLanguageBoost.Persian, "Persian" },
        { FallbackMinimaxVoiceLanguageBoost.Slovak, "Slovak" },
        { FallbackMinimaxVoiceLanguageBoost.Swedish, "Swedish" },
        { FallbackMinimaxVoiceLanguageBoost.Croatian, "Croatian" },
        { FallbackMinimaxVoiceLanguageBoost.Filipino, "Filipino" },
        { FallbackMinimaxVoiceLanguageBoost.Hungarian, "Hungarian" },
        { FallbackMinimaxVoiceLanguageBoost.Norwegian, "Norwegian" },
        { FallbackMinimaxVoiceLanguageBoost.Slovenian, "Slovenian" },
        { FallbackMinimaxVoiceLanguageBoost.Catalan, "Catalan" },
        { FallbackMinimaxVoiceLanguageBoost.Nynorsk, "Nynorsk" },
        { FallbackMinimaxVoiceLanguageBoost.Tamil, "Tamil" },
        { FallbackMinimaxVoiceLanguageBoost.Afrikaans, "Afrikaans" },
        { FallbackMinimaxVoiceLanguageBoost.Auto, "auto" },
    };

    public override FallbackMinimaxVoiceLanguageBoost Read(
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
        FallbackMinimaxVoiceLanguageBoost value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMinimaxVoiceLanguageBoost ReadAsPropertyName(
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
        FallbackMinimaxVoiceLanguageBoost value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
