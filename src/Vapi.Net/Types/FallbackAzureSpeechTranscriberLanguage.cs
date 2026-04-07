using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAzureSpeechTranscriberLanguageSerializer))]
public enum FallbackAzureSpeechTranscriberLanguage
{
    [EnumMember(Value = "af-ZA")]
    AfZa,

    [EnumMember(Value = "am-ET")]
    AmEt,

    [EnumMember(Value = "ar-AE")]
    ArAe,

    [EnumMember(Value = "ar-BH")]
    ArBh,

    [EnumMember(Value = "ar-DZ")]
    ArDz,

    [EnumMember(Value = "ar-EG")]
    ArEg,

    [EnumMember(Value = "ar-IL")]
    ArIl,

    [EnumMember(Value = "ar-IQ")]
    ArIq,

    [EnumMember(Value = "ar-JO")]
    ArJo,

    [EnumMember(Value = "ar-KW")]
    ArKw,

    [EnumMember(Value = "ar-LB")]
    ArLb,

    [EnumMember(Value = "ar-LY")]
    ArLy,

    [EnumMember(Value = "ar-MA")]
    ArMa,

    [EnumMember(Value = "ar-OM")]
    ArOm,

    [EnumMember(Value = "ar-PS")]
    ArPs,

    [EnumMember(Value = "ar-QA")]
    ArQa,

    [EnumMember(Value = "ar-SA")]
    ArSa,

    [EnumMember(Value = "ar-SY")]
    ArSy,

    [EnumMember(Value = "ar-TN")]
    ArTn,

    [EnumMember(Value = "ar-YE")]
    ArYe,

    [EnumMember(Value = "az-AZ")]
    AzAz,

    [EnumMember(Value = "bg-BG")]
    BgBg,

    [EnumMember(Value = "bn-IN")]
    BnIn,

    [EnumMember(Value = "bs-BA")]
    BsBa,

    [EnumMember(Value = "ca-ES")]
    CaEs,

    [EnumMember(Value = "cs-CZ")]
    CsCz,

    [EnumMember(Value = "cy-GB")]
    CyGb,

    [EnumMember(Value = "da-DK")]
    DaDk,

    [EnumMember(Value = "de-AT")]
    DeAt,

    [EnumMember(Value = "de-CH")]
    DeCh,

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

    [EnumMember(Value = "en-GH")]
    EnGh,

    [EnumMember(Value = "en-HK")]
    EnHk,

    [EnumMember(Value = "en-IE")]
    EnIe,

    [EnumMember(Value = "en-IN")]
    EnIn,

    [EnumMember(Value = "en-KE")]
    EnKe,

    [EnumMember(Value = "en-NG")]
    EnNg,

    [EnumMember(Value = "en-NZ")]
    EnNz,

    [EnumMember(Value = "en-PH")]
    EnPh,

    [EnumMember(Value = "en-SG")]
    EnSg,

    [EnumMember(Value = "en-TZ")]
    EnTz,

    [EnumMember(Value = "en-US")]
    EnUs,

    [EnumMember(Value = "en-ZA")]
    EnZa,

    [EnumMember(Value = "es-AR")]
    EsAr,

    [EnumMember(Value = "es-BO")]
    EsBo,

    [EnumMember(Value = "es-CL")]
    EsCl,

    [EnumMember(Value = "es-CO")]
    EsCo,

    [EnumMember(Value = "es-CR")]
    EsCr,

    [EnumMember(Value = "es-CU")]
    EsCu,

    [EnumMember(Value = "es-DO")]
    EsDo,

    [EnumMember(Value = "es-EC")]
    EsEc,

    [EnumMember(Value = "es-ES")]
    EsEs,

    [EnumMember(Value = "es-GQ")]
    EsGq,

    [EnumMember(Value = "es-GT")]
    EsGt,

    [EnumMember(Value = "es-HN")]
    EsHn,

    [EnumMember(Value = "es-MX")]
    EsMx,

    [EnumMember(Value = "es-NI")]
    EsNi,

    [EnumMember(Value = "es-PA")]
    EsPa,

    [EnumMember(Value = "es-PE")]
    EsPe,

    [EnumMember(Value = "es-PR")]
    EsPr,

    [EnumMember(Value = "es-PY")]
    EsPy,

    [EnumMember(Value = "es-SV")]
    EsSv,

    [EnumMember(Value = "es-US")]
    EsUs,

    [EnumMember(Value = "es-UY")]
    EsUy,

