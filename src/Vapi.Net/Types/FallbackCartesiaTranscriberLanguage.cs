using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackCartesiaTranscriberLanguageSerializer))]
public enum FallbackCartesiaTranscriberLanguage
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

internal class FallbackCartesiaTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackCartesiaTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackCartesiaTranscriberLanguage
    > _stringToEnum = new()
    {
        { "aa", FallbackCartesiaTranscriberLanguage.Aa },
        { "ab", FallbackCartesiaTranscriberLanguage.Ab },
        { "ae", FallbackCartesiaTranscriberLanguage.Ae },
        { "af", FallbackCartesiaTranscriberLanguage.Af },
        { "ak", FallbackCartesiaTranscriberLanguage.Ak },
        { "am", FallbackCartesiaTranscriberLanguage.Am },
        { "an", FallbackCartesiaTranscriberLanguage.An },
        { "ar", FallbackCartesiaTranscriberLanguage.Ar },
        { "as", FallbackCartesiaTranscriberLanguage.As },
        { "av", FallbackCartesiaTranscriberLanguage.Av },
        { "ay", FallbackCartesiaTranscriberLanguage.Ay },
        { "az", FallbackCartesiaTranscriberLanguage.Az },
        { "ba", FallbackCartesiaTranscriberLanguage.Ba },
        { "be", FallbackCartesiaTranscriberLanguage.Be },
        { "bg", FallbackCartesiaTranscriberLanguage.Bg },
        { "bh", FallbackCartesiaTranscriberLanguage.Bh },
        { "bi", FallbackCartesiaTranscriberLanguage.Bi },
        { "bm", FallbackCartesiaTranscriberLanguage.Bm },
        { "bn", FallbackCartesiaTranscriberLanguage.Bn },
        { "bo", FallbackCartesiaTranscriberLanguage.Bo },
        { "br", FallbackCartesiaTranscriberLanguage.Br },
        { "bs", FallbackCartesiaTranscriberLanguage.Bs },
        { "ca", FallbackCartesiaTranscriberLanguage.Ca },
        { "ce", FallbackCartesiaTranscriberLanguage.Ce },
        { "ch", FallbackCartesiaTranscriberLanguage.Ch },
        { "co", FallbackCartesiaTranscriberLanguage.Co },
        { "cr", FallbackCartesiaTranscriberLanguage.Cr },
        { "cs", FallbackCartesiaTranscriberLanguage.Cs },
        { "cu", FallbackCartesiaTranscriberLanguage.Cu },
        { "cv", FallbackCartesiaTranscriberLanguage.Cv },
        { "cy", FallbackCartesiaTranscriberLanguage.Cy },
        { "da", FallbackCartesiaTranscriberLanguage.Da },
        { "de", FallbackCartesiaTranscriberLanguage.De },
        { "dv", FallbackCartesiaTranscriberLanguage.Dv },
        { "dz", FallbackCartesiaTranscriberLanguage.Dz },
        { "ee", FallbackCartesiaTranscriberLanguage.Ee },
        { "el", FallbackCartesiaTranscriberLanguage.El },
        { "en", FallbackCartesiaTranscriberLanguage.En },
        { "eo", FallbackCartesiaTranscriberLanguage.Eo },
        { "es", FallbackCartesiaTranscriberLanguage.Es },
        { "et", FallbackCartesiaTranscriberLanguage.Et },
        { "eu", FallbackCartesiaTranscriberLanguage.Eu },
        { "fa", FallbackCartesiaTranscriberLanguage.Fa },
        { "ff", FallbackCartesiaTranscriberLanguage.Ff },
        { "fi", FallbackCartesiaTranscriberLanguage.Fi },
        { "fj", FallbackCartesiaTranscriberLanguage.Fj },
        { "fo", FallbackCartesiaTranscriberLanguage.Fo },
        { "fr", FallbackCartesiaTranscriberLanguage.Fr },
        { "fy", FallbackCartesiaTranscriberLanguage.Fy },
        { "ga", FallbackCartesiaTranscriberLanguage.Ga },
        { "gd", FallbackCartesiaTranscriberLanguage.Gd },
        { "gl", FallbackCartesiaTranscriberLanguage.Gl },
        { "gn", FallbackCartesiaTranscriberLanguage.Gn },
        { "gu", FallbackCartesiaTranscriberLanguage.Gu },
        { "gv", FallbackCartesiaTranscriberLanguage.Gv },
        { "ha", FallbackCartesiaTranscriberLanguage.Ha },
        { "he", FallbackCartesiaTranscriberLanguage.He },
        { "hi", FallbackCartesiaTranscriberLanguage.Hi },
        { "ho", FallbackCartesiaTranscriberLanguage.Ho },
        { "hr", FallbackCartesiaTranscriberLanguage.Hr },
        { "ht", FallbackCartesiaTranscriberLanguage.Ht },
        { "hu", FallbackCartesiaTranscriberLanguage.Hu },
        { "hy", FallbackCartesiaTranscriberLanguage.Hy },
        { "hz", FallbackCartesiaTranscriberLanguage.Hz },
        { "ia", FallbackCartesiaTranscriberLanguage.Ia },
        { "id", FallbackCartesiaTranscriberLanguage.Id },
        { "ie", FallbackCartesiaTranscriberLanguage.Ie },
        { "ig", FallbackCartesiaTranscriberLanguage.Ig },
        { "ii", FallbackCartesiaTranscriberLanguage.Ii },
        { "ik", FallbackCartesiaTranscriberLanguage.Ik },
        { "io", FallbackCartesiaTranscriberLanguage.Io },
        { "is", FallbackCartesiaTranscriberLanguage.Is },
        { "it", FallbackCartesiaTranscriberLanguage.It },
        { "iu", FallbackCartesiaTranscriberLanguage.Iu },
        { "ja", FallbackCartesiaTranscriberLanguage.Ja },
        { "jv", FallbackCartesiaTranscriberLanguage.Jv },
        { "ka", FallbackCartesiaTranscriberLanguage.Ka },
        { "kg", FallbackCartesiaTranscriberLanguage.Kg },
        { "ki", FallbackCartesiaTranscriberLanguage.Ki },
        { "kj", FallbackCartesiaTranscriberLanguage.Kj },
        { "kk", FallbackCartesiaTranscriberLanguage.Kk },
        { "kl", FallbackCartesiaTranscriberLanguage.Kl },
        { "km", FallbackCartesiaTranscriberLanguage.Km },
        { "kn", FallbackCartesiaTranscriberLanguage.Kn },
        { "ko", FallbackCartesiaTranscriberLanguage.Ko },
        { "kr", FallbackCartesiaTranscriberLanguage.Kr },
        { "ks", FallbackCartesiaTranscriberLanguage.Ks },
        { "ku", FallbackCartesiaTranscriberLanguage.Ku },
        { "kv", FallbackCartesiaTranscriberLanguage.Kv },
        { "kw", FallbackCartesiaTranscriberLanguage.Kw },
        { "ky", FallbackCartesiaTranscriberLanguage.Ky },
        { "la", FallbackCartesiaTranscriberLanguage.La },
        { "lb", FallbackCartesiaTranscriberLanguage.Lb },
        { "lg", FallbackCartesiaTranscriberLanguage.Lg },
        { "li", FallbackCartesiaTranscriberLanguage.Li },
        { "ln", FallbackCartesiaTranscriberLanguage.Ln },
        { "lo", FallbackCartesiaTranscriberLanguage.Lo },
        { "lt", FallbackCartesiaTranscriberLanguage.Lt },
        { "lu", FallbackCartesiaTranscriberLanguage.Lu },
        { "lv", FallbackCartesiaTranscriberLanguage.Lv },
        { "mg", FallbackCartesiaTranscriberLanguage.Mg },
        { "mh", FallbackCartesiaTranscriberLanguage.Mh },
        { "mi", FallbackCartesiaTranscriberLanguage.Mi },
        { "mk", FallbackCartesiaTranscriberLanguage.Mk },
        { "ml", FallbackCartesiaTranscriberLanguage.Ml },
        { "mn", FallbackCartesiaTranscriberLanguage.Mn },
        { "mr", FallbackCartesiaTranscriberLanguage.Mr },
        { "ms", FallbackCartesiaTranscriberLanguage.Ms },
        { "mt", FallbackCartesiaTranscriberLanguage.Mt },
        { "my", FallbackCartesiaTranscriberLanguage.My },
        { "na", FallbackCartesiaTranscriberLanguage.Na },
        { "nb", FallbackCartesiaTranscriberLanguage.Nb },
        { "nd", FallbackCartesiaTranscriberLanguage.Nd },
        { "ne", FallbackCartesiaTranscriberLanguage.Ne },
        { "ng", FallbackCartesiaTranscriberLanguage.Ng },
        { "nl", FallbackCartesiaTranscriberLanguage.Nl },
        { "nn", FallbackCartesiaTranscriberLanguage.Nn },
        { "no", FallbackCartesiaTranscriberLanguage.No },
        { "nr", FallbackCartesiaTranscriberLanguage.Nr },
        { "nv", FallbackCartesiaTranscriberLanguage.Nv },
        { "ny", FallbackCartesiaTranscriberLanguage.Ny },
        { "oc", FallbackCartesiaTranscriberLanguage.Oc },
        { "oj", FallbackCartesiaTranscriberLanguage.Oj },
        { "om", FallbackCartesiaTranscriberLanguage.Om },
        { "or", FallbackCartesiaTranscriberLanguage.Or },
        { "os", FallbackCartesiaTranscriberLanguage.Os },
        { "pa", FallbackCartesiaTranscriberLanguage.Pa },
        { "pi", FallbackCartesiaTranscriberLanguage.Pi },
        { "pl", FallbackCartesiaTranscriberLanguage.Pl },
        { "ps", FallbackCartesiaTranscriberLanguage.Ps },
        { "pt", FallbackCartesiaTranscriberLanguage.Pt },
        { "qu", FallbackCartesiaTranscriberLanguage.Qu },
        { "rm", FallbackCartesiaTranscriberLanguage.Rm },
        { "rn", FallbackCartesiaTranscriberLanguage.Rn },
        { "ro", FallbackCartesiaTranscriberLanguage.Ro },
        { "ru", FallbackCartesiaTranscriberLanguage.Ru },
        { "rw", FallbackCartesiaTranscriberLanguage.Rw },
        { "sa", FallbackCartesiaTranscriberLanguage.Sa },
        { "sc", FallbackCartesiaTranscriberLanguage.Sc },
        { "sd", FallbackCartesiaTranscriberLanguage.Sd },
        { "se", FallbackCartesiaTranscriberLanguage.Se },
        { "sg", FallbackCartesiaTranscriberLanguage.Sg },
        { "si", FallbackCartesiaTranscriberLanguage.Si },
        { "sk", FallbackCartesiaTranscriberLanguage.Sk },
        { "sl", FallbackCartesiaTranscriberLanguage.Sl },
        { "sm", FallbackCartesiaTranscriberLanguage.Sm },
        { "sn", FallbackCartesiaTranscriberLanguage.Sn },
        { "so", FallbackCartesiaTranscriberLanguage.So },
        { "sq", FallbackCartesiaTranscriberLanguage.Sq },
        { "sr", FallbackCartesiaTranscriberLanguage.Sr },
        { "ss", FallbackCartesiaTranscriberLanguage.Ss },
        { "st", FallbackCartesiaTranscriberLanguage.St },
        { "su", FallbackCartesiaTranscriberLanguage.Su },
        { "sv", FallbackCartesiaTranscriberLanguage.Sv },
        { "sw", FallbackCartesiaTranscriberLanguage.Sw },
        { "ta", FallbackCartesiaTranscriberLanguage.Ta },
        { "te", FallbackCartesiaTranscriberLanguage.Te },
        { "tg", FallbackCartesiaTranscriberLanguage.Tg },
        { "th", FallbackCartesiaTranscriberLanguage.Th },
        { "ti", FallbackCartesiaTranscriberLanguage.Ti },
        { "tk", FallbackCartesiaTranscriberLanguage.Tk },
        { "tl", FallbackCartesiaTranscriberLanguage.Tl },
        { "tn", FallbackCartesiaTranscriberLanguage.Tn },
        { "to", FallbackCartesiaTranscriberLanguage.To },
        { "tr", FallbackCartesiaTranscriberLanguage.Tr },
        { "ts", FallbackCartesiaTranscriberLanguage.Ts },
        { "tt", FallbackCartesiaTranscriberLanguage.Tt },
        { "tw", FallbackCartesiaTranscriberLanguage.Tw },
        { "ty", FallbackCartesiaTranscriberLanguage.Ty },
        { "ug", FallbackCartesiaTranscriberLanguage.Ug },
        { "uk", FallbackCartesiaTranscriberLanguage.Uk },
        { "ur", FallbackCartesiaTranscriberLanguage.Ur },
        { "uz", FallbackCartesiaTranscriberLanguage.Uz },
        { "ve", FallbackCartesiaTranscriberLanguage.Ve },
        { "vi", FallbackCartesiaTranscriberLanguage.Vi },
        { "vo", FallbackCartesiaTranscriberLanguage.Vo },
        { "wa", FallbackCartesiaTranscriberLanguage.Wa },
        { "wo", FallbackCartesiaTranscriberLanguage.Wo },
        { "xh", FallbackCartesiaTranscriberLanguage.Xh },
        { "yi", FallbackCartesiaTranscriberLanguage.Yi },
        { "yue", FallbackCartesiaTranscriberLanguage.Yue },
        { "yo", FallbackCartesiaTranscriberLanguage.Yo },
        { "za", FallbackCartesiaTranscriberLanguage.Za },
        { "zh", FallbackCartesiaTranscriberLanguage.Zh },
        { "zu", FallbackCartesiaTranscriberLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackCartesiaTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackCartesiaTranscriberLanguage.Aa, "aa" },
        { FallbackCartesiaTranscriberLanguage.Ab, "ab" },
        { FallbackCartesiaTranscriberLanguage.Ae, "ae" },
        { FallbackCartesiaTranscriberLanguage.Af, "af" },
        { FallbackCartesiaTranscriberLanguage.Ak, "ak" },
        { FallbackCartesiaTranscriberLanguage.Am, "am" },
        { FallbackCartesiaTranscriberLanguage.An, "an" },
        { FallbackCartesiaTranscriberLanguage.Ar, "ar" },
        { FallbackCartesiaTranscriberLanguage.As, "as" },
        { FallbackCartesiaTranscriberLanguage.Av, "av" },
        { FallbackCartesiaTranscriberLanguage.Ay, "ay" },
        { FallbackCartesiaTranscriberLanguage.Az, "az" },
        { FallbackCartesiaTranscriberLanguage.Ba, "ba" },
        { FallbackCartesiaTranscriberLanguage.Be, "be" },
        { FallbackCartesiaTranscriberLanguage.Bg, "bg" },
        { FallbackCartesiaTranscriberLanguage.Bh, "bh" },
        { FallbackCartesiaTranscriberLanguage.Bi, "bi" },
        { FallbackCartesiaTranscriberLanguage.Bm, "bm" },
        { FallbackCartesiaTranscriberLanguage.Bn, "bn" },
        { FallbackCartesiaTranscriberLanguage.Bo, "bo" },
        { FallbackCartesiaTranscriberLanguage.Br, "br" },
        { FallbackCartesiaTranscriberLanguage.Bs, "bs" },
        { FallbackCartesiaTranscriberLanguage.Ca, "ca" },
        { FallbackCartesiaTranscriberLanguage.Ce, "ce" },
        { FallbackCartesiaTranscriberLanguage.Ch, "ch" },
        { FallbackCartesiaTranscriberLanguage.Co, "co" },
        { FallbackCartesiaTranscriberLanguage.Cr, "cr" },
        { FallbackCartesiaTranscriberLanguage.Cs, "cs" },
        { FallbackCartesiaTranscriberLanguage.Cu, "cu" },
        { FallbackCartesiaTranscriberLanguage.Cv, "cv" },
        { FallbackCartesiaTranscriberLanguage.Cy, "cy" },
        { FallbackCartesiaTranscriberLanguage.Da, "da" },
        { FallbackCartesiaTranscriberLanguage.De, "de" },
        { FallbackCartesiaTranscriberLanguage.Dv, "dv" },
        { FallbackCartesiaTranscriberLanguage.Dz, "dz" },
        { FallbackCartesiaTranscriberLanguage.Ee, "ee" },
        { FallbackCartesiaTranscriberLanguage.El, "el" },
        { FallbackCartesiaTranscriberLanguage.En, "en" },
        { FallbackCartesiaTranscriberLanguage.Eo, "eo" },
        { FallbackCartesiaTranscriberLanguage.Es, "es" },
        { FallbackCartesiaTranscriberLanguage.Et, "et" },
        { FallbackCartesiaTranscriberLanguage.Eu, "eu" },
        { FallbackCartesiaTranscriberLanguage.Fa, "fa" },
        { FallbackCartesiaTranscriberLanguage.Ff, "ff" },
        { FallbackCartesiaTranscriberLanguage.Fi, "fi" },
        { FallbackCartesiaTranscriberLanguage.Fj, "fj" },
        { FallbackCartesiaTranscriberLanguage.Fo, "fo" },
        { FallbackCartesiaTranscriberLanguage.Fr, "fr" },
        { FallbackCartesiaTranscriberLanguage.Fy, "fy" },
        { FallbackCartesiaTranscriberLanguage.Ga, "ga" },
        { FallbackCartesiaTranscriberLanguage.Gd, "gd" },
        { FallbackCartesiaTranscriberLanguage.Gl, "gl" },
        { FallbackCartesiaTranscriberLanguage.Gn, "gn" },
        { FallbackCartesiaTranscriberLanguage.Gu, "gu" },
        { FallbackCartesiaTranscriberLanguage.Gv, "gv" },
        { FallbackCartesiaTranscriberLanguage.Ha, "ha" },
        { FallbackCartesiaTranscriberLanguage.He, "he" },
        { FallbackCartesiaTranscriberLanguage.Hi, "hi" },
        { FallbackCartesiaTranscriberLanguage.Ho, "ho" },
        { FallbackCartesiaTranscriberLanguage.Hr, "hr" },
        { FallbackCartesiaTranscriberLanguage.Ht, "ht" },
        { FallbackCartesiaTranscriberLanguage.Hu, "hu" },
        { FallbackCartesiaTranscriberLanguage.Hy, "hy" },
        { FallbackCartesiaTranscriberLanguage.Hz, "hz" },
        { FallbackCartesiaTranscriberLanguage.Ia, "ia" },
        { FallbackCartesiaTranscriberLanguage.Id, "id" },
        { FallbackCartesiaTranscriberLanguage.Ie, "ie" },
        { FallbackCartesiaTranscriberLanguage.Ig, "ig" },
        { FallbackCartesiaTranscriberLanguage.Ii, "ii" },
        { FallbackCartesiaTranscriberLanguage.Ik, "ik" },
        { FallbackCartesiaTranscriberLanguage.Io, "io" },
        { FallbackCartesiaTranscriberLanguage.Is, "is" },
        { FallbackCartesiaTranscriberLanguage.It, "it" },
        { FallbackCartesiaTranscriberLanguage.Iu, "iu" },
        { FallbackCartesiaTranscriberLanguage.Ja, "ja" },
        { FallbackCartesiaTranscriberLanguage.Jv, "jv" },
        { FallbackCartesiaTranscriberLanguage.Ka, "ka" },
        { FallbackCartesiaTranscriberLanguage.Kg, "kg" },
        { FallbackCartesiaTranscriberLanguage.Ki, "ki" },
        { FallbackCartesiaTranscriberLanguage.Kj, "kj" },
        { FallbackCartesiaTranscriberLanguage.Kk, "kk" },
        { FallbackCartesiaTranscriberLanguage.Kl, "kl" },
        { FallbackCartesiaTranscriberLanguage.Km, "km" },
        { FallbackCartesiaTranscriberLanguage.Kn, "kn" },
        { FallbackCartesiaTranscriberLanguage.Ko, "ko" },
        { FallbackCartesiaTranscriberLanguage.Kr, "kr" },
        { FallbackCartesiaTranscriberLanguage.Ks, "ks" },
        { FallbackCartesiaTranscriberLanguage.Ku, "ku" },
        { FallbackCartesiaTranscriberLanguage.Kv, "kv" },
        { FallbackCartesiaTranscriberLanguage.Kw, "kw" },
        { FallbackCartesiaTranscriberLanguage.Ky, "ky" },
        { FallbackCartesiaTranscriberLanguage.La, "la" },
        { FallbackCartesiaTranscriberLanguage.Lb, "lb" },
        { FallbackCartesiaTranscriberLanguage.Lg, "lg" },
        { FallbackCartesiaTranscriberLanguage.Li, "li" },
        { FallbackCartesiaTranscriberLanguage.Ln, "ln" },
        { FallbackCartesiaTranscriberLanguage.Lo, "lo" },
        { FallbackCartesiaTranscriberLanguage.Lt, "lt" },
        { FallbackCartesiaTranscriberLanguage.Lu, "lu" },
        { FallbackCartesiaTranscriberLanguage.Lv, "lv" },
        { FallbackCartesiaTranscriberLanguage.Mg, "mg" },
        { FallbackCartesiaTranscriberLanguage.Mh, "mh" },
        { FallbackCartesiaTranscriberLanguage.Mi, "mi" },
        { FallbackCartesiaTranscriberLanguage.Mk, "mk" },
        { FallbackCartesiaTranscriberLanguage.Ml, "ml" },
        { FallbackCartesiaTranscriberLanguage.Mn, "mn" },
        { FallbackCartesiaTranscriberLanguage.Mr, "mr" },
        { FallbackCartesiaTranscriberLanguage.Ms, "ms" },
        { FallbackCartesiaTranscriberLanguage.Mt, "mt" },
        { FallbackCartesiaTranscriberLanguage.My, "my" },
        { FallbackCartesiaTranscriberLanguage.Na, "na" },
        { FallbackCartesiaTranscriberLanguage.Nb, "nb" },
        { FallbackCartesiaTranscriberLanguage.Nd, "nd" },
        { FallbackCartesiaTranscriberLanguage.Ne, "ne" },
        { FallbackCartesiaTranscriberLanguage.Ng, "ng" },
        { FallbackCartesiaTranscriberLanguage.Nl, "nl" },
        { FallbackCartesiaTranscriberLanguage.Nn, "nn" },
        { FallbackCartesiaTranscriberLanguage.No, "no" },
        { FallbackCartesiaTranscriberLanguage.Nr, "nr" },
        { FallbackCartesiaTranscriberLanguage.Nv, "nv" },
        { FallbackCartesiaTranscriberLanguage.Ny, "ny" },
        { FallbackCartesiaTranscriberLanguage.Oc, "oc" },
        { FallbackCartesiaTranscriberLanguage.Oj, "oj" },
        { FallbackCartesiaTranscriberLanguage.Om, "om" },
        { FallbackCartesiaTranscriberLanguage.Or, "or" },
        { FallbackCartesiaTranscriberLanguage.Os, "os" },
        { FallbackCartesiaTranscriberLanguage.Pa, "pa" },
        { FallbackCartesiaTranscriberLanguage.Pi, "pi" },
        { FallbackCartesiaTranscriberLanguage.Pl, "pl" },
        { FallbackCartesiaTranscriberLanguage.Ps, "ps" },
        { FallbackCartesiaTranscriberLanguage.Pt, "pt" },
        { FallbackCartesiaTranscriberLanguage.Qu, "qu" },
        { FallbackCartesiaTranscriberLanguage.Rm, "rm" },
        { FallbackCartesiaTranscriberLanguage.Rn, "rn" },
        { FallbackCartesiaTranscriberLanguage.Ro, "ro" },
        { FallbackCartesiaTranscriberLanguage.Ru, "ru" },
        { FallbackCartesiaTranscriberLanguage.Rw, "rw" },
        { FallbackCartesiaTranscriberLanguage.Sa, "sa" },
        { FallbackCartesiaTranscriberLanguage.Sc, "sc" },
        { FallbackCartesiaTranscriberLanguage.Sd, "sd" },
        { FallbackCartesiaTranscriberLanguage.Se, "se" },
        { FallbackCartesiaTranscriberLanguage.Sg, "sg" },
        { FallbackCartesiaTranscriberLanguage.Si, "si" },
        { FallbackCartesiaTranscriberLanguage.Sk, "sk" },
        { FallbackCartesiaTranscriberLanguage.Sl, "sl" },
        { FallbackCartesiaTranscriberLanguage.Sm, "sm" },
        { FallbackCartesiaTranscriberLanguage.Sn, "sn" },
        { FallbackCartesiaTranscriberLanguage.So, "so" },
        { FallbackCartesiaTranscriberLanguage.Sq, "sq" },
        { FallbackCartesiaTranscriberLanguage.Sr, "sr" },
        { FallbackCartesiaTranscriberLanguage.Ss, "ss" },
        { FallbackCartesiaTranscriberLanguage.St, "st" },
        { FallbackCartesiaTranscriberLanguage.Su, "su" },
        { FallbackCartesiaTranscriberLanguage.Sv, "sv" },
        { FallbackCartesiaTranscriberLanguage.Sw, "sw" },
        { FallbackCartesiaTranscriberLanguage.Ta, "ta" },
        { FallbackCartesiaTranscriberLanguage.Te, "te" },
        { FallbackCartesiaTranscriberLanguage.Tg, "tg" },
        { FallbackCartesiaTranscriberLanguage.Th, "th" },
        { FallbackCartesiaTranscriberLanguage.Ti, "ti" },
        { FallbackCartesiaTranscriberLanguage.Tk, "tk" },
        { FallbackCartesiaTranscriberLanguage.Tl, "tl" },
        { FallbackCartesiaTranscriberLanguage.Tn, "tn" },
        { FallbackCartesiaTranscriberLanguage.To, "to" },
        { FallbackCartesiaTranscriberLanguage.Tr, "tr" },
        { FallbackCartesiaTranscriberLanguage.Ts, "ts" },
        { FallbackCartesiaTranscriberLanguage.Tt, "tt" },
        { FallbackCartesiaTranscriberLanguage.Tw, "tw" },
        { FallbackCartesiaTranscriberLanguage.Ty, "ty" },
        { FallbackCartesiaTranscriberLanguage.Ug, "ug" },
        { FallbackCartesiaTranscriberLanguage.Uk, "uk" },
        { FallbackCartesiaTranscriberLanguage.Ur, "ur" },
        { FallbackCartesiaTranscriberLanguage.Uz, "uz" },
        { FallbackCartesiaTranscriberLanguage.Ve, "ve" },
        { FallbackCartesiaTranscriberLanguage.Vi, "vi" },
        { FallbackCartesiaTranscriberLanguage.Vo, "vo" },
        { FallbackCartesiaTranscriberLanguage.Wa, "wa" },
        { FallbackCartesiaTranscriberLanguage.Wo, "wo" },
        { FallbackCartesiaTranscriberLanguage.Xh, "xh" },
        { FallbackCartesiaTranscriberLanguage.Yi, "yi" },
        { FallbackCartesiaTranscriberLanguage.Yue, "yue" },
        { FallbackCartesiaTranscriberLanguage.Yo, "yo" },
        { FallbackCartesiaTranscriberLanguage.Za, "za" },
        { FallbackCartesiaTranscriberLanguage.Zh, "zh" },
        { FallbackCartesiaTranscriberLanguage.Zu, "zu" },
    };

    public override FallbackCartesiaTranscriberLanguage Read(
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
        FallbackCartesiaTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackCartesiaTranscriberLanguage ReadAsPropertyName(
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
        FallbackCartesiaTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
