using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackTalkscriberTranscriberLanguage>))]
public enum FallbackTalkscriberTranscriberLanguage
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "la")]
    La,

    [EnumMember(Value = "mi")]
    Mi,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "cy")]
    Cy,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "br")]
    Br,

    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "is")]
    Is,

    [EnumMember(Value = "hy")]
    Hy,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "mn")]
    Mn,

    [EnumMember(Value = "bs")]
    Bs,

    [EnumMember(Value = "kk")]
    Kk,

    [EnumMember(Value = "sq")]
    Sq,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "si")]
    Si,

    [EnumMember(Value = "km")]
    Km,

    [EnumMember(Value = "sn")]
    Sn,

    [EnumMember(Value = "yo")]
    Yo,

    [EnumMember(Value = "so")]
    So,

    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "oc")]
    Oc,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "tg")]
    Tg,

    [EnumMember(Value = "sd")]
    Sd,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "am")]
    Am,

    [EnumMember(Value = "yi")]
    Yi,

    [EnumMember(Value = "lo")]
    Lo,

    [EnumMember(Value = "uz")]
    Uz,

    [EnumMember(Value = "fo")]
    Fo,

    [EnumMember(Value = "ht")]
    Ht,

    [EnumMember(Value = "ps")]
    Ps,

    [EnumMember(Value = "tk")]
    Tk,

    [EnumMember(Value = "nn")]
    Nn,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "sa")]
    Sa,

    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "my")]
    My,

    [EnumMember(Value = "bo")]
    Bo,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "mg")]
    Mg,

    [EnumMember(Value = "as")]
    As,

    [EnumMember(Value = "tt")]
    Tt,

    [EnumMember(Value = "haw")]
    Haw,

    [EnumMember(Value = "ln")]
    Ln,

    [EnumMember(Value = "ha")]
    Ha,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "jw")]
    Jw,

    [EnumMember(Value = "su")]
    Su,

    [EnumMember(Value = "yue")]
    Yue,
}
