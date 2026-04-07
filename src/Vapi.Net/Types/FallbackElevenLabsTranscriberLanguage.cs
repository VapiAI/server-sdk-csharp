using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackElevenLabsTranscriberLanguageSerializer))]
public enum FallbackElevenLabsTranscriberLanguage
{
    [EnumMember(Value = "aa")]
    Aa,

    [EnumMember(Value = "ab")]
    Ab,

    [EnumMember(Value = "ae")]
    Ae,

    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "ak")]
    Ak,

    [EnumMember(Value = "am")]
    Am,

    [EnumMember(Value = "an")]
    An,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "as")]
    As,

    [EnumMember(Value = "av")]
    Av,

    [EnumMember(Value = "ay")]
    Ay,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "bh")]
    Bh,

    [EnumMember(Value = "bi")]
    Bi,

    [EnumMember(Value = "bm")]
    Bm,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "bo")]
    Bo,

    [EnumMember(Value = "br")]
    Br,

    [EnumMember(Value = "bs")]
    Bs,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "ce")]
    Ce,

    [EnumMember(Value = "ch")]
    Ch,

    [EnumMember(Value = "co")]
    Co,

    [EnumMember(Value = "cr")]
    Cr,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "cu")]
    Cu,

    [EnumMember(Value = "cv")]
    Cv,

    [EnumMember(Value = "cy")]
    Cy,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "dv")]
    Dv,

    [EnumMember(Value = "dz")]
    Dz,

    [EnumMember(Value = "ee")]
    Ee,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "eo")]
    Eo,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "ff")]
    Ff,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fj")]
    Fj,

    [EnumMember(Value = "fo")]
    Fo,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "fy")]
    Fy,

    [EnumMember(Value = "ga")]
    Ga,

    [EnumMember(Value = "gd")]
    Gd,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "gn")]
    Gn,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "gv")]
    Gv,

    [EnumMember(Value = "ha")]
    Ha,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "ho")]
    Ho,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "ht")]
    Ht,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "hy")]
    Hy,

    [EnumMember(Value = "hz")]
    Hz,

    [EnumMember(Value = "ia")]
    Ia,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "ie")]
    Ie,

    [EnumMember(Value = "ig")]
    Ig,

    [EnumMember(Value = "ii")]
    Ii,

    [EnumMember(Value = "ik")]
    Ik,

    [EnumMember(Value = "io")]
    Io,

    [EnumMember(Value = "is")]
    Is,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "iu")]
    Iu,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "jv")]
    Jv,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "kg")]
    Kg,

    [EnumMember(Value = "ki")]
    Ki,

    [EnumMember(Value = "kj")]
    Kj,

    [EnumMember(Value = "kk")]
    Kk,

    [EnumMember(Value = "kl")]
    Kl,

    [EnumMember(Value = "km")]
    Km,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "kr")]
    Kr,

    [EnumMember(Value = "ks")]
    Ks,

    [EnumMember(Value = "ku")]
    Ku,

    [EnumMember(Value = "kv")]
    Kv,

    [EnumMember(Value = "kw")]
    Kw,

    [EnumMember(Value = "ky")]
    Ky,

    [EnumMember(Value = "la")]
    La,

    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "lg")]
    Lg,

    [EnumMember(Value = "li")]
    Li,

    [EnumMember(Value = "ln")]
    Ln,

    [EnumMember(Value = "lo")]
    Lo,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lu")]
    Lu,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "mg")]
    Mg,

    [EnumMember(Value = "mh")]
    Mh,

    [EnumMember(Value = "mi")]
    Mi,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mn")]
    Mn,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "my")]
    My,

    [EnumMember(Value = "na")]
    Na,

    [EnumMember(Value = "nb")]
    Nb,

    [EnumMember(Value = "nd")]
    Nd,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "ng")]
    Ng,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "nn")]
    Nn,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "nr")]
    Nr,

    [EnumMember(Value = "nv")]
    Nv,

    [EnumMember(Value = "ny")]
    Ny,

    [EnumMember(Value = "oc")]
    Oc,

    [EnumMember(Value = "oj")]
    Oj,

    [EnumMember(Value = "om")]
    Om,

    [EnumMember(Value = "or")]
    Or,

    [EnumMember(Value = "os")]
    Os,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "pi")]
    Pi,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "ps")]
    Ps,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "qu")]
    Qu,

    [EnumMember(Value = "rm")]
    Rm,

    [EnumMember(Value = "rn")]
    Rn,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "rw")]
    Rw,

    [EnumMember(Value = "sa")]
    Sa,

    [EnumMember(Value = "sc")]
    Sc,

    [EnumMember(Value = "sd")]
    Sd,

    [EnumMember(Value = "se")]
    Se,

    [EnumMember(Value = "sg")]
    Sg,

    [EnumMember(Value = "si")]
    Si,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "sm")]
    Sm,

    [EnumMember(Value = "sn")]
    Sn,

    [EnumMember(Value = "so")]
    So,

    [EnumMember(Value = "sq")]
    Sq,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "ss")]
    Ss,

    [EnumMember(Value = "st")]
    St,

    [EnumMember(Value = "su")]
    Su,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "tg")]
    Tg,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "ti")]
    Ti,

    [EnumMember(Value = "tk")]
    Tk,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "tn")]
    Tn,

    [EnumMember(Value = "to")]
    To,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "ts")]
    Ts,

    [EnumMember(Value = "tt")]
    Tt,

    [EnumMember(Value = "tw")]
    Tw,

    [EnumMember(Value = "ty")]
    Ty,

    [EnumMember(Value = "ug")]
    Ug,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "uz")]
    Uz,

    [EnumMember(Value = "ve")]
    Ve,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "vo")]
    Vo,

    [EnumMember(Value = "wa")]
    Wa,

    [EnumMember(Value = "wo")]
    Wo,

    [EnumMember(Value = "xh")]
    Xh,

    [EnumMember(Value = "yi")]
    Yi,

    [EnumMember(Value = "yue")]
    Yue,

    [EnumMember(Value = "yo")]
    Yo,

    [EnumMember(Value = "za")]
    Za,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "zu")]
    Zu,
}

