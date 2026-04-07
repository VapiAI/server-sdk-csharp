using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MinimaxVoiceLanguageBoostSerializer))]
public enum MinimaxVoiceLanguageBoost
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

internal class MinimaxVoiceLanguageBoostSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MinimaxVoiceLanguageBoost>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MinimaxVoiceLanguageBoost
    > _stringToEnum = new()
    {
        { "Chinese", MinimaxVoiceLanguageBoost.Chinese },
        { "Chinese,Yue", MinimaxVoiceLanguageBoost.ChineseYue },
        { "English", MinimaxVoiceLanguageBoost.English },
        { "Arabic", MinimaxVoiceLanguageBoost.Arabic },
        { "Russian", MinimaxVoiceLanguageBoost.Russian },
        { "Spanish", MinimaxVoiceLanguageBoost.Spanish },
        { "French", MinimaxVoiceLanguageBoost.French },
        { "Portuguese", MinimaxVoiceLanguageBoost.Portuguese },
        { "German", MinimaxVoiceLanguageBoost.German },
        { "Turkish", MinimaxVoiceLanguageBoost.Turkish },
        { "Dutch", MinimaxVoiceLanguageBoost.Dutch },
        { "Ukrainian", MinimaxVoiceLanguageBoost.Ukrainian },
        { "Vietnamese", MinimaxVoiceLanguageBoost.Vietnamese },
        { "Indonesian", MinimaxVoiceLanguageBoost.Indonesian },
        { "Japanese", MinimaxVoiceLanguageBoost.Japanese },
        { "Italian", MinimaxVoiceLanguageBoost.Italian },
        { "Korean", MinimaxVoiceLanguageBoost.Korean },
        { "Thai", MinimaxVoiceLanguageBoost.Thai },
        { "Polish", MinimaxVoiceLanguageBoost.Polish },
        { "Romanian", MinimaxVoiceLanguageBoost.Romanian },
        { "Greek", MinimaxVoiceLanguageBoost.Greek },
        { "Czech", MinimaxVoiceLanguageBoost.Czech },
        { "Finnish", MinimaxVoiceLanguageBoost.Finnish },
        { "Hindi", MinimaxVoiceLanguageBoost.Hindi },
        { "Bulgarian", MinimaxVoiceLanguageBoost.Bulgarian },
        { "Danish", MinimaxVoiceLanguageBoost.Danish },
        { "Hebrew", MinimaxVoiceLanguageBoost.Hebrew },
        { "Malay", MinimaxVoiceLanguageBoost.Malay },
        { "Persian", MinimaxVoiceLanguageBoost.Persian },
        { "Slovak", MinimaxVoiceLanguageBoost.Slovak },
        { "Swedish", MinimaxVoiceLanguageBoost.Swedish },
        { "Croatian", MinimaxVoiceLanguageBoost.Croatian },
        { "Filipino", MinimaxVoiceLanguageBoost.Filipino },
        { "Hungarian", MinimaxVoiceLanguageBoost.Hungarian },
        { "Norwegian", MinimaxVoiceLanguageBoost.Norwegian },
        { "Slovenian", MinimaxVoiceLanguageBoost.Slovenian },
        { "Catalan", MinimaxVoiceLanguageBoost.Catalan },
        { "Nynorsk", MinimaxVoiceLanguageBoost.Nynorsk },
        { "Tamil", MinimaxVoiceLanguageBoost.Tamil },
        { "Afrikaans", MinimaxVoiceLanguageBoost.Afrikaans },
        { "auto", MinimaxVoiceLanguageBoost.Auto },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MinimaxVoiceLanguageBoost,
        string
    > _enumToString = new()
    {
        { MinimaxVoiceLanguageBoost.Chinese, "Chinese" },
        { MinimaxVoiceLanguageBoost.ChineseYue, "Chinese,Yue" },
        { MinimaxVoiceLanguageBoost.English, "English" },
        { MinimaxVoiceLanguageBoost.Arabic, "Arabic" },
        { MinimaxVoiceLanguageBoost.Russian, "Russian" },
        { MinimaxVoiceLanguageBoost.Spanish, "Spanish" },
        { MinimaxVoiceLanguageBoost.French, "French" },
        { MinimaxVoiceLanguageBoost.Portuguese, "Portuguese" },
        { MinimaxVoiceLanguageBoost.German, "German" },
        { MinimaxVoiceLanguageBoost.Turkish, "Turkish" },
        { MinimaxVoiceLanguageBoost.Dutch, "Dutch" },
        { MinimaxVoiceLanguageBoost.Ukrainian, "Ukrainian" },
        { MinimaxVoiceLanguageBoost.Vietnamese, "Vietnamese" },
        { MinimaxVoiceLanguageBoost.Indonesian, "Indonesian" },
        { MinimaxVoiceLanguageBoost.Japanese, "Japanese" },
        { MinimaxVoiceLanguageBoost.Italian, "Italian" },
        { MinimaxVoiceLanguageBoost.Korean, "Korean" },
        { MinimaxVoiceLanguageBoost.Thai, "Thai" },
        { MinimaxVoiceLanguageBoost.Polish, "Polish" },
        { MinimaxVoiceLanguageBoost.Romanian, "Romanian" },
        { MinimaxVoiceLanguageBoost.Greek, "Greek" },
        { MinimaxVoiceLanguageBoost.Czech, "Czech" },
        { MinimaxVoiceLanguageBoost.Finnish, "Finnish" },
        { MinimaxVoiceLanguageBoost.Hindi, "Hindi" },
        { MinimaxVoiceLanguageBoost.Bulgarian, "Bulgarian" },
        { MinimaxVoiceLanguageBoost.Danish, "Danish" },
        { MinimaxVoiceLanguageBoost.Hebrew, "Hebrew" },
        { MinimaxVoiceLanguageBoost.Malay, "Malay" },
        { MinimaxVoiceLanguageBoost.Persian, "Persian" },
        { MinimaxVoiceLanguageBoost.Slovak, "Slovak" },
        { MinimaxVoiceLanguageBoost.Swedish, "Swedish" },
        { MinimaxVoiceLanguageBoost.Croatian, "Croatian" },
        { MinimaxVoiceLanguageBoost.Filipino, "Filipino" },
        { MinimaxVoiceLanguageBoost.Hungarian, "Hungarian" },
        { MinimaxVoiceLanguageBoost.Norwegian, "Norwegian" },
        { MinimaxVoiceLanguageBoost.Slovenian, "Slovenian" },
        { MinimaxVoiceLanguageBoost.Catalan, "Catalan" },
        { MinimaxVoiceLanguageBoost.Nynorsk, "Nynorsk" },
        { MinimaxVoiceLanguageBoost.Tamil, "Tamil" },
        { MinimaxVoiceLanguageBoost.Afrikaans, "Afrikaans" },
        { MinimaxVoiceLanguageBoost.Auto, "auto" },
    };

    public override MinimaxVoiceLanguageBoost Read(
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
        MinimaxVoiceLanguageBoost value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MinimaxVoiceLanguageBoost ReadAsPropertyName(
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
        MinimaxVoiceLanguageBoost value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
