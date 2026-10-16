using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackVapiVoiceLanguageSerializer))]
public enum FallbackVapiVoiceLanguage
{
    [EnumMember(Value = "en-US")]
    EnUs,

    [EnumMember(Value = "en-GB")]
    EnGb,

    [EnumMember(Value = "en-AU")]
    EnAu,

    [EnumMember(Value = "en-CA")]
    EnCa,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "fr-FR")]
    FrFr,

    [EnumMember(Value = "fr-CA")]
    FrCa,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "pt-PT")]
    PtPt,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "es-ES")]
    EsEs,

    [EnumMember(Value = "es-MX")]
    EsMx,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "fil")]
    Fil,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ar-SA")]
    ArSa,

    [EnumMember(Value = "ar-AE")]
    ArAe,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "ar-EG")]
    ArEg,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tl")]
    Tl,
}

internal class FallbackVapiVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackVapiVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackVapiVoiceLanguage
    > _stringToEnum = new()
    {
        { "en-US", FallbackVapiVoiceLanguage.EnUs },
        { "en-GB", FallbackVapiVoiceLanguage.EnGb },
        { "en-AU", FallbackVapiVoiceLanguage.EnAu },
        { "en-CA", FallbackVapiVoiceLanguage.EnCa },
        { "ja", FallbackVapiVoiceLanguage.Ja },
        { "zh", FallbackVapiVoiceLanguage.Zh },
        { "de", FallbackVapiVoiceLanguage.De },
        { "hi", FallbackVapiVoiceLanguage.Hi },
        { "fr-FR", FallbackVapiVoiceLanguage.FrFr },
        { "fr-CA", FallbackVapiVoiceLanguage.FrCa },
        { "ko", FallbackVapiVoiceLanguage.Ko },
        { "pt-BR", FallbackVapiVoiceLanguage.PtBr },
        { "pt-PT", FallbackVapiVoiceLanguage.PtPt },
        { "it", FallbackVapiVoiceLanguage.It },
        { "es-ES", FallbackVapiVoiceLanguage.EsEs },
        { "es-MX", FallbackVapiVoiceLanguage.EsMx },
        { "id", FallbackVapiVoiceLanguage.Id },
        { "nl", FallbackVapiVoiceLanguage.Nl },
        { "tr", FallbackVapiVoiceLanguage.Tr },
        { "fil", FallbackVapiVoiceLanguage.Fil },
        { "pl", FallbackVapiVoiceLanguage.Pl },
        { "sv", FallbackVapiVoiceLanguage.Sv },
        { "bg", FallbackVapiVoiceLanguage.Bg },
        { "ro", FallbackVapiVoiceLanguage.Ro },
        { "ar-SA", FallbackVapiVoiceLanguage.ArSa },
        { "ar-AE", FallbackVapiVoiceLanguage.ArAe },
        { "cs", FallbackVapiVoiceLanguage.Cs },
        { "el", FallbackVapiVoiceLanguage.El },
        { "fi", FallbackVapiVoiceLanguage.Fi },
        { "hr", FallbackVapiVoiceLanguage.Hr },
        { "ms", FallbackVapiVoiceLanguage.Ms },
        { "sk", FallbackVapiVoiceLanguage.Sk },
        { "da", FallbackVapiVoiceLanguage.Da },
        { "ta", FallbackVapiVoiceLanguage.Ta },
        { "uk", FallbackVapiVoiceLanguage.Uk },
        { "ru", FallbackVapiVoiceLanguage.Ru },
        { "hu", FallbackVapiVoiceLanguage.Hu },
        { "no", FallbackVapiVoiceLanguage.No },
        { "vi", FallbackVapiVoiceLanguage.Vi },
        { "auto", FallbackVapiVoiceLanguage.Auto },
        { "en", FallbackVapiVoiceLanguage.En },
        { "ar", FallbackVapiVoiceLanguage.Ar },
        { "ar-EG", FallbackVapiVoiceLanguage.ArEg },
        { "bn", FallbackVapiVoiceLanguage.Bn },
        { "es", FallbackVapiVoiceLanguage.Es },
        { "fr", FallbackVapiVoiceLanguage.Fr },
        { "gu", FallbackVapiVoiceLanguage.Gu },
        { "he", FallbackVapiVoiceLanguage.He },
        { "ka", FallbackVapiVoiceLanguage.Ka },
        { "kn", FallbackVapiVoiceLanguage.Kn },
        { "ml", FallbackVapiVoiceLanguage.Ml },
        { "mr", FallbackVapiVoiceLanguage.Mr },
        { "pa", FallbackVapiVoiceLanguage.Pa },
        { "pt", FallbackVapiVoiceLanguage.Pt },
        { "te", FallbackVapiVoiceLanguage.Te },
        { "th", FallbackVapiVoiceLanguage.Th },
        { "tl", FallbackVapiVoiceLanguage.Tl },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackVapiVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackVapiVoiceLanguage.EnUs, "en-US" },
        { FallbackVapiVoiceLanguage.EnGb, "en-GB" },
        { FallbackVapiVoiceLanguage.EnAu, "en-AU" },
        { FallbackVapiVoiceLanguage.EnCa, "en-CA" },
        { FallbackVapiVoiceLanguage.Ja, "ja" },
        { FallbackVapiVoiceLanguage.Zh, "zh" },
        { FallbackVapiVoiceLanguage.De, "de" },
        { FallbackVapiVoiceLanguage.Hi, "hi" },
        { FallbackVapiVoiceLanguage.FrFr, "fr-FR" },
        { FallbackVapiVoiceLanguage.FrCa, "fr-CA" },
        { FallbackVapiVoiceLanguage.Ko, "ko" },
        { FallbackVapiVoiceLanguage.PtBr, "pt-BR" },
        { FallbackVapiVoiceLanguage.PtPt, "pt-PT" },
        { FallbackVapiVoiceLanguage.It, "it" },
        { FallbackVapiVoiceLanguage.EsEs, "es-ES" },
        { FallbackVapiVoiceLanguage.EsMx, "es-MX" },
        { FallbackVapiVoiceLanguage.Id, "id" },
        { FallbackVapiVoiceLanguage.Nl, "nl" },
        { FallbackVapiVoiceLanguage.Tr, "tr" },
        { FallbackVapiVoiceLanguage.Fil, "fil" },
        { FallbackVapiVoiceLanguage.Pl, "pl" },
        { FallbackVapiVoiceLanguage.Sv, "sv" },
        { FallbackVapiVoiceLanguage.Bg, "bg" },
        { FallbackVapiVoiceLanguage.Ro, "ro" },
        { FallbackVapiVoiceLanguage.ArSa, "ar-SA" },
        { FallbackVapiVoiceLanguage.ArAe, "ar-AE" },
        { FallbackVapiVoiceLanguage.Cs, "cs" },
        { FallbackVapiVoiceLanguage.El, "el" },
        { FallbackVapiVoiceLanguage.Fi, "fi" },
        { FallbackVapiVoiceLanguage.Hr, "hr" },
        { FallbackVapiVoiceLanguage.Ms, "ms" },
        { FallbackVapiVoiceLanguage.Sk, "sk" },
        { FallbackVapiVoiceLanguage.Da, "da" },
        { FallbackVapiVoiceLanguage.Ta, "ta" },
        { FallbackVapiVoiceLanguage.Uk, "uk" },
        { FallbackVapiVoiceLanguage.Ru, "ru" },
        { FallbackVapiVoiceLanguage.Hu, "hu" },
        { FallbackVapiVoiceLanguage.No, "no" },
        { FallbackVapiVoiceLanguage.Vi, "vi" },
        { FallbackVapiVoiceLanguage.Auto, "auto" },
        { FallbackVapiVoiceLanguage.En, "en" },
        { FallbackVapiVoiceLanguage.Ar, "ar" },
        { FallbackVapiVoiceLanguage.ArEg, "ar-EG" },
        { FallbackVapiVoiceLanguage.Bn, "bn" },
        { FallbackVapiVoiceLanguage.Es, "es" },
        { FallbackVapiVoiceLanguage.Fr, "fr" },
        { FallbackVapiVoiceLanguage.Gu, "gu" },
        { FallbackVapiVoiceLanguage.He, "he" },
        { FallbackVapiVoiceLanguage.Ka, "ka" },
        { FallbackVapiVoiceLanguage.Kn, "kn" },
        { FallbackVapiVoiceLanguage.Ml, "ml" },
        { FallbackVapiVoiceLanguage.Mr, "mr" },
        { FallbackVapiVoiceLanguage.Pa, "pa" },
        { FallbackVapiVoiceLanguage.Pt, "pt" },
        { FallbackVapiVoiceLanguage.Te, "te" },
        { FallbackVapiVoiceLanguage.Th, "th" },
        { FallbackVapiVoiceLanguage.Tl, "tl" },
    };

    public override FallbackVapiVoiceLanguage Read(
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
        FallbackVapiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackVapiVoiceLanguage ReadAsPropertyName(
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
        FallbackVapiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
