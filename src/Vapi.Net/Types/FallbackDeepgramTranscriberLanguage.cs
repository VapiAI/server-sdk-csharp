using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackDeepgramTranscriberLanguage>))]
public enum FallbackDeepgramTranscriberLanguage
{
    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "da-DK")]
    DaDk,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "de-CH")]
    DeCh,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "en-AU")]
    EnAu,

    [EnumMember(Value = "en-GB")]
    EnGb,

    [EnumMember(Value = "en-IN")]
    EnIn,

    [EnumMember(Value = "en-NZ")]
    EnNz,

    [EnumMember(Value = "en-US")]
    EnUs,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "es-419")]
    Es419,

    [EnumMember(Value = "es-LATAM")]
    EsLatam,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "fr-CA")]
    FrCa,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "hi-Latn")]
    HiLatn,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "ko-KR")]
    KoKr,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "multi")]
    Multi,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "nl-BE")]
    NlBe,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "sv-SE")]
    SvSe,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "taq")]
    Taq,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "th-TH")]
    ThTh,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "zh-CN")]
    ZhCn,

    [EnumMember(Value = "zh-Hans")]
    ZhHans,

    [EnumMember(Value = "zh-Hant")]
    ZhHant,

    [EnumMember(Value = "zh-TW")]
    ZhTw,
}
