using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackVapiVoiceLanguage>))]
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
}
