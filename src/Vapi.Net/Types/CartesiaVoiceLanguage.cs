using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaVoiceLanguageSerializer))]
public enum CartesiaVoiceLanguage
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

internal class CartesiaVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaVoiceLanguage
    > _stringToEnum = new()
    {
        { "ar", CartesiaVoiceLanguage.Ar },
        { "bg", CartesiaVoiceLanguage.Bg },
        { "bn", CartesiaVoiceLanguage.Bn },
        { "cs", CartesiaVoiceLanguage.Cs },
        { "da", CartesiaVoiceLanguage.Da },
        { "de", CartesiaVoiceLanguage.De },
        { "el", CartesiaVoiceLanguage.El },
        { "en", CartesiaVoiceLanguage.En },
        { "es", CartesiaVoiceLanguage.Es },
        { "fi", CartesiaVoiceLanguage.Fi },
        { "fr", CartesiaVoiceLanguage.Fr },
        { "gu", CartesiaVoiceLanguage.Gu },
        { "he", CartesiaVoiceLanguage.He },
        { "hi", CartesiaVoiceLanguage.Hi },
        { "hr", CartesiaVoiceLanguage.Hr },
        { "hu", CartesiaVoiceLanguage.Hu },
        { "id", CartesiaVoiceLanguage.Id },
        { "it", CartesiaVoiceLanguage.It },
        { "ja", CartesiaVoiceLanguage.Ja },
        { "ka", CartesiaVoiceLanguage.Ka },
        { "kn", CartesiaVoiceLanguage.Kn },
        { "ko", CartesiaVoiceLanguage.Ko },
        { "ml", CartesiaVoiceLanguage.Ml },
        { "mr", CartesiaVoiceLanguage.Mr },
        { "ms", CartesiaVoiceLanguage.Ms },
        { "nl", CartesiaVoiceLanguage.Nl },
        { "no", CartesiaVoiceLanguage.No },
        { "or", CartesiaVoiceLanguage.Or },
        { "pa", CartesiaVoiceLanguage.Pa },
        { "pl", CartesiaVoiceLanguage.Pl },
        { "pt", CartesiaVoiceLanguage.Pt },
        { "ro", CartesiaVoiceLanguage.Ro },
        { "ru", CartesiaVoiceLanguage.Ru },
        { "sk", CartesiaVoiceLanguage.Sk },
        { "sv", CartesiaVoiceLanguage.Sv },
        { "ta", CartesiaVoiceLanguage.Ta },
        { "te", CartesiaVoiceLanguage.Te },
        { "th", CartesiaVoiceLanguage.Th },
        { "tl", CartesiaVoiceLanguage.Tl },
        { "tr", CartesiaVoiceLanguage.Tr },
        { "uk", CartesiaVoiceLanguage.Uk },
        { "ur", CartesiaVoiceLanguage.Ur },
        { "vi", CartesiaVoiceLanguage.Vi },
        { "zh", CartesiaVoiceLanguage.Zh },
        { "bg-BG", CartesiaVoiceLanguage.BgBg },
        { "bn-IN", CartesiaVoiceLanguage.BnIn },
        { "cs-CZ", CartesiaVoiceLanguage.CsCz },
        { "da-DK", CartesiaVoiceLanguage.DaDk },
        { "de-DE", CartesiaVoiceLanguage.DeDe },
        { "el-GR", CartesiaVoiceLanguage.ElGr },
        { "en-AU", CartesiaVoiceLanguage.EnAu },
        { "en-CA", CartesiaVoiceLanguage.EnCa },
        { "en-GB", CartesiaVoiceLanguage.EnGb },
        { "en-IE", CartesiaVoiceLanguage.EnIe },
        { "en-IN", CartesiaVoiceLanguage.EnIn },
        { "en-NZ", CartesiaVoiceLanguage.EnNz },
        { "en-SG", CartesiaVoiceLanguage.EnSg },
        { "en-US", CartesiaVoiceLanguage.EnUs },
        { "en-ZA", CartesiaVoiceLanguage.EnZa },
        { "es-ES", CartesiaVoiceLanguage.EsEs },
        { "es-MX", CartesiaVoiceLanguage.EsMx },
        { "es-US", CartesiaVoiceLanguage.EsUs },
        { "fi-FI", CartesiaVoiceLanguage.FiFi },
        { "fr-CA", CartesiaVoiceLanguage.FrCa },
        { "fr-FR", CartesiaVoiceLanguage.FrFr },
        { "gu-IN", CartesiaVoiceLanguage.GuIn },
        { "he-IL", CartesiaVoiceLanguage.HeIl },
        { "hi-IN", CartesiaVoiceLanguage.HiIn },
        { "hr-HR", CartesiaVoiceLanguage.HrHr },
        { "hu-HU", CartesiaVoiceLanguage.HuHu },
        { "id-ID", CartesiaVoiceLanguage.IdId },
        { "it-IT", CartesiaVoiceLanguage.ItIt },
        { "ja-JP", CartesiaVoiceLanguage.JaJp },
        { "ka-GE", CartesiaVoiceLanguage.KaGe },
        { "kn-IN", CartesiaVoiceLanguage.KnIn },
        { "ko-KR", CartesiaVoiceLanguage.KoKr },
        { "ml-IN", CartesiaVoiceLanguage.MlIn },
        { "mr-IN", CartesiaVoiceLanguage.MrIn },
        { "ms-MY", CartesiaVoiceLanguage.MsMy },
        { "nl-BE", CartesiaVoiceLanguage.NlBe },
        { "nl-NL", CartesiaVoiceLanguage.NlNl },
        { "no-NO", CartesiaVoiceLanguage.NoNo },
        { "or-IN", CartesiaVoiceLanguage.OrIn },
        { "pa-IN", CartesiaVoiceLanguage.PaIn },
        { "pl-PL", CartesiaVoiceLanguage.PlPl },
        { "pt-BR", CartesiaVoiceLanguage.PtBr },
        { "pt-PT", CartesiaVoiceLanguage.PtPt },
        { "ro-RO", CartesiaVoiceLanguage.RoRo },
        { "ru-RU", CartesiaVoiceLanguage.RuRu },
        { "sk-SK", CartesiaVoiceLanguage.SkSk },
        { "sv-SE", CartesiaVoiceLanguage.SvSe },
        { "ta-IN", CartesiaVoiceLanguage.TaIn },
        { "te-IN", CartesiaVoiceLanguage.TeIn },
        { "th-TH", CartesiaVoiceLanguage.ThTh },
        { "tl-PH", CartesiaVoiceLanguage.TlPh },
        { "tr-TR", CartesiaVoiceLanguage.TrTr },
        { "uk-UA", CartesiaVoiceLanguage.UkUa },
        { "ur-IN", CartesiaVoiceLanguage.UrIn },
        { "vi-VN", CartesiaVoiceLanguage.ViVn },
        { "zh-CN", CartesiaVoiceLanguage.ZhCn },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaVoiceLanguage,
        string
    > _enumToString = new()
    {
        { CartesiaVoiceLanguage.Ar, "ar" },
        { CartesiaVoiceLanguage.Bg, "bg" },
        { CartesiaVoiceLanguage.Bn, "bn" },
        { CartesiaVoiceLanguage.Cs, "cs" },
        { CartesiaVoiceLanguage.Da, "da" },
        { CartesiaVoiceLanguage.De, "de" },
        { CartesiaVoiceLanguage.El, "el" },
        { CartesiaVoiceLanguage.En, "en" },
        { CartesiaVoiceLanguage.Es, "es" },
        { CartesiaVoiceLanguage.Fi, "fi" },
        { CartesiaVoiceLanguage.Fr, "fr" },
        { CartesiaVoiceLanguage.Gu, "gu" },
        { CartesiaVoiceLanguage.He, "he" },
        { CartesiaVoiceLanguage.Hi, "hi" },
        { CartesiaVoiceLanguage.Hr, "hr" },
        { CartesiaVoiceLanguage.Hu, "hu" },
        { CartesiaVoiceLanguage.Id, "id" },
        { CartesiaVoiceLanguage.It, "it" },
        { CartesiaVoiceLanguage.Ja, "ja" },
        { CartesiaVoiceLanguage.Ka, "ka" },
        { CartesiaVoiceLanguage.Kn, "kn" },
        { CartesiaVoiceLanguage.Ko, "ko" },
        { CartesiaVoiceLanguage.Ml, "ml" },
        { CartesiaVoiceLanguage.Mr, "mr" },
        { CartesiaVoiceLanguage.Ms, "ms" },
        { CartesiaVoiceLanguage.Nl, "nl" },
        { CartesiaVoiceLanguage.No, "no" },
        { CartesiaVoiceLanguage.Or, "or" },
        { CartesiaVoiceLanguage.Pa, "pa" },
        { CartesiaVoiceLanguage.Pl, "pl" },
        { CartesiaVoiceLanguage.Pt, "pt" },
        { CartesiaVoiceLanguage.Ro, "ro" },
        { CartesiaVoiceLanguage.Ru, "ru" },
        { CartesiaVoiceLanguage.Sk, "sk" },
        { CartesiaVoiceLanguage.Sv, "sv" },
        { CartesiaVoiceLanguage.Ta, "ta" },
        { CartesiaVoiceLanguage.Te, "te" },
        { CartesiaVoiceLanguage.Th, "th" },
        { CartesiaVoiceLanguage.Tl, "tl" },
        { CartesiaVoiceLanguage.Tr, "tr" },
        { CartesiaVoiceLanguage.Uk, "uk" },
        { CartesiaVoiceLanguage.Ur, "ur" },
        { CartesiaVoiceLanguage.Vi, "vi" },
        { CartesiaVoiceLanguage.Zh, "zh" },
        { CartesiaVoiceLanguage.BgBg, "bg-BG" },
        { CartesiaVoiceLanguage.BnIn, "bn-IN" },
        { CartesiaVoiceLanguage.CsCz, "cs-CZ" },
        { CartesiaVoiceLanguage.DaDk, "da-DK" },
        { CartesiaVoiceLanguage.DeDe, "de-DE" },
        { CartesiaVoiceLanguage.ElGr, "el-GR" },
        { CartesiaVoiceLanguage.EnAu, "en-AU" },
        { CartesiaVoiceLanguage.EnCa, "en-CA" },
        { CartesiaVoiceLanguage.EnGb, "en-GB" },
        { CartesiaVoiceLanguage.EnIe, "en-IE" },
        { CartesiaVoiceLanguage.EnIn, "en-IN" },
        { CartesiaVoiceLanguage.EnNz, "en-NZ" },
        { CartesiaVoiceLanguage.EnSg, "en-SG" },
        { CartesiaVoiceLanguage.EnUs, "en-US" },
        { CartesiaVoiceLanguage.EnZa, "en-ZA" },
        { CartesiaVoiceLanguage.EsEs, "es-ES" },
        { CartesiaVoiceLanguage.EsMx, "es-MX" },
        { CartesiaVoiceLanguage.EsUs, "es-US" },
        { CartesiaVoiceLanguage.FiFi, "fi-FI" },
        { CartesiaVoiceLanguage.FrCa, "fr-CA" },
        { CartesiaVoiceLanguage.FrFr, "fr-FR" },
        { CartesiaVoiceLanguage.GuIn, "gu-IN" },
        { CartesiaVoiceLanguage.HeIl, "he-IL" },
        { CartesiaVoiceLanguage.HiIn, "hi-IN" },
        { CartesiaVoiceLanguage.HrHr, "hr-HR" },
        { CartesiaVoiceLanguage.HuHu, "hu-HU" },
        { CartesiaVoiceLanguage.IdId, "id-ID" },
        { CartesiaVoiceLanguage.ItIt, "it-IT" },
        { CartesiaVoiceLanguage.JaJp, "ja-JP" },
        { CartesiaVoiceLanguage.KaGe, "ka-GE" },
        { CartesiaVoiceLanguage.KnIn, "kn-IN" },
        { CartesiaVoiceLanguage.KoKr, "ko-KR" },
        { CartesiaVoiceLanguage.MlIn, "ml-IN" },
        { CartesiaVoiceLanguage.MrIn, "mr-IN" },
        { CartesiaVoiceLanguage.MsMy, "ms-MY" },
        { CartesiaVoiceLanguage.NlBe, "nl-BE" },
        { CartesiaVoiceLanguage.NlNl, "nl-NL" },
        { CartesiaVoiceLanguage.NoNo, "no-NO" },
        { CartesiaVoiceLanguage.OrIn, "or-IN" },
        { CartesiaVoiceLanguage.PaIn, "pa-IN" },
        { CartesiaVoiceLanguage.PlPl, "pl-PL" },
        { CartesiaVoiceLanguage.PtBr, "pt-BR" },
        { CartesiaVoiceLanguage.PtPt, "pt-PT" },
        { CartesiaVoiceLanguage.RoRo, "ro-RO" },
        { CartesiaVoiceLanguage.RuRu, "ru-RU" },
        { CartesiaVoiceLanguage.SkSk, "sk-SK" },
        { CartesiaVoiceLanguage.SvSe, "sv-SE" },
        { CartesiaVoiceLanguage.TaIn, "ta-IN" },
        { CartesiaVoiceLanguage.TeIn, "te-IN" },
        { CartesiaVoiceLanguage.ThTh, "th-TH" },
        { CartesiaVoiceLanguage.TlPh, "tl-PH" },
        { CartesiaVoiceLanguage.TrTr, "tr-TR" },
        { CartesiaVoiceLanguage.UkUa, "uk-UA" },
        { CartesiaVoiceLanguage.UrIn, "ur-IN" },
        { CartesiaVoiceLanguage.ViVn, "vi-VN" },
        { CartesiaVoiceLanguage.ZhCn, "zh-CN" },
    };

    public override CartesiaVoiceLanguage Read(
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
        CartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaVoiceLanguage ReadAsPropertyName(
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
        CartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
