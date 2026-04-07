using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsTranscriberLanguageSerializer))]
public enum ElevenLabsTranscriberLanguage
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

internal class ElevenLabsTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsTranscriberLanguage
    > _stringToEnum = new()
    {
        { "aa", ElevenLabsTranscriberLanguage.Aa },
        { "ab", ElevenLabsTranscriberLanguage.Ab },
        { "ae", ElevenLabsTranscriberLanguage.Ae },
        { "af", ElevenLabsTranscriberLanguage.Af },
        { "ak", ElevenLabsTranscriberLanguage.Ak },
        { "am", ElevenLabsTranscriberLanguage.Am },
        { "an", ElevenLabsTranscriberLanguage.An },
        { "ar", ElevenLabsTranscriberLanguage.Ar },
        { "as", ElevenLabsTranscriberLanguage.As },
        { "av", ElevenLabsTranscriberLanguage.Av },
        { "ay", ElevenLabsTranscriberLanguage.Ay },
        { "az", ElevenLabsTranscriberLanguage.Az },
        { "ba", ElevenLabsTranscriberLanguage.Ba },
        { "be", ElevenLabsTranscriberLanguage.Be },
        { "bg", ElevenLabsTranscriberLanguage.Bg },
        { "bh", ElevenLabsTranscriberLanguage.Bh },
        { "bi", ElevenLabsTranscriberLanguage.Bi },
        { "bm", ElevenLabsTranscriberLanguage.Bm },
        { "bn", ElevenLabsTranscriberLanguage.Bn },
        { "bo", ElevenLabsTranscriberLanguage.Bo },
        { "br", ElevenLabsTranscriberLanguage.Br },
        { "bs", ElevenLabsTranscriberLanguage.Bs },
        { "ca", ElevenLabsTranscriberLanguage.Ca },
        { "ce", ElevenLabsTranscriberLanguage.Ce },
        { "ch", ElevenLabsTranscriberLanguage.Ch },
        { "co", ElevenLabsTranscriberLanguage.Co },
        { "cr", ElevenLabsTranscriberLanguage.Cr },
        { "cs", ElevenLabsTranscriberLanguage.Cs },
        { "cu", ElevenLabsTranscriberLanguage.Cu },
        { "cv", ElevenLabsTranscriberLanguage.Cv },
        { "cy", ElevenLabsTranscriberLanguage.Cy },
        { "da", ElevenLabsTranscriberLanguage.Da },
        { "de", ElevenLabsTranscriberLanguage.De },
        { "dv", ElevenLabsTranscriberLanguage.Dv },
        { "dz", ElevenLabsTranscriberLanguage.Dz },
        { "ee", ElevenLabsTranscriberLanguage.Ee },
        { "el", ElevenLabsTranscriberLanguage.El },
        { "en", ElevenLabsTranscriberLanguage.En },
        { "eo", ElevenLabsTranscriberLanguage.Eo },
        { "es", ElevenLabsTranscriberLanguage.Es },
        { "et", ElevenLabsTranscriberLanguage.Et },
        { "eu", ElevenLabsTranscriberLanguage.Eu },
        { "fa", ElevenLabsTranscriberLanguage.Fa },
        { "ff", ElevenLabsTranscriberLanguage.Ff },
        { "fi", ElevenLabsTranscriberLanguage.Fi },
        { "fj", ElevenLabsTranscriberLanguage.Fj },
        { "fo", ElevenLabsTranscriberLanguage.Fo },
        { "fr", ElevenLabsTranscriberLanguage.Fr },
        { "fy", ElevenLabsTranscriberLanguage.Fy },
        { "ga", ElevenLabsTranscriberLanguage.Ga },
        { "gd", ElevenLabsTranscriberLanguage.Gd },
        { "gl", ElevenLabsTranscriberLanguage.Gl },
        { "gn", ElevenLabsTranscriberLanguage.Gn },
        { "gu", ElevenLabsTranscriberLanguage.Gu },
        { "gv", ElevenLabsTranscriberLanguage.Gv },
        { "ha", ElevenLabsTranscriberLanguage.Ha },
        { "he", ElevenLabsTranscriberLanguage.He },
        { "hi", ElevenLabsTranscriberLanguage.Hi },
        { "ho", ElevenLabsTranscriberLanguage.Ho },
        { "hr", ElevenLabsTranscriberLanguage.Hr },
        { "ht", ElevenLabsTranscriberLanguage.Ht },
        { "hu", ElevenLabsTranscriberLanguage.Hu },
        { "hy", ElevenLabsTranscriberLanguage.Hy },
        { "hz", ElevenLabsTranscriberLanguage.Hz },
        { "ia", ElevenLabsTranscriberLanguage.Ia },
        { "id", ElevenLabsTranscriberLanguage.Id },
        { "ie", ElevenLabsTranscriberLanguage.Ie },
        { "ig", ElevenLabsTranscriberLanguage.Ig },
        { "ii", ElevenLabsTranscriberLanguage.Ii },
        { "ik", ElevenLabsTranscriberLanguage.Ik },
        { "io", ElevenLabsTranscriberLanguage.Io },
        { "is", ElevenLabsTranscriberLanguage.Is },
        { "it", ElevenLabsTranscriberLanguage.It },
        { "iu", ElevenLabsTranscriberLanguage.Iu },
        { "ja", ElevenLabsTranscriberLanguage.Ja },
        { "jv", ElevenLabsTranscriberLanguage.Jv },
        { "ka", ElevenLabsTranscriberLanguage.Ka },
        { "kg", ElevenLabsTranscriberLanguage.Kg },
        { "ki", ElevenLabsTranscriberLanguage.Ki },
        { "kj", ElevenLabsTranscriberLanguage.Kj },
        { "kk", ElevenLabsTranscriberLanguage.Kk },
        { "kl", ElevenLabsTranscriberLanguage.Kl },
        { "km", ElevenLabsTranscriberLanguage.Km },
        { "kn", ElevenLabsTranscriberLanguage.Kn },
        { "ko", ElevenLabsTranscriberLanguage.Ko },
        { "kr", ElevenLabsTranscriberLanguage.Kr },
        { "ks", ElevenLabsTranscriberLanguage.Ks },
        { "ku", ElevenLabsTranscriberLanguage.Ku },
        { "kv", ElevenLabsTranscriberLanguage.Kv },
        { "kw", ElevenLabsTranscriberLanguage.Kw },
        { "ky", ElevenLabsTranscriberLanguage.Ky },
        { "la", ElevenLabsTranscriberLanguage.La },
        { "lb", ElevenLabsTranscriberLanguage.Lb },
        { "lg", ElevenLabsTranscriberLanguage.Lg },
        { "li", ElevenLabsTranscriberLanguage.Li },
        { "ln", ElevenLabsTranscriberLanguage.Ln },
        { "lo", ElevenLabsTranscriberLanguage.Lo },
        { "lt", ElevenLabsTranscriberLanguage.Lt },
        { "lu", ElevenLabsTranscriberLanguage.Lu },
        { "lv", ElevenLabsTranscriberLanguage.Lv },
        { "mg", ElevenLabsTranscriberLanguage.Mg },
        { "mh", ElevenLabsTranscriberLanguage.Mh },
        { "mi", ElevenLabsTranscriberLanguage.Mi },
        { "mk", ElevenLabsTranscriberLanguage.Mk },
        { "ml", ElevenLabsTranscriberLanguage.Ml },
        { "mn", ElevenLabsTranscriberLanguage.Mn },
        { "mr", ElevenLabsTranscriberLanguage.Mr },
        { "ms", ElevenLabsTranscriberLanguage.Ms },
        { "mt", ElevenLabsTranscriberLanguage.Mt },
        { "my", ElevenLabsTranscriberLanguage.My },
        { "na", ElevenLabsTranscriberLanguage.Na },
        { "nb", ElevenLabsTranscriberLanguage.Nb },
        { "nd", ElevenLabsTranscriberLanguage.Nd },
        { "ne", ElevenLabsTranscriberLanguage.Ne },
        { "ng", ElevenLabsTranscriberLanguage.Ng },
        { "nl", ElevenLabsTranscriberLanguage.Nl },
        { "nn", ElevenLabsTranscriberLanguage.Nn },
        { "no", ElevenLabsTranscriberLanguage.No },
        { "nr", ElevenLabsTranscriberLanguage.Nr },
        { "nv", ElevenLabsTranscriberLanguage.Nv },
        { "ny", ElevenLabsTranscriberLanguage.Ny },
        { "oc", ElevenLabsTranscriberLanguage.Oc },
        { "oj", ElevenLabsTranscriberLanguage.Oj },
        { "om", ElevenLabsTranscriberLanguage.Om },
        { "or", ElevenLabsTranscriberLanguage.Or },
        { "os", ElevenLabsTranscriberLanguage.Os },
        { "pa", ElevenLabsTranscriberLanguage.Pa },
        { "pi", ElevenLabsTranscriberLanguage.Pi },
        { "pl", ElevenLabsTranscriberLanguage.Pl },
        { "ps", ElevenLabsTranscriberLanguage.Ps },
        { "pt", ElevenLabsTranscriberLanguage.Pt },
        { "qu", ElevenLabsTranscriberLanguage.Qu },
        { "rm", ElevenLabsTranscriberLanguage.Rm },
        { "rn", ElevenLabsTranscriberLanguage.Rn },
        { "ro", ElevenLabsTranscriberLanguage.Ro },
        { "ru", ElevenLabsTranscriberLanguage.Ru },
        { "rw", ElevenLabsTranscriberLanguage.Rw },
        { "sa", ElevenLabsTranscriberLanguage.Sa },
        { "sc", ElevenLabsTranscriberLanguage.Sc },
        { "sd", ElevenLabsTranscriberLanguage.Sd },
        { "se", ElevenLabsTranscriberLanguage.Se },
        { "sg", ElevenLabsTranscriberLanguage.Sg },
        { "si", ElevenLabsTranscriberLanguage.Si },
        { "sk", ElevenLabsTranscriberLanguage.Sk },
        { "sl", ElevenLabsTranscriberLanguage.Sl },
        { "sm", ElevenLabsTranscriberLanguage.Sm },
        { "sn", ElevenLabsTranscriberLanguage.Sn },
        { "so", ElevenLabsTranscriberLanguage.So },
        { "sq", ElevenLabsTranscriberLanguage.Sq },
        { "sr", ElevenLabsTranscriberLanguage.Sr },
        { "ss", ElevenLabsTranscriberLanguage.Ss },
        { "st", ElevenLabsTranscriberLanguage.St },
        { "su", ElevenLabsTranscriberLanguage.Su },
        { "sv", ElevenLabsTranscriberLanguage.Sv },
        { "sw", ElevenLabsTranscriberLanguage.Sw },
        { "ta", ElevenLabsTranscriberLanguage.Ta },
        { "te", ElevenLabsTranscriberLanguage.Te },
        { "tg", ElevenLabsTranscriberLanguage.Tg },
        { "th", ElevenLabsTranscriberLanguage.Th },
        { "ti", ElevenLabsTranscriberLanguage.Ti },
        { "tk", ElevenLabsTranscriberLanguage.Tk },
        { "tl", ElevenLabsTranscriberLanguage.Tl },
        { "tn", ElevenLabsTranscriberLanguage.Tn },
        { "to", ElevenLabsTranscriberLanguage.To },
        { "tr", ElevenLabsTranscriberLanguage.Tr },
        { "ts", ElevenLabsTranscriberLanguage.Ts },
        { "tt", ElevenLabsTranscriberLanguage.Tt },
        { "tw", ElevenLabsTranscriberLanguage.Tw },
        { "ty", ElevenLabsTranscriberLanguage.Ty },
        { "ug", ElevenLabsTranscriberLanguage.Ug },
        { "uk", ElevenLabsTranscriberLanguage.Uk },
        { "ur", ElevenLabsTranscriberLanguage.Ur },
        { "uz", ElevenLabsTranscriberLanguage.Uz },
        { "ve", ElevenLabsTranscriberLanguage.Ve },
        { "vi", ElevenLabsTranscriberLanguage.Vi },
        { "vo", ElevenLabsTranscriberLanguage.Vo },
        { "wa", ElevenLabsTranscriberLanguage.Wa },
        { "wo", ElevenLabsTranscriberLanguage.Wo },
        { "xh", ElevenLabsTranscriberLanguage.Xh },
        { "yi", ElevenLabsTranscriberLanguage.Yi },
        { "yue", ElevenLabsTranscriberLanguage.Yue },
        { "yo", ElevenLabsTranscriberLanguage.Yo },
        { "za", ElevenLabsTranscriberLanguage.Za },
        { "zh", ElevenLabsTranscriberLanguage.Zh },
        { "zu", ElevenLabsTranscriberLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { ElevenLabsTranscriberLanguage.Aa, "aa" },
        { ElevenLabsTranscriberLanguage.Ab, "ab" },
        { ElevenLabsTranscriberLanguage.Ae, "ae" },
        { ElevenLabsTranscriberLanguage.Af, "af" },
        { ElevenLabsTranscriberLanguage.Ak, "ak" },
        { ElevenLabsTranscriberLanguage.Am, "am" },
        { ElevenLabsTranscriberLanguage.An, "an" },
        { ElevenLabsTranscriberLanguage.Ar, "ar" },
        { ElevenLabsTranscriberLanguage.As, "as" },
        { ElevenLabsTranscriberLanguage.Av, "av" },
        { ElevenLabsTranscriberLanguage.Ay, "ay" },
        { ElevenLabsTranscriberLanguage.Az, "az" },
        { ElevenLabsTranscriberLanguage.Ba, "ba" },
        { ElevenLabsTranscriberLanguage.Be, "be" },
        { ElevenLabsTranscriberLanguage.Bg, "bg" },
        { ElevenLabsTranscriberLanguage.Bh, "bh" },
        { ElevenLabsTranscriberLanguage.Bi, "bi" },
        { ElevenLabsTranscriberLanguage.Bm, "bm" },
        { ElevenLabsTranscriberLanguage.Bn, "bn" },
        { ElevenLabsTranscriberLanguage.Bo, "bo" },
        { ElevenLabsTranscriberLanguage.Br, "br" },
        { ElevenLabsTranscriberLanguage.Bs, "bs" },
        { ElevenLabsTranscriberLanguage.Ca, "ca" },
        { ElevenLabsTranscriberLanguage.Ce, "ce" },
        { ElevenLabsTranscriberLanguage.Ch, "ch" },
        { ElevenLabsTranscriberLanguage.Co, "co" },
        { ElevenLabsTranscriberLanguage.Cr, "cr" },
        { ElevenLabsTranscriberLanguage.Cs, "cs" },
        { ElevenLabsTranscriberLanguage.Cu, "cu" },
        { ElevenLabsTranscriberLanguage.Cv, "cv" },
        { ElevenLabsTranscriberLanguage.Cy, "cy" },
        { ElevenLabsTranscriberLanguage.Da, "da" },
        { ElevenLabsTranscriberLanguage.De, "de" },
        { ElevenLabsTranscriberLanguage.Dv, "dv" },
        { ElevenLabsTranscriberLanguage.Dz, "dz" },
        { ElevenLabsTranscriberLanguage.Ee, "ee" },
        { ElevenLabsTranscriberLanguage.El, "el" },
        { ElevenLabsTranscriberLanguage.En, "en" },
        { ElevenLabsTranscriberLanguage.Eo, "eo" },
        { ElevenLabsTranscriberLanguage.Es, "es" },
        { ElevenLabsTranscriberLanguage.Et, "et" },
        { ElevenLabsTranscriberLanguage.Eu, "eu" },
        { ElevenLabsTranscriberLanguage.Fa, "fa" },
        { ElevenLabsTranscriberLanguage.Ff, "ff" },
        { ElevenLabsTranscriberLanguage.Fi, "fi" },
        { ElevenLabsTranscriberLanguage.Fj, "fj" },
        { ElevenLabsTranscriberLanguage.Fo, "fo" },
        { ElevenLabsTranscriberLanguage.Fr, "fr" },
        { ElevenLabsTranscriberLanguage.Fy, "fy" },
        { ElevenLabsTranscriberLanguage.Ga, "ga" },
        { ElevenLabsTranscriberLanguage.Gd, "gd" },
        { ElevenLabsTranscriberLanguage.Gl, "gl" },
        { ElevenLabsTranscriberLanguage.Gn, "gn" },
        { ElevenLabsTranscriberLanguage.Gu, "gu" },
        { ElevenLabsTranscriberLanguage.Gv, "gv" },
        { ElevenLabsTranscriberLanguage.Ha, "ha" },
        { ElevenLabsTranscriberLanguage.He, "he" },
        { ElevenLabsTranscriberLanguage.Hi, "hi" },
        { ElevenLabsTranscriberLanguage.Ho, "ho" },
        { ElevenLabsTranscriberLanguage.Hr, "hr" },
        { ElevenLabsTranscriberLanguage.Ht, "ht" },
        { ElevenLabsTranscriberLanguage.Hu, "hu" },
        { ElevenLabsTranscriberLanguage.Hy, "hy" },
        { ElevenLabsTranscriberLanguage.Hz, "hz" },
        { ElevenLabsTranscriberLanguage.Ia, "ia" },
        { ElevenLabsTranscriberLanguage.Id, "id" },
        { ElevenLabsTranscriberLanguage.Ie, "ie" },
        { ElevenLabsTranscriberLanguage.Ig, "ig" },
        { ElevenLabsTranscriberLanguage.Ii, "ii" },
        { ElevenLabsTranscriberLanguage.Ik, "ik" },
        { ElevenLabsTranscriberLanguage.Io, "io" },
        { ElevenLabsTranscriberLanguage.Is, "is" },
        { ElevenLabsTranscriberLanguage.It, "it" },
        { ElevenLabsTranscriberLanguage.Iu, "iu" },
        { ElevenLabsTranscriberLanguage.Ja, "ja" },
        { ElevenLabsTranscriberLanguage.Jv, "jv" },
        { ElevenLabsTranscriberLanguage.Ka, "ka" },
        { ElevenLabsTranscriberLanguage.Kg, "kg" },
        { ElevenLabsTranscriberLanguage.Ki, "ki" },
        { ElevenLabsTranscriberLanguage.Kj, "kj" },
        { ElevenLabsTranscriberLanguage.Kk, "kk" },
        { ElevenLabsTranscriberLanguage.Kl, "kl" },
        { ElevenLabsTranscriberLanguage.Km, "km" },
        { ElevenLabsTranscriberLanguage.Kn, "kn" },
        { ElevenLabsTranscriberLanguage.Ko, "ko" },
        { ElevenLabsTranscriberLanguage.Kr, "kr" },
        { ElevenLabsTranscriberLanguage.Ks, "ks" },
        { ElevenLabsTranscriberLanguage.Ku, "ku" },
        { ElevenLabsTranscriberLanguage.Kv, "kv" },
        { ElevenLabsTranscriberLanguage.Kw, "kw" },
        { ElevenLabsTranscriberLanguage.Ky, "ky" },
        { ElevenLabsTranscriberLanguage.La, "la" },
        { ElevenLabsTranscriberLanguage.Lb, "lb" },
        { ElevenLabsTranscriberLanguage.Lg, "lg" },
        { ElevenLabsTranscriberLanguage.Li, "li" },
        { ElevenLabsTranscriberLanguage.Ln, "ln" },
        { ElevenLabsTranscriberLanguage.Lo, "lo" },
        { ElevenLabsTranscriberLanguage.Lt, "lt" },
        { ElevenLabsTranscriberLanguage.Lu, "lu" },
        { ElevenLabsTranscriberLanguage.Lv, "lv" },
        { ElevenLabsTranscriberLanguage.Mg, "mg" },
        { ElevenLabsTranscriberLanguage.Mh, "mh" },
        { ElevenLabsTranscriberLanguage.Mi, "mi" },
        { ElevenLabsTranscriberLanguage.Mk, "mk" },
        { ElevenLabsTranscriberLanguage.Ml, "ml" },
        { ElevenLabsTranscriberLanguage.Mn, "mn" },
        { ElevenLabsTranscriberLanguage.Mr, "mr" },
        { ElevenLabsTranscriberLanguage.Ms, "ms" },
        { ElevenLabsTranscriberLanguage.Mt, "mt" },
        { ElevenLabsTranscriberLanguage.My, "my" },
        { ElevenLabsTranscriberLanguage.Na, "na" },
        { ElevenLabsTranscriberLanguage.Nb, "nb" },
        { ElevenLabsTranscriberLanguage.Nd, "nd" },
        { ElevenLabsTranscriberLanguage.Ne, "ne" },
        { ElevenLabsTranscriberLanguage.Ng, "ng" },
        { ElevenLabsTranscriberLanguage.Nl, "nl" },
        { ElevenLabsTranscriberLanguage.Nn, "nn" },
        { ElevenLabsTranscriberLanguage.No, "no" },
        { ElevenLabsTranscriberLanguage.Nr, "nr" },
        { ElevenLabsTranscriberLanguage.Nv, "nv" },
        { ElevenLabsTranscriberLanguage.Ny, "ny" },
        { ElevenLabsTranscriberLanguage.Oc, "oc" },
        { ElevenLabsTranscriberLanguage.Oj, "oj" },
        { ElevenLabsTranscriberLanguage.Om, "om" },
        { ElevenLabsTranscriberLanguage.Or, "or" },
        { ElevenLabsTranscriberLanguage.Os, "os" },
        { ElevenLabsTranscriberLanguage.Pa, "pa" },
        { ElevenLabsTranscriberLanguage.Pi, "pi" },
        { ElevenLabsTranscriberLanguage.Pl, "pl" },
        { ElevenLabsTranscriberLanguage.Ps, "ps" },
        { ElevenLabsTranscriberLanguage.Pt, "pt" },
        { ElevenLabsTranscriberLanguage.Qu, "qu" },
        { ElevenLabsTranscriberLanguage.Rm, "rm" },
        { ElevenLabsTranscriberLanguage.Rn, "rn" },
        { ElevenLabsTranscriberLanguage.Ro, "ro" },
        { ElevenLabsTranscriberLanguage.Ru, "ru" },
        { ElevenLabsTranscriberLanguage.Rw, "rw" },
        { ElevenLabsTranscriberLanguage.Sa, "sa" },
        { ElevenLabsTranscriberLanguage.Sc, "sc" },
        { ElevenLabsTranscriberLanguage.Sd, "sd" },
        { ElevenLabsTranscriberLanguage.Se, "se" },
        { ElevenLabsTranscriberLanguage.Sg, "sg" },
        { ElevenLabsTranscriberLanguage.Si, "si" },
        { ElevenLabsTranscriberLanguage.Sk, "sk" },
        { ElevenLabsTranscriberLanguage.Sl, "sl" },
        { ElevenLabsTranscriberLanguage.Sm, "sm" },
        { ElevenLabsTranscriberLanguage.Sn, "sn" },
        { ElevenLabsTranscriberLanguage.So, "so" },
        { ElevenLabsTranscriberLanguage.Sq, "sq" },
        { ElevenLabsTranscriberLanguage.Sr, "sr" },
        { ElevenLabsTranscriberLanguage.Ss, "ss" },
        { ElevenLabsTranscriberLanguage.St, "st" },
        { ElevenLabsTranscriberLanguage.Su, "su" },
        { ElevenLabsTranscriberLanguage.Sv, "sv" },
        { ElevenLabsTranscriberLanguage.Sw, "sw" },
        { ElevenLabsTranscriberLanguage.Ta, "ta" },
        { ElevenLabsTranscriberLanguage.Te, "te" },
        { ElevenLabsTranscriberLanguage.Tg, "tg" },
        { ElevenLabsTranscriberLanguage.Th, "th" },
        { ElevenLabsTranscriberLanguage.Ti, "ti" },
        { ElevenLabsTranscriberLanguage.Tk, "tk" },
        { ElevenLabsTranscriberLanguage.Tl, "tl" },
        { ElevenLabsTranscriberLanguage.Tn, "tn" },
        { ElevenLabsTranscriberLanguage.To, "to" },
        { ElevenLabsTranscriberLanguage.Tr, "tr" },
        { ElevenLabsTranscriberLanguage.Ts, "ts" },
        { ElevenLabsTranscriberLanguage.Tt, "tt" },
        { ElevenLabsTranscriberLanguage.Tw, "tw" },
        { ElevenLabsTranscriberLanguage.Ty, "ty" },
        { ElevenLabsTranscriberLanguage.Ug, "ug" },
        { ElevenLabsTranscriberLanguage.Uk, "uk" },
        { ElevenLabsTranscriberLanguage.Ur, "ur" },
        { ElevenLabsTranscriberLanguage.Uz, "uz" },
        { ElevenLabsTranscriberLanguage.Ve, "ve" },
        { ElevenLabsTranscriberLanguage.Vi, "vi" },
        { ElevenLabsTranscriberLanguage.Vo, "vo" },
        { ElevenLabsTranscriberLanguage.Wa, "wa" },
        { ElevenLabsTranscriberLanguage.Wo, "wo" },
        { ElevenLabsTranscriberLanguage.Xh, "xh" },
        { ElevenLabsTranscriberLanguage.Yi, "yi" },
        { ElevenLabsTranscriberLanguage.Yue, "yue" },
        { ElevenLabsTranscriberLanguage.Yo, "yo" },
        { ElevenLabsTranscriberLanguage.Za, "za" },
        { ElevenLabsTranscriberLanguage.Zh, "zh" },
        { ElevenLabsTranscriberLanguage.Zu, "zu" },
    };

    public override ElevenLabsTranscriberLanguage Read(
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
        ElevenLabsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsTranscriberLanguage ReadAsPropertyName(
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
        ElevenLabsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
