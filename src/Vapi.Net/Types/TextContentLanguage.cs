using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TextContentLanguageSerializer))]
public enum TextContentLanguage
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

internal class TextContentLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TextContentLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TextContentLanguage
    > _stringToEnum = new()
    {
        { "aa", TextContentLanguage.Aa },
        { "ab", TextContentLanguage.Ab },
        { "ae", TextContentLanguage.Ae },
        { "af", TextContentLanguage.Af },
        { "ak", TextContentLanguage.Ak },
        { "am", TextContentLanguage.Am },
        { "an", TextContentLanguage.An },
        { "ar", TextContentLanguage.Ar },
        { "as", TextContentLanguage.As },
        { "av", TextContentLanguage.Av },
        { "ay", TextContentLanguage.Ay },
        { "az", TextContentLanguage.Az },
        { "ba", TextContentLanguage.Ba },
        { "be", TextContentLanguage.Be },
        { "bg", TextContentLanguage.Bg },
        { "bh", TextContentLanguage.Bh },
        { "bi", TextContentLanguage.Bi },
        { "bm", TextContentLanguage.Bm },
        { "bn", TextContentLanguage.Bn },
        { "bo", TextContentLanguage.Bo },
        { "br", TextContentLanguage.Br },
        { "bs", TextContentLanguage.Bs },
        { "ca", TextContentLanguage.Ca },
        { "ce", TextContentLanguage.Ce },
        { "ch", TextContentLanguage.Ch },
        { "co", TextContentLanguage.Co },
        { "cr", TextContentLanguage.Cr },
        { "cs", TextContentLanguage.Cs },
        { "cu", TextContentLanguage.Cu },
        { "cv", TextContentLanguage.Cv },
        { "cy", TextContentLanguage.Cy },
        { "da", TextContentLanguage.Da },
        { "de", TextContentLanguage.De },
        { "dv", TextContentLanguage.Dv },
        { "dz", TextContentLanguage.Dz },
        { "ee", TextContentLanguage.Ee },
        { "el", TextContentLanguage.El },
        { "en", TextContentLanguage.En },
        { "eo", TextContentLanguage.Eo },
        { "es", TextContentLanguage.Es },
        { "et", TextContentLanguage.Et },
        { "eu", TextContentLanguage.Eu },
        { "fa", TextContentLanguage.Fa },
        { "ff", TextContentLanguage.Ff },
        { "fi", TextContentLanguage.Fi },
        { "fj", TextContentLanguage.Fj },
        { "fo", TextContentLanguage.Fo },
        { "fr", TextContentLanguage.Fr },
        { "fy", TextContentLanguage.Fy },
        { "ga", TextContentLanguage.Ga },
        { "gd", TextContentLanguage.Gd },
        { "gl", TextContentLanguage.Gl },
        { "gn", TextContentLanguage.Gn },
        { "gu", TextContentLanguage.Gu },
        { "gv", TextContentLanguage.Gv },
        { "ha", TextContentLanguage.Ha },
        { "he", TextContentLanguage.He },
        { "hi", TextContentLanguage.Hi },
        { "ho", TextContentLanguage.Ho },
        { "hr", TextContentLanguage.Hr },
        { "ht", TextContentLanguage.Ht },
        { "hu", TextContentLanguage.Hu },
        { "hy", TextContentLanguage.Hy },
        { "hz", TextContentLanguage.Hz },
        { "ia", TextContentLanguage.Ia },
        { "id", TextContentLanguage.Id },
        { "ie", TextContentLanguage.Ie },
        { "ig", TextContentLanguage.Ig },
        { "ii", TextContentLanguage.Ii },
        { "ik", TextContentLanguage.Ik },
        { "io", TextContentLanguage.Io },
        { "is", TextContentLanguage.Is },
        { "it", TextContentLanguage.It },
        { "iu", TextContentLanguage.Iu },
        { "ja", TextContentLanguage.Ja },
        { "jv", TextContentLanguage.Jv },
        { "ka", TextContentLanguage.Ka },
        { "kg", TextContentLanguage.Kg },
        { "ki", TextContentLanguage.Ki },
        { "kj", TextContentLanguage.Kj },
        { "kk", TextContentLanguage.Kk },
        { "kl", TextContentLanguage.Kl },
        { "km", TextContentLanguage.Km },
        { "kn", TextContentLanguage.Kn },
        { "ko", TextContentLanguage.Ko },
        { "kr", TextContentLanguage.Kr },
        { "ks", TextContentLanguage.Ks },
        { "ku", TextContentLanguage.Ku },
        { "kv", TextContentLanguage.Kv },
        { "kw", TextContentLanguage.Kw },
        { "ky", TextContentLanguage.Ky },
        { "la", TextContentLanguage.La },
        { "lb", TextContentLanguage.Lb },
        { "lg", TextContentLanguage.Lg },
        { "li", TextContentLanguage.Li },
        { "ln", TextContentLanguage.Ln },
        { "lo", TextContentLanguage.Lo },
        { "lt", TextContentLanguage.Lt },
        { "lu", TextContentLanguage.Lu },
        { "lv", TextContentLanguage.Lv },
        { "mg", TextContentLanguage.Mg },
        { "mh", TextContentLanguage.Mh },
        { "mi", TextContentLanguage.Mi },
        { "mk", TextContentLanguage.Mk },
        { "ml", TextContentLanguage.Ml },
        { "mn", TextContentLanguage.Mn },
        { "mr", TextContentLanguage.Mr },
        { "ms", TextContentLanguage.Ms },
        { "mt", TextContentLanguage.Mt },
        { "my", TextContentLanguage.My },
        { "na", TextContentLanguage.Na },
        { "nb", TextContentLanguage.Nb },
        { "nd", TextContentLanguage.Nd },
        { "ne", TextContentLanguage.Ne },
        { "ng", TextContentLanguage.Ng },
        { "nl", TextContentLanguage.Nl },
        { "nn", TextContentLanguage.Nn },
        { "no", TextContentLanguage.No },
        { "nr", TextContentLanguage.Nr },
        { "nv", TextContentLanguage.Nv },
        { "ny", TextContentLanguage.Ny },
        { "oc", TextContentLanguage.Oc },
        { "oj", TextContentLanguage.Oj },
        { "om", TextContentLanguage.Om },
        { "or", TextContentLanguage.Or },
        { "os", TextContentLanguage.Os },
        { "pa", TextContentLanguage.Pa },
        { "pi", TextContentLanguage.Pi },
        { "pl", TextContentLanguage.Pl },
        { "ps", TextContentLanguage.Ps },
        { "pt", TextContentLanguage.Pt },
        { "qu", TextContentLanguage.Qu },
        { "rm", TextContentLanguage.Rm },
        { "rn", TextContentLanguage.Rn },
        { "ro", TextContentLanguage.Ro },
        { "ru", TextContentLanguage.Ru },
        { "rw", TextContentLanguage.Rw },
        { "sa", TextContentLanguage.Sa },
        { "sc", TextContentLanguage.Sc },
        { "sd", TextContentLanguage.Sd },
        { "se", TextContentLanguage.Se },
        { "sg", TextContentLanguage.Sg },
        { "si", TextContentLanguage.Si },
        { "sk", TextContentLanguage.Sk },
        { "sl", TextContentLanguage.Sl },
        { "sm", TextContentLanguage.Sm },
        { "sn", TextContentLanguage.Sn },
        { "so", TextContentLanguage.So },
        { "sq", TextContentLanguage.Sq },
        { "sr", TextContentLanguage.Sr },
        { "ss", TextContentLanguage.Ss },
        { "st", TextContentLanguage.St },
        { "su", TextContentLanguage.Su },
        { "sv", TextContentLanguage.Sv },
        { "sw", TextContentLanguage.Sw },
        { "ta", TextContentLanguage.Ta },
        { "te", TextContentLanguage.Te },
        { "tg", TextContentLanguage.Tg },
        { "th", TextContentLanguage.Th },
        { "ti", TextContentLanguage.Ti },
        { "tk", TextContentLanguage.Tk },
        { "tl", TextContentLanguage.Tl },
        { "tn", TextContentLanguage.Tn },
        { "to", TextContentLanguage.To },
        { "tr", TextContentLanguage.Tr },
        { "ts", TextContentLanguage.Ts },
        { "tt", TextContentLanguage.Tt },
        { "tw", TextContentLanguage.Tw },
        { "ty", TextContentLanguage.Ty },
        { "ug", TextContentLanguage.Ug },
        { "uk", TextContentLanguage.Uk },
        { "ur", TextContentLanguage.Ur },
        { "uz", TextContentLanguage.Uz },
        { "ve", TextContentLanguage.Ve },
        { "vi", TextContentLanguage.Vi },
        { "vo", TextContentLanguage.Vo },
        { "wa", TextContentLanguage.Wa },
        { "wo", TextContentLanguage.Wo },
        { "xh", TextContentLanguage.Xh },
        { "yi", TextContentLanguage.Yi },
        { "yue", TextContentLanguage.Yue },
        { "yo", TextContentLanguage.Yo },
        { "za", TextContentLanguage.Za },
        { "zh", TextContentLanguage.Zh },
        { "zu", TextContentLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TextContentLanguage,
        string
    > _enumToString = new()
    {
        { TextContentLanguage.Aa, "aa" },
        { TextContentLanguage.Ab, "ab" },
        { TextContentLanguage.Ae, "ae" },
        { TextContentLanguage.Af, "af" },
        { TextContentLanguage.Ak, "ak" },
        { TextContentLanguage.Am, "am" },
        { TextContentLanguage.An, "an" },
        { TextContentLanguage.Ar, "ar" },
        { TextContentLanguage.As, "as" },
        { TextContentLanguage.Av, "av" },
        { TextContentLanguage.Ay, "ay" },
        { TextContentLanguage.Az, "az" },
        { TextContentLanguage.Ba, "ba" },
        { TextContentLanguage.Be, "be" },
        { TextContentLanguage.Bg, "bg" },
        { TextContentLanguage.Bh, "bh" },
        { TextContentLanguage.Bi, "bi" },
        { TextContentLanguage.Bm, "bm" },
        { TextContentLanguage.Bn, "bn" },
        { TextContentLanguage.Bo, "bo" },
        { TextContentLanguage.Br, "br" },
        { TextContentLanguage.Bs, "bs" },
        { TextContentLanguage.Ca, "ca" },
        { TextContentLanguage.Ce, "ce" },
        { TextContentLanguage.Ch, "ch" },
        { TextContentLanguage.Co, "co" },
        { TextContentLanguage.Cr, "cr" },
        { TextContentLanguage.Cs, "cs" },
        { TextContentLanguage.Cu, "cu" },
        { TextContentLanguage.Cv, "cv" },
        { TextContentLanguage.Cy, "cy" },
        { TextContentLanguage.Da, "da" },
        { TextContentLanguage.De, "de" },
        { TextContentLanguage.Dv, "dv" },
        { TextContentLanguage.Dz, "dz" },
        { TextContentLanguage.Ee, "ee" },
        { TextContentLanguage.El, "el" },
        { TextContentLanguage.En, "en" },
        { TextContentLanguage.Eo, "eo" },
        { TextContentLanguage.Es, "es" },
        { TextContentLanguage.Et, "et" },
        { TextContentLanguage.Eu, "eu" },
        { TextContentLanguage.Fa, "fa" },
        { TextContentLanguage.Ff, "ff" },
        { TextContentLanguage.Fi, "fi" },
        { TextContentLanguage.Fj, "fj" },
        { TextContentLanguage.Fo, "fo" },
        { TextContentLanguage.Fr, "fr" },
        { TextContentLanguage.Fy, "fy" },
        { TextContentLanguage.Ga, "ga" },
        { TextContentLanguage.Gd, "gd" },
        { TextContentLanguage.Gl, "gl" },
        { TextContentLanguage.Gn, "gn" },
        { TextContentLanguage.Gu, "gu" },
        { TextContentLanguage.Gv, "gv" },
        { TextContentLanguage.Ha, "ha" },
        { TextContentLanguage.He, "he" },
        { TextContentLanguage.Hi, "hi" },
        { TextContentLanguage.Ho, "ho" },
        { TextContentLanguage.Hr, "hr" },
        { TextContentLanguage.Ht, "ht" },
        { TextContentLanguage.Hu, "hu" },
        { TextContentLanguage.Hy, "hy" },
        { TextContentLanguage.Hz, "hz" },
        { TextContentLanguage.Ia, "ia" },
        { TextContentLanguage.Id, "id" },
        { TextContentLanguage.Ie, "ie" },
        { TextContentLanguage.Ig, "ig" },
        { TextContentLanguage.Ii, "ii" },
        { TextContentLanguage.Ik, "ik" },
        { TextContentLanguage.Io, "io" },
        { TextContentLanguage.Is, "is" },
        { TextContentLanguage.It, "it" },
        { TextContentLanguage.Iu, "iu" },
        { TextContentLanguage.Ja, "ja" },
        { TextContentLanguage.Jv, "jv" },
        { TextContentLanguage.Ka, "ka" },
        { TextContentLanguage.Kg, "kg" },
        { TextContentLanguage.Ki, "ki" },
        { TextContentLanguage.Kj, "kj" },
        { TextContentLanguage.Kk, "kk" },
        { TextContentLanguage.Kl, "kl" },
        { TextContentLanguage.Km, "km" },
        { TextContentLanguage.Kn, "kn" },
        { TextContentLanguage.Ko, "ko" },
        { TextContentLanguage.Kr, "kr" },
        { TextContentLanguage.Ks, "ks" },
        { TextContentLanguage.Ku, "ku" },
        { TextContentLanguage.Kv, "kv" },
        { TextContentLanguage.Kw, "kw" },
        { TextContentLanguage.Ky, "ky" },
        { TextContentLanguage.La, "la" },
        { TextContentLanguage.Lb, "lb" },
        { TextContentLanguage.Lg, "lg" },
        { TextContentLanguage.Li, "li" },
        { TextContentLanguage.Ln, "ln" },
        { TextContentLanguage.Lo, "lo" },
        { TextContentLanguage.Lt, "lt" },
        { TextContentLanguage.Lu, "lu" },
        { TextContentLanguage.Lv, "lv" },
        { TextContentLanguage.Mg, "mg" },
        { TextContentLanguage.Mh, "mh" },
        { TextContentLanguage.Mi, "mi" },
        { TextContentLanguage.Mk, "mk" },
        { TextContentLanguage.Ml, "ml" },
        { TextContentLanguage.Mn, "mn" },
        { TextContentLanguage.Mr, "mr" },
        { TextContentLanguage.Ms, "ms" },
        { TextContentLanguage.Mt, "mt" },
        { TextContentLanguage.My, "my" },
        { TextContentLanguage.Na, "na" },
        { TextContentLanguage.Nb, "nb" },
        { TextContentLanguage.Nd, "nd" },
        { TextContentLanguage.Ne, "ne" },
        { TextContentLanguage.Ng, "ng" },
        { TextContentLanguage.Nl, "nl" },
        { TextContentLanguage.Nn, "nn" },
        { TextContentLanguage.No, "no" },
        { TextContentLanguage.Nr, "nr" },
        { TextContentLanguage.Nv, "nv" },
        { TextContentLanguage.Ny, "ny" },
        { TextContentLanguage.Oc, "oc" },
        { TextContentLanguage.Oj, "oj" },
        { TextContentLanguage.Om, "om" },
        { TextContentLanguage.Or, "or" },
        { TextContentLanguage.Os, "os" },
        { TextContentLanguage.Pa, "pa" },
        { TextContentLanguage.Pi, "pi" },
        { TextContentLanguage.Pl, "pl" },
        { TextContentLanguage.Ps, "ps" },
        { TextContentLanguage.Pt, "pt" },
        { TextContentLanguage.Qu, "qu" },
        { TextContentLanguage.Rm, "rm" },
        { TextContentLanguage.Rn, "rn" },
        { TextContentLanguage.Ro, "ro" },
        { TextContentLanguage.Ru, "ru" },
        { TextContentLanguage.Rw, "rw" },
        { TextContentLanguage.Sa, "sa" },
        { TextContentLanguage.Sc, "sc" },
        { TextContentLanguage.Sd, "sd" },
        { TextContentLanguage.Se, "se" },
        { TextContentLanguage.Sg, "sg" },
        { TextContentLanguage.Si, "si" },
        { TextContentLanguage.Sk, "sk" },
        { TextContentLanguage.Sl, "sl" },
        { TextContentLanguage.Sm, "sm" },
        { TextContentLanguage.Sn, "sn" },
        { TextContentLanguage.So, "so" },
        { TextContentLanguage.Sq, "sq" },
        { TextContentLanguage.Sr, "sr" },
        { TextContentLanguage.Ss, "ss" },
        { TextContentLanguage.St, "st" },
        { TextContentLanguage.Su, "su" },
        { TextContentLanguage.Sv, "sv" },
        { TextContentLanguage.Sw, "sw" },
        { TextContentLanguage.Ta, "ta" },
        { TextContentLanguage.Te, "te" },
        { TextContentLanguage.Tg, "tg" },
        { TextContentLanguage.Th, "th" },
        { TextContentLanguage.Ti, "ti" },
        { TextContentLanguage.Tk, "tk" },
        { TextContentLanguage.Tl, "tl" },
        { TextContentLanguage.Tn, "tn" },
        { TextContentLanguage.To, "to" },
        { TextContentLanguage.Tr, "tr" },
        { TextContentLanguage.Ts, "ts" },
        { TextContentLanguage.Tt, "tt" },
        { TextContentLanguage.Tw, "tw" },
        { TextContentLanguage.Ty, "ty" },
        { TextContentLanguage.Ug, "ug" },
        { TextContentLanguage.Uk, "uk" },
        { TextContentLanguage.Ur, "ur" },
        { TextContentLanguage.Uz, "uz" },
        { TextContentLanguage.Ve, "ve" },
        { TextContentLanguage.Vi, "vi" },
        { TextContentLanguage.Vo, "vo" },
        { TextContentLanguage.Wa, "wa" },
        { TextContentLanguage.Wo, "wo" },
        { TextContentLanguage.Xh, "xh" },
        { TextContentLanguage.Yi, "yi" },
        { TextContentLanguage.Yue, "yue" },
        { TextContentLanguage.Yo, "yo" },
        { TextContentLanguage.Za, "za" },
        { TextContentLanguage.Zh, "zh" },
        { TextContentLanguage.Zu, "zu" },
    };

    public override TextContentLanguage Read(
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
        TextContentLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TextContentLanguage ReadAsPropertyName(
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
        TextContentLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
