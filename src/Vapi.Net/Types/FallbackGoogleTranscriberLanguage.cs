using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGoogleTranscriberLanguageSerializer))]
public enum FallbackGoogleTranscriberLanguage
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

internal class FallbackGoogleTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGoogleTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGoogleTranscriberLanguage
    > _stringToEnum = new()
    {
        { "Multilingual", FallbackGoogleTranscriberLanguage.Multilingual },
        { "Arabic", FallbackGoogleTranscriberLanguage.Arabic },
        { "Bengali", FallbackGoogleTranscriberLanguage.Bengali },
        { "Bulgarian", FallbackGoogleTranscriberLanguage.Bulgarian },
        { "Chinese", FallbackGoogleTranscriberLanguage.Chinese },
        { "Croatian", FallbackGoogleTranscriberLanguage.Croatian },
        { "Czech", FallbackGoogleTranscriberLanguage.Czech },
        { "Danish", FallbackGoogleTranscriberLanguage.Danish },
        { "Dutch", FallbackGoogleTranscriberLanguage.Dutch },
        { "English", FallbackGoogleTranscriberLanguage.English },
        { "Estonian", FallbackGoogleTranscriberLanguage.Estonian },
        { "Finnish", FallbackGoogleTranscriberLanguage.Finnish },
        { "French", FallbackGoogleTranscriberLanguage.French },
        { "German", FallbackGoogleTranscriberLanguage.German },
        { "Greek", FallbackGoogleTranscriberLanguage.Greek },
        { "Hebrew", FallbackGoogleTranscriberLanguage.Hebrew },
        { "Hindi", FallbackGoogleTranscriberLanguage.Hindi },
        { "Hungarian", FallbackGoogleTranscriberLanguage.Hungarian },
        { "Indonesian", FallbackGoogleTranscriberLanguage.Indonesian },
        { "Italian", FallbackGoogleTranscriberLanguage.Italian },
        { "Japanese", FallbackGoogleTranscriberLanguage.Japanese },
        { "Korean", FallbackGoogleTranscriberLanguage.Korean },
        { "Latvian", FallbackGoogleTranscriberLanguage.Latvian },
        { "Lithuanian", FallbackGoogleTranscriberLanguage.Lithuanian },
        { "Norwegian", FallbackGoogleTranscriberLanguage.Norwegian },
        { "Polish", FallbackGoogleTranscriberLanguage.Polish },
        { "Portuguese", FallbackGoogleTranscriberLanguage.Portuguese },
        { "Romanian", FallbackGoogleTranscriberLanguage.Romanian },
        { "Russian", FallbackGoogleTranscriberLanguage.Russian },
        { "Serbian", FallbackGoogleTranscriberLanguage.Serbian },
        { "Slovak", FallbackGoogleTranscriberLanguage.Slovak },
        { "Slovenian", FallbackGoogleTranscriberLanguage.Slovenian },
        { "Spanish", FallbackGoogleTranscriberLanguage.Spanish },
        { "Swahili", FallbackGoogleTranscriberLanguage.Swahili },
        { "Swedish", FallbackGoogleTranscriberLanguage.Swedish },
        { "Thai", FallbackGoogleTranscriberLanguage.Thai },
        { "Turkish", FallbackGoogleTranscriberLanguage.Turkish },
        { "Ukrainian", FallbackGoogleTranscriberLanguage.Ukrainian },
        { "Vietnamese", FallbackGoogleTranscriberLanguage.Vietnamese },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGoogleTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackGoogleTranscriberLanguage.Multilingual, "Multilingual" },
        { FallbackGoogleTranscriberLanguage.Arabic, "Arabic" },
        { FallbackGoogleTranscriberLanguage.Bengali, "Bengali" },
        { FallbackGoogleTranscriberLanguage.Bulgarian, "Bulgarian" },
        { FallbackGoogleTranscriberLanguage.Chinese, "Chinese" },
        { FallbackGoogleTranscriberLanguage.Croatian, "Croatian" },
        { FallbackGoogleTranscriberLanguage.Czech, "Czech" },
        { FallbackGoogleTranscriberLanguage.Danish, "Danish" },
        { FallbackGoogleTranscriberLanguage.Dutch, "Dutch" },
        { FallbackGoogleTranscriberLanguage.English, "English" },
        { FallbackGoogleTranscriberLanguage.Estonian, "Estonian" },
        { FallbackGoogleTranscriberLanguage.Finnish, "Finnish" },
        { FallbackGoogleTranscriberLanguage.French, "French" },
        { FallbackGoogleTranscriberLanguage.German, "German" },
        { FallbackGoogleTranscriberLanguage.Greek, "Greek" },
        { FallbackGoogleTranscriberLanguage.Hebrew, "Hebrew" },
        { FallbackGoogleTranscriberLanguage.Hindi, "Hindi" },
        { FallbackGoogleTranscriberLanguage.Hungarian, "Hungarian" },
        { FallbackGoogleTranscriberLanguage.Indonesian, "Indonesian" },
        { FallbackGoogleTranscriberLanguage.Italian, "Italian" },
        { FallbackGoogleTranscriberLanguage.Japanese, "Japanese" },
        { FallbackGoogleTranscriberLanguage.Korean, "Korean" },
        { FallbackGoogleTranscriberLanguage.Latvian, "Latvian" },
        { FallbackGoogleTranscriberLanguage.Lithuanian, "Lithuanian" },
        { FallbackGoogleTranscriberLanguage.Norwegian, "Norwegian" },
        { FallbackGoogleTranscriberLanguage.Polish, "Polish" },
        { FallbackGoogleTranscriberLanguage.Portuguese, "Portuguese" },
        { FallbackGoogleTranscriberLanguage.Romanian, "Romanian" },
        { FallbackGoogleTranscriberLanguage.Russian, "Russian" },
        { FallbackGoogleTranscriberLanguage.Serbian, "Serbian" },
        { FallbackGoogleTranscriberLanguage.Slovak, "Slovak" },
        { FallbackGoogleTranscriberLanguage.Slovenian, "Slovenian" },
        { FallbackGoogleTranscriberLanguage.Spanish, "Spanish" },
        { FallbackGoogleTranscriberLanguage.Swahili, "Swahili" },
        { FallbackGoogleTranscriberLanguage.Swedish, "Swedish" },
        { FallbackGoogleTranscriberLanguage.Thai, "Thai" },
        { FallbackGoogleTranscriberLanguage.Turkish, "Turkish" },
        { FallbackGoogleTranscriberLanguage.Ukrainian, "Ukrainian" },
        { FallbackGoogleTranscriberLanguage.Vietnamese, "Vietnamese" },
    };

    public override FallbackGoogleTranscriberLanguage Read(
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
        FallbackGoogleTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGoogleTranscriberLanguage ReadAsPropertyName(
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
        FallbackGoogleTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
