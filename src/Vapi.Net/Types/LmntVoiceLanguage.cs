using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LmntVoiceLanguageSerializer))]
public enum LmntVoiceLanguage
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

    [EnumMember(Value = "auto")]
    Auto,
}

internal class LmntVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LmntVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LmntVoiceLanguage
    > _stringToEnum = new()
    {
        { "aa", LmntVoiceLanguage.Aa },
        { "ab", LmntVoiceLanguage.Ab },
        { "ae", LmntVoiceLanguage.Ae },
        { "af", LmntVoiceLanguage.Af },
        { "ak", LmntVoiceLanguage.Ak },
        { "am", LmntVoiceLanguage.Am },
        { "an", LmntVoiceLanguage.An },
        { "ar", LmntVoiceLanguage.Ar },
        { "as", LmntVoiceLanguage.As },
        { "av", LmntVoiceLanguage.Av },
        { "ay", LmntVoiceLanguage.Ay },
        { "az", LmntVoiceLanguage.Az },
        { "ba", LmntVoiceLanguage.Ba },
        { "be", LmntVoiceLanguage.Be },
        { "bg", LmntVoiceLanguage.Bg },
        { "bh", LmntVoiceLanguage.Bh },
        { "bi", LmntVoiceLanguage.Bi },
        { "bm", LmntVoiceLanguage.Bm },
        { "bn", LmntVoiceLanguage.Bn },
        { "bo", LmntVoiceLanguage.Bo },
        { "br", LmntVoiceLanguage.Br },
        { "bs", LmntVoiceLanguage.Bs },
        { "ca", LmntVoiceLanguage.Ca },
        { "ce", LmntVoiceLanguage.Ce },
        { "ch", LmntVoiceLanguage.Ch },
        { "co", LmntVoiceLanguage.Co },
        { "cr", LmntVoiceLanguage.Cr },
        { "cs", LmntVoiceLanguage.Cs },
        { "cu", LmntVoiceLanguage.Cu },
        { "cv", LmntVoiceLanguage.Cv },
        { "cy", LmntVoiceLanguage.Cy },
        { "da", LmntVoiceLanguage.Da },
        { "de", LmntVoiceLanguage.De },
        { "dv", LmntVoiceLanguage.Dv },
        { "dz", LmntVoiceLanguage.Dz },
        { "ee", LmntVoiceLanguage.Ee },
        { "el", LmntVoiceLanguage.El },
        { "en", LmntVoiceLanguage.En },
        { "eo", LmntVoiceLanguage.Eo },
        { "es", LmntVoiceLanguage.Es },
        { "et", LmntVoiceLanguage.Et },
        { "eu", LmntVoiceLanguage.Eu },
        { "fa", LmntVoiceLanguage.Fa },
        { "ff", LmntVoiceLanguage.Ff },
        { "fi", LmntVoiceLanguage.Fi },
        { "fj", LmntVoiceLanguage.Fj },
        { "fo", LmntVoiceLanguage.Fo },
        { "fr", LmntVoiceLanguage.Fr },
        { "fy", LmntVoiceLanguage.Fy },
        { "ga", LmntVoiceLanguage.Ga },
        { "gd", LmntVoiceLanguage.Gd },
        { "gl", LmntVoiceLanguage.Gl },
        { "gn", LmntVoiceLanguage.Gn },
        { "gu", LmntVoiceLanguage.Gu },
        { "gv", LmntVoiceLanguage.Gv },
        { "ha", LmntVoiceLanguage.Ha },
        { "he", LmntVoiceLanguage.He },
        { "hi", LmntVoiceLanguage.Hi },
        { "ho", LmntVoiceLanguage.Ho },
        { "hr", LmntVoiceLanguage.Hr },
        { "ht", LmntVoiceLanguage.Ht },
        { "hu", LmntVoiceLanguage.Hu },
        { "hy", LmntVoiceLanguage.Hy },
        { "hz", LmntVoiceLanguage.Hz },
        { "ia", LmntVoiceLanguage.Ia },
        { "id", LmntVoiceLanguage.Id },
        { "ie", LmntVoiceLanguage.Ie },
        { "ig", LmntVoiceLanguage.Ig },
        { "ii", LmntVoiceLanguage.Ii },
        { "ik", LmntVoiceLanguage.Ik },
        { "io", LmntVoiceLanguage.Io },
        { "is", LmntVoiceLanguage.Is },
        { "it", LmntVoiceLanguage.It },
        { "iu", LmntVoiceLanguage.Iu },
        { "ja", LmntVoiceLanguage.Ja },
        { "jv", LmntVoiceLanguage.Jv },
        { "ka", LmntVoiceLanguage.Ka },
        { "kg", LmntVoiceLanguage.Kg },
        { "ki", LmntVoiceLanguage.Ki },
        { "kj", LmntVoiceLanguage.Kj },
        { "kk", LmntVoiceLanguage.Kk },
        { "kl", LmntVoiceLanguage.Kl },
        { "km", LmntVoiceLanguage.Km },
        { "kn", LmntVoiceLanguage.Kn },
        { "ko", LmntVoiceLanguage.Ko },
        { "kr", LmntVoiceLanguage.Kr },
        { "ks", LmntVoiceLanguage.Ks },
        { "ku", LmntVoiceLanguage.Ku },
        { "kv", LmntVoiceLanguage.Kv },
        { "kw", LmntVoiceLanguage.Kw },
        { "ky", LmntVoiceLanguage.Ky },
        { "la", LmntVoiceLanguage.La },
        { "lb", LmntVoiceLanguage.Lb },
        { "lg", LmntVoiceLanguage.Lg },
        { "li", LmntVoiceLanguage.Li },
        { "ln", LmntVoiceLanguage.Ln },
        { "lo", LmntVoiceLanguage.Lo },
        { "lt", LmntVoiceLanguage.Lt },
        { "lu", LmntVoiceLanguage.Lu },
        { "lv", LmntVoiceLanguage.Lv },
        { "mg", LmntVoiceLanguage.Mg },
        { "mh", LmntVoiceLanguage.Mh },
        { "mi", LmntVoiceLanguage.Mi },
        { "mk", LmntVoiceLanguage.Mk },
        { "ml", LmntVoiceLanguage.Ml },
        { "mn", LmntVoiceLanguage.Mn },
        { "mr", LmntVoiceLanguage.Mr },
        { "ms", LmntVoiceLanguage.Ms },
        { "mt", LmntVoiceLanguage.Mt },
        { "my", LmntVoiceLanguage.My },
        { "na", LmntVoiceLanguage.Na },
        { "nb", LmntVoiceLanguage.Nb },
        { "nd", LmntVoiceLanguage.Nd },
        { "ne", LmntVoiceLanguage.Ne },
        { "ng", LmntVoiceLanguage.Ng },
        { "nl", LmntVoiceLanguage.Nl },
        { "nn", LmntVoiceLanguage.Nn },
        { "no", LmntVoiceLanguage.No },
        { "nr", LmntVoiceLanguage.Nr },
        { "nv", LmntVoiceLanguage.Nv },
        { "ny", LmntVoiceLanguage.Ny },
        { "oc", LmntVoiceLanguage.Oc },
        { "oj", LmntVoiceLanguage.Oj },
        { "om", LmntVoiceLanguage.Om },
        { "or", LmntVoiceLanguage.Or },
        { "os", LmntVoiceLanguage.Os },
        { "pa", LmntVoiceLanguage.Pa },
        { "pi", LmntVoiceLanguage.Pi },
        { "pl", LmntVoiceLanguage.Pl },
        { "ps", LmntVoiceLanguage.Ps },
        { "pt", LmntVoiceLanguage.Pt },
        { "qu", LmntVoiceLanguage.Qu },
        { "rm", LmntVoiceLanguage.Rm },
        { "rn", LmntVoiceLanguage.Rn },
        { "ro", LmntVoiceLanguage.Ro },
        { "ru", LmntVoiceLanguage.Ru },
        { "rw", LmntVoiceLanguage.Rw },
        { "sa", LmntVoiceLanguage.Sa },
        { "sc", LmntVoiceLanguage.Sc },
        { "sd", LmntVoiceLanguage.Sd },
        { "se", LmntVoiceLanguage.Se },
        { "sg", LmntVoiceLanguage.Sg },
        { "si", LmntVoiceLanguage.Si },
        { "sk", LmntVoiceLanguage.Sk },
        { "sl", LmntVoiceLanguage.Sl },
        { "sm", LmntVoiceLanguage.Sm },
        { "sn", LmntVoiceLanguage.Sn },
        { "so", LmntVoiceLanguage.So },
        { "sq", LmntVoiceLanguage.Sq },
        { "sr", LmntVoiceLanguage.Sr },
        { "ss", LmntVoiceLanguage.Ss },
        { "st", LmntVoiceLanguage.St },
        { "su", LmntVoiceLanguage.Su },
        { "sv", LmntVoiceLanguage.Sv },
        { "sw", LmntVoiceLanguage.Sw },
        { "ta", LmntVoiceLanguage.Ta },
        { "te", LmntVoiceLanguage.Te },
        { "tg", LmntVoiceLanguage.Tg },
        { "th", LmntVoiceLanguage.Th },
        { "ti", LmntVoiceLanguage.Ti },
        { "tk", LmntVoiceLanguage.Tk },
        { "tl", LmntVoiceLanguage.Tl },
        { "tn", LmntVoiceLanguage.Tn },
        { "to", LmntVoiceLanguage.To },
        { "tr", LmntVoiceLanguage.Tr },
        { "ts", LmntVoiceLanguage.Ts },
        { "tt", LmntVoiceLanguage.Tt },
        { "tw", LmntVoiceLanguage.Tw },
        { "ty", LmntVoiceLanguage.Ty },
        { "ug", LmntVoiceLanguage.Ug },
        { "uk", LmntVoiceLanguage.Uk },
        { "ur", LmntVoiceLanguage.Ur },
        { "uz", LmntVoiceLanguage.Uz },
        { "ve", LmntVoiceLanguage.Ve },
        { "vi", LmntVoiceLanguage.Vi },
        { "vo", LmntVoiceLanguage.Vo },
        { "wa", LmntVoiceLanguage.Wa },
        { "wo", LmntVoiceLanguage.Wo },
        { "xh", LmntVoiceLanguage.Xh },
        { "yi", LmntVoiceLanguage.Yi },
        { "yue", LmntVoiceLanguage.Yue },
        { "yo", LmntVoiceLanguage.Yo },
        { "za", LmntVoiceLanguage.Za },
        { "zh", LmntVoiceLanguage.Zh },
        { "zu", LmntVoiceLanguage.Zu },
        { "auto", LmntVoiceLanguage.Auto },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LmntVoiceLanguage,
        string
    > _enumToString = new()
    {
        { LmntVoiceLanguage.Aa, "aa" },
        { LmntVoiceLanguage.Ab, "ab" },
        { LmntVoiceLanguage.Ae, "ae" },
        { LmntVoiceLanguage.Af, "af" },
        { LmntVoiceLanguage.Ak, "ak" },
        { LmntVoiceLanguage.Am, "am" },
        { LmntVoiceLanguage.An, "an" },
        { LmntVoiceLanguage.Ar, "ar" },
        { LmntVoiceLanguage.As, "as" },
        { LmntVoiceLanguage.Av, "av" },
        { LmntVoiceLanguage.Ay, "ay" },
        { LmntVoiceLanguage.Az, "az" },
        { LmntVoiceLanguage.Ba, "ba" },
        { LmntVoiceLanguage.Be, "be" },
        { LmntVoiceLanguage.Bg, "bg" },
        { LmntVoiceLanguage.Bh, "bh" },
        { LmntVoiceLanguage.Bi, "bi" },
        { LmntVoiceLanguage.Bm, "bm" },
        { LmntVoiceLanguage.Bn, "bn" },
        { LmntVoiceLanguage.Bo, "bo" },
        { LmntVoiceLanguage.Br, "br" },
        { LmntVoiceLanguage.Bs, "bs" },
        { LmntVoiceLanguage.Ca, "ca" },
        { LmntVoiceLanguage.Ce, "ce" },
        { LmntVoiceLanguage.Ch, "ch" },
        { LmntVoiceLanguage.Co, "co" },
        { LmntVoiceLanguage.Cr, "cr" },
        { LmntVoiceLanguage.Cs, "cs" },
        { LmntVoiceLanguage.Cu, "cu" },
        { LmntVoiceLanguage.Cv, "cv" },
        { LmntVoiceLanguage.Cy, "cy" },
        { LmntVoiceLanguage.Da, "da" },
        { LmntVoiceLanguage.De, "de" },
        { LmntVoiceLanguage.Dv, "dv" },
        { LmntVoiceLanguage.Dz, "dz" },
        { LmntVoiceLanguage.Ee, "ee" },
        { LmntVoiceLanguage.El, "el" },
        { LmntVoiceLanguage.En, "en" },
        { LmntVoiceLanguage.Eo, "eo" },
        { LmntVoiceLanguage.Es, "es" },
        { LmntVoiceLanguage.Et, "et" },
        { LmntVoiceLanguage.Eu, "eu" },
        { LmntVoiceLanguage.Fa, "fa" },
        { LmntVoiceLanguage.Ff, "ff" },
        { LmntVoiceLanguage.Fi, "fi" },
        { LmntVoiceLanguage.Fj, "fj" },
        { LmntVoiceLanguage.Fo, "fo" },
        { LmntVoiceLanguage.Fr, "fr" },
        { LmntVoiceLanguage.Fy, "fy" },
        { LmntVoiceLanguage.Ga, "ga" },
        { LmntVoiceLanguage.Gd, "gd" },
        { LmntVoiceLanguage.Gl, "gl" },
        { LmntVoiceLanguage.Gn, "gn" },
        { LmntVoiceLanguage.Gu, "gu" },
        { LmntVoiceLanguage.Gv, "gv" },
        { LmntVoiceLanguage.Ha, "ha" },
        { LmntVoiceLanguage.He, "he" },
        { LmntVoiceLanguage.Hi, "hi" },
        { LmntVoiceLanguage.Ho, "ho" },
        { LmntVoiceLanguage.Hr, "hr" },
        { LmntVoiceLanguage.Ht, "ht" },
        { LmntVoiceLanguage.Hu, "hu" },
        { LmntVoiceLanguage.Hy, "hy" },
        { LmntVoiceLanguage.Hz, "hz" },
        { LmntVoiceLanguage.Ia, "ia" },
        { LmntVoiceLanguage.Id, "id" },
        { LmntVoiceLanguage.Ie, "ie" },
        { LmntVoiceLanguage.Ig, "ig" },
        { LmntVoiceLanguage.Ii, "ii" },
        { LmntVoiceLanguage.Ik, "ik" },
        { LmntVoiceLanguage.Io, "io" },
        { LmntVoiceLanguage.Is, "is" },
        { LmntVoiceLanguage.It, "it" },
        { LmntVoiceLanguage.Iu, "iu" },
        { LmntVoiceLanguage.Ja, "ja" },
        { LmntVoiceLanguage.Jv, "jv" },
        { LmntVoiceLanguage.Ka, "ka" },
        { LmntVoiceLanguage.Kg, "kg" },
        { LmntVoiceLanguage.Ki, "ki" },
        { LmntVoiceLanguage.Kj, "kj" },
        { LmntVoiceLanguage.Kk, "kk" },
        { LmntVoiceLanguage.Kl, "kl" },
        { LmntVoiceLanguage.Km, "km" },
        { LmntVoiceLanguage.Kn, "kn" },
        { LmntVoiceLanguage.Ko, "ko" },
        { LmntVoiceLanguage.Kr, "kr" },
        { LmntVoiceLanguage.Ks, "ks" },
        { LmntVoiceLanguage.Ku, "ku" },
        { LmntVoiceLanguage.Kv, "kv" },
        { LmntVoiceLanguage.Kw, "kw" },
        { LmntVoiceLanguage.Ky, "ky" },
        { LmntVoiceLanguage.La, "la" },
        { LmntVoiceLanguage.Lb, "lb" },
        { LmntVoiceLanguage.Lg, "lg" },
        { LmntVoiceLanguage.Li, "li" },
        { LmntVoiceLanguage.Ln, "ln" },
        { LmntVoiceLanguage.Lo, "lo" },
        { LmntVoiceLanguage.Lt, "lt" },
        { LmntVoiceLanguage.Lu, "lu" },
        { LmntVoiceLanguage.Lv, "lv" },
        { LmntVoiceLanguage.Mg, "mg" },
        { LmntVoiceLanguage.Mh, "mh" },
        { LmntVoiceLanguage.Mi, "mi" },
        { LmntVoiceLanguage.Mk, "mk" },
        { LmntVoiceLanguage.Ml, "ml" },
        { LmntVoiceLanguage.Mn, "mn" },
        { LmntVoiceLanguage.Mr, "mr" },
        { LmntVoiceLanguage.Ms, "ms" },
        { LmntVoiceLanguage.Mt, "mt" },
        { LmntVoiceLanguage.My, "my" },
        { LmntVoiceLanguage.Na, "na" },
        { LmntVoiceLanguage.Nb, "nb" },
        { LmntVoiceLanguage.Nd, "nd" },
        { LmntVoiceLanguage.Ne, "ne" },
        { LmntVoiceLanguage.Ng, "ng" },
        { LmntVoiceLanguage.Nl, "nl" },
        { LmntVoiceLanguage.Nn, "nn" },
        { LmntVoiceLanguage.No, "no" },
        { LmntVoiceLanguage.Nr, "nr" },
        { LmntVoiceLanguage.Nv, "nv" },
        { LmntVoiceLanguage.Ny, "ny" },
        { LmntVoiceLanguage.Oc, "oc" },
        { LmntVoiceLanguage.Oj, "oj" },
        { LmntVoiceLanguage.Om, "om" },
        { LmntVoiceLanguage.Or, "or" },
        { LmntVoiceLanguage.Os, "os" },
        { LmntVoiceLanguage.Pa, "pa" },
        { LmntVoiceLanguage.Pi, "pi" },
        { LmntVoiceLanguage.Pl, "pl" },
        { LmntVoiceLanguage.Ps, "ps" },
        { LmntVoiceLanguage.Pt, "pt" },
        { LmntVoiceLanguage.Qu, "qu" },
        { LmntVoiceLanguage.Rm, "rm" },
        { LmntVoiceLanguage.Rn, "rn" },
        { LmntVoiceLanguage.Ro, "ro" },
        { LmntVoiceLanguage.Ru, "ru" },
        { LmntVoiceLanguage.Rw, "rw" },
        { LmntVoiceLanguage.Sa, "sa" },
        { LmntVoiceLanguage.Sc, "sc" },
        { LmntVoiceLanguage.Sd, "sd" },
        { LmntVoiceLanguage.Se, "se" },
        { LmntVoiceLanguage.Sg, "sg" },
        { LmntVoiceLanguage.Si, "si" },
        { LmntVoiceLanguage.Sk, "sk" },
        { LmntVoiceLanguage.Sl, "sl" },
        { LmntVoiceLanguage.Sm, "sm" },
        { LmntVoiceLanguage.Sn, "sn" },
        { LmntVoiceLanguage.So, "so" },
        { LmntVoiceLanguage.Sq, "sq" },
        { LmntVoiceLanguage.Sr, "sr" },
        { LmntVoiceLanguage.Ss, "ss" },
        { LmntVoiceLanguage.St, "st" },
        { LmntVoiceLanguage.Su, "su" },
        { LmntVoiceLanguage.Sv, "sv" },
        { LmntVoiceLanguage.Sw, "sw" },
        { LmntVoiceLanguage.Ta, "ta" },
        { LmntVoiceLanguage.Te, "te" },
        { LmntVoiceLanguage.Tg, "tg" },
        { LmntVoiceLanguage.Th, "th" },
        { LmntVoiceLanguage.Ti, "ti" },
        { LmntVoiceLanguage.Tk, "tk" },
        { LmntVoiceLanguage.Tl, "tl" },
        { LmntVoiceLanguage.Tn, "tn" },
        { LmntVoiceLanguage.To, "to" },
        { LmntVoiceLanguage.Tr, "tr" },
        { LmntVoiceLanguage.Ts, "ts" },
        { LmntVoiceLanguage.Tt, "tt" },
        { LmntVoiceLanguage.Tw, "tw" },
        { LmntVoiceLanguage.Ty, "ty" },
        { LmntVoiceLanguage.Ug, "ug" },
        { LmntVoiceLanguage.Uk, "uk" },
        { LmntVoiceLanguage.Ur, "ur" },
        { LmntVoiceLanguage.Uz, "uz" },
        { LmntVoiceLanguage.Ve, "ve" },
        { LmntVoiceLanguage.Vi, "vi" },
        { LmntVoiceLanguage.Vo, "vo" },
        { LmntVoiceLanguage.Wa, "wa" },
        { LmntVoiceLanguage.Wo, "wo" },
        { LmntVoiceLanguage.Xh, "xh" },
        { LmntVoiceLanguage.Yi, "yi" },
        { LmntVoiceLanguage.Yue, "yue" },
        { LmntVoiceLanguage.Yo, "yo" },
        { LmntVoiceLanguage.Za, "za" },
        { LmntVoiceLanguage.Zh, "zh" },
        { LmntVoiceLanguage.Zu, "zu" },
        { LmntVoiceLanguage.Auto, "auto" },
    };

    public override LmntVoiceLanguage Read(
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
        LmntVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LmntVoiceLanguage ReadAsPropertyName(
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
        LmntVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
