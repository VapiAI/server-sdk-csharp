using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(XaiVoiceLanguageSerializer))]
public enum XaiVoiceLanguage
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "ar-EG")]
    ArEg,

    [EnumMember(Value = "ar-SA")]
    ArSa,

    [EnumMember(Value = "ar-AE")]
    ArAe,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "pt-PT")]
    PtPt,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "es-MX")]
    EsMx,

    [EnumMember(Value = "es-ES")]
    EsEs,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "vi")]
    Vi,
}

internal class XaiVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<XaiVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        XaiVoiceLanguage
    > _stringToEnum = new()
    {
        { "auto", XaiVoiceLanguage.Auto },
        { "en", XaiVoiceLanguage.En },
        { "ar-EG", XaiVoiceLanguage.ArEg },
        { "ar-SA", XaiVoiceLanguage.ArSa },
        { "ar-AE", XaiVoiceLanguage.ArAe },
        { "bn", XaiVoiceLanguage.Bn },
        { "zh", XaiVoiceLanguage.Zh },
        { "fr", XaiVoiceLanguage.Fr },
        { "de", XaiVoiceLanguage.De },
        { "hi", XaiVoiceLanguage.Hi },
        { "id", XaiVoiceLanguage.Id },
        { "it", XaiVoiceLanguage.It },
        { "ja", XaiVoiceLanguage.Ja },
        { "ko", XaiVoiceLanguage.Ko },
        { "pt-BR", XaiVoiceLanguage.PtBr },
        { "pt-PT", XaiVoiceLanguage.PtPt },
        { "ru", XaiVoiceLanguage.Ru },
        { "es-MX", XaiVoiceLanguage.EsMx },
        { "es-ES", XaiVoiceLanguage.EsEs },
        { "tr", XaiVoiceLanguage.Tr },
        { "vi", XaiVoiceLanguage.Vi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        XaiVoiceLanguage,
        string
    > _enumToString = new()
    {
        { XaiVoiceLanguage.Auto, "auto" },
        { XaiVoiceLanguage.En, "en" },
        { XaiVoiceLanguage.ArEg, "ar-EG" },
        { XaiVoiceLanguage.ArSa, "ar-SA" },
        { XaiVoiceLanguage.ArAe, "ar-AE" },
        { XaiVoiceLanguage.Bn, "bn" },
        { XaiVoiceLanguage.Zh, "zh" },
        { XaiVoiceLanguage.Fr, "fr" },
        { XaiVoiceLanguage.De, "de" },
        { XaiVoiceLanguage.Hi, "hi" },
        { XaiVoiceLanguage.Id, "id" },
        { XaiVoiceLanguage.It, "it" },
        { XaiVoiceLanguage.Ja, "ja" },
        { XaiVoiceLanguage.Ko, "ko" },
        { XaiVoiceLanguage.PtBr, "pt-BR" },
        { XaiVoiceLanguage.PtPt, "pt-PT" },
        { XaiVoiceLanguage.Ru, "ru" },
        { XaiVoiceLanguage.EsMx, "es-MX" },
        { XaiVoiceLanguage.EsEs, "es-ES" },
        { XaiVoiceLanguage.Tr, "tr" },
        { XaiVoiceLanguage.Vi, "vi" },
    };

    public override XaiVoiceLanguage Read(
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
        XaiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override XaiVoiceLanguage ReadAsPropertyName(
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
        XaiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