internal class FallbackElevenLabsTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackElevenLabsTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackElevenLabsTranscriberLanguage
    > _stringToEnum = new()
    {
        { "aa", FallbackElevenLabsTranscriberLanguage.Aa },
        { "ab", FallbackElevenLabsTranscriberLanguage.Ab },
        { "ae", FallbackElevenLabsTranscriberLanguage.Ae },
        { "af", FallbackElevenLabsTranscriberLanguage.Af },
        { "ak", FallbackElevenLabsTranscriberLanguage.Ak },
        { "am", FallbackElevenLabsTranscriberLanguage.Am },
        { "an", FallbackElevenLabsTranscriberLanguage.An },
        { "ar", FallbackElevenLabsTranscriberLanguage.Ar },
        { "as", FallbackElevenLabsTranscriberLanguage.As },
        { "av", FallbackElevenLabsTranscriberLanguage.Av },
        { "ay", FallbackElevenLabsTranscriberLanguage.Ay },
        { "az", FallbackElevenLabsTranscriberLanguage.Az },
        { "ba", FallbackElevenLabsTranscriberLanguage.Ba },
        { "be", FallbackElevenLabsTranscriberLanguage.Be },
        { "bg", FallbackElevenLabsTranscriberLanguage.Bg },
        { "bh", FallbackElevenLabsTranscriberLanguage.Bh },
        { "bi", FallbackElevenLabsTranscriberLanguage.Bi },
        { "bm", FallbackElevenLabsTranscriberLanguage.Bm },
        { "bn", FallbackElevenLabsTranscriberLanguage.Bn },
        { "bo", FallbackElevenLabsTranscriberLanguage.Bo },
        { "br", FallbackElevenLabsTranscriberLanguage.Br },
        { "bs", FallbackElevenLabsTranscriberLanguage.Bs },
        { "ca", FallbackElevenLabsTranscriberLanguage.Ca },
        { "ce", FallbackElevenLabsTranscriberLanguage.Ce },
        { "ch", FallbackElevenLabsTranscriberLanguage.Ch },
        { "co", FallbackElevenLabsTranscriberLanguage.Co },
        { "cr", FallbackElevenLabsTranscriberLanguage.Cr },
        { "cs", FallbackElevenLabsTranscriberLanguage.Cs },
        { "cu", FallbackElevenLabsTranscriberLanguage.Cu },
        { "cv", FallbackElevenLabsTranscriberLanguage.Cv },
        { "cy", FallbackElevenLabsTranscriberLanguage.Cy },
        { "da", FallbackElevenLabsTranscriberLanguage.Da },
        { "de", FallbackElevenLabsTranscriberLanguage.De },
        { "dv", FallbackElevenLabsTranscriberLanguage.Dv },
        { "dz", FallbackElevenLabsTranscriberLanguage.Dz },
        { "ee", FallbackElevenLabsTranscriberLanguage.Ee },
        { "el", FallbackElevenLabsTranscriberLanguage.El },
        { "en", FallbackElevenLabsTranscriberLanguage.En },
        { "eo", FallbackElevenLabsTranscriberLanguage.Eo },
        { "es", FallbackElevenLabsTranscriberLanguage.Es },
        { "et", FallbackElevenLabsTranscriberLanguage.Et },
        { "eu", FallbackElevenLabsTranscriberLanguage.Eu },
        { "fa", FallbackElevenLabsTranscriberLanguage.Fa },
        { "ff", FallbackElevenLabsTranscriberLanguage.Ff },
        { "fi", FallbackElevenLabsTranscriberLanguage.Fi },
        { "fj", FallbackElevenLabsTranscriberLanguage.Fj },
        { "fo", FallbackElevenLabsTranscriberLanguage.Fo },
        { "fr", FallbackElevenLabsTranscriberLanguage.Fr },
        { "fy", FallbackElevenLabsTranscriberLanguage.Fy },
        { "ga", FallbackElevenLabsTranscriberLanguage.Ga },
        { "gd", FallbackElevenLabsTranscriberLanguage.Gd },
        { "gl", FallbackElevenLabsTranscriberLanguage.Gl },
        { "gn", FallbackElevenLabsTranscriberLanguage.Gn },
        { "gu", FallbackElevenLabsTranscriberLanguage.Gu },
        { "gv", FallbackElevenLabsTranscriberLanguage.Gv },
        { "ha", FallbackElevenLabsTranscriberLanguage.Ha },
        { "he", FallbackElevenLabsTranscriberLanguage.He },
        { "hi", FallbackElevenLabsTranscriberLanguage.Hi },
        { "ho", FallbackElevenLabsTranscriberLanguage.Ho },
        { "hr", FallbackElevenLabsTranscriberLanguage.Hr },
        { "ht", FallbackElevenLabsTranscriberLanguage.Ht },
        { "hu", FallbackElevenLabsTranscriberLanguage.Hu },
        { "hy", FallbackElevenLabsTranscriberLanguage.Hy },
        { "hz", FallbackElevenLabsTranscriberLanguage.Hz },
        { "ia", FallbackElevenLabsTranscriberLanguage.Ia },
        { "id", FallbackElevenLabsTranscriberLanguage.Id },
        { "ie", FallbackElevenLabsTranscriberLanguage.Ie },
        { "ig", FallbackElevenLabsTranscriberLanguage.Ig },
        { "ii", FallbackElevenLabsTranscriberLanguage.Ii },
        { "ik", FallbackElevenLabsTranscriberLanguage.Ik },
        { "io", FallbackElevenLabsTranscriberLanguage.Io },
        { "is", FallbackElevenLabsTranscriberLanguage.Is },
        { "it", FallbackElevenLabsTranscriberLanguage.It },
        { "iu", FallbackElevenLabsTranscriberLanguage.Iu },
        { "ja", FallbackElevenLabsTranscriberLanguage.Ja },
        { "jv", FallbackElevenLabsTranscriberLanguage.Jv },
        { "ka", FallbackElevenLabsTranscriberLanguage.Ka },
        { "kg", FallbackElevenLabsTranscriberLanguage.Kg },
        { "ki", FallbackElevenLabsTranscriberLanguage.Ki },
        { "kj", FallbackElevenLabsTranscriberLanguage.Kj },
        { "kk", FallbackElevenLabsTranscriberLanguage.Kk },
        { "kl", FallbackElevenLabsTranscriberLanguage.Kl },
        { "km", FallbackElevenLabsTranscriberLanguage.Km },
        { "kn", FallbackElevenLabsTranscriberLanguage.Kn },
        { "ko", FallbackElevenLabsTranscriberLanguage.Ko },
        { "kr", FallbackElevenLabsTranscriberLanguage.Kr },
        { "ks", FallbackElevenLabsTranscriberLanguage.Ks },
        { "ku", FallbackElevenLabsTranscriberLanguage.Ku },
        { "kv", FallbackElevenLabsTranscriberLanguage.Kv },
        { "kw", FallbackElevenLabsTranscriberLanguage.Kw },
        { "ky", FallbackElevenLabsTranscriberLanguage.Ky },
        { "la", FallbackElevenLabsTranscriberLanguage.La },
        { "lb", FallbackElevenLabsTranscriberLanguage.Lb },
        { "lg", FallbackElevenLabsTranscriberLanguage.Lg },
        { "li", FallbackElevenLabsTranscriberLanguage.Li },
        { "ln", FallbackElevenLabsTranscriberLanguage.Ln },
        { "lo", FallbackElevenLabsTranscriberLanguage.Lo },
        { "lt", FallbackElevenLabsTranscriberLanguage.Lt },
        { "lu", FallbackElevenLabsTranscriberLanguage.Lu },
        { "lv", FallbackElevenLabsTranscriberLanguage.Lv },
        { "mg", FallbackElevenLabsTranscriberLanguage.Mg },
        { "mh", FallbackElevenLabsTranscriberLanguage.Mh },
        { "mi", FallbackElevenLabsTranscriberLanguage.Mi },
        { "mk", FallbackElevenLabsTranscriberLanguage.Mk },
        { "ml", FallbackElevenLabsTranscriberLanguage.Ml },
        { "mn", FallbackElevenLabsTranscriberLanguage.Mn },
        { "mr", FallbackElevenLabsTranscriberLanguage.Mr },
        { "ms", FallbackElevenLabsTranscriberLanguage.Ms },
        { "mt", FallbackElevenLabsTranscriberLanguage.Mt },
        { "my", FallbackElevenLabsTranscriberLanguage.My },
        { "na", FallbackElevenLabsTranscriberLanguage.Na },
        { "nb", FallbackElevenLabsTranscriberLanguage.Nb },
        { "nd", FallbackElevenLabsTranscriberLanguage.Nd },
        { "ne", FallbackElevenLabsTranscriberLanguage.Ne },
        { "ng", FallbackElevenLabsTranscriberLanguage.Ng },
        { "nl", FallbackElevenLabsTranscriberLanguage.Nl },
        { "nn", FallbackElevenLabsTranscriberLanguage.Nn },
        { "no", FallbackElevenLabsTranscriberLanguage.No },
        { "nr", FallbackElevenLabsTranscriberLanguage.Nr },
        { "nv", FallbackElevenLabsTranscriberLanguage.Nv },
        { "ny", FallbackElevenLabsTranscriberLanguage.Ny },
        { "oc", FallbackElevenLabsTranscriberLanguage.Oc },
        { "oj", FallbackElevenLabsTranscriberLanguage.Oj },
        { "om", FallbackElevenLabsTranscriberLanguage.Om },
        { "or", FallbackElevenLabsTranscriberLanguage.Or },
        { "os", FallbackElevenLabsTranscriberLanguage.Os },
        { "pa", FallbackElevenLabsTranscriberLanguage.Pa },
        { "pi", FallbackElevenLabsTranscriberLanguage.Pi },
        { "pl", FallbackElevenLabsTranscriberLanguage.Pl },
        { "ps", FallbackElevenLabsTranscriberLanguage.Ps },
        { "pt", FallbackElevenLabsTranscriberLanguage.Pt },
        { "qu", FallbackElevenLabsTranscriberLanguage.Qu },
        { "rm", FallbackElevenLabsTranscriberLanguage.Rm },
        { "rn", FallbackElevenLabsTranscriberLanguage.Rn },
        { "ro", FallbackElevenLabsTranscriberLanguage.Ro },
        { "ru", FallbackElevenLabsTranscriberLanguage.Ru },
        { "rw", FallbackElevenLabsTranscriberLanguage.Rw },
        { "sa", FallbackElevenLabsTranscriberLanguage.Sa },
        { "sc", FallbackElevenLabsTranscriberLanguage.Sc },
        { "sd", FallbackElevenLabsTranscriberLanguage.Sd },
        { "se", FallbackElevenLabsTranscriberLanguage.Se },
        { "sg", FallbackElevenLabsTranscriberLanguage.Sg },
        { "si", FallbackElevenLabsTranscriberLanguage.Si },
        { "sk", FallbackElevenLabsTranscriberLanguage.Sk },
        { "sl", FallbackElevenLabsTranscriberLanguage.Sl },
        { "sm", FallbackElevenLabsTranscriberLanguage.Sm },
        { "sn", FallbackElevenLabsTranscriberLanguage.Sn },
        { "so", FallbackElevenLabsTranscriberLanguage.So },
        { "sq", FallbackElevenLabsTranscriberLanguage.Sq },
        { "sr", FallbackElevenLabsTranscriberLanguage.Sr },
        { "ss", FallbackElevenLabsTranscriberLanguage.Ss },
        { "st", FallbackElevenLabsTranscriberLanguage.St },
        { "su", FallbackElevenLabsTranscriberLanguage.Su },
        { "sv", FallbackElevenLabsTranscriberLanguage.Sv },
        { "sw", FallbackElevenLabsTranscriberLanguage.Sw },
        { "ta", FallbackElevenLabsTranscriberLanguage.Ta },
        { "te", FallbackElevenLabsTranscriberLanguage.Te },
        { "tg", FallbackElevenLabsTranscriberLanguage.Tg },
        { "th", FallbackElevenLabsTranscriberLanguage.Th },
        { "ti", FallbackElevenLabsTranscriberLanguage.Ti },
        { "tk", FallbackElevenLabsTranscriberLanguage.Tk },
        { "tl", FallbackElevenLabsTranscriberLanguage.Tl },
        { "tn", FallbackElevenLabsTranscriberLanguage.Tn },
        { "to", FallbackElevenLabsTranscriberLanguage.To },
        { "tr", FallbackElevenLabsTranscriberLanguage.Tr },
        { "ts", FallbackElevenLabsTranscriberLanguage.Ts },
        { "tt", FallbackElevenLabsTranscriberLanguage.Tt },
        { "tw", FallbackElevenLabsTranscriberLanguage.Tw },
        { "ty", FallbackElevenLabsTranscriberLanguage.Ty },
        { "ug", FallbackElevenLabsTranscriberLanguage.Ug },
        { "uk", FallbackElevenLabsTranscriberLanguage.Uk },
        { "ur", FallbackElevenLabsTranscriberLanguage.Ur },
        { "uz", FallbackElevenLabsTranscriberLanguage.Uz },
        { "ve", FallbackElevenLabsTranscriberLanguage.Ve },
        { "vi", FallbackElevenLabsTranscriberLanguage.Vi },
        { "vo", FallbackElevenLabsTranscriberLanguage.Vo },
        { "wa", FallbackElevenLabsTranscriberLanguage.Wa },
        { "wo", FallbackElevenLabsTranscriberLanguage.Wo },
        { "xh", FallbackElevenLabsTranscriberLanguage.Xh },
        { "yi", FallbackElevenLabsTranscriberLanguage.Yi },
        { "yue", FallbackElevenLabsTranscriberLanguage.Yue },
        { "yo", FallbackElevenLabsTranscriberLanguage.Yo },
        { "za", FallbackElevenLabsTranscriberLanguage.Za },
        { "zh", FallbackElevenLabsTranscriberLanguage.Zh },
        { "zu", FallbackElevenLabsTranscriberLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackElevenLabsTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackElevenLabsTranscriberLanguage.Aa, "aa" },
        { FallbackElevenLabsTranscriberLanguage.Ab, "ab" },
        { FallbackElevenLabsTranscriberLanguage.Ae, "ae" },
        { FallbackElevenLabsTranscriberLanguage.Af, "af" },
        { FallbackElevenLabsTranscriberLanguage.Ak, "ak" },
        { FallbackElevenLabsTranscriberLanguage.Am, "am" },
        { FallbackElevenLabsTranscriberLanguage.An, "an" },
        { FallbackElevenLabsTranscriberLanguage.Ar, "ar" },
        { FallbackElevenLabsTranscriberLanguage.As, "as" },
        { FallbackElevenLabsTranscriberLanguage.Av, "av" },
        { FallbackElevenLabsTranscriberLanguage.Ay, "ay" },
        { FallbackElevenLabsTranscriberLanguage.Az, "az" },
        { FallbackElevenLabsTranscriberLanguage.Ba, "ba" },
        { FallbackElevenLabsTranscriberLanguage.Be, "be" },
        { FallbackElevenLabsTranscriberLanguage.Bg, "bg" },
        { FallbackElevenLabsTranscriberLanguage.Bh, "bh" },
        { FallbackElevenLabsTranscriberLanguage.Bi, "bi" },
        { FallbackElevenLabsTranscriberLanguage.Bm, "bm" },
        { FallbackElevenLabsTranscriberLanguage.Bn, "bn" },
        { FallbackElevenLabsTranscriberLanguage.Bo, "bo" },
        { FallbackElevenLabsTranscriberLanguage.Br, "br" },
        { FallbackElevenLabsTranscriberLanguage.Bs, "bs" },
        { FallbackElevenLabsTranscriberLanguage.Ca, "ca" },
        { FallbackElevenLabsTranscriberLanguage.Ce, "ce" },
        { FallbackElevenLabsTranscriberLanguage.Ch, "ch" },
        { FallbackElevenLabsTranscriberLanguage.Co, "co" },
        { FallbackElevenLabsTranscriberLanguage.Cr, "cr" },
        { FallbackElevenLabsTranscriberLanguage.Cs, "cs" },
        { FallbackElevenLabsTranscriberLanguage.Cu, "cu" },
        { FallbackElevenLabsTranscriberLanguage.Cv, "cv" },
        { FallbackElevenLabsTranscriberLanguage.Cy, "cy" },
        { FallbackElevenLabsTranscriberLanguage.Da, "da" },
        { FallbackElevenLabsTranscriberLanguage.De, "de" },
        { FallbackElevenLabsTranscriberLanguage.Dv, "dv" },
        { FallbackElevenLabsTranscriberLanguage.Dz, "dz" },
        { FallbackElevenLabsTranscriberLanguage.Ee, "ee" },
        { FallbackElevenLabsTranscriberLanguage.El, "el" },
        { FallbackElevenLabsTranscriberLanguage.En, "en" },
        { FallbackElevenLabsTranscriberLanguage.Eo, "eo" },
        { FallbackElevenLabsTranscriberLanguage.Es, "es" },
        { FallbackElevenLabsTranscriberLanguage.Et, "et" },
        { FallbackElevenLabsTranscriberLanguage.Eu, "eu" },
        { FallbackElevenLabsTranscriberLanguage.Fa, "fa" },
        { FallbackElevenLabsTranscriberLanguage.Ff, "ff" },
        { FallbackElevenLabsTranscriberLanguage.Fi, "fi" },
        { FallbackElevenLabsTranscriberLanguage.Fj, "fj" },
        { FallbackElevenLabsTranscriberLanguage.Fo, "fo" },
        { FallbackElevenLabsTranscriberLanguage.Fr, "fr" },
        { FallbackElevenLabsTranscriberLanguage.Fy, "fy" },
        { FallbackElevenLabsTranscriberLanguage.Ga, "ga" },
        { FallbackElevenLabsTranscriberLanguage.Gd, "gd" },
        { FallbackElevenLabsTranscriberLanguage.Gl, "gl" },
        { FallbackElevenLabsTranscriberLanguage.Gn, "gn" },
        { FallbackElevenLabsTranscriberLanguage.Gu, "gu" },
        { FallbackElevenLabsTranscriberLanguage.Gv, "gv" },
        { FallbackElevenLabsTranscriberLanguage.Ha, "ha" },
        { FallbackElevenLabsTranscriberLanguage.He, "he" },
        { FallbackElevenLabsTranscriberLanguage.Hi, "hi" },
        { FallbackElevenLabsTranscriberLanguage.Ho, "ho" },
        { FallbackElevenLabsTranscriberLanguage.Hr, "hr" },
        { FallbackElevenLabsTranscriberLanguage.Ht, "ht" },
        { FallbackElevenLabsTranscriberLanguage.Hu, "hu" },
        { FallbackElevenLabsTranscriberLanguage.Hy, "hy" },
        { FallbackElevenLabsTranscriberLanguage.Hz, "hz" },
        { FallbackElevenLabsTranscriberLanguage.Ia, "ia" },
        { FallbackElevenLabsTranscriberLanguage.Id, "id" },
        { FallbackElevenLabsTranscriberLanguage.Ie, "ie" },
        { FallbackElevenLabsTranscriberLanguage.Ig, "ig" },
        { FallbackElevenLabsTranscriberLanguage.Ii, "ii" },
        { FallbackElevenLabsTranscriberLanguage.Ik, "ik" },
        { FallbackElevenLabsTranscriberLanguage.Io, "io" },
        { FallbackElevenLabsTranscriberLanguage.Is, "is" },
        { FallbackElevenLabsTranscriberLanguage.It, "it" },
        { FallbackElevenLabsTranscriberLanguage.Iu, "iu" },
        { FallbackElevenLabsTranscriberLanguage.Ja, "ja" },
        { FallbackElevenLabsTranscriberLanguage.Jv, "jv" },
        { FallbackElevenLabsTranscriberLanguage.Ka, "ka" },
        { FallbackElevenLabsTranscriberLanguage.Kg, "kg" },
        { FallbackElevenLabsTranscriberLanguage.Ki, "ki" },
        { FallbackElevenLabsTranscriberLanguage.Kj, "kj" },
        { FallbackElevenLabsTranscriberLanguage.Kk, "kk" },
        { FallbackElevenLabsTranscriberLanguage.Kl, "kl" },
        { FallbackElevenLabsTranscriberLanguage.Km, "km" },
        { FallbackElevenLabsTranscriberLanguage.Kn, "kn" },
        { FallbackElevenLabsTranscriberLanguage.Ko, "ko" },
        { FallbackElevenLabsTranscriberLanguage.Kr, "kr" },
        { FallbackElevenLabsTranscriberLanguage.Ks, "ks" },
        { FallbackElevenLabsTranscriberLanguage.Ku, "ku" },
        { FallbackElevenLabsTranscriberLanguage.Kv, "kv" },
        { FallbackElevenLabsTranscriberLanguage.Kw, "kw" },
        { FallbackElevenLabsTranscriberLanguage.Ky, "ky" },
        { FallbackElevenLabsTranscriberLanguage.La, "la" },
        { FallbackElevenLabsTranscriberLanguage.Lb, "lb" },
        { FallbackElevenLabsTranscriberLanguage.Lg, "lg" },
        { FallbackElevenLabsTranscriberLanguage.Li, "li" },
        { FallbackElevenLabsTranscriberLanguage.Ln, "ln" },
        { FallbackElevenLabsTranscriberLanguage.Lo, "lo" },
        { FallbackElevenLabsTranscriberLanguage.Lt, "lt" },
        { FallbackElevenLabsTranscriberLanguage.Lu, "lu" },
        { FallbackElevenLabsTranscriberLanguage.Lv, "lv" },
        { FallbackElevenLabsTranscriberLanguage.Mg, "mg" },
        { FallbackElevenLabsTranscriberLanguage.Mh, "mh" },
        { FallbackElevenLabsTranscriberLanguage.Mi, "mi" },
        { FallbackElevenLabsTranscriberLanguage.Mk, "mk" },
        { FallbackElevenLabsTranscriberLanguage.Ml, "ml" },
        { FallbackElevenLabsTranscriberLanguage.Mn, "mn" },
        { FallbackElevenLabsTranscriberLanguage.Mr, "mr" },
        { FallbackElevenLabsTranscriberLanguage.Ms, "ms" },
        { FallbackElevenLabsTranscriberLanguage.Mt, "mt" },
        { FallbackElevenLabsTranscriberLanguage.My, "my" },
        { FallbackElevenLabsTranscriberLanguage.Na, "na" },
        { FallbackElevenLabsTranscriberLanguage.Nb, "nb" },
        { FallbackElevenLabsTranscriberLanguage.Nd, "nd" },
        { FallbackElevenLabsTranscriberLanguage.Ne, "ne" },
        { FallbackElevenLabsTranscriberLanguage.Ng, "ng" },
        { FallbackElevenLabsTranscriberLanguage.Nl, "nl" },
        { FallbackElevenLabsTranscriberLanguage.Nn, "nn" },
        { FallbackElevenLabsTranscriberLanguage.No, "no" },
        { FallbackElevenLabsTranscriberLanguage.Nr, "nr" },
        { FallbackElevenLabsTranscriberLanguage.Nv, "nv" },
        { FallbackElevenLabsTranscriberLanguage.Ny, "ny" },
        { FallbackElevenLabsTranscriberLanguage.Oc, "oc" },
        { FallbackElevenLabsTranscriberLanguage.Oj, "oj" },
        { FallbackElevenLabsTranscriberLanguage.Om, "om" },
        { FallbackElevenLabsTranscriberLanguage.Or, "or" },
        { FallbackElevenLabsTranscriberLanguage.Os, "os" },
        { FallbackElevenLabsTranscriberLanguage.Pa, "pa" },
        { FallbackElevenLabsTranscriberLanguage.Pi, "pi" },
        { FallbackElevenLabsTranscriberLanguage.Pl, "pl" },
        { FallbackElevenLabsTranscriberLanguage.Ps, "ps" },
        { FallbackElevenLabsTranscriberLanguage.Pt, "pt" },
        { FallbackElevenLabsTranscriberLanguage.Qu, "qu" },
        { FallbackElevenLabsTranscriberLanguage.Rm, "rm" },
        { FallbackElevenLabsTranscriberLanguage.Rn, "rn" },
        { FallbackElevenLabsTranscriberLanguage.Ro, "ro" },
        { FallbackElevenLabsTranscriberLanguage.Ru, "ru" },
        { FallbackElevenLabsTranscriberLanguage.Rw, "rw" },
        { FallbackElevenLabsTranscriberLanguage.Sa, "sa" },
        { FallbackElevenLabsTranscriberLanguage.Sc, "sc" },
        { FallbackElevenLabsTranscriberLanguage.Sd, "sd" },
        { FallbackElevenLabsTranscriberLanguage.Se, "se" },
        { FallbackElevenLabsTranscriberLanguage.Sg, "sg" },
        { FallbackElevenLabsTranscriberLanguage.Si, "si" },
        { FallbackElevenLabsTranscriberLanguage.Sk, "sk" },
        { FallbackElevenLabsTranscriberLanguage.Sl, "sl" },
        { FallbackElevenLabsTranscriberLanguage.Sm, "sm" },
        { FallbackElevenLabsTranscriberLanguage.Sn, "sn" },
        { FallbackElevenLabsTranscriberLanguage.So, "so" },
        { FallbackElevenLabsTranscriberLanguage.Sq, "sq" },
        { FallbackElevenLabsTranscriberLanguage.Sr, "sr" },
        { FallbackElevenLabsTranscriberLanguage.Ss, "ss" },
        { FallbackElevenLabsTranscriberLanguage.St, "st" },
        { FallbackElevenLabsTranscriberLanguage.Su, "su" },
        { FallbackElevenLabsTranscriberLanguage.Sv, "sv" },
        { FallbackElevenLabsTranscriberLanguage.Sw, "sw" },
        { FallbackElevenLabsTranscriberLanguage.Ta, "ta" },
        { FallbackElevenLabsTranscriberLanguage.Te, "te" },
        { FallbackElevenLabsTranscriberLanguage.Tg, "tg" },
        { FallbackElevenLabsTranscriberLanguage.Th, "th" },
        { FallbackElevenLabsTranscriberLanguage.Ti, "ti" },
        { FallbackElevenLabsTranscriberLanguage.Tk, "tk" },
        { FallbackElevenLabsTranscriberLanguage.Tl, "tl" },
        { FallbackElevenLabsTranscriberLanguage.Tn, "tn" },
        { FallbackElevenLabsTranscriberLanguage.To, "to" },
        { FallbackElevenLabsTranscriberLanguage.Tr, "tr" },
        { FallbackElevenLabsTranscriberLanguage.Ts, "ts" },
        { FallbackElevenLabsTranscriberLanguage.Tt, "tt" },
        { FallbackElevenLabsTranscriberLanguage.Tw, "tw" },
        { FallbackElevenLabsTranscriberLanguage.Ty, "ty" },
        { FallbackElevenLabsTranscriberLanguage.Ug, "ug" },
        { FallbackElevenLabsTranscriberLanguage.Uk, "uk" },
        { FallbackElevenLabsTranscriberLanguage.Ur, "ur" },
        { FallbackElevenLabsTranscriberLanguage.Uz, "uz" },
        { FallbackElevenLabsTranscriberLanguage.Ve, "ve" },
        { FallbackElevenLabsTranscriberLanguage.Vi, "vi" },
        { FallbackElevenLabsTranscriberLanguage.Vo, "vo" },
        { FallbackElevenLabsTranscriberLanguage.Wa, "wa" },
        { FallbackElevenLabsTranscriberLanguage.Wo, "wo" },
        { FallbackElevenLabsTranscriberLanguage.Xh, "xh" },
        { FallbackElevenLabsTranscriberLanguage.Yi, "yi" },
        { FallbackElevenLabsTranscriberLanguage.Yue, "yue" },
        { FallbackElevenLabsTranscriberLanguage.Yo, "yo" },
        { FallbackElevenLabsTranscriberLanguage.Za, "za" },
        { FallbackElevenLabsTranscriberLanguage.Zh, "zh" },
        { FallbackElevenLabsTranscriberLanguage.Zu, "zu" },
    };

    public override FallbackElevenLabsTranscriberLanguage Read(
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
        FallbackElevenLabsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackElevenLabsTranscriberLanguage ReadAsPropertyName(
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
        FallbackElevenLabsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
