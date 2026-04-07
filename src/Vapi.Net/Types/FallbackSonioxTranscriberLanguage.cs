using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSonioxTranscriberLanguageSerializer))]
public enum FallbackSonioxTranscriberLanguage
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

internal class FallbackSonioxTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSonioxTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSonioxTranscriberLanguage
    > _stringToEnum = new()
    {
        { "aa", FallbackSonioxTranscriberLanguage.Aa },
        { "ab", FallbackSonioxTranscriberLanguage.Ab },
        { "ae", FallbackSonioxTranscriberLanguage.Ae },
        { "af", FallbackSonioxTranscriberLanguage.Af },
        { "ak", FallbackSonioxTranscriberLanguage.Ak },
        { "am", FallbackSonioxTranscriberLanguage.Am },
        { "an", FallbackSonioxTranscriberLanguage.An },
        { "ar", FallbackSonioxTranscriberLanguage.Ar },
        { "as", FallbackSonioxTranscriberLanguage.As },
        { "av", FallbackSonioxTranscriberLanguage.Av },
        { "ay", FallbackSonioxTranscriberLanguage.Ay },
        { "az", FallbackSonioxTranscriberLanguage.Az },
        { "ba", FallbackSonioxTranscriberLanguage.Ba },
        { "be", FallbackSonioxTranscriberLanguage.Be },
        { "bg", FallbackSonioxTranscriberLanguage.Bg },
        { "bh", FallbackSonioxTranscriberLanguage.Bh },
        { "bi", FallbackSonioxTranscriberLanguage.Bi },
        { "bm", FallbackSonioxTranscriberLanguage.Bm },
        { "bn", FallbackSonioxTranscriberLanguage.Bn },
        { "bo", FallbackSonioxTranscriberLanguage.Bo },
        { "br", FallbackSonioxTranscriberLanguage.Br },
        { "bs", FallbackSonioxTranscriberLanguage.Bs },
        { "ca", FallbackSonioxTranscriberLanguage.Ca },
        { "ce", FallbackSonioxTranscriberLanguage.Ce },
        { "ch", FallbackSonioxTranscriberLanguage.Ch },
        { "co", FallbackSonioxTranscriberLanguage.Co },
        { "cr", FallbackSonioxTranscriberLanguage.Cr },
        { "cs", FallbackSonioxTranscriberLanguage.Cs },
        { "cu", FallbackSonioxTranscriberLanguage.Cu },
        { "cv", FallbackSonioxTranscriberLanguage.Cv },
        { "cy", FallbackSonioxTranscriberLanguage.Cy },
        { "da", FallbackSonioxTranscriberLanguage.Da },
        { "de", FallbackSonioxTranscriberLanguage.De },
        { "dv", FallbackSonioxTranscriberLanguage.Dv },
        { "dz", FallbackSonioxTranscriberLanguage.Dz },
        { "ee", FallbackSonioxTranscriberLanguage.Ee },
        { "el", FallbackSonioxTranscriberLanguage.El },
        { "en", FallbackSonioxTranscriberLanguage.En },
        { "eo", FallbackSonioxTranscriberLanguage.Eo },
        { "es", FallbackSonioxTranscriberLanguage.Es },
        { "et", FallbackSonioxTranscriberLanguage.Et },
        { "eu", FallbackSonioxTranscriberLanguage.Eu },
        { "fa", FallbackSonioxTranscriberLanguage.Fa },
        { "ff", FallbackSonioxTranscriberLanguage.Ff },
        { "fi", FallbackSonioxTranscriberLanguage.Fi },
        { "fj", FallbackSonioxTranscriberLanguage.Fj },
        { "fo", FallbackSonioxTranscriberLanguage.Fo },
        { "fr", FallbackSonioxTranscriberLanguage.Fr },
        { "fy", FallbackSonioxTranscriberLanguage.Fy },
        { "ga", FallbackSonioxTranscriberLanguage.Ga },
        { "gd", FallbackSonioxTranscriberLanguage.Gd },
        { "gl", FallbackSonioxTranscriberLanguage.Gl },
        { "gn", FallbackSonioxTranscriberLanguage.Gn },
        { "gu", FallbackSonioxTranscriberLanguage.Gu },
        { "gv", FallbackSonioxTranscriberLanguage.Gv },
        { "ha", FallbackSonioxTranscriberLanguage.Ha },
        { "he", FallbackSonioxTranscriberLanguage.He },
        { "hi", FallbackSonioxTranscriberLanguage.Hi },
        { "ho", FallbackSonioxTranscriberLanguage.Ho },
        { "hr", FallbackSonioxTranscriberLanguage.Hr },
        { "ht", FallbackSonioxTranscriberLanguage.Ht },
        { "hu", FallbackSonioxTranscriberLanguage.Hu },
        { "hy", FallbackSonioxTranscriberLanguage.Hy },
        { "hz", FallbackSonioxTranscriberLanguage.Hz },
        { "ia", FallbackSonioxTranscriberLanguage.Ia },
        { "id", FallbackSonioxTranscriberLanguage.Id },
        { "ie", FallbackSonioxTranscriberLanguage.Ie },
        { "ig", FallbackSonioxTranscriberLanguage.Ig },
        { "ii", FallbackSonioxTranscriberLanguage.Ii },
        { "ik", FallbackSonioxTranscriberLanguage.Ik },
        { "io", FallbackSonioxTranscriberLanguage.Io },
        { "is", FallbackSonioxTranscriberLanguage.Is },
        { "it", FallbackSonioxTranscriberLanguage.It },
        { "iu", FallbackSonioxTranscriberLanguage.Iu },
        { "ja", FallbackSonioxTranscriberLanguage.Ja },
        { "jv", FallbackSonioxTranscriberLanguage.Jv },
        { "ka", FallbackSonioxTranscriberLanguage.Ka },
        { "kg", FallbackSonioxTranscriberLanguage.Kg },
        { "ki", FallbackSonioxTranscriberLanguage.Ki },
        { "kj", FallbackSonioxTranscriberLanguage.Kj },
        { "kk", FallbackSonioxTranscriberLanguage.Kk },
        { "kl", FallbackSonioxTranscriberLanguage.Kl },
        { "km", FallbackSonioxTranscriberLanguage.Km },
        { "kn", FallbackSonioxTranscriberLanguage.Kn },
        { "ko", FallbackSonioxTranscriberLanguage.Ko },
        { "kr", FallbackSonioxTranscriberLanguage.Kr },
        { "ks", FallbackSonioxTranscriberLanguage.Ks },
        { "ku", FallbackSonioxTranscriberLanguage.Ku },
        { "kv", FallbackSonioxTranscriberLanguage.Kv },
        { "kw", FallbackSonioxTranscriberLanguage.Kw },
        { "ky", FallbackSonioxTranscriberLanguage.Ky },
        { "la", FallbackSonioxTranscriberLanguage.La },
        { "lb", FallbackSonioxTranscriberLanguage.Lb },
        { "lg", FallbackSonioxTranscriberLanguage.Lg },
        { "li", FallbackSonioxTranscriberLanguage.Li },
        { "ln", FallbackSonioxTranscriberLanguage.Ln },
        { "lo", FallbackSonioxTranscriberLanguage.Lo },
        { "lt", FallbackSonioxTranscriberLanguage.Lt },
        { "lu", FallbackSonioxTranscriberLanguage.Lu },
        { "lv", FallbackSonioxTranscriberLanguage.Lv },
        { "mg", FallbackSonioxTranscriberLanguage.Mg },
        { "mh", FallbackSonioxTranscriberLanguage.Mh },
        { "mi", FallbackSonioxTranscriberLanguage.Mi },
        { "mk", FallbackSonioxTranscriberLanguage.Mk },
        { "ml", FallbackSonioxTranscriberLanguage.Ml },
        { "mn", FallbackSonioxTranscriberLanguage.Mn },
        { "mr", FallbackSonioxTranscriberLanguage.Mr },
        { "ms", FallbackSonioxTranscriberLanguage.Ms },
        { "mt", FallbackSonioxTranscriberLanguage.Mt },
        { "my", FallbackSonioxTranscriberLanguage.My },
        { "na", FallbackSonioxTranscriberLanguage.Na },
        { "nb", FallbackSonioxTranscriberLanguage.Nb },
        { "nd", FallbackSonioxTranscriberLanguage.Nd },
        { "ne", FallbackSonioxTranscriberLanguage.Ne },
        { "ng", FallbackSonioxTranscriberLanguage.Ng },
        { "nl", FallbackSonioxTranscriberLanguage.Nl },
        { "nn", FallbackSonioxTranscriberLanguage.Nn },
        { "no", FallbackSonioxTranscriberLanguage.No },
        { "nr", FallbackSonioxTranscriberLanguage.Nr },
        { "nv", FallbackSonioxTranscriberLanguage.Nv },
        { "ny", FallbackSonioxTranscriberLanguage.Ny },
        { "oc", FallbackSonioxTranscriberLanguage.Oc },
        { "oj", FallbackSonioxTranscriberLanguage.Oj },
        { "om", FallbackSonioxTranscriberLanguage.Om },
        { "or", FallbackSonioxTranscriberLanguage.Or },
        { "os", FallbackSonioxTranscriberLanguage.Os },
        { "pa", FallbackSonioxTranscriberLanguage.Pa },
        { "pi", FallbackSonioxTranscriberLanguage.Pi },
        { "pl", FallbackSonioxTranscriberLanguage.Pl },
        { "ps", FallbackSonioxTranscriberLanguage.Ps },
        { "pt", FallbackSonioxTranscriberLanguage.Pt },
        { "qu", FallbackSonioxTranscriberLanguage.Qu },
        { "rm", FallbackSonioxTranscriberLanguage.Rm },
        { "rn", FallbackSonioxTranscriberLanguage.Rn },
        { "ro", FallbackSonioxTranscriberLanguage.Ro },
        { "ru", FallbackSonioxTranscriberLanguage.Ru },
        { "rw", FallbackSonioxTranscriberLanguage.Rw },
        { "sa", FallbackSonioxTranscriberLanguage.Sa },
        { "sc", FallbackSonioxTranscriberLanguage.Sc },
        { "sd", FallbackSonioxTranscriberLanguage.Sd },
        { "se", FallbackSonioxTranscriberLanguage.Se },
        { "sg", FallbackSonioxTranscriberLanguage.Sg },
        { "si", FallbackSonioxTranscriberLanguage.Si },
        { "sk", FallbackSonioxTranscriberLanguage.Sk },
        { "sl", FallbackSonioxTranscriberLanguage.Sl },
        { "sm", FallbackSonioxTranscriberLanguage.Sm },
        { "sn", FallbackSonioxTranscriberLanguage.Sn },
        { "so", FallbackSonioxTranscriberLanguage.So },
        { "sq", FallbackSonioxTranscriberLanguage.Sq },
        { "sr", FallbackSonioxTranscriberLanguage.Sr },
        { "ss", FallbackSonioxTranscriberLanguage.Ss },
        { "st", FallbackSonioxTranscriberLanguage.St },
        { "su", FallbackSonioxTranscriberLanguage.Su },
        { "sv", FallbackSonioxTranscriberLanguage.Sv },
        { "sw", FallbackSonioxTranscriberLanguage.Sw },
        { "ta", FallbackSonioxTranscriberLanguage.Ta },
        { "te", FallbackSonioxTranscriberLanguage.Te },
        { "tg", FallbackSonioxTranscriberLanguage.Tg },
        { "th", FallbackSonioxTranscriberLanguage.Th },
        { "ti", FallbackSonioxTranscriberLanguage.Ti },
        { "tk", FallbackSonioxTranscriberLanguage.Tk },
        { "tl", FallbackSonioxTranscriberLanguage.Tl },
        { "tn", FallbackSonioxTranscriberLanguage.Tn },
        { "to", FallbackSonioxTranscriberLanguage.To },
        { "tr", FallbackSonioxTranscriberLanguage.Tr },
        { "ts", FallbackSonioxTranscriberLanguage.Ts },
        { "tt", FallbackSonioxTranscriberLanguage.Tt },
        { "tw", FallbackSonioxTranscriberLanguage.Tw },
        { "ty", FallbackSonioxTranscriberLanguage.Ty },
        { "ug", FallbackSonioxTranscriberLanguage.Ug },
        { "uk", FallbackSonioxTranscriberLanguage.Uk },
        { "ur", FallbackSonioxTranscriberLanguage.Ur },
        { "uz", FallbackSonioxTranscriberLanguage.Uz },
        { "ve", FallbackSonioxTranscriberLanguage.Ve },
        { "vi", FallbackSonioxTranscriberLanguage.Vi },
        { "vo", FallbackSonioxTranscriberLanguage.Vo },
        { "wa", FallbackSonioxTranscriberLanguage.Wa },
        { "wo", FallbackSonioxTranscriberLanguage.Wo },
        { "xh", FallbackSonioxTranscriberLanguage.Xh },
        { "yi", FallbackSonioxTranscriberLanguage.Yi },
        { "yue", FallbackSonioxTranscriberLanguage.Yue },
        { "yo", FallbackSonioxTranscriberLanguage.Yo },
        { "za", FallbackSonioxTranscriberLanguage.Za },
        { "zh", FallbackSonioxTranscriberLanguage.Zh },
        { "zu", FallbackSonioxTranscriberLanguage.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSonioxTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackSonioxTranscriberLanguage.Aa, "aa" },
        { FallbackSonioxTranscriberLanguage.Ab, "ab" },
        { FallbackSonioxTranscriberLanguage.Ae, "ae" },
        { FallbackSonioxTranscriberLanguage.Af, "af" },
        { FallbackSonioxTranscriberLanguage.Ak, "ak" },
        { FallbackSonioxTranscriberLanguage.Am, "am" },
        { FallbackSonioxTranscriberLanguage.An, "an" },
        { FallbackSonioxTranscriberLanguage.Ar, "ar" },
        { FallbackSonioxTranscriberLanguage.As, "as" },
        { FallbackSonioxTranscriberLanguage.Av, "av" },
        { FallbackSonioxTranscriberLanguage.Ay, "ay" },
        { FallbackSonioxTranscriberLanguage.Az, "az" },
        { FallbackSonioxTranscriberLanguage.Ba, "ba" },
        { FallbackSonioxTranscriberLanguage.Be, "be" },
        { FallbackSonioxTranscriberLanguage.Bg, "bg" },
        { FallbackSonioxTranscriberLanguage.Bh, "bh" },
        { FallbackSonioxTranscriberLanguage.Bi, "bi" },
        { FallbackSonioxTranscriberLanguage.Bm, "bm" },
        { FallbackSonioxTranscriberLanguage.Bn, "bn" },
        { FallbackSonioxTranscriberLanguage.Bo, "bo" },
        { FallbackSonioxTranscriberLanguage.Br, "br" },
        { FallbackSonioxTranscriberLanguage.Bs, "bs" },
        { FallbackSonioxTranscriberLanguage.Ca, "ca" },
        { FallbackSonioxTranscriberLanguage.Ce, "ce" },
        { FallbackSonioxTranscriberLanguage.Ch, "ch" },
        { FallbackSonioxTranscriberLanguage.Co, "co" },
        { FallbackSonioxTranscriberLanguage.Cr, "cr" },
        { FallbackSonioxTranscriberLanguage.Cs, "cs" },
        { FallbackSonioxTranscriberLanguage.Cu, "cu" },
        { FallbackSonioxTranscriberLanguage.Cv, "cv" },
        { FallbackSonioxTranscriberLanguage.Cy, "cy" },
        { FallbackSonioxTranscriberLanguage.Da, "da" },
        { FallbackSonioxTranscriberLanguage.De, "de" },
        { FallbackSonioxTranscriberLanguage.Dv, "dv" },
        { FallbackSonioxTranscriberLanguage.Dz, "dz" },
        { FallbackSonioxTranscriberLanguage.Ee, "ee" },
        { FallbackSonioxTranscriberLanguage.El, "el" },
        { FallbackSonioxTranscriberLanguage.En, "en" },
        { FallbackSonioxTranscriberLanguage.Eo, "eo" },
        { FallbackSonioxTranscriberLanguage.Es, "es" },
        { FallbackSonioxTranscriberLanguage.Et, "et" },
        { FallbackSonioxTranscriberLanguage.Eu, "eu" },
        { FallbackSonioxTranscriberLanguage.Fa, "fa" },
        { FallbackSonioxTranscriberLanguage.Ff, "ff" },
        { FallbackSonioxTranscriberLanguage.Fi, "fi" },
        { FallbackSonioxTranscriberLanguage.Fj, "fj" },
        { FallbackSonioxTranscriberLanguage.Fo, "fo" },
        { FallbackSonioxTranscriberLanguage.Fr, "fr" },
        { FallbackSonioxTranscriberLanguage.Fy, "fy" },
        { FallbackSonioxTranscriberLanguage.Ga, "ga" },
        { FallbackSonioxTranscriberLanguage.Gd, "gd" },
        { FallbackSonioxTranscriberLanguage.Gl, "gl" },
        { FallbackSonioxTranscriberLanguage.Gn, "gn" },
        { FallbackSonioxTranscriberLanguage.Gu, "gu" },
        { FallbackSonioxTranscriberLanguage.Gv, "gv" },
        { FallbackSonioxTranscriberLanguage.Ha, "ha" },
        { FallbackSonioxTranscriberLanguage.He, "he" },
        { FallbackSonioxTranscriberLanguage.Hi, "hi" },
        { FallbackSonioxTranscriberLanguage.Ho, "ho" },
        { FallbackSonioxTranscriberLanguage.Hr, "hr" },
        { FallbackSonioxTranscriberLanguage.Ht, "ht" },
        { FallbackSonioxTranscriberLanguage.Hu, "hu" },
        { FallbackSonioxTranscriberLanguage.Hy, "hy" },
        { FallbackSonioxTranscriberLanguage.Hz, "hz" },
        { FallbackSonioxTranscriberLanguage.Ia, "ia" },
        { FallbackSonioxTranscriberLanguage.Id, "id" },
        { FallbackSonioxTranscriberLanguage.Ie, "ie" },
        { FallbackSonioxTranscriberLanguage.Ig, "ig" },
        { FallbackSonioxTranscriberLanguage.Ii, "ii" },
        { FallbackSonioxTranscriberLanguage.Ik, "ik" },
        { FallbackSonioxTranscriberLanguage.Io, "io" },
        { FallbackSonioxTranscriberLanguage.Is, "is" },
        { FallbackSonioxTranscriberLanguage.It, "it" },
        { FallbackSonioxTranscriberLanguage.Iu, "iu" },
        { FallbackSonioxTranscriberLanguage.Ja, "ja" },
        { FallbackSonioxTranscriberLanguage.Jv, "jv" },
        { FallbackSonioxTranscriberLanguage.Ka, "ka" },
        { FallbackSonioxTranscriberLanguage.Kg, "kg" },
        { FallbackSonioxTranscriberLanguage.Ki, "ki" },
        { FallbackSonioxTranscriberLanguage.Kj, "kj" },
        { FallbackSonioxTranscriberLanguage.Kk, "kk" },
        { FallbackSonioxTranscriberLanguage.Kl, "kl" },
        { FallbackSonioxTranscriberLanguage.Km, "km" },
        { FallbackSonioxTranscriberLanguage.Kn, "kn" },
        { FallbackSonioxTranscriberLanguage.Ko, "ko" },
        { FallbackSonioxTranscriberLanguage.Kr, "kr" },
        { FallbackSonioxTranscriberLanguage.Ks, "ks" },
        { FallbackSonioxTranscriberLanguage.Ku, "ku" },
        { FallbackSonioxTranscriberLanguage.Kv, "kv" },
        { FallbackSonioxTranscriberLanguage.Kw, "kw" },
        { FallbackSonioxTranscriberLanguage.Ky, "ky" },
        { FallbackSonioxTranscriberLanguage.La, "la" },
        { FallbackSonioxTranscriberLanguage.Lb, "lb" },
        { FallbackSonioxTranscriberLanguage.Lg, "lg" },
        { FallbackSonioxTranscriberLanguage.Li, "li" },
        { FallbackSonioxTranscriberLanguage.Ln, "ln" },
        { FallbackSonioxTranscriberLanguage.Lo, "lo" },
        { FallbackSonioxTranscriberLanguage.Lt, "lt" },
        { FallbackSonioxTranscriberLanguage.Lu, "lu" },
        { FallbackSonioxTranscriberLanguage.Lv, "lv" },
        { FallbackSonioxTranscriberLanguage.Mg, "mg" },
        { FallbackSonioxTranscriberLanguage.Mh, "mh" },
        { FallbackSonioxTranscriberLanguage.Mi, "mi" },
        { FallbackSonioxTranscriberLanguage.Mk, "mk" },
        { FallbackSonioxTranscriberLanguage.Ml, "ml" },
        { FallbackSonioxTranscriberLanguage.Mn, "mn" },
        { FallbackSonioxTranscriberLanguage.Mr, "mr" },
        { FallbackSonioxTranscriberLanguage.Ms, "ms" },
        { FallbackSonioxTranscriberLanguage.Mt, "mt" },
        { FallbackSonioxTranscriberLanguage.My, "my" },
        { FallbackSonioxTranscriberLanguage.Na, "na" },
        { FallbackSonioxTranscriberLanguage.Nb, "nb" },
        { FallbackSonioxTranscriberLanguage.Nd, "nd" },
        { FallbackSonioxTranscriberLanguage.Ne, "ne" },
        { FallbackSonioxTranscriberLanguage.Ng, "ng" },
        { FallbackSonioxTranscriberLanguage.Nl, "nl" },
        { FallbackSonioxTranscriberLanguage.Nn, "nn" },
        { FallbackSonioxTranscriberLanguage.No, "no" },
        { FallbackSonioxTranscriberLanguage.Nr, "nr" },
        { FallbackSonioxTranscriberLanguage.Nv, "nv" },
        { FallbackSonioxTranscriberLanguage.Ny, "ny" },
        { FallbackSonioxTranscriberLanguage.Oc, "oc" },
        { FallbackSonioxTranscriberLanguage.Oj, "oj" },
        { FallbackSonioxTranscriberLanguage.Om, "om" },
        { FallbackSonioxTranscriberLanguage.Or, "or" },
        { FallbackSonioxTranscriberLanguage.Os, "os" },
        { FallbackSonioxTranscriberLanguage.Pa, "pa" },
        { FallbackSonioxTranscriberLanguage.Pi, "pi" },
        { FallbackSonioxTranscriberLanguage.Pl, "pl" },
        { FallbackSonioxTranscriberLanguage.Ps, "ps" },
        { FallbackSonioxTranscriberLanguage.Pt, "pt" },
        { FallbackSonioxTranscriberLanguage.Qu, "qu" },
        { FallbackSonioxTranscriberLanguage.Rm, "rm" },
        { FallbackSonioxTranscriberLanguage.Rn, "rn" },
        { FallbackSonioxTranscriberLanguage.Ro, "ro" },
        { FallbackSonioxTranscriberLanguage.Ru, "ru" },
        { FallbackSonioxTranscriberLanguage.Rw, "rw" },
        { FallbackSonioxTranscriberLanguage.Sa, "sa" },
        { FallbackSonioxTranscriberLanguage.Sc, "sc" },
        { FallbackSonioxTranscriberLanguage.Sd, "sd" },
        { FallbackSonioxTranscriberLanguage.Se, "se" },
        { FallbackSonioxTranscriberLanguage.Sg, "sg" },
        { FallbackSonioxTranscriberLanguage.Si, "si" },
        { FallbackSonioxTranscriberLanguage.Sk, "sk" },
        { FallbackSonioxTranscriberLanguage.Sl, "sl" },
        { FallbackSonioxTranscriberLanguage.Sm, "sm" },
        { FallbackSonioxTranscriberLanguage.Sn, "sn" },
        { FallbackSonioxTranscriberLanguage.So, "so" },
        { FallbackSonioxTranscriberLanguage.Sq, "sq" },
        { FallbackSonioxTranscriberLanguage.Sr, "sr" },
        { FallbackSonioxTranscriberLanguage.Ss, "ss" },
        { FallbackSonioxTranscriberLanguage.St, "st" },
        { FallbackSonioxTranscriberLanguage.Su, "su" },
        { FallbackSonioxTranscriberLanguage.Sv, "sv" },
        { FallbackSonioxTranscriberLanguage.Sw, "sw" },
        { FallbackSonioxTranscriberLanguage.Ta, "ta" },
        { FallbackSonioxTranscriberLanguage.Te, "te" },
        { FallbackSonioxTranscriberLanguage.Tg, "tg" },
        { FallbackSonioxTranscriberLanguage.Th, "th" },
        { FallbackSonioxTranscriberLanguage.Ti, "ti" },
        { FallbackSonioxTranscriberLanguage.Tk, "tk" },
        { FallbackSonioxTranscriberLanguage.Tl, "tl" },
        { FallbackSonioxTranscriberLanguage.Tn, "tn" },
        { FallbackSonioxTranscriberLanguage.To, "to" },
        { FallbackSonioxTranscriberLanguage.Tr, "tr" },
        { FallbackSonioxTranscriberLanguage.Ts, "ts" },
        { FallbackSonioxTranscriberLanguage.Tt, "tt" },
        { FallbackSonioxTranscriberLanguage.Tw, "tw" },
        { FallbackSonioxTranscriberLanguage.Ty, "ty" },
        { FallbackSonioxTranscriberLanguage.Ug, "ug" },
        { FallbackSonioxTranscriberLanguage.Uk, "uk" },
        { FallbackSonioxTranscriberLanguage.Ur, "ur" },
        { FallbackSonioxTranscriberLanguage.Uz, "uz" },
        { FallbackSonioxTranscriberLanguage.Ve, "ve" },
        { FallbackSonioxTranscriberLanguage.Vi, "vi" },
        { FallbackSonioxTranscriberLanguage.Vo, "vo" },
        { FallbackSonioxTranscriberLanguage.Wa, "wa" },
        { FallbackSonioxTranscriberLanguage.Wo, "wo" },
        { FallbackSonioxTranscriberLanguage.Xh, "xh" },
        { FallbackSonioxTranscriberLanguage.Yi, "yi" },
        { FallbackSonioxTranscriberLanguage.Yue, "yue" },
        { FallbackSonioxTranscriberLanguage.Yo, "yo" },
        { FallbackSonioxTranscriberLanguage.Za, "za" },
        { FallbackSonioxTranscriberLanguage.Zh, "zh" },
        { FallbackSonioxTranscriberLanguage.Zu, "zu" },
    };

    public override FallbackSonioxTranscriberLanguage Read(
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
        FallbackSonioxTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSonioxTranscriberLanguage ReadAsPropertyName(
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
        FallbackSonioxTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