    [EnumMember(Value = "es-VE")]
    EsVe,

    [EnumMember(Value = "et-EE")]
    EtEe,

    [EnumMember(Value = "eu-ES")]
    EuEs,

    [EnumMember(Value = "fa-IR")]
    FaIr,

    [EnumMember(Value = "fi-FI")]
    FiFi,

    [EnumMember(Value = "fil-PH")]
    FilPh,

    [EnumMember(Value = "fr-BE")]
    FrBe,

    [EnumMember(Value = "fr-CA")]
    FrCa,

    [EnumMember(Value = "fr-CH")]
    FrCh,

    [EnumMember(Value = "fr-FR")]
    FrFr,

    [EnumMember(Value = "ga-IE")]
    GaIe,

    [EnumMember(Value = "gl-ES")]
    GlEs,

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

    [EnumMember(Value = "hy-AM")]
    HyAm,

    [EnumMember(Value = "id-ID")]
    IdId,

    [EnumMember(Value = "is-IS")]
    IsIs,

    [EnumMember(Value = "it-CH")]
    ItCh,

    [EnumMember(Value = "it-IT")]
    ItIt,

    [EnumMember(Value = "ja-JP")]
    JaJp,

    [EnumMember(Value = "jv-ID")]
    JvId,

    [EnumMember(Value = "ka-GE")]
    KaGe,

    [EnumMember(Value = "kk-KZ")]
    KkKz,

    [EnumMember(Value = "km-KH")]
    KmKh,

    [EnumMember(Value = "kn-IN")]
    KnIn,

    [EnumMember(Value = "ko-KR")]
    KoKr,

    [EnumMember(Value = "lo-LA")]
    LoLa,

    [EnumMember(Value = "lt-LT")]
    LtLt,

    [EnumMember(Value = "lv-LV")]
    LvLv,

    [EnumMember(Value = "mk-MK")]
    MkMk,

    [EnumMember(Value = "ml-IN")]
    MlIn,

    [EnumMember(Value = "mn-MN")]
    MnMn,

    [EnumMember(Value = "mr-IN")]
    MrIn,

    [EnumMember(Value = "ms-MY")]
    MsMy,

    [EnumMember(Value = "mt-MT")]
    MtMt,

    [EnumMember(Value = "my-MM")]
    MyMm,

    [EnumMember(Value = "nb-NO")]
    NbNo,

    [EnumMember(Value = "ne-NP")]
    NeNp,

    [EnumMember(Value = "nl-BE")]
    NlBe,

    [EnumMember(Value = "nl-NL")]
    NlNl,

    [EnumMember(Value = "pa-IN")]
    PaIn,

    [EnumMember(Value = "pl-PL")]
    PlPl,

    [EnumMember(Value = "ps-AF")]
    PsAf,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "pt-PT")]
    PtPt,

    [EnumMember(Value = "ro-RO")]
    RoRo,

    [EnumMember(Value = "ru-RU")]
    RuRu,

    [EnumMember(Value = "si-LK")]
    SiLk,

    [EnumMember(Value = "sk-SK")]
    SkSk,

    [EnumMember(Value = "sl-SI")]
    SlSi,

    [EnumMember(Value = "so-SO")]
    SoSo,

    [EnumMember(Value = "sq-AL")]
    SqAl,

    [EnumMember(Value = "sr-RS")]
    SrRs,

    [EnumMember(Value = "sv-SE")]
    SvSe,

    [EnumMember(Value = "sw-KE")]
    SwKe,

    [EnumMember(Value = "sw-TZ")]
    SwTz,

    [EnumMember(Value = "ta-IN")]
    TaIn,

    [EnumMember(Value = "te-IN")]
    TeIn,

    [EnumMember(Value = "th-TH")]
    ThTh,

    [EnumMember(Value = "tr-TR")]
    TrTr,

    [EnumMember(Value = "uk-UA")]
    UkUa,

    [EnumMember(Value = "ur-IN")]
    UrIn,

    [EnumMember(Value = "uz-UZ")]
    UzUz,

    [EnumMember(Value = "vi-VN")]
    ViVn,

    [EnumMember(Value = "wuu-CN")]
    WuuCn,

    [EnumMember(Value = "yue-CN")]
    YueCn,

    [EnumMember(Value = "zh-CN")]
    ZhCn,

    [EnumMember(Value = "zh-CN-shandong")]
    ZhCnShandong,

    [EnumMember(Value = "zh-CN-sichuan")]
    ZhCnSichuan,

    [EnumMember(Value = "zh-HK")]
    ZhHk,

    [EnumMember(Value = "zh-TW")]
    ZhTw,

    [EnumMember(Value = "zu-ZA")]
    ZuZa,
}

