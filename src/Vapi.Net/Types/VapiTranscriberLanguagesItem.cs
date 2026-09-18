using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiTranscriberLanguagesItemSerializer))]
public enum VapiTranscriberLanguagesItem
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

internal class VapiTranscriberLanguagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiTranscriberLanguagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiTranscriberLanguagesItem
    > _stringToEnum = new()
    {
        { "aa", VapiTranscriberLanguagesItem.Aa },
        { "ab", VapiTranscriberLanguagesItem.Ab },
        { "ae", VapiTranscriberLanguagesItem.Ae },
        { "af", VapiTranscriberLanguagesItem.Af },
        { "ak", VapiTranscriberLanguagesItem.Ak },
        { "am", VapiTranscriberLanguagesItem.Am },
        { "an", VapiTranscriberLanguagesItem.An },
        { "ar", VapiTranscriberLanguagesItem.Ar },
        { "as", VapiTranscriberLanguagesItem.As },
        { "av", VapiTranscriberLanguagesItem.Av },
        { "ay", VapiTranscriberLanguagesItem.Ay },
        { "az", VapiTranscriberLanguagesItem.Az },
        { "ba", VapiTranscriberLanguagesItem.Ba },
        { "be", VapiTranscriberLanguagesItem.Be },
        { "bg", VapiTranscriberLanguagesItem.Bg },
        { "bh", VapiTranscriberLanguagesItem.Bh },
        { "bi", VapiTranscriberLanguagesItem.Bi },
        { "bm", VapiTranscriberLanguagesItem.Bm },
        { "bn", VapiTranscriberLanguagesItem.Bn },
        { "bo", VapiTranscriberLanguagesItem.Bo },
        { "br", VapiTranscriberLanguagesItem.Br },
        { "bs", VapiTranscriberLanguagesItem.Bs },
        { "ca", VapiTranscriberLanguagesItem.Ca },
        { "ce", VapiTranscriberLanguagesItem.Ce },
        { "ch", VapiTranscriberLanguagesItem.Ch },
        { "co", VapiTranscriberLanguagesItem.Co },
        { "cr", VapiTranscriberLanguagesItem.Cr },
        { "cs", VapiTranscriberLanguagesItem.Cs },
        { "cu", VapiTranscriberLanguagesItem.Cu },
        { "cv", VapiTranscriberLanguagesItem.Cv },
        { "cy", VapiTranscriberLanguagesItem.Cy },
        { "da", VapiTranscriberLanguagesItem.Da },
        { "de", VapiTranscriberLanguagesItem.De },
        { "dv", VapiTranscriberLanguagesItem.Dv },
        { "dz", VapiTranscriberLanguagesItem.Dz },
        { "ee", VapiTranscriberLanguagesItem.Ee },
        { "el", VapiTranscriberLanguagesItem.El },
        { "en", VapiTranscriberLanguagesItem.En },
        { "eo", VapiTranscriberLanguagesItem.Eo },
        { "es", VapiTranscriberLanguagesItem.Es },
        { "et", VapiTranscriberLanguagesItem.Et },
        { "eu", VapiTranscriberLanguagesItem.Eu },
        { "fa", VapiTranscriberLanguagesItem.Fa },
        { "ff", VapiTranscriberLanguagesItem.Ff },
        { "fi", VapiTranscriberLanguagesItem.Fi },
        { "fj", VapiTranscriberLanguagesItem.Fj },
        { "fo", VapiTranscriberLanguagesItem.Fo },
        { "fr", VapiTranscriberLanguagesItem.Fr },
        { "fy", VapiTranscriberLanguagesItem.Fy },
        { "ga", VapiTranscriberLanguagesItem.Ga },
        { "gd", VapiTranscriberLanguagesItem.Gd },
        { "gl", VapiTranscriberLanguagesItem.Gl },
        { "gn", VapiTranscriberLanguagesItem.Gn },
        { "gu", VapiTranscriberLanguagesItem.Gu },
        { "gv", VapiTranscriberLanguagesItem.Gv },
        { "ha", VapiTranscriberLanguagesItem.Ha },
        { "he", VapiTranscriberLanguagesItem.He },
        { "hi", VapiTranscriberLanguagesItem.Hi },
        { "ho", VapiTranscriberLanguagesItem.Ho },
        { "hr", VapiTranscriberLanguagesItem.Hr },
        { "ht", VapiTranscriberLanguagesItem.Ht },
        { "hu", VapiTranscriberLanguagesItem.Hu },
        { "hy", VapiTranscriberLanguagesItem.Hy },
        { "hz", VapiTranscriberLanguagesItem.Hz },
        { "ia", VapiTranscriberLanguagesItem.Ia },
        { "id", VapiTranscriberLanguagesItem.Id },
        { "ie", VapiTranscriberLanguagesItem.Ie },
        { "ig", VapiTranscriberLanguagesItem.Ig },
        { "ii", VapiTranscriberLanguagesItem.Ii },
        { "ik", VapiTranscriberLanguagesItem.Ik },
        { "io", VapiTranscriberLanguagesItem.Io },
        { "is", VapiTranscriberLanguagesItem.Is },
        { "it", VapiTranscriberLanguagesItem.It },
        { "iu", VapiTranscriberLanguagesItem.Iu },
        { "ja", VapiTranscriberLanguagesItem.Ja },
        { "jv", VapiTranscriberLanguagesItem.Jv },
        { "ka", VapiTranscriberLanguagesItem.Ka },
        { "kg", VapiTranscriberLanguagesItem.Kg },
        { "ki", VapiTranscriberLanguagesItem.Ki },
        { "kj", VapiTranscriberLanguagesItem.Kj },
        { "kk", VapiTranscriberLanguagesItem.Kk },
        { "kl", VapiTranscriberLanguagesItem.Kl },
        { "km", VapiTranscriberLanguagesItem.Km },
        { "kn", VapiTranscriberLanguagesItem.Kn },
        { "ko", VapiTranscriberLanguagesItem.Ko },
        { "kr", VapiTranscriberLanguagesItem.Kr },
        { "ks", VapiTranscriberLanguagesItem.Ks },
        { "ku", VapiTranscriberLanguagesItem.Ku },
        { "kv", VapiTranscriberLanguagesItem.Kv },
        { "kw", VapiTranscriberLanguagesItem.Kw },
        { "ky", VapiTranscriberLanguagesItem.Ky },
        { "la", VapiTranscriberLanguagesItem.La },
        { "lb", VapiTranscriberLanguagesItem.Lb },
        { "lg", VapiTranscriberLanguagesItem.Lg },
        { "li", VapiTranscriberLanguagesItem.Li },
        { "ln", VapiTranscriberLanguagesItem.Ln },
        { "lo", VapiTranscriberLanguagesItem.Lo },
        { "lt", VapiTranscriberLanguagesItem.Lt },
        { "lu", VapiTranscriberLanguagesItem.Lu },
        { "lv", VapiTranscriberLanguagesItem.Lv },
        { "mg", VapiTranscriberLanguagesItem.Mg },
        { "mh", VapiTranscriberLanguagesItem.Mh },
        { "mi", VapiTranscriberLanguagesItem.Mi },
        { "mk", VapiTranscriberLanguagesItem.Mk },
        { "ml", VapiTranscriberLanguagesItem.Ml },
        { "mn", VapiTranscriberLanguagesItem.Mn },
        { "mr", VapiTranscriberLanguagesItem.Mr },
        { "ms", VapiTranscriberLanguagesItem.Ms },
        { "mt", VapiTranscriberLanguagesItem.Mt },
        { "my", VapiTranscriberLanguagesItem.My },
        { "na", VapiTranscriberLanguagesItem.Na },
        { "nb", VapiTranscriberLanguagesItem.Nb },
        { "nd", VapiTranscriberLanguagesItem.Nd },
        { "ne", VapiTranscriberLanguagesItem.Ne },
        { "ng", VapiTranscriberLanguagesItem.Ng },
        { "nl", VapiTranscriberLanguagesItem.Nl },
        { "nn", VapiTranscriberLanguagesItem.Nn },
        { "no", VapiTranscriberLanguagesItem.No },
        { "nr", VapiTranscriberLanguagesItem.Nr },
        { "nv", VapiTranscriberLanguagesItem.Nv },
        { "ny", VapiTranscriberLanguagesItem.Ny },
        { "oc", VapiTranscriberLanguagesItem.Oc },
        { "oj", VapiTranscriberLanguagesItem.Oj },
        { "om", VapiTranscriberLanguagesItem.Om },
        { "or", VapiTranscriberLanguagesItem.Or },
        { "os", VapiTranscriberLanguagesItem.Os },
        { "pa", VapiTranscriberLanguagesItem.Pa },
        { "pi", VapiTranscriberLanguagesItem.Pi },
        { "pl", VapiTranscriberLanguagesItem.Pl },
        { "ps", VapiTranscriberLanguagesItem.Ps },
        { "pt", VapiTranscriberLanguagesItem.Pt },
        { "qu", VapiTranscriberLanguagesItem.Qu },
        { "rm", VapiTranscriberLanguagesItem.Rm },
        { "rn", VapiTranscriberLanguagesItem.Rn },
        { "ro", VapiTranscriberLanguagesItem.Ro },
        { "ru", VapiTranscriberLanguagesItem.Ru },
        { "rw", VapiTranscriberLanguagesItem.Rw },
        { "sa", VapiTranscriberLanguagesItem.Sa },
        { "sc", VapiTranscriberLanguagesItem.Sc },
        { "sd", VapiTranscriberLanguagesItem.Sd },
        { "se", VapiTranscriberLanguagesItem.Se },
        { "sg", VapiTranscriberLanguagesItem.Sg },
        { "si", VapiTranscriberLanguagesItem.Si },
        { "sk", VapiTranscriberLanguagesItem.Sk },
        { "sl", VapiTranscriberLanguagesItem.Sl },
        { "sm", VapiTranscriberLanguagesItem.Sm },
        { "sn", VapiTranscriberLanguagesItem.Sn },
        { "so", VapiTranscriberLanguagesItem.So },
        { "sq", VapiTranscriberLanguagesItem.Sq },
        { "sr", VapiTranscriberLanguagesItem.Sr },
        { "ss", VapiTranscriberLanguagesItem.Ss },
        { "st", VapiTranscriberLanguagesItem.St },
        { "su", VapiTranscriberLanguagesItem.Su },
        { "sv", VapiTranscriberLanguagesItem.Sv },
        { "sw", VapiTranscriberLanguagesItem.Sw },
        { "ta", VapiTranscriberLanguagesItem.Ta },
        { "te", VapiTranscriberLanguagesItem.Te },
        { "tg", VapiTranscriberLanguagesItem.Tg },
        { "th", VapiTranscriberLanguagesItem.Th },
        { "ti", VapiTranscriberLanguagesItem.Ti },
        { "tk", VapiTranscriberLanguagesItem.Tk },
        { "tl", VapiTranscriberLanguagesItem.Tl },
        { "tn", VapiTranscriberLanguagesItem.Tn },
        { "to", VapiTranscriberLanguagesItem.To },
        { "tr", VapiTranscriberLanguagesItem.Tr },
        { "ts", VapiTranscriberLanguagesItem.Ts },
        { "tt", VapiTranscriberLanguagesItem.Tt },
        { "tw", VapiTranscriberLanguagesItem.Tw },
        { "ty", VapiTranscriberLanguagesItem.Ty },
        { "ug", VapiTranscriberLanguagesItem.Ug },
        { "uk", VapiTranscriberLanguagesItem.Uk },
        { "ur", VapiTranscriberLanguagesItem.Ur },
        { "uz", VapiTranscriberLanguagesItem.Uz },
        { "ve", VapiTranscriberLanguagesItem.Ve },
        { "vi", VapiTranscriberLanguagesItem.Vi },
        { "vo", VapiTranscriberLanguagesItem.Vo },
        { "wa", VapiTranscriberLanguagesItem.Wa },
        { "wo", VapiTranscriberLanguagesItem.Wo },
        { "xh", VapiTranscriberLanguagesItem.Xh },
        { "yi", VapiTranscriberLanguagesItem.Yi },
        { "yue", VapiTranscriberLanguagesItem.Yue },
        { "yo", VapiTranscriberLanguagesItem.Yo },
        { "za", VapiTranscriberLanguagesItem.Za },
        { "zh", VapiTranscriberLanguagesItem.Zh },
        { "zu", VapiTranscriberLanguagesItem.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiTranscriberLanguagesItem,
        string
    > _enumToString = new()
    {
        { VapiTranscriberLanguagesItem.Aa, "aa" },
        { VapiTranscriberLanguagesItem.Ab, "ab" },
        { VapiTranscriberLanguagesItem.Ae, "ae" },
        { VapiTranscriberLanguagesItem.Af, "af" },
        { VapiTranscriberLanguagesItem.Ak, "ak" },
        { VapiTranscriberLanguagesItem.Am, "am" },
        { VapiTranscriberLanguagesItem.An, "an" },
        { VapiTranscriberLanguagesItem.Ar, "ar" },
        { VapiTranscriberLanguagesItem.As, "as" },
        { VapiTranscriberLanguagesItem.Av, "av" },
        { VapiTranscriberLanguagesItem.Ay, "ay" },
        { VapiTranscriberLanguagesItem.Az, "az" },
        { VapiTranscriberLanguagesItem.Ba, "ba" },
        { VapiTranscriberLanguagesItem.Be, "be" },
        { VapiTranscriberLanguagesItem.Bg, "bg" },
        { VapiTranscriberLanguagesItem.Bh, "bh" },
        { VapiTranscriberLanguagesItem.Bi, "bi" },
        { VapiTranscriberLanguagesItem.Bm, "bm" },
        { VapiTranscriberLanguagesItem.Bn, "bn" },
        { VapiTranscriberLanguagesItem.Bo, "bo" },
        { VapiTranscriberLanguagesItem.Br, "br" },
        { VapiTranscriberLanguagesItem.Bs, "bs" },
        { VapiTranscriberLanguagesItem.Ca, "ca" },
        { VapiTranscriberLanguagesItem.Ce, "ce" },
        { VapiTranscriberLanguagesItem.Ch, "ch" },
        { VapiTranscriberLanguagesItem.Co, "co" },
        { VapiTranscriberLanguagesItem.Cr, "cr" },
        { VapiTranscriberLanguagesItem.Cs, "cs" },
        { VapiTranscriberLanguagesItem.Cu, "cu" },
        { VapiTranscriberLanguagesItem.Cv, "cv" },
        { VapiTranscriberLanguagesItem.Cy, "cy" },
        { VapiTranscriberLanguagesItem.Da, "da" },
        { VapiTranscriberLanguagesItem.De, "de" },
        { VapiTranscriberLanguagesItem.Dv, "dv" },
        { VapiTranscriberLanguagesItem.Dz, "dz" },
        { VapiTranscriberLanguagesItem.Ee, "ee" },
        { VapiTranscriberLanguagesItem.El, "el" },
        { VapiTranscriberLanguagesItem.En, "en" },
        { VapiTranscriberLanguagesItem.Eo, "eo" },
        { VapiTranscriberLanguagesItem.Es, "es" },
        { VapiTranscriberLanguagesItem.Et, "et" },
        { VapiTranscriberLanguagesItem.Eu, "eu" },
        { VapiTranscriberLanguagesItem.Fa, "fa" },
        { VapiTranscriberLanguagesItem.Ff, "ff" },
        { VapiTranscriberLanguagesItem.Fi, "fi" },
        { VapiTranscriberLanguagesItem.Fj, "fj" },
        { VapiTranscriberLanguagesItem.Fo, "fo" },
        { VapiTranscriberLanguagesItem.Fr, "fr" },
        { VapiTranscriberLanguagesItem.Fy, "fy" },
        { VapiTranscriberLanguagesItem.Ga, "ga" },
        { VapiTranscriberLanguagesItem.Gd, "gd" },
        { VapiTranscriberLanguagesItem.Gl, "gl" },
        { VapiTranscriberLanguagesItem.Gn, "gn" },
        { VapiTranscriberLanguagesItem.Gu, "gu" },
        { VapiTranscriberLanguagesItem.Gv, "gv" },
        { VapiTranscriberLanguagesItem.Ha, "ha" },
        { VapiTranscriberLanguagesItem.He, "he" },
        { VapiTranscriberLanguagesItem.Hi, "hi" },
        { VapiTranscriberLanguagesItem.Ho, "ho" },
        { VapiTranscriberLanguagesItem.Hr, "hr" },
        { VapiTranscriberLanguagesItem.Ht, "ht" },
        { VapiTranscriberLanguagesItem.Hu, "hu" },
        { VapiTranscriberLanguagesItem.Hy, "hy" },
        { VapiTranscriberLanguagesItem.Hz, "hz" },
        { VapiTranscriberLanguagesItem.Ia, "ia" },
        { VapiTranscriberLanguagesItem.Id, "id" },
        { VapiTranscriberLanguagesItem.Ie, "ie" },
        { VapiTranscriberLanguagesItem.Ig, "ig" },
        { VapiTranscriberLanguagesItem.Ii, "ii" },
        { VapiTranscriberLanguagesItem.Ik, "ik" },
        { VapiTranscriberLanguagesItem.Io, "io" },
        { VapiTranscriberLanguagesItem.Is, "is" },
        { VapiTranscriberLanguagesItem.It, "it" },
        { VapiTranscriberLanguagesItem.Iu, "iu" },
        { VapiTranscriberLanguagesItem.Ja, "ja" },
        { VapiTranscriberLanguagesItem.Jv, "jv" },
        { VapiTranscriberLanguagesItem.Ka, "ka" },
        { VapiTranscriberLanguagesItem.Kg, "kg" },
        { VapiTranscriberLanguagesItem.Ki, "ki" },
        { VapiTranscriberLanguagesItem.Kj, "kj" },
        { VapiTranscriberLanguagesItem.Kk, "kk" },
        { VapiTranscriberLanguagesItem.Kl, "kl" },
        { VapiTranscriberLanguagesItem.Km, "km" },
        { VapiTranscriberLanguagesItem.Kn, "kn" },
        { VapiTranscriberLanguagesItem.Ko, "ko" },
        { VapiTranscriberLanguagesItem.Kr, "kr" },
        { VapiTranscriberLanguagesItem.Ks, "ks" },
        { VapiTranscriberLanguagesItem.Ku, "ku" },
        { VapiTranscriberLanguagesItem.Kv, "kv" },
        { VapiTranscriberLanguagesItem.Kw, "kw" },
        { VapiTranscriberLanguagesItem.Ky, "ky" },
        { VapiTranscriberLanguagesItem.La, "la" },
        { VapiTranscriberLanguagesItem.Lb, "lb" },
        { VapiTranscriberLanguagesItem.Lg, "lg" },
        { VapiTranscriberLanguagesItem.Li, "li" },
        { VapiTranscriberLanguagesItem.Ln, "ln" },
        { VapiTranscriberLanguagesItem.Lo, "lo" },
        { VapiTranscriberLanguagesItem.Lt, "lt" },
        { VapiTranscriberLanguagesItem.Lu, "lu" },
        { VapiTranscriberLanguagesItem.Lv, "lv" },
        { VapiTranscriberLanguagesItem.Mg, "mg" },
        { VapiTranscriberLanguagesItem.Mh, "mh" },
        { VapiTranscriberLanguagesItem.Mi, "mi" },
        { VapiTranscriberLanguagesItem.Mk, "mk" },
        { VapiTranscriberLanguagesItem.Ml, "ml" },
        { VapiTranscriberLanguagesItem.Mn, "mn" },
        { VapiTranscriberLanguagesItem.Mr, "mr" },
        { VapiTranscriberLanguagesItem.Ms, "ms" },
        { VapiTranscriberLanguagesItem.Mt, "mt" },
        { VapiTranscriberLanguagesItem.My, "my" },
        { VapiTranscriberLanguagesItem.Na, "na" },
        { VapiTranscriberLanguagesItem.Nb, "nb" },
        { VapiTranscriberLanguagesItem.Nd, "nd" },
        { VapiTranscriberLanguagesItem.Ne, "ne" },
        { VapiTranscriberLanguagesItem.Ng, "ng" },
        { VapiTranscriberLanguagesItem.Nl, "nl" },
        { VapiTranscriberLanguagesItem.Nn, "nn" },
        { VapiTranscriberLanguagesItem.No, "no" },
        { VapiTranscriberLanguagesItem.Nr, "nr" },
        { VapiTranscriberLanguagesItem.Nv, "nv" },
        { VapiTranscriberLanguagesItem.Ny, "ny" },
        { VapiTranscriberLanguagesItem.Oc, "oc" },
        { VapiTranscriberLanguagesItem.Oj, "oj" },
        { VapiTranscriberLanguagesItem.Om, "om" },
        { VapiTranscriberLanguagesItem.Or, "or" },
        { VapiTranscriberLanguagesItem.Os, "os" },
        { VapiTranscriberLanguagesItem.Pa, "pa" },
        { VapiTranscriberLanguagesItem.Pi, "pi" },
        { VapiTranscriberLanguagesItem.Pl, "pl" },
        { VapiTranscriberLanguagesItem.Ps, "ps" },
        { VapiTranscriberLanguagesItem.Pt, "pt" },
        { VapiTranscriberLanguagesItem.Qu, "qu" },
        { VapiTranscriberLanguagesItem.Rm, "rm" },
        { VapiTranscriberLanguagesItem.Rn, "rn" },
        { VapiTranscriberLanguagesItem.Ro, "ro" },
        { VapiTranscriberLanguagesItem.Ru, "ru" },
        { VapiTranscriberLanguagesItem.Rw, "rw" },
        { VapiTranscriberLanguagesItem.Sa, "sa" },
        { VapiTranscriberLanguagesItem.Sc, "sc" },
        { VapiTranscriberLanguagesItem.Sd, "sd" },
        { VapiTranscriberLanguagesItem.Se, "se" },
        { VapiTranscriberLanguagesItem.Sg, "sg" },
        { VapiTranscriberLanguagesItem.Si, "si" },
        { VapiTranscriberLanguagesItem.Sk, "sk" },
        { VapiTranscriberLanguagesItem.Sl, "sl" },
        { VapiTranscriberLanguagesItem.Sm, "sm" },
        { VapiTranscriberLanguagesItem.Sn, "sn" },
        { VapiTranscriberLanguagesItem.So, "so" },
        { VapiTranscriberLanguagesItem.Sq, "sq" },
        { VapiTranscriberLanguagesItem.Sr, "sr" },
        { VapiTranscriberLanguagesItem.Ss, "ss" },
        { VapiTranscriberLanguagesItem.St, "st" },
        { VapiTranscriberLanguagesItem.Su, "su" },
        { VapiTranscriberLanguagesItem.Sv, "sv" },
        { VapiTranscriberLanguagesItem.Sw, "sw" },
        { VapiTranscriberLanguagesItem.Ta, "ta" },
        { VapiTranscriberLanguagesItem.Te, "te" },
        { VapiTranscriberLanguagesItem.Tg, "tg" },
        { VapiTranscriberLanguagesItem.Th, "th" },
        { VapiTranscriberLanguagesItem.Ti, "ti" },
        { VapiTranscriberLanguagesItem.Tk, "tk" },
        { VapiTranscriberLanguagesItem.Tl, "tl" },
        { VapiTranscriberLanguagesItem.Tn, "tn" },
        { VapiTranscriberLanguagesItem.To, "to" },
        { VapiTranscriberLanguagesItem.Tr, "tr" },
        { VapiTranscriberLanguagesItem.Ts, "ts" },
        { VapiTranscriberLanguagesItem.Tt, "tt" },
        { VapiTranscriberLanguagesItem.Tw, "tw" },
        { VapiTranscriberLanguagesItem.Ty, "ty" },
        { VapiTranscriberLanguagesItem.Ug, "ug" },
        { VapiTranscriberLanguagesItem.Uk, "uk" },
        { VapiTranscriberLanguagesItem.Ur, "ur" },
        { VapiTranscriberLanguagesItem.Uz, "uz" },
        { VapiTranscriberLanguagesItem.Ve, "ve" },
        { VapiTranscriberLanguagesItem.Vi, "vi" },
        { VapiTranscriberLanguagesItem.Vo, "vo" },
        { VapiTranscriberLanguagesItem.Wa, "wa" },
        { VapiTranscriberLanguagesItem.Wo, "wo" },
        { VapiTranscriberLanguagesItem.Xh, "xh" },
        { VapiTranscriberLanguagesItem.Yi, "yi" },
        { VapiTranscriberLanguagesItem.Yue, "yue" },
        { VapiTranscriberLanguagesItem.Yo, "yo" },
        { VapiTranscriberLanguagesItem.Za, "za" },
        { VapiTranscriberLanguagesItem.Zh, "zh" },
        { VapiTranscriberLanguagesItem.Zu, "zu" },
    };

    public override VapiTranscriberLanguagesItem Read(
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
        VapiTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiTranscriberLanguagesItem ReadAsPropertyName(
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
        VapiTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
