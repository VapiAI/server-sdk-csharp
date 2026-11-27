using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackCartesiaVoiceLanguageSerializer))]
public enum FallbackCartesiaVoiceLanguage
{
    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "or")]
    Or,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "bg-BG")]
    BgBg,

    [EnumMember(Value = "bn-IN")]
    BnIn,

    [EnumMember(Value = "cs-CZ")]
    CsCz,

    [EnumMember(Value = "da-DK")]
    DaDk,

    [EnumMember(Value = "de-DE")]
    DeDe,

    [EnumMember(Value = "el-GR")]
    ElGr,

    [EnumMember(Value = "en-AU")]
    EnAu,

    [EnumMember(Value = "en-CA")]
    EnCa,

    [EnumMember(Value = "en-GB")]
    EnGb,

    [EnumMember(Value = "en-IE")]
    EnIe,

    [EnumMember(Value = "en-IN")]
    EnIn,

    [EnumMember(Value = "en-NZ")]
    EnNz,

    [EnumMember(Value = "en-SG")]
    EnSg,

    [EnumMember(Value = "en-US")]
    EnUs,

    [EnumMember(Value = "en-ZA")]
    EnZa,

    [EnumMember(Value = "es-ES")]
    EsEs,

    [EnumMember(Value = "es-MX")]
    EsMx,

    [EnumMember(Value = "es-US")]
    EsUs,

    [EnumMember(Value = "fi-FI")]
    FiFi,

    [EnumMember(Value = "fr-CA")]
    FrCa,

    [EnumMember(Value = "fr-FR")]
    FrFr,

    [EnumMember(Value = "gu-IN")]
    GuIn,

    [EnumMember(Value = "he-IL")]
    HeIl,

    [EnumMember(Value = "hi-IN")]
    HiIn,

    [EnumMember(Value = "hr-HR")]
    HrHr,

    [EnumMember(Value = "hu-HU")]
    HuHu,

    [EnumMember(Value = "id-ID")]
    IdId,

    [EnumMember(Value = "it-IT")]
    ItIt,

    [EnumMember(Value = "ja-JP")]
    JaJp,

    [EnumMember(Value = "ka-GE")]
    KaGe,

    [EnumMember(Value = "kn-IN")]
    KnIn,

    [EnumMember(Value = "ko-KR")]
    KoKr,

    [EnumMember(Value = "ml-IN")]
    MlIn,

    [EnumMember(Value = "mr-IN")]
    MrIn,

    [EnumMember(Value = "ms-MY")]
    MsMy,

    [EnumMember(Value = "nl-BE")]
    NlBe,

    [EnumMember(Value = "nl-NL")]
    NlNl,

    [EnumMember(Value = "no-NO")]
    NoNo,

    [EnumMember(Value = "or-IN")]
    OrIn,

    [EnumMember(Value = "pa-IN")]
    PaIn,

    [EnumMember(Value = "pl-PL")]
    PlPl,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "pt-PT")]
    PtPt,

    [EnumMember(Value = "ro-RO")]
    RoRo,

    [EnumMember(Value = "ru-RU")]
    RuRu,

    [EnumMember(Value = "sk-SK")]
    SkSk,

    [EnumMember(Value = "sv-SE")]
    SvSe,

    [EnumMember(Value = "ta-IN")]
    TaIn,

    [EnumMember(Value = "te-IN")]
    TeIn,

    [EnumMember(Value = "th-TH")]
    ThTh,

    [EnumMember(Value = "tl-PH")]
    TlPh,

    [EnumMember(Value = "tr-TR")]
    TrTr,

    [EnumMember(Value = "uk-UA")]
    UkUa,

    [EnumMember(Value = "ur-IN")]
    UrIn,

    [EnumMember(Value = "vi-VN")]
    ViVn,

    [EnumMember(Value = "zh-CN")]
    ZhCn,
}

