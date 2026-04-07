using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureSpeechTranscriberLanguageSerializer))]
public enum AzureSpeechTranscriberLanguage
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

internal class AzureSpeechTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureSpeechTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureSpeechTranscriberLanguage
    > _stringToEnum = new()
    {
        { "af-ZA", AzureSpeechTranscriberLanguage.AfZa },
        { "am-ET", AzureSpeechTranscriberLanguage.AmEt },
        { "ar-AE", AzureSpeechTranscriberLanguage.ArAe },
        { "ar-BH", AzureSpeechTranscriberLanguage.ArBh },
        { "ar-DZ", AzureSpeechTranscriberLanguage.ArDz },
        { "ar-EG", AzureSpeechTranscriberLanguage.ArEg },
        { "ar-IL", AzureSpeechTranscriberLanguage.ArIl },
        { "ar-IQ", AzureSpeechTranscriberLanguage.ArIq },
        { "ar-JO", AzureSpeechTranscriberLanguage.ArJo },
        { "ar-KW", AzureSpeechTranscriberLanguage.ArKw },
        { "ar-LB", AzureSpeechTranscriberLanguage.ArLb },
        { "ar-LY", AzureSpeechTranscriberLanguage.ArLy },
        { "ar-MA", AzureSpeechTranscriberLanguage.ArMa },
        { "ar-OM", AzureSpeechTranscriberLanguage.ArOm },
        { "ar-PS", AzureSpeechTranscriberLanguage.ArPs },
        { "ar-QA", AzureSpeechTranscriberLanguage.ArQa },
        { "ar-SA", AzureSpeechTranscriberLanguage.ArSa },
        { "ar-SY", AzureSpeechTranscriberLanguage.ArSy },
        { "ar-TN", AzureSpeechTranscriberLanguage.ArTn },
        { "ar-YE", AzureSpeechTranscriberLanguage.ArYe },
        { "az-AZ", AzureSpeechTranscriberLanguage.AzAz },
        { "bg-BG", AzureSpeechTranscriberLanguage.BgBg },
        { "bn-IN", AzureSpeechTranscriberLanguage.BnIn },
        { "bs-BA", AzureSpeechTranscriberLanguage.BsBa },
        { "ca-ES", AzureSpeechTranscriberLanguage.CaEs },
        { "cs-CZ", AzureSpeechTranscriberLanguage.CsCz },
        { "cy-GB", AzureSpeechTranscriberLanguage.CyGb },
        { "da-DK", AzureSpeechTranscriberLanguage.DaDk },
        { "de-AT", AzureSpeechTranscriberLanguage.DeAt },
        { "de-CH", AzureSpeechTranscriberLanguage.DeCh },
        { "de-DE", AzureSpeechTranscriberLanguage.DeDe },
        { "el-GR", AzureSpeechTranscriberLanguage.ElGr },
        { "en-AU", AzureSpeechTranscriberLanguage.EnAu },
        { "en-CA", AzureSpeechTranscriberLanguage.EnCa },
        { "en-GB", AzureSpeechTranscriberLanguage.EnGb },
        { "en-GH", AzureSpeechTranscriberLanguage.EnGh },
        { "en-HK", AzureSpeechTranscriberLanguage.EnHk },
        { "en-IE", AzureSpeechTranscriberLanguage.EnIe },
        { "en-IN", AzureSpeechTranscriberLanguage.EnIn },
        { "en-KE", AzureSpeechTranscriberLanguage.EnKe },
        { "en-NG", AzureSpeechTranscriberLanguage.EnNg },
        { "en-NZ", AzureSpeechTranscriberLanguage.EnNz },
        { "en-PH", AzureSpeechTranscriberLanguage.EnPh },
        { "en-SG", AzureSpeechTranscriberLanguage.EnSg },
        { "en-TZ", AzureSpeechTranscriberLanguage.EnTz },
        { "en-US", AzureSpeechTranscriberLanguage.EnUs },
        { "en-ZA", AzureSpeechTranscriberLanguage.EnZa },
        { "es-AR", AzureSpeechTranscriberLanguage.EsAr },
        { "es-BO", AzureSpeechTranscriberLanguage.EsBo },
        { "es-CL", AzureSpeechTranscriberLanguage.EsCl },
        { "es-CO", AzureSpeechTranscriberLanguage.EsCo },
        { "es-CR", AzureSpeechTranscriberLanguage.EsCr },
        { "es-CU", AzureSpeechTranscriberLanguage.EsCu },
        { "es-DO", AzureSpeechTranscriberLanguage.EsDo },
        { "es-EC", AzureSpeechTranscriberLanguage.EsEc },
        { "es-ES", AzureSpeechTranscriberLanguage.EsEs },
        { "es-GQ", AzureSpeechTranscriberLanguage.EsGq },
        { "es-GT", AzureSpeechTranscriberLanguage.EsGt },
        { "es-HN", AzureSpeechTranscriberLanguage.EsHn },
        { "es-MX", AzureSpeechTranscriberLanguage.EsMx },
        { "es-NI", AzureSpeechTranscriberLanguage.EsNi },
        { "es-PA", AzureSpeechTranscriberLanguage.EsPa },
        { "es-PE", AzureSpeechTranscriberLanguage.EsPe },
        { "es-PR", AzureSpeechTranscriberLanguage.EsPr },
        { "es-PY", AzureSpeechTranscriberLanguage.EsPy },
        { "es-SV", AzureSpeechTranscriberLanguage.EsSv },
        { "es-US", AzureSpeechTranscriberLanguage.EsUs },
        { "es-UY", AzureSpeechTranscriberLanguage.EsUy },
        { "es-VE", AzureSpeechTranscriberLanguage.EsVe },
        { "et-EE", AzureSpeechTranscriberLanguage.EtEe },
        { "eu-ES", AzureSpeechTranscriberLanguage.EuEs },
        { "fa-IR", AzureSpeechTranscriberLanguage.FaIr },
        { "fi-FI", AzureSpeechTranscriberLanguage.FiFi },
        { "fil-PH", AzureSpeechTranscriberLanguage.FilPh },
        { "fr-BE", AzureSpeechTranscriberLanguage.FrBe },
        { "fr-CA", AzureSpeechTranscriberLanguage.FrCa },
        { "fr-CH", AzureSpeechTranscriberLanguage.FrCh },
        { "fr-FR", AzureSpeechTranscriberLanguage.FrFr },
        { "ga-IE", AzureSpeechTranscriberLanguage.GaIe },
        { "gl-ES", AzureSpeechTranscriberLanguage.GlEs },
        { "gu-IN", AzureSpeechTranscriberLanguage.GuIn },
        { "he-IL", AzureSpeechTranscriberLanguage.HeIl },
        { "hi-IN", AzureSpeechTranscriberLanguage.HiIn },
        { "hr-HR", AzureSpeechTranscriberLanguage.HrHr },
        { "hu-HU", AzureSpeechTranscriberLanguage.HuHu },
        { "hy-AM", AzureSpeechTranscriberLanguage.HyAm },
        { "id-ID", AzureSpeechTranscriberLanguage.IdId },
        { "is-IS", AzureSpeechTranscriberLanguage.IsIs },
        { "it-CH", AzureSpeechTranscriberLanguage.ItCh },
        { "it-IT", AzureSpeechTranscriberLanguage.ItIt },
        { "ja-JP", AzureSpeechTranscriberLanguage.JaJp },
        { "jv-ID", AzureSpeechTranscriberLanguage.JvId },
        { "ka-GE", AzureSpeechTranscriberLanguage.KaGe },
        { "kk-KZ", AzureSpeechTranscriberLanguage.KkKz },
        { "km-KH", AzureSpeechTranscriberLanguage.KmKh },
        { "kn-IN", AzureSpeechTranscriberLanguage.KnIn },
        { "ko-KR", AzureSpeechTranscriberLanguage.KoKr },
        { "lo-LA", AzureSpeechTranscriberLanguage.LoLa },
        { "lt-LT", AzureSpeechTranscriberLanguage.LtLt },
        { "lv-LV", AzureSpeechTranscriberLanguage.LvLv },
        { "mk-MK", AzureSpeechTranscriberLanguage.MkMk },
        { "ml-IN", AzureSpeechTranscriberLanguage.MlIn },
        { "mn-MN", AzureSpeechTranscriberLanguage.MnMn },
        { "mr-IN", AzureSpeechTranscriberLanguage.MrIn },
        { "ms-MY", AzureSpeechTranscriberLanguage.MsMy },
        { "mt-MT", AzureSpeechTranscriberLanguage.MtMt },
        { "my-MM", AzureSpeechTranscriberLanguage.MyMm },
        { "nb-NO", AzureSpeechTranscriberLanguage.NbNo },
        { "ne-NP", AzureSpeechTranscriberLanguage.NeNp },
        { "nl-BE", AzureSpeechTranscriberLanguage.NlBe },
        { "nl-NL", AzureSpeechTranscriberLanguage.NlNl },
        { "pa-IN", AzureSpeechTranscriberLanguage.PaIn },
        { "pl-PL", AzureSpeechTranscriberLanguage.PlPl },
        { "ps-AF", AzureSpeechTranscriberLanguage.PsAf },
        { "pt-BR", AzureSpeechTranscriberLanguage.PtBr },
        { "pt-PT", AzureSpeechTranscriberLanguage.PtPt },
        { "ro-RO", AzureSpeechTranscriberLanguage.RoRo },
        { "ru-RU", AzureSpeechTranscriberLanguage.RuRu },
        { "si-LK", AzureSpeechTranscriberLanguage.SiLk },
        { "sk-SK", AzureSpeechTranscriberLanguage.SkSk },
        { "sl-SI", AzureSpeechTranscriberLanguage.SlSi },
        { "so-SO", AzureSpeechTranscriberLanguage.SoSo },
        { "sq-AL", AzureSpeechTranscriberLanguage.SqAl },
        { "sr-RS", AzureSpeechTranscriberLanguage.SrRs },
        { "sv-SE", AzureSpeechTranscriberLanguage.SvSe },
        { "sw-KE", AzureSpeechTranscriberLanguage.SwKe },
        { "sw-TZ", AzureSpeechTranscriberLanguage.SwTz },
        { "ta-IN", AzureSpeechTranscriberLanguage.TaIn },
        { "te-IN", AzureSpeechTranscriberLanguage.TeIn },
        { "th-TH", AzureSpeechTranscriberLanguage.ThTh },
        { "tr-TR", AzureSpeechTranscriberLanguage.TrTr },
        { "uk-UA", AzureSpeechTranscriberLanguage.UkUa },
        { "ur-IN", AzureSpeechTranscriberLanguage.UrIn },
        { "uz-UZ", AzureSpeechTranscriberLanguage.UzUz },
        { "vi-VN", AzureSpeechTranscriberLanguage.ViVn },
        { "wuu-CN", AzureSpeechTranscriberLanguage.WuuCn },
        { "yue-CN", AzureSpeechTranscriberLanguage.YueCn },
        { "zh-CN", AzureSpeechTranscriberLanguage.ZhCn },
        { "zh-CN-shandong", AzureSpeechTranscriberLanguage.ZhCnShandong },
        { "zh-CN-sichuan", AzureSpeechTranscriberLanguage.ZhCnSichuan },
        { "zh-HK", AzureSpeechTranscriberLanguage.ZhHk },
        { "zh-TW", AzureSpeechTranscriberLanguage.ZhTw },
        { "zu-ZA", AzureSpeechTranscriberLanguage.ZuZa },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureSpeechTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { AzureSpeechTranscriberLanguage.AfZa, "af-ZA" },
        { AzureSpeechTranscriberLanguage.AmEt, "am-ET" },
        { AzureSpeechTranscriberLanguage.ArAe, "ar-AE" },
        { AzureSpeechTranscriberLanguage.ArBh, "ar-BH" },
        { AzureSpeechTranscriberLanguage.ArDz, "ar-DZ" },
        { AzureSpeechTranscriberLanguage.ArEg, "ar-EG" },
        { AzureSpeechTranscriberLanguage.ArIl, "ar-IL" },
        { AzureSpeechTranscriberLanguage.ArIq, "ar-IQ" },
        { AzureSpeechTranscriberLanguage.ArJo, "ar-JO" },
        { AzureSpeechTranscriberLanguage.ArKw, "ar-KW" },
        { AzureSpeechTranscriberLanguage.ArLb, "ar-LB" },
        { AzureSpeechTranscriberLanguage.ArLy, "ar-LY" },
        { AzureSpeechTranscriberLanguage.ArMa, "ar-MA" },
        { AzureSpeechTranscriberLanguage.ArOm, "ar-OM" },
        { AzureSpeechTranscriberLanguage.ArPs, "ar-PS" },
        { AzureSpeechTranscriberLanguage.ArQa, "ar-QA" },
        { AzureSpeechTranscriberLanguage.ArSa, "ar-SA" },
        { AzureSpeechTranscriberLanguage.ArSy, "ar-SY" },
        { AzureSpeechTranscriberLanguage.ArTn, "ar-TN" },
        { AzureSpeechTranscriberLanguage.ArYe, "ar-YE" },
        { AzureSpeechTranscriberLanguage.AzAz, "az-AZ" },
        { AzureSpeechTranscriberLanguage.BgBg, "bg-BG" },
        { AzureSpeechTranscriberLanguage.BnIn, "bn-IN" },
        { AzureSpeechTranscriberLanguage.BsBa, "bs-BA" },
        { AzureSpeechTranscriberLanguage.CaEs, "ca-ES" },
        { AzureSpeechTranscriberLanguage.CsCz, "cs-CZ" },
        { AzureSpeechTranscriberLanguage.CyGb, "cy-GB" },
        { AzureSpeechTranscriberLanguage.DaDk, "da-DK" },
        { AzureSpeechTranscriberLanguage.DeAt, "de-AT" },
        { AzureSpeechTranscriberLanguage.DeCh, "de-CH" },
        { AzureSpeechTranscriberLanguage.DeDe, "de-DE" },
        { AzureSpeechTranscriberLanguage.ElGr, "el-GR" },
        { AzureSpeechTranscriberLanguage.EnAu, "en-AU" },
        { AzureSpeechTranscriberLanguage.EnCa, "en-CA" },
        { AzureSpeechTranscriberLanguage.EnGb, "en-GB" },
        { AzureSpeechTranscriberLanguage.EnGh, "en-GH" },
        { AzureSpeechTranscriberLanguage.EnHk, "en-HK" },
        { AzureSpeechTranscriberLanguage.EnIe, "en-IE" },
        { AzureSpeechTranscriberLanguage.EnIn, "en-IN" },
        { AzureSpeechTranscriberLanguage.EnKe, "en-KE" },
        { AzureSpeechTranscriberLanguage.EnNg, "en-NG" },
        { AzureSpeechTranscriberLanguage.EnNz, "en-NZ" },
        { AzureSpeechTranscriberLanguage.EnPh, "en-PH" },
        { AzureSpeechTranscriberLanguage.EnSg, "en-SG" },
        { AzureSpeechTranscriberLanguage.EnTz, "en-TZ" },
        { AzureSpeechTranscriberLanguage.EnUs, "en-US" },
        { AzureSpeechTranscriberLanguage.EnZa, "en-ZA" },
        { AzureSpeechTranscriberLanguage.EsAr, "es-AR" },
        { AzureSpeechTranscriberLanguage.EsBo, "es-BO" },
        { AzureSpeechTranscriberLanguage.EsCl, "es-CL" },
        { AzureSpeechTranscriberLanguage.EsCo, "es-CO" },
        { AzureSpeechTranscriberLanguage.EsCr, "es-CR" },
        { AzureSpeechTranscriberLanguage.EsCu, "es-CU" },
        { AzureSpeechTranscriberLanguage.EsDo, "es-DO" },
        { AzureSpeechTranscriberLanguage.EsEc, "es-EC" },
        { AzureSpeechTranscriberLanguage.EsEs, "es-ES" },
        { AzureSpeechTranscriberLanguage.EsGq, "es-GQ" },
        { AzureSpeechTranscriberLanguage.EsGt, "es-GT" },
        { AzureSpeechTranscriberLanguage.EsHn, "es-HN" },
        { AzureSpeechTranscriberLanguage.EsMx, "es-MX" },
        { AzureSpeechTranscriberLanguage.EsNi, "es-NI" },
        { AzureSpeechTranscriberLanguage.EsPa, "es-PA" },
        { AzureSpeechTranscriberLanguage.EsPe, "es-PE" },
        { AzureSpeechTranscriberLanguage.EsPr, "es-PR" },
        { AzureSpeechTranscriberLanguage.EsPy, "es-PY" },
        { AzureSpeechTranscriberLanguage.EsSv, "es-SV" },
        { AzureSpeechTranscriberLanguage.EsUs, "es-US" },
        { AzureSpeechTranscriberLanguage.EsUy, "es-UY" },
        { AzureSpeechTranscriberLanguage.EsVe, "es-VE" },
        { AzureSpeechTranscriberLanguage.EtEe, "et-EE" },
        { AzureSpeechTranscriberLanguage.EuEs, "eu-ES" },
        { AzureSpeechTranscriberLanguage.FaIr, "fa-IR" },
        { AzureSpeechTranscriberLanguage.FiFi, "fi-FI" },
        { AzureSpeechTranscriberLanguage.FilPh, "fil-PH" },
        { AzureSpeechTranscriberLanguage.FrBe, "fr-BE" },
        { AzureSpeechTranscriberLanguage.FrCa, "fr-CA" },
        { AzureSpeechTranscriberLanguage.FrCh, "fr-CH" },
        { AzureSpeechTranscriberLanguage.FrFr, "fr-FR" },
        { AzureSpeechTranscriberLanguage.GaIe, "ga-IE" },
        { AzureSpeechTranscriberLanguage.GlEs, "gl-ES" },
        { AzureSpeechTranscriberLanguage.GuIn, "gu-IN" },
        { AzureSpeechTranscriberLanguage.HeIl, "he-IL" },
        { AzureSpeechTranscriberLanguage.HiIn, "hi-IN" },
        { AzureSpeechTranscriberLanguage.HrHr, "hr-HR" },
        { AzureSpeechTranscriberLanguage.HuHu, "hu-HU" },
        { AzureSpeechTranscriberLanguage.HyAm, "hy-AM" },
        { AzureSpeechTranscriberLanguage.IdId, "id-ID" },
        { AzureSpeechTranscriberLanguage.IsIs, "is-IS" },
        { AzureSpeechTranscriberLanguage.ItCh, "it-CH" },
        { AzureSpeechTranscriberLanguage.ItIt, "it-IT" },
        { AzureSpeechTranscriberLanguage.JaJp, "ja-JP" },
        { AzureSpeechTranscriberLanguage.JvId, "jv-ID" },
        { AzureSpeechTranscriberLanguage.KaGe, "ka-GE" },
        { AzureSpeechTranscriberLanguage.KkKz, "kk-KZ" },
        { AzureSpeechTranscriberLanguage.KmKh, "km-KH" },
        { AzureSpeechTranscriberLanguage.KnIn, "kn-IN" },
        { AzureSpeechTranscriberLanguage.KoKr, "ko-KR" },
        { AzureSpeechTranscriberLanguage.LoLa, "lo-LA" },
        { AzureSpeechTranscriberLanguage.LtLt, "lt-LT" },
        { AzureSpeechTranscriberLanguage.LvLv, "lv-LV" },
        { AzureSpeechTranscriberLanguage.MkMk, "mk-MK" },
        { AzureSpeechTranscriberLanguage.MlIn, "ml-IN" },
        { AzureSpeechTranscriberLanguage.MnMn, "mn-MN" },
        { AzureSpeechTranscriberLanguage.MrIn, "mr-IN" },
        { AzureSpeechTranscriberLanguage.MsMy, "ms-MY" },
        { AzureSpeechTranscriberLanguage.MtMt, "mt-MT" },
        { AzureSpeechTranscriberLanguage.MyMm, "my-MM" },
        { AzureSpeechTranscriberLanguage.NbNo, "nb-NO" },
        { AzureSpeechTranscriberLanguage.NeNp, "ne-NP" },
        { AzureSpeechTranscriberLanguage.NlBe, "nl-BE" },
        { AzureSpeechTranscriberLanguage.NlNl, "nl-NL" },
        { AzureSpeechTranscriberLanguage.PaIn, "pa-IN" },
        { AzureSpeechTranscriberLanguage.PlPl, "pl-PL" },
        { AzureSpeechTranscriberLanguage.PsAf, "ps-AF" },
        { AzureSpeechTranscriberLanguage.PtBr, "pt-BR" },
        { AzureSpeechTranscriberLanguage.PtPt, "pt-PT" },
        { AzureSpeechTranscriberLanguage.RoRo, "ro-RO" },
        { AzureSpeechTranscriberLanguage.RuRu, "ru-RU" },
        { AzureSpeechTranscriberLanguage.SiLk, "si-LK" },
        { AzureSpeechTranscriberLanguage.SkSk, "sk-SK" },
        { AzureSpeechTranscriberLanguage.SlSi, "sl-SI" },
        { AzureSpeechTranscriberLanguage.SoSo, "so-SO" },
        { AzureSpeechTranscriberLanguage.SqAl, "sq-AL" },
        { AzureSpeechTranscriberLanguage.SrRs, "sr-RS" },
        { AzureSpeechTranscriberLanguage.SvSe, "sv-SE" },
        { AzureSpeechTranscriberLanguage.SwKe, "sw-KE" },
        { AzureSpeechTranscriberLanguage.SwTz, "sw-TZ" },
        { AzureSpeechTranscriberLanguage.TaIn, "ta-IN" },
        { AzureSpeechTranscriberLanguage.TeIn, "te-IN" },
        { AzureSpeechTranscriberLanguage.ThTh, "th-TH" },
        { AzureSpeechTranscriberLanguage.TrTr, "tr-TR" },
        { AzureSpeechTranscriberLanguage.UkUa, "uk-UA" },
        { AzureSpeechTranscriberLanguage.UrIn, "ur-IN" },
        { AzureSpeechTranscriberLanguage.UzUz, "uz-UZ" },
        { AzureSpeechTranscriberLanguage.ViVn, "vi-VN" },
        { AzureSpeechTranscriberLanguage.WuuCn, "wuu-CN" },
        { AzureSpeechTranscriberLanguage.YueCn, "yue-CN" },
        { AzureSpeechTranscriberLanguage.ZhCn, "zh-CN" },
        { AzureSpeechTranscriberLanguage.ZhCnShandong, "zh-CN-shandong" },
        { AzureSpeechTranscriberLanguage.ZhCnSichuan, "zh-CN-sichuan" },
        { AzureSpeechTranscriberLanguage.ZhHk, "zh-HK" },
        { AzureSpeechTranscriberLanguage.ZhTw, "zh-TW" },
        { AzureSpeechTranscriberLanguage.ZuZa, "zu-ZA" },
    };

    public override AzureSpeechTranscriberLanguage Read(
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
        AzureSpeechTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureSpeechTranscriberLanguage ReadAsPropertyName(
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
        AzureSpeechTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
