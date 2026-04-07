using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SonioxTranscriberLanguageSerializer))]
public enum SonioxTranscriberLanguage
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

internal class SonioxTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SonioxTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SonioxTranscriberLanguage
    > _stringToEnum = new()
    {
        { "aa", SonioxTranscriberLanguage.Aa },
        { "ab", SonioxTranscriberLanguage.Ab },
        { "ae", SonioxTranscriberLanguage.Ae },
        { "af", SonioxTranscriberLanguage.Af },
        { "ak", SonioxTranscriberLanguage.Ak },
        { "am", SonioxTranscriberLanguage.Am },
        { "an", SonioxTranscriberLanguage.An },
        { "ar", SonioxTranscriberLanguage.Ar },
        { "as", SonioxTranscriberLanguage.As },
        { "av", SonioxTranscriberLanguage.Av },
        { "ay", SonioxTranscriberLanguage.Ay },
        { "az", SonioxTranscriberLanguage.Az },
        { "ba", SonioxTranscriberLanguage.Ba },
        { "be", SonioxTranscriberLanguage.Be },
        { "bg", SonioxTranscriberLanguage.Bg },
        { "bh", SonioxTranscriberLanguage.Bh },
        { "bi", SonioxTranscriberLanguage.Bi },
        { "bm", SonioxTranscriberLanguage.Bm },
        { "bn", SonioxTranscriberLanguage.Bn },
        { "bo", SonioxTranscriberLanguage.Bo },
        { "br", SonioxTranscriberLanguage.Br },
        { "bs", SonioxTranscriberLanguage.Bs },
        { "ca", SonioxTranscriberLanguage.Ca },
        { "ce", SonioxTranscriberLanguage.Ce },
        { "ch", SonioxTranscriberLanguage.Ch },
        { "co", SonioxTranscriberLanguage.Co },
        { "cr", SonioxTranscriberLanguage.Cr },
        { "cs", SonioxTranscriberLanguage.Cs },
        { "cu", SonioxTranscriberLanguage.Cu },
        { "cv", SonioxTranscriberLanguage.Cv },
        { "cy", SonioxTranscriberLanguage.Cy },
        { "da", SonioxTranscriberLanguage.Da },
        { "de", SonioxTranscriberLanguage.De },
        { "dv", SonioxTranscriberLanguage.Dv },
        { "dz", SonioxTranscriberLanguage.Dz },
        { "ee", SonioxTranscriberLanguage.Ee },
        { "el", SonioxTranscriberLanguage.El },
        { "en", SonioxTranscriberLanguage.En },
        { "eo", SonioxTranscriberLanguage.Eo },
        { "es", SonioxTranscriberLanguage.Es },
        { "et", SonioxTranscriberLanguage.Et },
        { "eu", SonioxTranscriberLanguage.Eu },
        { "fa", SonioxTranscriberLanguage.Fa },
        { "ff", SonioxTranscriberLanguage.Ff },
        { "fi", SonioxTranscriberLanguage.Fi },
        { "fj", SonioxTranscriberLanguage.Fj },
        { "fo", SonioxTranscriberLanguage.Fo },
        { "fr", SonioxTranscriberLanguage.Fr },
        { "fy", SonioxTranscriberLanguage.Fy },
        { "ga", SonioxTranscriberLanguage.Ga },
        { "gd", SonioxTranscriberLanguage.Gd },
        { "gl", SonioxTranscriberLanguage.Gl },
        { "gn", SonioxTranscriberLanguage.Gn },
        { "gu", SonioxTranscriberLanguage.Gu },
        { "gv", SonioxTranscriberLanguage.Gv },
        { "ha", SonioxTranscriberLanguage.Ha },
        { "he", SonioxTranscriberLanguage.He },
        { "hi", SonioxTranscriberLanguage.Hi },
        { "ho", SonioxTranscriberLanguage.Ho },
        { "hr", SonioxTranscriberLanguage.Hr },
        { "ht", SonioxTranscriberLanguage.Ht },
        { "hu", SonioxTranscriberLanguage.Hu },
        { "hy", SonioxTranscriberLanguage.Hy },
        { "hz", SonioxTranscriberLanguage.Hz },
        { "ia", SonioxTranscriberLanguage.Ia },
        { "id", SonioxTranscriberLanguage.Id },
        { "ie", SonioxTranscriberLanguage.Ie },
        { "ig", SonioxTranscriberLanguage.Ig },
        { "ii", SonioxTranscriberLanguage.Ii },
        { "ik", SonioxTranscriberLanguage.Ik },
        { "io", SonioxTranscriberLanguage.Io },
        { "is", SonioxTranscriberLanguage.Is },
        { "it", SonioxTranscriberLanguage.It },
        { "iu", SonioxTranscriberLanguage.Iu },
        { "ja", SonioxTranscriberLanguage.Ja },
        { "jv", SonioxTranscriberLanguage.Jv },
        { "ka", SonioxTranscriberLanguage.Ka },
        { "kg", SonioxTranscriberLanguage.Kg },
        { "ki", SonioxTranscriberLanguage.Ki },
        { "kj", SonioxTranscriberLanguage.Kj },
        { "kk", SonioxTranscriberLanguage.Kk },
        { "kl", SonioxTranscriberLanguage.Kl },
        { "km", SonioxTranscriberLanguage.Km },
        { "kn", SonioxTranscriberLanguage.Kn },
        { "ko", SonioxTranscriberLanguage.Ko },
        { "kr", SonioxTranscriberLanguage.Kr },
        { "ks", SonioxTranscriberLanguage.Ks },
        { "ku", SonioxTranscriberLanguage.Ku },
        { "kv", SonioxTranscriberLanguage.Kv },
        { "kw", SonioxTranscriberLanguage.Kw },
        { "ky", SonioxTranscriberLanguage.Ky },
        { "la", SonioxTranscriberLanguage.La },
        { "lb", SonioxTranscriberLanguage.Lb },
        { "lg", SonioxTranscriberLanguage.Lg },
        { "li", SonioxTranscriberLanguage.Li },
        { "ln", SonioxTranscriberLanguage.Ln },
        { "lo", SonioxTranscriberLanguage.Lo },
        { "lt", SonioxTranscriberLanguage.Lt },
        { "lu", SonioxTranscriberLanguage.Lu },
        { "lv", SonioxTranscriberLanguage.Lv },
        { "mg", SonioxTranscriberLanguage.Mg },
        { "mh", SonioxTranscriberLanguage.Mh },
        { "mi", SonioxTranscriberLanguage.Mi },
        { "mk", SonioxTranscriberLanguage.Mk },
        { "ml", SonioxTranscriberLanguage.Ml },
        { "mn", SonioxTranscriberLanguage.Mn },
        { "mr", SonioxTranscriberLanguage.Mr },
        { "ms", SonioxTranscriberLanguage.Ms },
        { "mt", SonioxTranscriberLanguage.Mt },
        { "my", SonioxTranscriberLanguage.My },
        { "na", SonioxTranscriberLanguage.Na },
        { "nb", SonioxTranscriberLanguage.Nb },
        { "nd", SonioxTranscriberLanguage.Nd },
        { "ne", SonioxTranscriberLanguage.Ne },
        { "ng", SonioxTranscriberLanguage.Ng },
        { "nl", SonioxTranscriberLanguage.Nl },
        { "nn", SonioxTranscriberLanguage.Nn },
        { "no", SonioxTranscriberLanguage.No },
        { "nr", SonioxTranscriberLanguage.Nr },
        { "nv", SonioxTranscriberLanguage.Nv },
        { "ny", SonioxTranscriberLanguage.Ny },
        { "oc", SonioxTranscriberLanguage.Oc },
        { "oj", SonioxTranscriberLanguage.Oj },
        { "om", SonioxTranscriberLanguage.Om },
        { "or", SonioxTranscriberLanguage.Or },
        { "os", SonioxTranscriberLanguage.Os },
        { "pa", SonioxTranscriberLanguage.Pa },
        { "pi", SonioxTranscriberLanguage.Pi },
        { "pl", SonioxTranscriberLanguage.Pl },
        { "ps", SonioxTranscriberLanguage.Ps },
        { "pt", SonioxTranscriberLanguage.Pt },
        { "qu", SonioxTranscriberLanguage.Qu },
        { "rm", SonioxTranscriberLanguage.Rm },
        { "rn", SonioxTranscriberLanguage.Rn },
        { "ro", SonioxTranscriberLanguage.Ro },
        { "ru", SonioxTranscriberLanguage.Ru },
        { "rw", SonioxTranscriberLanguage.Rw },
        { "sa", SonioxTranscriberLanguage.Sa },
        { "sc", SonioxTranscriberLanguage.Sc },
        { "sd", SonioxTranscriberLanguage.Sd },
        { "se", SonioxTranscriberLanguage.Se },
        { "sg", SonioxTranscriberLanguage.Sg },
        { "si", SonioxTranscriberLanguage.Si },
        { "sk", SonioxTranscriberLanguage.Sk },
        { "sl", SonioxTranscriberLanguage.Sl },
        { "sm", SonioxTranscriberLanguage.Sm },
        { "sn", SonioxTranscriberLanguage.Sn },
        { "so", SonioxTranscriberLanguage.So },
        { "sq", SonioxTranscriberLanguage.Sq },
        { "sr", SonioxTranscriberLanguage.Sr },
        { "ss", SonioxTranscriberLanguage.Ss },
        { "st", SonioxTranscriberLanguage.St },
        { "su", SonioxTranscriberLanguage.Su },
        { "sv", SonioxTranscriberLanguage.Sv },
        { "sw", SonioxTranscriberLanguage.Sw },
        { "ta", SonioxTranscriberLanguage.Ta },
        { "te", SonioxTranscriberLanguage.Te },
        { "tg", SonioxTranscriberLanguage.Tg },
        { "th", SonioxTranscriberLanguage.Th },
        { "ti", SonioxTranscriberLanguage.Ti },
        { "tk", SonioxTranscriberLanguage.Tk },
        { "tl", SonioxTranscriberLanguage.Tl },
        { "tn", SonioxTranscriberLanguage.Tn },
        { "to", SonioxTranscriberLanguage.To },
        { "tr", SonioxTranscriberLanguage.Tr },
        { "ts", SonioxTranscriberLanguage.Ts },
        { "tt", SonioxTranscriberLanguage.Tt },
        { "tw", SonioxTranscriberLanguage.Tw },
        { "ty", SonioxTranscriberLanguage.Ty },
        { "ug", SonioxTranscriberLanguage.Ug },
        { "uk", SonioxTranscriberLanguage.Uk },
        { "ur", SonioxTranscriberLanguage.Ur },
        { "uz", SonioxTranscriberLanguage.Uz },
        { "ve", SonioxTranscriberLanguage.Ve },
        { "vi", SonioxTranscriberLanguage.Vi },
        { "vo", SonioxTranscriberLanguage.Vo },
        { "wa", SonioxTranscriberLanguage.Wa },
        { "wo", SonioxTranscriberLanguage.Wo },
        { "xh", SonioxTranscriberLanguage.Xh },
        { "yi", SonioxTranscriberLanguage.Yi },
        { "yue", SonioxTranscriberLanguage.Yue },
        { "yo", SonioxTranscriberLanguage.Yo },
        { "za", SonioxTranscriberLanguage.Za },
        { "zh", SonioxTranscriberLanguage.Zh },
        { "zu", SonioxTranscriberLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SonioxTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { SonioxTranscriberLanguage.Aa, "aa" },
        { SonioxTranscriberLanguage.Ab, "ab" },
        { SonioxTranscriberLanguage.Ae, "ae" },
        { SonioxTranscriberLanguage.Af, "af" },
        { SonioxTranscriberLanguage.Ak, "ak" },
        { SonioxTranscriberLanguage.Am, "am" },
        { SonioxTranscriberLanguage.An, "an" },
        { SonioxTranscriberLanguage.Ar, "ar" },
        { SonioxTranscriberLanguage.As, "as" },
        { SonioxTranscriberLanguage.Av, "av" },
        { SonioxTranscriberLanguage.Ay, "ay" },
        { SonioxTranscriberLanguage.Az, "az" },
        { SonioxTranscriberLanguage.Ba, "ba" },
        { SonioxTranscriberLanguage.Be, "be" },
        { SonioxTranscriberLanguage.Bg, "bg" },
        { SonioxTranscriberLanguage.Bh, "bh" },
        { SonioxTranscriberLanguage.Bi, "bi" },
        { SonioxTranscriberLanguage.Bm, "bm" },
        { SonioxTranscriberLanguage.Bn, "bn" },
        { SonioxTranscriberLanguage.Bo, "bo" },
        { SonioxTranscriberLanguage.Br, "br" },
        { SonioxTranscriberLanguage.Bs, "bs" },
        { SonioxTranscriberLanguage.Ca, "ca" },
        { SonioxTranscriberLanguage.Ce, "ce" },
        { SonioxTranscriberLanguage.Ch, "ch" },
        { SonioxTranscriberLanguage.Co, "co" },
        { SonioxTranscriberLanguage.Cr, "cr" },
        { SonioxTranscriberLanguage.Cs, "cs" },
        { SonioxTranscriberLanguage.Cu, "cu" },
        { SonioxTranscriberLanguage.Cv, "cv" },
        { SonioxTranscriberLanguage.Cy, "cy" },
        { SonioxTranscriberLanguage.Da, "da" },
        { SonioxTranscriberLanguage.De, "de" },
        { SonioxTranscriberLanguage.Dv, "dv" },
        { SonioxTranscriberLanguage.Dz, "dz" },
        { SonioxTranscriberLanguage.Ee, "ee" },
        { SonioxTranscriberLanguage.El, "el" },
        { SonioxTranscriberLanguage.En, "en" },
        { SonioxTranscriberLanguage.Eo, "eo" },
        { SonioxTranscriberLanguage.Es, "es" },
        { SonioxTranscriberLanguage.Et, "et" },
        { SonioxTranscriberLanguage.Eu, "eu" },
        { SonioxTranscriberLanguage.Fa, "fa" },
        { SonioxTranscriberLanguage.Ff, "ff" },
        { SonioxTranscriberLanguage.Fi, "fi" },
        { SonioxTranscriberLanguage.Fj, "fj" },
        { SonioxTranscriberLanguage.Fo, "fo" },
        { SonioxTranscriberLanguage.Fr, "fr" },
        { SonioxTranscriberLanguage.Fy, "fy" },
        { SonioxTranscriberLanguage.Ga, "ga" },
        { SonioxTranscriberLanguage.Gd, "gd" },
        { SonioxTranscriberLanguage.Gl, "gl" },
        { SonioxTranscriberLanguage.Gn, "gn" },
        { SonioxTranscriberLanguage.Gu, "gu" },
        { SonioxTranscriberLanguage.Gv, "gv" },
        { SonioxTranscriberLanguage.Ha, "ha" },
        { SonioxTranscriberLanguage.He, "he" },
        { SonioxTranscriberLanguage.Hi, "hi" },
        { SonioxTranscriberLanguage.Ho, "ho" },
        { SonioxTranscriberLanguage.Hr, "hr" },
        { SonioxTranscriberLanguage.Ht, "ht" },
        { SonioxTranscriberLanguage.Hu, "hu" },
        { SonioxTranscriberLanguage.Hy, "hy" },
        { SonioxTranscriberLanguage.Hz, "hz" },
        { SonioxTranscriberLanguage.Ia, "ia" },
        { SonioxTranscriberLanguage.Id, "id" },
        { SonioxTranscriberLanguage.Ie, "ie" },
        { SonioxTranscriberLanguage.Ig, "ig" },
        { SonioxTranscriberLanguage.Ii, "ii" },
        { SonioxTranscriberLanguage.Ik, "ik" },
        { SonioxTranscriberLanguage.Io, "io" },
        { SonioxTranscriberLanguage.Is, "is" },
        { SonioxTranscriberLanguage.It, "it" },
        { SonioxTranscriberLanguage.Iu, "iu" },
        { SonioxTranscriberLanguage.Ja, "ja" },
        { SonioxTranscriberLanguage.Jv, "jv" },
        { SonioxTranscriberLanguage.Ka, "ka" },
        { SonioxTranscriberLanguage.Kg, "kg" },
        { SonioxTranscriberLanguage.Ki, "ki" },
        { SonioxTranscriberLanguage.Kj, "kj" },
        { SonioxTranscriberLanguage.Kk, "kk" },
        { SonioxTranscriberLanguage.Kl, "kl" },
        { SonioxTranscriberLanguage.Km, "km" },
        { SonioxTranscriberLanguage.Kn, "kn" },
        { SonioxTranscriberLanguage.Ko, "ko" },
        { SonioxTranscriberLanguage.Kr, "kr" },
        { SonioxTranscriberLanguage.Ks, "ks" },
        { SonioxTranscriberLanguage.Ku, "ku" },
        { SonioxTranscriberLanguage.Kv, "kv" },
        { SonioxTranscriberLanguage.Kw, "kw" },
        { SonioxTranscriberLanguage.Ky, "ky" },
        { SonioxTranscriberLanguage.La, "la" },
        { SonioxTranscriberLanguage.Lb, "lb" },
        { SonioxTranscriberLanguage.Lg, "lg" },
        { SonioxTranscriberLanguage.Li, "li" },
        { SonioxTranscriberLanguage.Ln, "ln" },
        { SonioxTranscriberLanguage.Lo, "lo" },
        { SonioxTranscriberLanguage.Lt, "lt" },
        { SonioxTranscriberLanguage.Lu, "lu" },
        { SonioxTranscriberLanguage.Lv, "lv" },
        { SonioxTranscriberLanguage.Mg, "mg" },
        { SonioxTranscriberLanguage.Mh, "mh" },
        { SonioxTranscriberLanguage.Mi, "mi" },
        { SonioxTranscriberLanguage.Mk, "mk" },
        { SonioxTranscriberLanguage.Ml, "ml" },
        { SonioxTranscriberLanguage.Mn, "mn" },
        { SonioxTranscriberLanguage.Mr, "mr" },
        { SonioxTranscriberLanguage.Ms, "ms" },
        { SonioxTranscriberLanguage.Mt, "mt" },
        { SonioxTranscriberLanguage.My, "my" },
        { SonioxTranscriberLanguage.Na, "na" },
        { SonioxTranscriberLanguage.Nb, "nb" },
        { SonioxTranscriberLanguage.Nd, "nd" },
        { SonioxTranscriberLanguage.Ne, "ne" },
        { SonioxTranscriberLanguage.Ng, "ng" },
        { SonioxTranscriberLanguage.Nl, "nl" },
        { SonioxTranscriberLanguage.Nn, "nn" },
        { SonioxTranscriberLanguage.No, "no" },
        { SonioxTranscriberLanguage.Nr, "nr" },
        { SonioxTranscriberLanguage.Nv, "nv" },
        { SonioxTranscriberLanguage.Ny, "ny" },
        { SonioxTranscriberLanguage.Oc, "oc" },
        { SonioxTranscriberLanguage.Oj, "oj" },
        { SonioxTranscriberLanguage.Om, "om" },
        { SonioxTranscriberLanguage.Or, "or" },
        { SonioxTranscriberLanguage.Os, "os" },
        { SonioxTranscriberLanguage.Pa, "pa" },
        { SonioxTranscriberLanguage.Pi, "pi" },
        { SonioxTranscriberLanguage.Pl, "pl" },
        { SonioxTranscriberLanguage.Ps, "ps" },
        { SonioxTranscriberLanguage.Pt, "pt" },
        { SonioxTranscriberLanguage.Qu, "qu" },
        { SonioxTranscriberLanguage.Rm, "rm" },
        { SonioxTranscriberLanguage.Rn, "rn" },
        { SonioxTranscriberLanguage.Ro, "ro" },
        { SonioxTranscriberLanguage.Ru, "ru" },
        { SonioxTranscriberLanguage.Rw, "rw" },
        { SonioxTranscriberLanguage.Sa, "sa" },
        { SonioxTranscriberLanguage.Sc, "sc" },
        { SonioxTranscriberLanguage.Sd, "sd" },
        { SonioxTranscriberLanguage.Se, "se" },
        { SonioxTranscriberLanguage.Sg, "sg" },
        { SonioxTranscriberLanguage.Si, "si" },
        { SonioxTranscriberLanguage.Sk, "sk" },
        { SonioxTranscriberLanguage.Sl, "sl" },
        { SonioxTranscriberLanguage.Sm, "sm" },
        { SonioxTranscriberLanguage.Sn, "sn" },
        { SonioxTranscriberLanguage.So, "so" },
        { SonioxTranscriberLanguage.Sq, "sq" },
        { SonioxTranscriberLanguage.Sr, "sr" },
        { SonioxTranscriberLanguage.Ss, "ss" },
        { SonioxTranscriberLanguage.St, "st" },
        { SonioxTranscriberLanguage.Su, "su" },
        { SonioxTranscriberLanguage.Sv, "sv" },
        { SonioxTranscriberLanguage.Sw, "sw" },
        { SonioxTranscriberLanguage.Ta, "ta" },
        { SonioxTranscriberLanguage.Te, "te" },
        { SonioxTranscriberLanguage.Tg, "tg" },
        { SonioxTranscriberLanguage.Th, "th" },
        { SonioxTranscriberLanguage.Ti, "ti" },
        { SonioxTranscriberLanguage.Tk, "tk" },
        { SonioxTranscriberLanguage.Tl, "tl" },
        { SonioxTranscriberLanguage.Tn, "tn" },
        { SonioxTranscriberLanguage.To, "to" },
        { SonioxTranscriberLanguage.Tr, "tr" },
        { SonioxTranscriberLanguage.Ts, "ts" },
        { SonioxTranscriberLanguage.Tt, "tt" },
        { SonioxTranscriberLanguage.Tw, "tw" },
        { SonioxTranscriberLanguage.Ty, "ty" },
        { SonioxTranscriberLanguage.Ug, "ug" },
        { SonioxTranscriberLanguage.Uk, "uk" },
        { SonioxTranscriberLanguage.Ur, "ur" },
        { SonioxTranscriberLanguage.Uz, "uz" },
        { SonioxTranscriberLanguage.Ve, "ve" },
        { SonioxTranscriberLanguage.Vi, "vi" },
        { SonioxTranscriberLanguage.Vo, "vo" },
        { SonioxTranscriberLanguage.Wa, "wa" },
        { SonioxTranscriberLanguage.Wo, "wo" },
        { SonioxTranscriberLanguage.Xh, "xh" },
        { SonioxTranscriberLanguage.Yi, "yi" },
        { SonioxTranscriberLanguage.Yue, "yue" },
        { SonioxTranscriberLanguage.Yo, "yo" },
        { SonioxTranscriberLanguage.Za, "za" },
        { SonioxTranscriberLanguage.Zh, "zh" },
        { SonioxTranscriberLanguage.Zu, "zu" },
    };

    public override SonioxTranscriberLanguage Read(
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
        SonioxTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SonioxTranscriberLanguage ReadAsPropertyName(
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
        SonioxTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
