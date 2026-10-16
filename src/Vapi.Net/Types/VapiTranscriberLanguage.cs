using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiTranscriberLanguageSerializer))]
public enum VapiTranscriberLanguage
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

internal class VapiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "aa", VapiTranscriberLanguage.Aa },
        { "ab", VapiTranscriberLanguage.Ab },
        { "ae", VapiTranscriberLanguage.Ae },
        { "af", VapiTranscriberLanguage.Af },
        { "ak", VapiTranscriberLanguage.Ak },
        { "am", VapiTranscriberLanguage.Am },
        { "an", VapiTranscriberLanguage.An },
        { "ar", VapiTranscriberLanguage.Ar },
        { "as", VapiTranscriberLanguage.As },
        { "av", VapiTranscriberLanguage.Av },
        { "ay", VapiTranscriberLanguage.Ay },
        { "az", VapiTranscriberLanguage.Az },
        { "ba", VapiTranscriberLanguage.Ba },
        { "be", VapiTranscriberLanguage.Be },
        { "bg", VapiTranscriberLanguage.Bg },
        { "bh", VapiTranscriberLanguage.Bh },
        { "bi", VapiTranscriberLanguage.Bi },
        { "bm", VapiTranscriberLanguage.Bm },
        { "bn", VapiTranscriberLanguage.Bn },
        { "bo", VapiTranscriberLanguage.Bo },
        { "br", VapiTranscriberLanguage.Br },
        { "bs", VapiTranscriberLanguage.Bs },
        { "ca", VapiTranscriberLanguage.Ca },
        { "ce", VapiTranscriberLanguage.Ce },
        { "ch", VapiTranscriberLanguage.Ch },
        { "co", VapiTranscriberLanguage.Co },
        { "cr", VapiTranscriberLanguage.Cr },
        { "cs", VapiTranscriberLanguage.Cs },
        { "cu", VapiTranscriberLanguage.Cu },
        { "cv", VapiTranscriberLanguage.Cv },
        { "cy", VapiTranscriberLanguage.Cy },
        { "da", VapiTranscriberLanguage.Da },
        { "de", VapiTranscriberLanguage.De },
        { "dv", VapiTranscriberLanguage.Dv },
        { "dz", VapiTranscriberLanguage.Dz },
        { "ee", VapiTranscriberLanguage.Ee },
        { "el", VapiTranscriberLanguage.El },
        { "en", VapiTranscriberLanguage.En },
        { "eo", VapiTranscriberLanguage.Eo },
        { "es", VapiTranscriberLanguage.Es },
        { "et", VapiTranscriberLanguage.Et },
        { "eu", VapiTranscriberLanguage.Eu },
        { "fa", VapiTranscriberLanguage.Fa },
        { "ff", VapiTranscriberLanguage.Ff },
        { "fi", VapiTranscriberLanguage.Fi },
        { "fj", VapiTranscriberLanguage.Fj },
        { "fo", VapiTranscriberLanguage.Fo },
        { "fr", VapiTranscriberLanguage.Fr },
        { "fy", VapiTranscriberLanguage.Fy },
        { "ga", VapiTranscriberLanguage.Ga },
        { "gd", VapiTranscriberLanguage.Gd },
        { "gl", VapiTranscriberLanguage.Gl },
        { "gn", VapiTranscriberLanguage.Gn },
        { "gu", VapiTranscriberLanguage.Gu },
        { "gv", VapiTranscriberLanguage.Gv },
        { "ha", VapiTranscriberLanguage.Ha },
        { "he", VapiTranscriberLanguage.He },
        { "hi", VapiTranscriberLanguage.Hi },
        { "ho", VapiTranscriberLanguage.Ho },
        { "hr", VapiTranscriberLanguage.Hr },
        { "ht", VapiTranscriberLanguage.Ht },
        { "hu", VapiTranscriberLanguage.Hu },
        { "hy", VapiTranscriberLanguage.Hy },
        { "hz", VapiTranscriberLanguage.Hz },
        { "ia", VapiTranscriberLanguage.Ia },
        { "id", VapiTranscriberLanguage.Id },
        { "ie", VapiTranscriberLanguage.Ie },
        { "ig", VapiTranscriberLanguage.Ig },
        { "ii", VapiTranscriberLanguage.Ii },
        { "ik", VapiTranscriberLanguage.Ik },
        { "io", VapiTranscriberLanguage.Io },
        { "is", VapiTranscriberLanguage.Is },
        { "it", VapiTranscriberLanguage.It },
        { "iu", VapiTranscriberLanguage.Iu },
        { "ja", VapiTranscriberLanguage.Ja },
        { "jv", VapiTranscriberLanguage.Jv },
        { "ka", VapiTranscriberLanguage.Ka },
        { "kg", VapiTranscriberLanguage.Kg },
        { "ki", VapiTranscriberLanguage.Ki },
        { "kj", VapiTranscriberLanguage.Kj },
        { "kk", VapiTranscriberLanguage.Kk },
        { "kl", VapiTranscriberLanguage.Kl },
        { "km", VapiTranscriberLanguage.Km },
        { "kn", VapiTranscriberLanguage.Kn },
        { "ko", VapiTranscriberLanguage.Ko },
        { "kr", VapiTranscriberLanguage.Kr },
        { "ks", VapiTranscriberLanguage.Ks },
        { "ku", VapiTranscriberLanguage.Ku },
        { "kv", VapiTranscriberLanguage.Kv },
        { "kw", VapiTranscriberLanguage.Kw },
        { "ky", VapiTranscriberLanguage.Ky },
        { "la", VapiTranscriberLanguage.La },
        { "lb", VapiTranscriberLanguage.Lb },
        { "lg", VapiTranscriberLanguage.Lg },
        { "li", VapiTranscriberLanguage.Li },
        { "ln", VapiTranscriberLanguage.Ln },
        { "lo", VapiTranscriberLanguage.Lo },
        { "lt", VapiTranscriberLanguage.Lt },
        { "lu", VapiTranscriberLanguage.Lu },
        { "lv", VapiTranscriberLanguage.Lv },
        { "mg", VapiTranscriberLanguage.Mg },
        { "mh", VapiTranscriberLanguage.Mh },
        { "mi", VapiTranscriberLanguage.Mi },
        { "mk", VapiTranscriberLanguage.Mk },
        { "ml", VapiTranscriberLanguage.Ml },
        { "mn", VapiTranscriberLanguage.Mn },
        { "mr", VapiTranscriberLanguage.Mr },
        { "ms", VapiTranscriberLanguage.Ms },
        { "mt", VapiTranscriberLanguage.Mt },
        { "my", VapiTranscriberLanguage.My },
        { "na", VapiTranscriberLanguage.Na },
        { "nb", VapiTranscriberLanguage.Nb },
        { "nd", VapiTranscriberLanguage.Nd },
        { "ne", VapiTranscriberLanguage.Ne },
        { "ng", VapiTranscriberLanguage.Ng },
        { "nl", VapiTranscriberLanguage.Nl },
        { "nn", VapiTranscriberLanguage.Nn },
        { "no", VapiTranscriberLanguage.No },
        { "nr", VapiTranscriberLanguage.Nr },
        { "nv", VapiTranscriberLanguage.Nv },
        { "ny", VapiTranscriberLanguage.Ny },
        { "oc", VapiTranscriberLanguage.Oc },
        { "oj", VapiTranscriberLanguage.Oj },
        { "om", VapiTranscriberLanguage.Om },
        { "or", VapiTranscriberLanguage.Or },
        { "os", VapiTranscriberLanguage.Os },
        { "pa", VapiTranscriberLanguage.Pa },
        { "pi", VapiTranscriberLanguage.Pi },
        { "pl", VapiTranscriberLanguage.Pl },
        { "ps", VapiTranscriberLanguage.Ps },
        { "pt", VapiTranscriberLanguage.Pt },
        { "qu", VapiTranscriberLanguage.Qu },
        { "rm", VapiTranscriberLanguage.Rm },
        { "rn", VapiTranscriberLanguage.Rn },
        { "ro", VapiTranscriberLanguage.Ro },
        { "ru", VapiTranscriberLanguage.Ru },
        { "rw", VapiTranscriberLanguage.Rw },
        { "sa", VapiTranscriberLanguage.Sa },
        { "sc", VapiTranscriberLanguage.Sc },
        { "sd", VapiTranscriberLanguage.Sd },
        { "se", VapiTranscriberLanguage.Se },
        { "sg", VapiTranscriberLanguage.Sg },
        { "si", VapiTranscriberLanguage.Si },
        { "sk", VapiTranscriberLanguage.Sk },
        { "sl", VapiTranscriberLanguage.Sl },
        { "sm", VapiTranscriberLanguage.Sm },
        { "sn", VapiTranscriberLanguage.Sn },
        { "so", VapiTranscriberLanguage.So },
        { "sq", VapiTranscriberLanguage.Sq },
        { "sr", VapiTranscriberLanguage.Sr },
        { "ss", VapiTranscriberLanguage.Ss },
        { "st", VapiTranscriberLanguage.St },
        { "su", VapiTranscriberLanguage.Su },
        { "sv", VapiTranscriberLanguage.Sv },
        { "sw", VapiTranscriberLanguage.Sw },
        { "ta", VapiTranscriberLanguage.Ta },
        { "te", VapiTranscriberLanguage.Te },
        { "tg", VapiTranscriberLanguage.Tg },
        { "th", VapiTranscriberLanguage.Th },
        { "ti", VapiTranscriberLanguage.Ti },
        { "tk", VapiTranscriberLanguage.Tk },
        { "tl", VapiTranscriberLanguage.Tl },
        { "tn", VapiTranscriberLanguage.Tn },
        { "to", VapiTranscriberLanguage.To },
        { "tr", VapiTranscriberLanguage.Tr },
        { "ts", VapiTranscriberLanguage.Ts },
        { "tt", VapiTranscriberLanguage.Tt },
        { "tw", VapiTranscriberLanguage.Tw },
        { "ty", VapiTranscriberLanguage.Ty },
        { "ug", VapiTranscriberLanguage.Ug },
        { "uk", VapiTranscriberLanguage.Uk },
        { "ur", VapiTranscriberLanguage.Ur },
        { "uz", VapiTranscriberLanguage.Uz },
        { "ve", VapiTranscriberLanguage.Ve },
        { "vi", VapiTranscriberLanguage.Vi },
        { "vo", VapiTranscriberLanguage.Vo },
        { "wa", VapiTranscriberLanguage.Wa },
        { "wo", VapiTranscriberLanguage.Wo },
        { "xh", VapiTranscriberLanguage.Xh },
        { "yi", VapiTranscriberLanguage.Yi },
        { "yue", VapiTranscriberLanguage.Yue },
        { "yo", VapiTranscriberLanguage.Yo },
        { "za", VapiTranscriberLanguage.Za },
        { "zh", VapiTranscriberLanguage.Zh },
        { "zu", VapiTranscriberLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { VapiTranscriberLanguage.Aa, "aa" },
        { VapiTranscriberLanguage.Ab, "ab" },
        { VapiTranscriberLanguage.Ae, "ae" },
        { VapiTranscriberLanguage.Af, "af" },
        { VapiTranscriberLanguage.Ak, "ak" },
        { VapiTranscriberLanguage.Am, "am" },
        { VapiTranscriberLanguage.An, "an" },
        { VapiTranscriberLanguage.Ar, "ar" },
        { VapiTranscriberLanguage.As, "as" },
        { VapiTranscriberLanguage.Av, "av" },
        { VapiTranscriberLanguage.Ay, "ay" },
        { VapiTranscriberLanguage.Az, "az" },
        { VapiTranscriberLanguage.Ba, "ba" },
        { VapiTranscriberLanguage.Be, "be" },
        { VapiTranscriberLanguage.Bg, "bg" },
        { VapiTranscriberLanguage.Bh, "bh" },
        { VapiTranscriberLanguage.Bi, "bi" },
        { VapiTranscriberLanguage.Bm, "bm" },
        { VapiTranscriberLanguage.Bn, "bn" },
        { VapiTranscriberLanguage.Bo, "bo" },
        { VapiTranscriberLanguage.Br, "br" },
        { VapiTranscriberLanguage.Bs, "bs" },
        { VapiTranscriberLanguage.Ca, "ca" },
        { VapiTranscriberLanguage.Ce, "ce" },
        { VapiTranscriberLanguage.Ch, "ch" },
        { VapiTranscriberLanguage.Co, "co" },
        { VapiTranscriberLanguage.Cr, "cr" },
        { VapiTranscriberLanguage.Cs, "cs" },
        { VapiTranscriberLanguage.Cu, "cu" },
        { VapiTranscriberLanguage.Cv, "cv" },
        { VapiTranscriberLanguage.Cy, "cy" },
        { VapiTranscriberLanguage.Da, "da" },
        { VapiTranscriberLanguage.De, "de" },
        { VapiTranscriberLanguage.Dv, "dv" },
        { VapiTranscriberLanguage.Dz, "dz" },
        { VapiTranscriberLanguage.Ee, "ee" },
        { VapiTranscriberLanguage.El, "el" },
        { VapiTranscriberLanguage.En, "en" },
        { VapiTranscriberLanguage.Eo, "eo" },
        { VapiTranscriberLanguage.Es, "es" },
        { VapiTranscriberLanguage.Et, "et" },
        { VapiTranscriberLanguage.Eu, "eu" },
        { VapiTranscriberLanguage.Fa, "fa" },
        { VapiTranscriberLanguage.Ff, "ff" },
        { VapiTranscriberLanguage.Fi, "fi" },
        { VapiTranscriberLanguage.Fj, "fj" },
        { VapiTranscriberLanguage.Fo, "fo" },
        { VapiTranscriberLanguage.Fr, "fr" },
        { VapiTranscriberLanguage.Fy, "fy" },
        { VapiTranscriberLanguage.Ga, "ga" },
        { VapiTranscriberLanguage.Gd, "gd" },
        { VapiTranscriberLanguage.Gl, "gl" },
        { VapiTranscriberLanguage.Gn, "gn" },
        { VapiTranscriberLanguage.Gu, "gu" },
        { VapiTranscriberLanguage.Gv, "gv" },
        { VapiTranscriberLanguage.Ha, "ha" },
        { VapiTranscriberLanguage.He, "he" },
        { VapiTranscriberLanguage.Hi, "hi" },
        { VapiTranscriberLanguage.Ho, "ho" },
        { VapiTranscriberLanguage.Hr, "hr" },
        { VapiTranscriberLanguage.Ht, "ht" },
        { VapiTranscriberLanguage.Hu, "hu" },
        { VapiTranscriberLanguage.Hy, "hy" },
        { VapiTranscriberLanguage.Hz, "hz" },
        { VapiTranscriberLanguage.Ia, "ia" },
        { VapiTranscriberLanguage.Id, "id" },
        { VapiTranscriberLanguage.Ie, "ie" },
        { VapiTranscriberLanguage.Ig, "ig" },
        { VapiTranscriberLanguage.Ii, "ii" },
        { VapiTranscriberLanguage.Ik, "ik" },
        { VapiTranscriberLanguage.Io, "io" },
        { VapiTranscriberLanguage.Is, "is" },
        { VapiTranscriberLanguage.It, "it" },
        { VapiTranscriberLanguage.Iu, "iu" },
        { VapiTranscriberLanguage.Ja, "ja" },
        { VapiTranscriberLanguage.Jv, "jv" },
        { VapiTranscriberLanguage.Ka, "ka" },
        { VapiTranscriberLanguage.Kg, "kg" },
        { VapiTranscriberLanguage.Ki, "ki" },
        { VapiTranscriberLanguage.Kj, "kj" },
        { VapiTranscriberLanguage.Kk, "kk" },
        { VapiTranscriberLanguage.Kl, "kl" },
        { VapiTranscriberLanguage.Km, "km" },
        { VapiTranscriberLanguage.Kn, "kn" },
        { VapiTranscriberLanguage.Ko, "ko" },
        { VapiTranscriberLanguage.Kr, "kr" },
        { VapiTranscriberLanguage.Ks, "ks" },
        { VapiTranscriberLanguage.Ku, "ku" },
        { VapiTranscriberLanguage.Kv, "kv" },
        { VapiTranscriberLanguage.Kw, "kw" },
        { VapiTranscriberLanguage.Ky, "ky" },
        { VapiTranscriberLanguage.La, "la" },
        { VapiTranscriberLanguage.Lb, "lb" },
        { VapiTranscriberLanguage.Lg, "lg" },
        { VapiTranscriberLanguage.Li, "li" },
        { VapiTranscriberLanguage.Ln, "ln" },
        { VapiTranscriberLanguage.Lo, "lo" },
        { VapiTranscriberLanguage.Lt, "lt" },
        { VapiTranscriberLanguage.Lu, "lu" },
        { VapiTranscriberLanguage.Lv, "lv" },
        { VapiTranscriberLanguage.Mg, "mg" },
        { VapiTranscriberLanguage.Mh, "mh" },
        { VapiTranscriberLanguage.Mi, "mi" },
        { VapiTranscriberLanguage.Mk, "mk" },
        { VapiTranscriberLanguage.Ml, "ml" },
        { VapiTranscriberLanguage.Mn, "mn" },
        { VapiTranscriberLanguage.Mr, "mr" },
        { VapiTranscriberLanguage.Ms, "ms" },
        { VapiTranscriberLanguage.Mt, "mt" },
        { VapiTranscriberLanguage.My, "my" },
        { VapiTranscriberLanguage.Na, "na" },
        { VapiTranscriberLanguage.Nb, "nb" },
        { VapiTranscriberLanguage.Nd, "nd" },
        { VapiTranscriberLanguage.Ne, "ne" },
        { VapiTranscriberLanguage.Ng, "ng" },
        { VapiTranscriberLanguage.Nl, "nl" },
        { VapiTranscriberLanguage.Nn, "nn" },
        { VapiTranscriberLanguage.No, "no" },
        { VapiTranscriberLanguage.Nr, "nr" },
        { VapiTranscriberLanguage.Nv, "nv" },
        { VapiTranscriberLanguage.Ny, "ny" },
        { VapiTranscriberLanguage.Oc, "oc" },
        { VapiTranscriberLanguage.Oj, "oj" },
        { VapiTranscriberLanguage.Om, "om" },
        { VapiTranscriberLanguage.Or, "or" },
        { VapiTranscriberLanguage.Os, "os" },
        { VapiTranscriberLanguage.Pa, "pa" },
        { VapiTranscriberLanguage.Pi, "pi" },
        { VapiTranscriberLanguage.Pl, "pl" },
        { VapiTranscriberLanguage.Ps, "ps" },
        { VapiTranscriberLanguage.Pt, "pt" },
        { VapiTranscriberLanguage.Qu, "qu" },
        { VapiTranscriberLanguage.Rm, "rm" },
        { VapiTranscriberLanguage.Rn, "rn" },
        { VapiTranscriberLanguage.Ro, "ro" },
        { VapiTranscriberLanguage.Ru, "ru" },
        { VapiTranscriberLanguage.Rw, "rw" },
        { VapiTranscriberLanguage.Sa, "sa" },
        { VapiTranscriberLanguage.Sc, "sc" },
        { VapiTranscriberLanguage.Sd, "sd" },
        { VapiTranscriberLanguage.Se, "se" },
        { VapiTranscriberLanguage.Sg, "sg" },
        { VapiTranscriberLanguage.Si, "si" },
        { VapiTranscriberLanguage.Sk, "sk" },
        { VapiTranscriberLanguage.Sl, "sl" },
        { VapiTranscriberLanguage.Sm, "sm" },
        { VapiTranscriberLanguage.Sn, "sn" },
        { VapiTranscriberLanguage.So, "so" },
        { VapiTranscriberLanguage.Sq, "sq" },
        { VapiTranscriberLanguage.Sr, "sr" },
        { VapiTranscriberLanguage.Ss, "ss" },
        { VapiTranscriberLanguage.St, "st" },
        { VapiTranscriberLanguage.Su, "su" },
        { VapiTranscriberLanguage.Sv, "sv" },
        { VapiTranscriberLanguage.Sw, "sw" },
        { VapiTranscriberLanguage.Ta, "ta" },
        { VapiTranscriberLanguage.Te, "te" },
        { VapiTranscriberLanguage.Tg, "tg" },
        { VapiTranscriberLanguage.Th, "th" },
        { VapiTranscriberLanguage.Ti, "ti" },
        { VapiTranscriberLanguage.Tk, "tk" },
        { VapiTranscriberLanguage.Tl, "tl" },
        { VapiTranscriberLanguage.Tn, "tn" },
        { VapiTranscriberLanguage.To, "to" },
        { VapiTranscriberLanguage.Tr, "tr" },
        { VapiTranscriberLanguage.Ts, "ts" },
        { VapiTranscriberLanguage.Tt, "tt" },
        { VapiTranscriberLanguage.Tw, "tw" },
        { VapiTranscriberLanguage.Ty, "ty" },
        { VapiTranscriberLanguage.Ug, "ug" },
        { VapiTranscriberLanguage.Uk, "uk" },
        { VapiTranscriberLanguage.Ur, "ur" },
        { VapiTranscriberLanguage.Uz, "uz" },
        { VapiTranscriberLanguage.Ve, "ve" },
        { VapiTranscriberLanguage.Vi, "vi" },
        { VapiTranscriberLanguage.Vo, "vo" },
        { VapiTranscriberLanguage.Wa, "wa" },
        { VapiTranscriberLanguage.Wo, "wo" },
        { VapiTranscriberLanguage.Xh, "xh" },
        { VapiTranscriberLanguage.Yi, "yi" },
        { VapiTranscriberLanguage.Yue, "yue" },
        { VapiTranscriberLanguage.Yo, "yo" },
        { VapiTranscriberLanguage.Za, "za" },
        { VapiTranscriberLanguage.Zh, "zh" },
        { VapiTranscriberLanguage.Zu, "zu" },
    };

    public override VapiTranscriberLanguage Read(
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
        VapiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiTranscriberLanguage ReadAsPropertyName(
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
        VapiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
