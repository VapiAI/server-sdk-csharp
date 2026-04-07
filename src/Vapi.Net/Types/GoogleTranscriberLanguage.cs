using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleTranscriberLanguageSerializer))]
public enum GoogleTranscriberLanguage
{
    [EnumMember(Value = "Multilingual")]
    Multilingual,

    [EnumMember(Value = "Arabic")]
    Arabic,

    [EnumMember(Value = "Bengali")]
    Bengali,

    [EnumMember(Value = "Bulgarian")]
    Bulgarian,

    [EnumMember(Value = "Chinese")]
    Chinese,

    [EnumMember(Value = "Croatian")]
    Croatian,

    [EnumMember(Value = "Czech")]
    Czech,

    [EnumMember(Value = "Danish")]
    Danish,

    [EnumMember(Value = "Dutch")]
    Dutch,

    [EnumMember(Value = "English")]
    English,

    [EnumMember(Value = "Estonian")]
    Estonian,

    [EnumMember(Value = "Finnish")]
    Finnish,

    [EnumMember(Value = "French")]
    French,

    [EnumMember(Value = "German")]
    German,

    [EnumMember(Value = "Greek")]
    Greek,

    [EnumMember(Value = "Hebrew")]
    Hebrew,

    [EnumMember(Value = "Hindi")]
    Hindi,

    [EnumMember(Value = "Hungarian")]
    Hungarian,

    [EnumMember(Value = "Indonesian")]
    Indonesian,

    [EnumMember(Value = "Italian")]
    Italian,

    [EnumMember(Value = "Japanese")]
    Japanese,

    [EnumMember(Value = "Korean")]
    Korean,

    [EnumMember(Value = "Latvian")]
    Latvian,

    [EnumMember(Value = "Lithuanian")]
    Lithuanian,

    [EnumMember(Value = "Norwegian")]
    Norwegian,

    [EnumMember(Value = "Polish")]
    Polish,

    [EnumMember(Value = "Portuguese")]
    Portuguese,

    [EnumMember(Value = "Romanian")]
    Romanian,

    [EnumMember(Value = "Russian")]
    Russian,

    [EnumMember(Value = "Serbian")]
    Serbian,

    [EnumMember(Value = "Slovak")]
    Slovak,

    [EnumMember(Value = "Slovenian")]
    Slovenian,

    [EnumMember(Value = "Spanish")]
    Spanish,

    [EnumMember(Value = "Swahili")]
    Swahili,

    [EnumMember(Value = "Swedish")]
    Swedish,

    [EnumMember(Value = "Thai")]
    Thai,

    [EnumMember(Value = "Turkish")]
    Turkish,

    [EnumMember(Value = "Ukrainian")]
    Ukrainian,

    [EnumMember(Value = "Vietnamese")]
    Vietnamese,
}