internal class FallbackAzureSpeechTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAzureSpeechTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAzureSpeechTranscriberLanguage
    > _stringToEnum = new()
    {
        { "af-ZA", FallbackAzureSpeechTranscriberLanguage.AfZa },
        { "am-ET", FallbackAzureSpeechTranscriberLanguage.AmEt },
        { "ar-AE", FallbackAzureSpeechTranscriberLanguage.ArAe },
        { "ar-BH", FallbackAzureSpeechTranscriberLanguage.ArBh },
        { "ar-DZ", FallbackAzureSpeechTranscriberLanguage.ArDz },
        { "ar-EG", FallbackAzureSpeechTranscriberLanguage.ArEg },
        { "ar-IL", FallbackAzureSpeechTranscriberLanguage.ArIl },
        { "ar-IQ", FallbackAzureSpeechTranscriberLanguage.ArIq },
        { "ar-JO", FallbackAzureSpeechTranscriberLanguage.ArJo },
        { "ar-KW", FallbackAzureSpeechTranscriberLanguage.ArKw },
        { "ar-LB", FallbackAzureSpeechTranscriberLanguage.ArLb },
        { "ar-LY", FallbackAzureSpeechTranscriberLanguage.ArLy },
        { "ar-MA", FallbackAzureSpeechTranscriberLanguage.ArMa },
        { "ar-OM", FallbackAzureSpeechTranscriberLanguage.ArOm },
        { "ar-PS", FallbackAzureSpeechTranscriberLanguage.ArPs },
        { "ar-QA", FallbackAzureSpeechTranscriberLanguage.ArQa },
        { "ar-SA", FallbackAzureSpeechTranscriberLanguage.ArSa },
        { "ar-SY", FallbackAzureSpeechTranscriberLanguage.ArSy },
        { "ar-TN", FallbackAzureSpeechTranscriberLanguage.ArTn },
        { "ar-YE", FallbackAzureSpeechTranscriberLanguage.ArYe },
        { "az-AZ", FallbackAzureSpeechTranscriberLanguage.AzAz },
        { "bg-BG", FallbackAzureSpeechTranscriberLanguage.BgBg },
        { "bn-IN", FallbackAzureSpeechTranscriberLanguage.BnIn },
        { "bs-BA", FallbackAzureSpeechTranscriberLanguage.BsBa },
        { "ca-ES", FallbackAzureSpeechTranscriberLanguage.CaEs },
        { "cs-CZ", FallbackAzureSpeechTranscriberLanguage.CsCz },
        { "cy-GB", FallbackAzureSpeechTranscriberLanguage.CyGb },
        { "da-DK", FallbackAzureSpeechTranscriberLanguage.DaDk },
        { "de-AT", FallbackAzureSpeechTranscriberLanguage.DeAt },
        { "de-CH", FallbackAzureSpeechTranscriberLanguage.DeCh },
        { "de-DE", FallbackAzureSpeechTranscriberLanguage.DeDe },
        { "el-GR", FallbackAzureSpeechTranscriberLanguage.ElGr },
        { "en-AU", FallbackAzureSpeechTranscriberLanguage.EnAu },
        { "en-CA", FallbackAzureSpeechTranscriberLanguage.EnCa },
        { "en-GB", FallbackAzureSpeechTranscriberLanguage.EnGb },
        { "en-GH", FallbackAzureSpeechTranscriberLanguage.EnGh },
        { "en-HK", FallbackAzureSpeechTranscriberLanguage.EnHk },
        { "en-IE", FallbackAzureSpeechTranscriberLanguage.EnIe },
        { "en-IN", FallbackAzureSpeechTranscriberLanguage.EnIn },
        { "en-KE", FallbackAzureSpeechTranscriberLanguage.EnKe },
        { "en-NG", FallbackAzureSpeechTranscriberLanguage.EnNg },
        { "en-NZ", FallbackAzureSpeechTranscriberLanguage.EnNz },
        { "en-PH", FallbackAzureSpeechTranscriberLanguage.EnPh },
        { "en-SG", FallbackAzureSpeechTranscriberLanguage.EnSg },
        { "en-TZ", FallbackAzureSpeechTranscriberLanguage.EnTz },
        { "en-US", FallbackAzureSpeechTranscriberLanguage.EnUs },
        { "en-ZA", FallbackAzureSpeechTranscriberLanguage.EnZa },
        { "es-AR", FallbackAzureSpeechTranscriberLanguage.EsAr },
        { "es-BO", FallbackAzureSpeechTranscriberLanguage.EsBo },
        { "es-CL", FallbackAzureSpeechTranscriberLanguage.EsCl },
        { "es-CO", FallbackAzureSpeechTranscriberLanguage.EsCo },
        { "es-CR", FallbackAzureSpeechTranscriberLanguage.EsCr },
        { "es-CU", FallbackAzureSpeechTranscriberLanguage.EsCu },
        { "es-DO", FallbackAzureSpeechTranscriberLanguage.EsDo },
        { "es-EC", FallbackAzureSpeechTranscriberLanguage.EsEc },
        { "es-ES", FallbackAzureSpeechTranscriberLanguage.EsEs },
        { "es-GQ", FallbackAzureSpeechTranscriberLanguage.EsGq },
        { "es-GT", FallbackAzureSpeechTranscriberLanguage.EsGt },
        { "es-HN", FallbackAzureSpeechTranscriberLanguage.EsHn },
        { "es-MX", FallbackAzureSpeechTranscriberLanguage.EsMx },
        { "es-NI", FallbackAzureSpeechTranscriberLanguage.EsNi },
        { "es-PA", FallbackAzureSpeechTranscriberLanguage.EsPa },
        { "es-PE", FallbackAzureSpeechTranscriberLanguage.EsPe },
        { "es-PR", FallbackAzureSpeechTranscriberLanguage.EsPr },
        { "es-PY", FallbackAzureSpeechTranscriberLanguage.EsPy },
        { "es-SV", FallbackAzureSpeechTranscriberLanguage.EsSv },
        { "es-US", FallbackAzureSpeechTranscriberLanguage.EsUs },
        { "es-UY", FallbackAzureSpeechTranscriberLanguage.EsUy },
        { "es-VE", FallbackAzureSpeechTranscriberLanguage.EsVe },
        { "et-EE", FallbackAzureSpeechTranscriberLanguage.EtEe },
        { "eu-ES", FallbackAzureSpeechTranscriberLanguage.EuEs },
        { "fa-IR", FallbackAzureSpeechTranscriberLanguage.FaIr },
        { "fi-FI", FallbackAzureSpeechTranscriberLanguage.FiFi },
        { "fil-PH", FallbackAzureSpeechTranscriberLanguage.FilPh },
        { "fr-BE", FallbackAzureSpeechTranscriberLanguage.FrBe },
        { "fr-CA", FallbackAzureSpeechTranscriberLanguage.FrCa },
        { "fr-CH", FallbackAzureSpeechTranscriberLanguage.FrCh },
        { "fr-FR", FallbackAzureSpeechTranscriberLanguage.FrFr },
        { "ga-IE", FallbackAzureSpeechTranscriberLanguage.GaIe },
        { "gl-ES", FallbackAzureSpeechTranscriberLanguage.GlEs },
        { "gu-IN", FallbackAzureSpeechTranscriberLanguage.GuIn },
        { "he-IL", FallbackAzureSpeechTranscriberLanguage.HeIl },
        { "hi-IN", FallbackAzureSpeechTranscriberLanguage.HiIn },
        { "hr-HR", FallbackAzureSpeechTranscriberLanguage.HrHr },
        { "hu-HU", FallbackAzureSpeechTranscriberLanguage.HuHu },
        { "hy-AM", FallbackAzureSpeechTranscriberLanguage.HyAm },
        { "id-ID", FallbackAzureSpeechTranscriberLanguage.IdId },
        { "is-IS", FallbackAzureSpeechTranscriberLanguage.IsIs },
        { "it-CH", FallbackAzureSpeechTranscriberLanguage.ItCh },
        { "it-IT", FallbackAzureSpeechTranscriberLanguage.ItIt },
        { "ja-JP", FallbackAzureSpeechTranscriberLanguage.JaJp },
        { "jv-ID", FallbackAzureSpeechTranscriberLanguage.JvId },
        { "ka-GE", FallbackAzureSpeechTranscriberLanguage.KaGe },
        { "kk-KZ", FallbackAzureSpeechTranscriberLanguage.KkKz },
        { "km-KH", FallbackAzureSpeechTranscriberLanguage.KmKh },
        { "kn-IN", FallbackAzureSpeechTranscriberLanguage.KnIn },
        { "ko-KR", FallbackAzureSpeechTranscriberLanguage.KoKr },
        { "lo-LA", FallbackAzureSpeechTranscriberLanguage.LoLa },
        { "lt-LT", FallbackAzureSpeechTranscriberLanguage.LtLt },
        { "lv-LV", FallbackAzureSpeechTranscriberLanguage.LvLv },
        { "mk-MK", FallbackAzureSpeechTranscriberLanguage.MkMk },
        { "ml-IN", FallbackAzureSpeechTranscriberLanguage.MlIn },
        { "mn-MN", FallbackAzureSpeechTranscriberLanguage.MnMn },
        { "mr-IN", FallbackAzureSpeechTranscriberLanguage.MrIn },
        { "ms-MY", FallbackAzureSpeechTranscriberLanguage.MsMy },
        { "mt-MT", FallbackAzureSpeechTranscriberLanguage.MtMt },
        { "my-MM", FallbackAzureSpeechTranscriberLanguage.MyMm },
        { "nb-NO", FallbackAzureSpeechTranscriberLanguage.NbNo },
        { "ne-NP", FallbackAzureSpeechTranscriberLanguage.NeNp },
        { "nl-BE", FallbackAzureSpeechTranscriberLanguage.NlBe },
        { "nl-NL", FallbackAzureSpeechTranscriberLanguage.NlNl },
        { "pa-IN", FallbackAzureSpeechTranscriberLanguage.PaIn },
        { "pl-PL", FallbackAzureSpeechTranscriberLanguage.PlPl },
        { "ps-AF", FallbackAzureSpeechTranscriberLanguage.PsAf },
        { "pt-BR", FallbackAzureSpeechTranscriberLanguage.PtBr },
        { "pt-PT", FallbackAzureSpeechTranscriberLanguage.PtPt },
        { "ro-RO", FallbackAzureSpeechTranscriberLanguage.RoRo },
        { "ru-RU", FallbackAzureSpeechTranscriberLanguage.RuRu },
        { "si-LK", FallbackAzureSpeechTranscriberLanguage.SiLk },
        { "sk-SK", FallbackAzureSpeechTranscriberLanguage.SkSk },
        { "sl-SI", FallbackAzureSpeechTranscriberLanguage.SlSi },
        { "so-SO", FallbackAzureSpeechTranscriberLanguage.SoSo },
        { "sq-AL", FallbackAzureSpeechTranscriberLanguage.SqAl },
        { "sr-RS", FallbackAzureSpeechTranscriberLanguage.SrRs },
        { "sv-SE", FallbackAzureSpeechTranscriberLanguage.SvSe },
        { "sw-KE", FallbackAzureSpeechTranscriberLanguage.SwKe },
        { "sw-TZ", FallbackAzureSpeechTranscriberLanguage.SwTz },
        { "ta-IN", FallbackAzureSpeechTranscriberLanguage.TaIn },
        { "te-IN", FallbackAzureSpeechTranscriberLanguage.TeIn },
        { "th-TH", FallbackAzureSpeechTranscriberLanguage.ThTh },
        { "tr-TR", FallbackAzureSpeechTranscriberLanguage.TrTr },
        { "uk-UA", FallbackAzureSpeechTranscriberLanguage.UkUa },
        { "ur-IN", FallbackAzureSpeechTranscriberLanguage.UrIn },
        { "uz-UZ", FallbackAzureSpeechTranscriberLanguage.UzUz },
        { "vi-VN", FallbackAzureSpeechTranscriberLanguage.ViVn },
        { "wuu-CN", FallbackAzureSpeechTranscriberLanguage.WuuCn },
        { "yue-CN", FallbackAzureSpeechTranscriberLanguage.YueCn },
        { "zh-CN", FallbackAzureSpeechTranscriberLanguage.ZhCn },
        { "zh-CN-shandong", FallbackAzureSpeechTranscriberLanguage.ZhCnShandong },
        { "zh-CN-sichuan", FallbackAzureSpeechTranscriberLanguage.ZhCnSichuan },
        { "zh-HK", FallbackAzureSpeechTranscriberLanguage.ZhHk },
        { "zh-TW", FallbackAzureSpeechTranscriberLanguage.ZhTw },
        { "zu-ZA", FallbackAzureSpeechTranscriberLanguage.ZuZa },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAzureSpeechTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackAzureSpeechTranscriberLanguage.AfZa, "af-ZA" },
        { FallbackAzureSpeechTranscriberLanguage.AmEt, "am-ET" },
        { FallbackAzureSpeechTranscriberLanguage.ArAe, "ar-AE" },
        { FallbackAzureSpeechTranscriberLanguage.ArBh, "ar-BH" },
        { FallbackAzureSpeechTranscriberLanguage.ArDz, "ar-DZ" },
        { FallbackAzureSpeechTranscriberLanguage.ArEg, "ar-EG" },
        { FallbackAzureSpeechTranscriberLanguage.ArIl, "ar-IL" },
        { FallbackAzureSpeechTranscriberLanguage.ArIq, "ar-IQ" },
        { FallbackAzureSpeechTranscriberLanguage.ArJo, "ar-JO" },
        { FallbackAzureSpeechTranscriberLanguage.ArKw, "ar-KW" },
        { FallbackAzureSpeechTranscriberLanguage.ArLb, "ar-LB" },
        { FallbackAzureSpeechTranscriberLanguage.ArLy, "ar-LY" },
        { FallbackAzureSpeechTranscriberLanguage.ArMa, "ar-MA" },
        { FallbackAzureSpeechTranscriberLanguage.ArOm, "ar-OM" },
        { FallbackAzureSpeechTranscriberLanguage.ArPs, "ar-PS" },
        { FallbackAzureSpeechTranscriberLanguage.ArQa, "ar-QA" },
        { FallbackAzureSpeechTranscriberLanguage.ArSa, "ar-SA" },
        { FallbackAzureSpeechTranscriberLanguage.ArSy, "ar-SY" },
        { FallbackAzureSpeechTranscriberLanguage.ArTn, "ar-TN" },
        { FallbackAzureSpeechTranscriberLanguage.ArYe, "ar-YE" },
        { FallbackAzureSpeechTranscriberLanguage.AzAz, "az-AZ" },
        { FallbackAzureSpeechTranscriberLanguage.BgBg, "bg-BG" },
        { FallbackAzureSpeechTranscriberLanguage.BnIn, "bn-IN" },
        { FallbackAzureSpeechTranscriberLanguage.BsBa, "bs-BA" },
        { FallbackAzureSpeechTranscriberLanguage.CaEs, "ca-ES" },
        { FallbackAzureSpeechTranscriberLanguage.CsCz, "cs-CZ" },
        { FallbackAzureSpeechTranscriberLanguage.CyGb, "cy-GB" },
        { FallbackAzureSpeechTranscriberLanguage.DaDk, "da-DK" },
        { FallbackAzureSpeechTranscriberLanguage.DeAt, "de-AT" },
        { FallbackAzureSpeechTranscriberLanguage.DeCh, "de-CH" },
        { FallbackAzureSpeechTranscriberLanguage.DeDe, "de-DE" },
        { FallbackAzureSpeechTranscriberLanguage.ElGr, "el-GR" },
        { FallbackAzureSpeechTranscriberLanguage.EnAu, "en-AU" },
        { FallbackAzureSpeechTranscriberLanguage.EnCa, "en-CA" },
        { FallbackAzureSpeechTranscriberLanguage.EnGb, "en-GB" },
        { FallbackAzureSpeechTranscriberLanguage.EnGh, "en-GH" },
        { FallbackAzureSpeechTranscriberLanguage.EnHk, "en-HK" },
        { FallbackAzureSpeechTranscriberLanguage.EnIe, "en-IE" },
        { FallbackAzureSpeechTranscriberLanguage.EnIn, "en-IN" },
        { FallbackAzureSpeechTranscriberLanguage.EnKe, "en-KE" },
        { FallbackAzureSpeechTranscriberLanguage.EnNg, "en-NG" },
        { FallbackAzureSpeechTranscriberLanguage.EnNz, "en-NZ" },
        { FallbackAzureSpeechTranscriberLanguage.EnPh, "en-PH" },
        { FallbackAzureSpeechTranscriberLanguage.EnSg, "en-SG" },
        { FallbackAzureSpeechTranscriberLanguage.EnTz, "en-TZ" },
        { FallbackAzureSpeechTranscriberLanguage.EnUs, "en-US" },
        { FallbackAzureSpeechTranscriberLanguage.EnZa, "en-ZA" },
        { FallbackAzureSpeechTranscriberLanguage.EsAr, "es-AR" },
        { FallbackAzureSpeechTranscriberLanguage.EsBo, "es-BO" },
        { FallbackAzureSpeechTranscriberLanguage.EsCl, "es-CL" },
        { FallbackAzureSpeechTranscriberLanguage.EsCo, "es-CO" },
        { FallbackAzureSpeechTranscriberLanguage.EsCr, "es-CR" },
        { FallbackAzureSpeechTranscriberLanguage.EsCu, "es-CU" },
        { FallbackAzureSpeechTranscriberLanguage.EsDo, "es-DO" },
        { FallbackAzureSpeechTranscriberLanguage.EsEc, "es-EC" },
        { FallbackAzureSpeechTranscriberLanguage.EsEs, "es-ES" },
        { FallbackAzureSpeechTranscriberLanguage.EsGq, "es-GQ" },
        { FallbackAzureSpeechTranscriberLanguage.EsGt, "es-GT" },
        { FallbackAzureSpeechTranscriberLanguage.EsHn, "es-HN" },
        { FallbackAzureSpeechTranscriberLanguage.EsMx, "es-MX" },
        { FallbackAzureSpeechTranscriberLanguage.EsNi, "es-NI" },
        { FallbackAzureSpeechTranscriberLanguage.EsPa, "es-PA" },
        { FallbackAzureSpeechTranscriberLanguage.EsPe, "es-PE" },
        { FallbackAzureSpeechTranscriberLanguage.EsPr, "es-PR" },
        { FallbackAzureSpeechTranscriberLanguage.EsPy, "es-PY" },
        { FallbackAzureSpeechTranscriberLanguage.EsSv, "es-SV" },
        { FallbackAzureSpeechTranscriberLanguage.EsUs, "es-US" },
        { FallbackAzureSpeechTranscriberLanguage.EsUy, "es-UY" },
        { FallbackAzureSpeechTranscriberLanguage.EsVe, "es-VE" },
        { FallbackAzureSpeechTranscriberLanguage.EtEe, "et-EE" },
        { FallbackAzureSpeechTranscriberLanguage.EuEs, "eu-ES" },
        { FallbackAzureSpeechTranscriberLanguage.FaIr, "fa-IR" },
        { FallbackAzureSpeechTranscriberLanguage.FiFi, "fi-FI" },
        { FallbackAzureSpeechTranscriberLanguage.FilPh, "fil-PH" },
        { FallbackAzureSpeechTranscriberLanguage.FrBe, "fr-BE" },
        { FallbackAzureSpeechTranscriberLanguage.FrCa, "fr-CA" },
        { FallbackAzureSpeechTranscriberLanguage.FrCh, "fr-CH" },
        { FallbackAzureSpeechTranscriberLanguage.FrFr, "fr-FR" },
        { FallbackAzureSpeechTranscriberLanguage.GaIe, "ga-IE" },
        { FallbackAzureSpeechTranscriberLanguage.GlEs, "gl-ES" },
        { FallbackAzureSpeechTranscriberLanguage.GuIn, "gu-IN" },
        { FallbackAzureSpeechTranscriberLanguage.HeIl, "he-IL" },
        { FallbackAzureSpeechTranscriberLanguage.HiIn, "hi-IN" },
        { FallbackAzureSpeechTranscriberLanguage.HrHr, "hr-HR" },
        { FallbackAzureSpeechTranscriberLanguage.HuHu, "hu-HU" },
        { FallbackAzureSpeechTranscriberLanguage.HyAm, "hy-AM" },
        { FallbackAzureSpeechTranscriberLanguage.IdId, "id-ID" },
        { FallbackAzureSpeechTranscriberLanguage.IsIs, "is-IS" },
        { FallbackAzureSpeechTranscriberLanguage.ItCh, "it-CH" },
        { FallbackAzureSpeechTranscriberLanguage.ItIt, "it-IT" },
        { FallbackAzureSpeechTranscriberLanguage.JaJp, "ja-JP" },
        { FallbackAzureSpeechTranscriberLanguage.JvId, "jv-ID" },
        { FallbackAzureSpeechTranscriberLanguage.KaGe, "ka-GE" },
        { FallbackAzureSpeechTranscriberLanguage.KkKz, "kk-KZ" },
        { FallbackAzureSpeechTranscriberLanguage.KmKh, "km-KH" },
        { FallbackAzureSpeechTranscriberLanguage.KnIn, "kn-IN" },
        { FallbackAzureSpeechTranscriberLanguage.KoKr, "ko-KR" },
        { FallbackAzureSpeechTranscriberLanguage.LoLa, "lo-LA" },
        { FallbackAzureSpeechTranscriberLanguage.LtLt, "lt-LT" },
        { FallbackAzureSpeechTranscriberLanguage.LvLv, "lv-LV" },
        { FallbackAzureSpeechTranscriberLanguage.MkMk, "mk-MK" },
        { FallbackAzureSpeechTranscriberLanguage.MlIn, "ml-IN" },
        { FallbackAzureSpeechTranscriberLanguage.MnMn, "mn-MN" },
        { FallbackAzureSpeechTranscriberLanguage.MrIn, "mr-IN" },
        { FallbackAzureSpeechTranscriberLanguage.MsMy, "ms-MY" },
        { FallbackAzureSpeechTranscriberLanguage.MtMt, "mt-MT" },
        { FallbackAzureSpeechTranscriberLanguage.MyMm, "my-MM" },
        { FallbackAzureSpeechTranscriberLanguage.NbNo, "nb-NO" },
        { FallbackAzureSpeechTranscriberLanguage.NeNp, "ne-NP" },
        { FallbackAzureSpeechTranscriberLanguage.NlBe, "nl-BE" },
        { FallbackAzureSpeechTranscriberLanguage.NlNl, "nl-NL" },
        { FallbackAzureSpeechTranscriberLanguage.PaIn, "pa-IN" },
        { FallbackAzureSpeechTranscriberLanguage.PlPl, "pl-PL" },
        { FallbackAzureSpeechTranscriberLanguage.PsAf, "ps-AF" },
        { FallbackAzureSpeechTranscriberLanguage.PtBr, "pt-BR" },
        { FallbackAzureSpeechTranscriberLanguage.PtPt, "pt-PT" },
        { FallbackAzureSpeechTranscriberLanguage.RoRo, "ro-RO" },
        { FallbackAzureSpeechTranscriberLanguage.RuRu, "ru-RU" },
        { FallbackAzureSpeechTranscriberLanguage.SiLk, "si-LK" },
        { FallbackAzureSpeechTranscriberLanguage.SkSk, "sk-SK" },
        { FallbackAzureSpeechTranscriberLanguage.SlSi, "sl-SI" },
        { FallbackAzureSpeechTranscriberLanguage.SoSo, "so-SO" },
        { FallbackAzureSpeechTranscriberLanguage.SqAl, "sq-AL" },
        { FallbackAzureSpeechTranscriberLanguage.SrRs, "sr-RS" },
        { FallbackAzureSpeechTranscriberLanguage.SvSe, "sv-SE" },
        { FallbackAzureSpeechTranscriberLanguage.SwKe, "sw-KE" },
        { FallbackAzureSpeechTranscriberLanguage.SwTz, "sw-TZ" },
        { FallbackAzureSpeechTranscriberLanguage.TaIn, "ta-IN" },
        { FallbackAzureSpeechTranscriberLanguage.TeIn, "te-IN" },
        { FallbackAzureSpeechTranscriberLanguage.ThTh, "th-TH" },
        { FallbackAzureSpeechTranscriberLanguage.TrTr, "tr-TR" },
        { FallbackAzureSpeechTranscriberLanguage.UkUa, "uk-UA" },
        { FallbackAzureSpeechTranscriberLanguage.UrIn, "ur-IN" },
        { FallbackAzureSpeechTranscriberLanguage.UzUz, "uz-UZ" },
        { FallbackAzureSpeechTranscriberLanguage.ViVn, "vi-VN" },
        { FallbackAzureSpeechTranscriberLanguage.WuuCn, "wuu-CN" },
        { FallbackAzureSpeechTranscriberLanguage.YueCn, "yue-CN" },
        { FallbackAzureSpeechTranscriberLanguage.ZhCn, "zh-CN" },
        { FallbackAzureSpeechTranscriberLanguage.ZhCnShandong, "zh-CN-shandong" },
        { FallbackAzureSpeechTranscriberLanguage.ZhCnSichuan, "zh-CN-sichuan" },
        { FallbackAzureSpeechTranscriberLanguage.ZhHk, "zh-HK" },
        { FallbackAzureSpeechTranscriberLanguage.ZhTw, "zh-TW" },
        { FallbackAzureSpeechTranscriberLanguage.ZuZa, "zu-ZA" },
    };

    public override FallbackAzureSpeechTranscriberLanguage Read(
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
        FallbackAzureSpeechTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAzureSpeechTranscriberLanguage ReadAsPropertyName(
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
        FallbackAzureSpeechTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
