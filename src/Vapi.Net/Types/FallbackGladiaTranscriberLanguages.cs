using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackGladiaTranscriberLanguages>))]
public enum FallbackGladiaTranscriberLanguages
{
    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "sq")]
    Sq,

    [EnumMember(Value = "am")]
    Am,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "hy")]
    Hy,

    [EnumMember(Value = "as")]
    As,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "bs")]
    Bs,

    [EnumMember(Value = "br")]
    Br,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "fo")]
    Fo,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "ht")]
    Ht,

    [EnumMember(Value = "ha")]
    Ha,

    [EnumMember(Value = "haw")]
    Haw,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "is")]
    Is,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "jv")]
    Jv,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "kk")]
    Kk,

    [EnumMember(Value = "km")]
    Km,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "lo")]
    Lo,

    [EnumMember(Value = "la")]
    La,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "ln")]
    Ln,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "mg")]
    Mg,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "mi")]
    Mi,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "mn")]
    Mn,

    [EnumMember(Value = "my")]
    My,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "nn")]
    Nn,

    [EnumMember(Value = "oc")]
    Oc,

    [EnumMember(Value = "ps")]
    Ps,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sa")]
    Sa,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "sn")]
    Sn,

    [EnumMember(Value = "sd")]
    Sd,

    [EnumMember(Value = "si")]
    Si,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "so")]
    So,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "su")]
    Su,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "tg")]
    Tg,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "tt")]
    Tt,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "bo")]
    Bo,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "tk")]
    Tk,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "uz")]
    Uz,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "cy")]
    Cy,

    [EnumMember(Value = "yi")]
    Yi,

    [EnumMember(Value = "yo")]
    Yo,
}