internal class FallbackCartesiaVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackCartesiaVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackCartesiaVoiceLanguage
    > _stringToEnum = new()
    {
        { "ar", FallbackCartesiaVoiceLanguage.Ar },
        { "bg", FallbackCartesiaVoiceLanguage.Bg },
        { "bn", FallbackCartesiaVoiceLanguage.Bn },
        { "cs", FallbackCartesiaVoiceLanguage.Cs },
        { "da", FallbackCartesiaVoiceLanguage.Da },
        { "de", FallbackCartesiaVoiceLanguage.De },
        { "el", FallbackCartesiaVoiceLanguage.El },
        { "en", FallbackCartesiaVoiceLanguage.En },
        { "es", FallbackCartesiaVoiceLanguage.Es },
        { "fi", FallbackCartesiaVoiceLanguage.Fi },
        { "fr", FallbackCartesiaVoiceLanguage.Fr },
        { "gu", FallbackCartesiaVoiceLanguage.Gu },
        { "he", FallbackCartesiaVoiceLanguage.He },
        { "hi", FallbackCartesiaVoiceLanguage.Hi },
        { "hr", FallbackCartesiaVoiceLanguage.Hr },
        { "hu", FallbackCartesiaVoiceLanguage.Hu },
        { "id", FallbackCartesiaVoiceLanguage.Id },
        { "it", FallbackCartesiaVoiceLanguage.It },
        { "ja", FallbackCartesiaVoiceLanguage.Ja },
        { "ka", FallbackCartesiaVoiceLanguage.Ka },
        { "kn", FallbackCartesiaVoiceLanguage.Kn },
        { "ko", FallbackCartesiaVoiceLanguage.Ko },
        { "ml", FallbackCartesiaVoiceLanguage.Ml },
        { "mr", FallbackCartesiaVoiceLanguage.Mr },
        { "ms", FallbackCartesiaVoiceLanguage.Ms },
        { "nl", FallbackCartesiaVoiceLanguage.Nl },
        { "no", FallbackCartesiaVoiceLanguage.No },
        { "or", FallbackCartesiaVoiceLanguage.Or },
        { "pa", FallbackCartesiaVoiceLanguage.Pa },
        { "pl", FallbackCartesiaVoiceLanguage.Pl },
        { "pt", FallbackCartesiaVoiceLanguage.Pt },
        { "ro", FallbackCartesiaVoiceLanguage.Ro },
        { "ru", FallbackCartesiaVoiceLanguage.Ru },
        { "sk", FallbackCartesiaVoiceLanguage.Sk },
        { "sv", FallbackCartesiaVoiceLanguage.Sv },
        { "ta", FallbackCartesiaVoiceLanguage.Ta },
        { "te", FallbackCartesiaVoiceLanguage.Te },
        { "th", FallbackCartesiaVoiceLanguage.Th },
        { "tl", FallbackCartesiaVoiceLanguage.Tl },
        { "tr", FallbackCartesiaVoiceLanguage.Tr },
        { "uk", FallbackCartesiaVoiceLanguage.Uk },
        { "ur", FallbackCartesiaVoiceLanguage.Ur },
        { "vi", FallbackCartesiaVoiceLanguage.Vi },
        { "zh", FallbackCartesiaVoiceLanguage.Zh },
        { "bg-BG", FallbackCartesiaVoiceLanguage.BgBg },
        { "bn-IN", FallbackCartesiaVoiceLanguage.BnIn },
        { "cs-CZ", FallbackCartesiaVoiceLanguage.CsCz },
        { "da-DK", FallbackCartesiaVoiceLanguage.DaDk },
        { "de-DE", FallbackCartesiaVoiceLanguage.DeDe },
        { "el-GR", FallbackCartesiaVoiceLanguage.ElGr },
        { "en-AU", FallbackCartesiaVoiceLanguage.EnAu },
        { "en-CA", FallbackCartesiaVoiceLanguage.EnCa },
        { "en-GB", FallbackCartesiaVoiceLanguage.EnGb },
        { "en-IE", FallbackCartesiaVoiceLanguage.EnIe },
        { "en-IN", FallbackCartesiaVoiceLanguage.EnIn },
        { "en-NZ", FallbackCartesiaVoiceLanguage.EnNz },
        { "en-SG", FallbackCartesiaVoiceLanguage.EnSg },
        { "en-US", FallbackCartesiaVoiceLanguage.EnUs },
        { "en-ZA", FallbackCartesiaVoiceLanguage.EnZa },
        { "es-ES", FallbackCartesiaVoiceLanguage.EsEs },
        { "es-MX", FallbackCartesiaVoiceLanguage.EsMx },
        { "es-US", FallbackCartesiaVoiceLanguage.EsUs },
        { "fi-FI", FallbackCartesiaVoiceLanguage.FiFi },
        { "fr-CA", FallbackCartesiaVoiceLanguage.FrCa },
        { "fr-FR", FallbackCartesiaVoiceLanguage.FrFr },
        { "gu-IN", FallbackCartesiaVoiceLanguage.GuIn },
        { "he-IL", FallbackCartesiaVoiceLanguage.HeIl },
        { "hi-IN", FallbackCartesiaVoiceLanguage.HiIn },
        { "hr-HR", FallbackCartesiaVoiceLanguage.HrHr },
        { "hu-HU", FallbackCartesiaVoiceLanguage.HuHu },
        { "id-ID", FallbackCartesiaVoiceLanguage.IdId },
        { "it-IT", FallbackCartesiaVoiceLanguage.ItIt },
        { "ja-JP", FallbackCartesiaVoiceLanguage.JaJp },
        { "ka-GE", FallbackCartesiaVoiceLanguage.KaGe },
        { "kn-IN", FallbackCartesiaVoiceLanguage.KnIn },
        { "ko-KR", FallbackCartesiaVoiceLanguage.KoKr },
        { "ml-IN", FallbackCartesiaVoiceLanguage.MlIn },
        { "mr-IN", FallbackCartesiaVoiceLanguage.MrIn },
        { "ms-MY", FallbackCartesiaVoiceLanguage.MsMy },
        { "nl-BE", FallbackCartesiaVoiceLanguage.NlBe },
        { "nl-NL", FallbackCartesiaVoiceLanguage.NlNl },
        { "no-NO", FallbackCartesiaVoiceLanguage.NoNo },
        { "or-IN", FallbackCartesiaVoiceLanguage.OrIn },
        { "pa-IN", FallbackCartesiaVoiceLanguage.PaIn },
        { "pl-PL", FallbackCartesiaVoiceLanguage.PlPl },
        { "pt-BR", FallbackCartesiaVoiceLanguage.PtBr },
        { "pt-PT", FallbackCartesiaVoiceLanguage.PtPt },
        { "ro-RO", FallbackCartesiaVoiceLanguage.RoRo },
        { "ru-RU", FallbackCartesiaVoiceLanguage.RuRu },
        { "sk-SK", FallbackCartesiaVoiceLanguage.SkSk },
        { "sv-SE", FallbackCartesiaVoiceLanguage.SvSe },
        { "ta-IN", FallbackCartesiaVoiceLanguage.TaIn },
        { "te-IN", FallbackCartesiaVoiceLanguage.TeIn },
        { "th-TH", FallbackCartesiaVoiceLanguage.ThTh },
        { "tl-PH", FallbackCartesiaVoiceLanguage.TlPh },
        { "tr-TR", FallbackCartesiaVoiceLanguage.TrTr },
        { "uk-UA", FallbackCartesiaVoiceLanguage.UkUa },
        { "ur-IN", FallbackCartesiaVoiceLanguage.UrIn },
        { "vi-VN", FallbackCartesiaVoiceLanguage.ViVn },
        { "zh-CN", FallbackCartesiaVoiceLanguage.ZhCn },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackCartesiaVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackCartesiaVoiceLanguage.Ar, "ar" },
        { FallbackCartesiaVoiceLanguage.Bg, "bg" },
        { FallbackCartesiaVoiceLanguage.Bn, "bn" },
        { FallbackCartesiaVoiceLanguage.Cs, "cs" },
        { FallbackCartesiaVoiceLanguage.Da, "da" },
        { FallbackCartesiaVoiceLanguage.De, "de" },
        { FallbackCartesiaVoiceLanguage.El, "el" },
        { FallbackCartesiaVoiceLanguage.En, "en" },
        { FallbackCartesiaVoiceLanguage.Es, "es" },
        { FallbackCartesiaVoiceLanguage.Fi, "fi" },
        { FallbackCartesiaVoiceLanguage.Fr, "fr" },
        { FallbackCartesiaVoiceLanguage.Gu, "gu" },
        { FallbackCartesiaVoiceLanguage.He, "he" },
        { FallbackCartesiaVoiceLanguage.Hi, "hi" },
        { FallbackCartesiaVoiceLanguage.Hr, "hr" },
        { FallbackCartesiaVoiceLanguage.Hu, "hu" },
        { FallbackCartesiaVoiceLanguage.Id, "id" },
        { FallbackCartesiaVoiceLanguage.It, "it" },
        { FallbackCartesiaVoiceLanguage.Ja, "ja" },
        { FallbackCartesiaVoiceLanguage.Ka, "ka" },
        { FallbackCartesiaVoiceLanguage.Kn, "kn" },
        { FallbackCartesiaVoiceLanguage.Ko, "ko" },
        { FallbackCartesiaVoiceLanguage.Ml, "ml" },
        { FallbackCartesiaVoiceLanguage.Mr, "mr" },
        { FallbackCartesiaVoiceLanguage.Ms, "ms" },
        { FallbackCartesiaVoiceLanguage.Nl, "nl" },
        { FallbackCartesiaVoiceLanguage.No, "no" },
        { FallbackCartesiaVoiceLanguage.Or, "or" },
        { FallbackCartesiaVoiceLanguage.Pa, "pa" },
        { FallbackCartesiaVoiceLanguage.Pl, "pl" },
        { FallbackCartesiaVoiceLanguage.Pt, "pt" },
        { FallbackCartesiaVoiceLanguage.Ro, "ro" },
        { FallbackCartesiaVoiceLanguage.Ru, "ru" },
        { FallbackCartesiaVoiceLanguage.Sk, "sk" },
        { FallbackCartesiaVoiceLanguage.Sv, "sv" },
        { FallbackCartesiaVoiceLanguage.Ta, "ta" },
        { FallbackCartesiaVoiceLanguage.Te, "te" },
        { FallbackCartesiaVoiceLanguage.Th, "th" },
        { FallbackCartesiaVoiceLanguage.Tl, "tl" },
        { FallbackCartesiaVoiceLanguage.Tr, "tr" },
        { FallbackCartesiaVoiceLanguage.Uk, "uk" },
        { FallbackCartesiaVoiceLanguage.Ur, "ur" },
        { FallbackCartesiaVoiceLanguage.Vi, "vi" },
        { FallbackCartesiaVoiceLanguage.Zh, "zh" },
        { FallbackCartesiaVoiceLanguage.BgBg, "bg-BG" },
        { FallbackCartesiaVoiceLanguage.BnIn, "bn-IN" },
        { FallbackCartesiaVoiceLanguage.CsCz, "cs-CZ" },
        { FallbackCartesiaVoiceLanguage.DaDk, "da-DK" },
        { FallbackCartesiaVoiceLanguage.DeDe, "de-DE" },
        { FallbackCartesiaVoiceLanguage.ElGr, "el-GR" },
        { FallbackCartesiaVoiceLanguage.EnAu, "en-AU" },
        { FallbackCartesiaVoiceLanguage.EnCa, "en-CA" },
        { FallbackCartesiaVoiceLanguage.EnGb, "en-GB" },
        { FallbackCartesiaVoiceLanguage.EnIe, "en-IE" },
        { FallbackCartesiaVoiceLanguage.EnIn, "en-IN" },
        { FallbackCartesiaVoiceLanguage.EnNz, "en-NZ" },
        { FallbackCartesiaVoiceLanguage.EnSg, "en-SG" },
        { FallbackCartesiaVoiceLanguage.EnUs, "en-US" },
        { FallbackCartesiaVoiceLanguage.EnZa, "en-ZA" },
        { FallbackCartesiaVoiceLanguage.EsEs, "es-ES" },
        { FallbackCartesiaVoiceLanguage.EsMx, "es-MX" },
        { FallbackCartesiaVoiceLanguage.EsUs, "es-US" },
        { FallbackCartesiaVoiceLanguage.FiFi, "fi-FI" },
        { FallbackCartesiaVoiceLanguage.FrCa, "fr-CA" },
        { FallbackCartesiaVoiceLanguage.FrFr, "fr-FR" },
        { FallbackCartesiaVoiceLanguage.GuIn, "gu-IN" },
        { FallbackCartesiaVoiceLanguage.HeIl, "he-IL" },
        { FallbackCartesiaVoiceLanguage.HiIn, "hi-IN" },
        { FallbackCartesiaVoiceLanguage.HrHr, "hr-HR" },
        { FallbackCartesiaVoiceLanguage.HuHu, "hu-HU" },
        { FallbackCartesiaVoiceLanguage.IdId, "id-ID" },
        { FallbackCartesiaVoiceLanguage.ItIt, "it-IT" },
        { FallbackCartesiaVoiceLanguage.JaJp, "ja-JP" },
        { FallbackCartesiaVoiceLanguage.KaGe, "ka-GE" },
        { FallbackCartesiaVoiceLanguage.KnIn, "kn-IN" },
        { FallbackCartesiaVoiceLanguage.KoKr, "ko-KR" },
        { FallbackCartesiaVoiceLanguage.MlIn, "ml-IN" },
        { FallbackCartesiaVoiceLanguage.MrIn, "mr-IN" },
        { FallbackCartesiaVoiceLanguage.MsMy, "ms-MY" },
        { FallbackCartesiaVoiceLanguage.NlBe, "nl-BE" },
        { FallbackCartesiaVoiceLanguage.NlNl, "nl-NL" },
        { FallbackCartesiaVoiceLanguage.NoNo, "no-NO" },
        { FallbackCartesiaVoiceLanguage.OrIn, "or-IN" },
        { FallbackCartesiaVoiceLanguage.PaIn, "pa-IN" },
        { FallbackCartesiaVoiceLanguage.PlPl, "pl-PL" },
        { FallbackCartesiaVoiceLanguage.PtBr, "pt-BR" },
        { FallbackCartesiaVoiceLanguage.PtPt, "pt-PT" },
        { FallbackCartesiaVoiceLanguage.RoRo, "ro-RO" },
        { FallbackCartesiaVoiceLanguage.RuRu, "ru-RU" },
        { FallbackCartesiaVoiceLanguage.SkSk, "sk-SK" },
        { FallbackCartesiaVoiceLanguage.SvSe, "sv-SE" },
        { FallbackCartesiaVoiceLanguage.TaIn, "ta-IN" },
        { FallbackCartesiaVoiceLanguage.TeIn, "te-IN" },
        { FallbackCartesiaVoiceLanguage.ThTh, "th-TH" },
        { FallbackCartesiaVoiceLanguage.TlPh, "tl-PH" },
        { FallbackCartesiaVoiceLanguage.TrTr, "tr-TR" },
        { FallbackCartesiaVoiceLanguage.UkUa, "uk-UA" },
        { FallbackCartesiaVoiceLanguage.UrIn, "ur-IN" },
        { FallbackCartesiaVoiceLanguage.ViVn, "vi-VN" },
        { FallbackCartesiaVoiceLanguage.ZhCn, "zh-CN" },
    };

    public override FallbackCartesiaVoiceLanguage Read(
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
        FallbackCartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackCartesiaVoiceLanguage ReadAsPropertyName(
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
        FallbackCartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