internal class GoogleTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleTranscriberLanguage
    > _stringToEnum = new()
    {
        { "Multilingual", GoogleTranscriberLanguage.Multilingual },
        { "Arabic", GoogleTranscriberLanguage.Arabic },
        { "Bengali", GoogleTranscriberLanguage.Bengali },
        { "Bulgarian", GoogleTranscriberLanguage.Bulgarian },
        { "Chinese", GoogleTranscriberLanguage.Chinese },
        { "Croatian", GoogleTranscriberLanguage.Croatian },
        { "Czech", GoogleTranscriberLanguage.Czech },
        { "Danish", GoogleTranscriberLanguage.Danish },
        { "Dutch", GoogleTranscriberLanguage.Dutch },
        { "English", GoogleTranscriberLanguage.English },
        { "Estonian", GoogleTranscriberLanguage.Estonian },
        { "Finnish", GoogleTranscriberLanguage.Finnish },
        { "French", GoogleTranscriberLanguage.French },
        { "German", GoogleTranscriberLanguage.German },
        { "Greek", GoogleTranscriberLanguage.Greek },
        { "Hebrew", GoogleTranscriberLanguage.Hebrew },
        { "Hindi", GoogleTranscriberLanguage.Hindi },
        { "Hungarian", GoogleTranscriberLanguage.Hungarian },
        { "Indonesian", GoogleTranscriberLanguage.Indonesian },
        { "Italian", GoogleTranscriberLanguage.Italian },
        { "Japanese", GoogleTranscriberLanguage.Japanese },
        { "Korean", GoogleTranscriberLanguage.Korean },
        { "Latvian", GoogleTranscriberLanguage.Latvian },
        { "Lithuanian", GoogleTranscriberLanguage.Lithuanian },
        { "Norwegian", GoogleTranscriberLanguage.Norwegian },
        { "Polish", GoogleTranscriberLanguage.Polish },
        { "Portuguese", GoogleTranscriberLanguage.Portuguese },
        { "Romanian", GoogleTranscriberLanguage.Romanian },
        { "Russian", GoogleTranscriberLanguage.Russian },
        { "Serbian", GoogleTranscriberLanguage.Serbian },
        { "Slovak", GoogleTranscriberLanguage.Slovak },
        { "Slovenian", GoogleTranscriberLanguage.Slovenian },
        { "Spanish", GoogleTranscriberLanguage.Spanish },
        { "Swahili", GoogleTranscriberLanguage.Swahili },
        { "Swedish", GoogleTranscriberLanguage.Swedish },
        { "Thai", GoogleTranscriberLanguage.Thai },
        { "Turkish", GoogleTranscriberLanguage.Turkish },
        { "Ukrainian", GoogleTranscriberLanguage.Ukrainian },
        { "Vietnamese", GoogleTranscriberLanguage.Vietnamese },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { GoogleTranscriberLanguage.Multilingual, "Multilingual" },
        { GoogleTranscriberLanguage.Arabic, "Arabic" },
        { GoogleTranscriberLanguage.Bengali, "Bengali" },
        { GoogleTranscriberLanguage.Bulgarian, "Bulgarian" },
        { GoogleTranscriberLanguage.Chinese, "Chinese" },
        { GoogleTranscriberLanguage.Croatian, "Croatian" },
        { GoogleTranscriberLanguage.Czech, "Czech" },
        { GoogleTranscriberLanguage.Danish, "Danish" },
        { GoogleTranscriberLanguage.Dutch, "Dutch" },
        { GoogleTranscriberLanguage.English, "English" },
        { GoogleTranscriberLanguage.Estonian, "Estonian" },
        { GoogleTranscriberLanguage.Finnish, "Finnish" },
        { GoogleTranscriberLanguage.French, "French" },
        { GoogleTranscriberLanguage.German, "German" },
        { GoogleTranscriberLanguage.Greek, "Greek" },
        { GoogleTranscriberLanguage.Hebrew, "Hebrew" },
        { GoogleTranscriberLanguage.Hindi, "Hindi" },
        { GoogleTranscriberLanguage.Hungarian, "Hungarian" },
        { GoogleTranscriberLanguage.Indonesian, "Indonesian" },
        { GoogleTranscriberLanguage.Italian, "Italian" },
        { GoogleTranscriberLanguage.Japanese, "Japanese" },
        { GoogleTranscriberLanguage.Korean, "Korean" },
        { GoogleTranscriberLanguage.Latvian, "Latvian" },
        { GoogleTranscriberLanguage.Lithuanian, "Lithuanian" },
        { GoogleTranscriberLanguage.Norwegian, "Norwegian" },
        { GoogleTranscriberLanguage.Polish, "Polish" },
        { GoogleTranscriberLanguage.Portuguese, "Portuguese" },
        { GoogleTranscriberLanguage.Romanian, "Romanian" },
        { GoogleTranscriberLanguage.Russian, "Russian" },
        { GoogleTranscriberLanguage.Serbian, "Serbian" },
        { GoogleTranscriberLanguage.Slovak, "Slovak" },
        { GoogleTranscriberLanguage.Slovenian, "Slovenian" },
        { GoogleTranscriberLanguage.Spanish, "Spanish" },
        { GoogleTranscriberLanguage.Swahili, "Swahili" },
        { GoogleTranscriberLanguage.Swedish, "Swedish" },
        { GoogleTranscriberLanguage.Thai, "Thai" },
        { GoogleTranscriberLanguage.Turkish, "Turkish" },
        { GoogleTranscriberLanguage.Ukrainian, "Ukrainian" },
        { GoogleTranscriberLanguage.Vietnamese, "Vietnamese" },
    };

    public override GoogleTranscriberLanguage Read(
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
        GoogleTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleTranscriberLanguage ReadAsPropertyName(
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
        GoogleTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
