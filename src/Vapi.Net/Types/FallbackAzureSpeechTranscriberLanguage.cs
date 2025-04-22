using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackAzureSpeechTranscriberLanguage>))]
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
