using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackLmntVoiceLanguageSerializer))]
public enum FallbackLmntVoiceLanguage
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

internal class FallbackLmntVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackLmntVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackLmntVoiceLanguage
    > _stringToEnum = new()
    {
        { "aa", FallbackLmntVoiceLanguage.Aa },
        { "ab", FallbackLmntVoiceLanguage.Ab },
        { "ae", FallbackLmntVoiceLanguage.Ae },
        { "af", FallbackLmntVoiceLanguage.Af },
        { "ak", FallbackLmntVoiceLanguage.Ak },
        { "am", FallbackLmntVoiceLanguage.Am },
        { "an", FallbackLmntVoiceLanguage.An },
        { "ar", FallbackLmntVoiceLanguage.Ar },
        { "as", FallbackLmntVoiceLanguage.As },
        { "av", FallbackLmntVoiceLanguage.Av },
        { "ay", FallbackLmntVoiceLanguage.Ay },
        { "az", FallbackLmntVoiceLanguage.Az },
        { "ba", FallbackLmntVoiceLanguage.Ba },
        { "be", FallbackLmntVoiceLanguage.Be },
        { "bg", FallbackLmntVoiceLanguage.Bg },
        { "bh", FallbackLmntVoiceLanguage.Bh },
        { "bi", FallbackLmntVoiceLanguage.Bi },
        { "bm", FallbackLmntVoiceLanguage.Bm },
        { "bn", FallbackLmntVoiceLanguage.Bn },
        { "bo", FallbackLmntVoiceLanguage.Bo },
        { "br", FallbackLmntVoiceLanguage.Br },
        { "bs", FallbackLmntVoiceLanguage.Bs },
        { "ca", FallbackLmntVoiceLanguage.Ca },
        { "ce", FallbackLmntVoiceLanguage.Ce },
        { "ch", FallbackLmntVoiceLanguage.Ch },
        { "co", FallbackLmntVoiceLanguage.Co },
        { "cr", FallbackLmntVoiceLanguage.Cr },
        { "cs", FallbackLmntVoiceLanguage.Cs },
        { "cu", FallbackLmntVoiceLanguage.Cu },
        { "cv", FallbackLmntVoiceLanguage.Cv },
        { "cy", FallbackLmntVoiceLanguage.Cy },
        { "da", FallbackLmntVoiceLanguage.Da },
        { "de", FallbackLmntVoiceLanguage.De },
        { "dv", FallbackLmntVoiceLanguage.Dv },
        { "dz", FallbackLmntVoiceLanguage.Dz },
        { "ee", FallbackLmntVoiceLanguage.Ee },
        { "el", FallbackLmntVoiceLanguage.El },
        { "en", FallbackLmntVoiceLanguage.En },
        { "eo", FallbackLmntVoiceLanguage.Eo },
        { "es", FallbackLmntVoiceLanguage.Es },
        { "et", FallbackLmntVoiceLanguage.Et },
        { "eu", FallbackLmntVoiceLanguage.Eu },
        { "fa", FallbackLmntVoiceLanguage.Fa },
        { "ff", FallbackLmntVoiceLanguage.Ff },
        { "fi", FallbackLmntVoiceLanguage.Fi },
        { "fj", FallbackLmntVoiceLanguage.Fj },
        { "fo", FallbackLmntVoiceLanguage.Fo },
        { "fr", FallbackLmntVoiceLanguage.Fr },
        { "fy", FallbackLmntVoiceLanguage.Fy },
        { "ga", FallbackLmntVoiceLanguage.Ga },
        { "gd", FallbackLmntVoiceLanguage.Gd },
        { "gl", FallbackLmntVoiceLanguage.Gl },
        { "gn", FallbackLmntVoiceLanguage.Gn },
        { "gu", FallbackLmntVoiceLanguage.Gu },
        { "gv", FallbackLmntVoiceLanguage.Gv },
        { "ha", FallbackLmntVoiceLanguage.Ha },
        { "he", FallbackLmntVoiceLanguage.He },
        { "hi", FallbackLmntVoiceLanguage.Hi },
        { "ho", FallbackLmntVoiceLanguage.Ho },
        { "hr", FallbackLmntVoiceLanguage.Hr },
        { "ht", FallbackLmntVoiceLanguage.Ht },
        { "hu", FallbackLmntVoiceLanguage.Hu },
        { "hy", FallbackLmntVoiceLanguage.Hy },
        { "hz", FallbackLmntVoiceLanguage.Hz },
        { "ia", FallbackLmntVoiceLanguage.Ia },
        { "id", FallbackLmntVoiceLanguage.Id },
        { "ie", FallbackLmntVoiceLanguage.Ie },
        { "ig", FallbackLmntVoiceLanguage.Ig },
        { "ii", FallbackLmntVoiceLanguage.Ii },
        { "ik", FallbackLmntVoiceLanguage.Ik },
        { "io", FallbackLmntVoiceLanguage.Io },
        { "is", FallbackLmntVoiceLanguage.Is },
        { "it", FallbackLmntVoiceLanguage.It },
        { "iu", FallbackLmntVoiceLanguage.Iu },
        { "ja", FallbackLmntVoiceLanguage.Ja },
        { "jv", FallbackLmntVoiceLanguage.Jv },
        { "ka", FallbackLmntVoiceLanguage.Ka },
        { "kg", FallbackLmntVoiceLanguage.Kg },
        { "ki", FallbackLmntVoiceLanguage.Ki },
        { "kj", FallbackLmntVoiceLanguage.Kj },
        { "kk", FallbackLmntVoiceLanguage.Kk },
        { "kl", FallbackLmntVoiceLanguage.Kl },
        { "km", FallbackLmntVoiceLanguage.Km },
        { "kn", FallbackLmntVoiceLanguage.Kn },
        { "ko", FallbackLmntVoiceLanguage.Ko },
        { "kr", FallbackLmntVoiceLanguage.Kr },
        { "ks", FallbackLmntVoiceLanguage.Ks },
        { "ku", FallbackLmntVoiceLanguage.Ku },
        { "kv", FallbackLmntVoiceLanguage.Kv },
        { "kw", FallbackLmntVoiceLanguage.Kw },
        { "ky", FallbackLmntVoiceLanguage.Ky },
        { "la", FallbackLmntVoiceLanguage.La },
        { "lb", FallbackLmntVoiceLanguage.Lb },
        { "lg", FallbackLmntVoiceLanguage.Lg },
        { "li", FallbackLmntVoiceLanguage.Li },
        { "ln", FallbackLmntVoiceLanguage.Ln },
        { "lo", FallbackLmntVoiceLanguage.Lo },
        { "lt", FallbackLmntVoiceLanguage.Lt },
        { "lu", FallbackLmntVoiceLanguage.Lu },
        { "lv", FallbackLmntVoiceLanguage.Lv },
        { "mg", FallbackLmntVoiceLanguage.Mg },
        { "mh", FallbackLmntVoiceLanguage.Mh },
        { "mi", FallbackLmntVoiceLanguage.Mi },
        { "mk", FallbackLmntVoiceLanguage.Mk },
        { "ml", FallbackLmntVoiceLanguage.Ml },
        { "mn", FallbackLmntVoiceLanguage.Mn },
        { "mr", FallbackLmntVoiceLanguage.Mr },
        { "ms", FallbackLmntVoiceLanguage.Ms },
        { "mt", FallbackLmntVoiceLanguage.Mt },
        { "my", FallbackLmntVoiceLanguage.My },
        { "na", FallbackLmntVoiceLanguage.Na },
        { "nb", FallbackLmntVoiceLanguage.Nb },
        { "nd", FallbackLmntVoiceLanguage.Nd },
        { "ne", FallbackLmntVoiceLanguage.Ne },
        { "ng", FallbackLmntVoiceLanguage.Ng },
        { "nl", FallbackLmntVoiceLanguage.Nl },
        { "nn", FallbackLmntVoiceLanguage.Nn },
        { "no", FallbackLmntVoiceLanguage.No },
        { "nr", FallbackLmntVoiceLanguage.Nr },
        { "nv", FallbackLmntVoiceLanguage.Nv },
        { "ny", FallbackLmntVoiceLanguage.Ny },
        { "oc", FallbackLmntVoiceLanguage.Oc },
        { "oj", FallbackLmntVoiceLanguage.Oj },
        { "om", FallbackLmntVoiceLanguage.Om },
        { "or", FallbackLmntVoiceLanguage.Or },
        { "os", FallbackLmntVoiceLanguage.Os },
        { "pa", FallbackLmntVoiceLanguage.Pa },
        { "pi", FallbackLmntVoiceLanguage.Pi },
        { "pl", FallbackLmntVoiceLanguage.Pl },
        { "ps", FallbackLmntVoiceLanguage.Ps },
        { "pt", FallbackLmntVoiceLanguage.Pt },
        { "qu", FallbackLmntVoiceLanguage.Qu },
        { "rm", FallbackLmntVoiceLanguage.Rm },
        { "rn", FallbackLmntVoiceLanguage.Rn },
        { "ro", FallbackLmntVoiceLanguage.Ro },
        { "ru", FallbackLmntVoiceLanguage.Ru },
        { "rw", FallbackLmntVoiceLanguage.Rw },
        { "sa", FallbackLmntVoiceLanguage.Sa },
        { "sc", FallbackLmntVoiceLanguage.Sc },
        { "sd", FallbackLmntVoiceLanguage.Sd },
        { "se", FallbackLmntVoiceLanguage.Se },
        { "sg", FallbackLmntVoiceLanguage.Sg },
        { "si", FallbackLmntVoiceLanguage.Si },
        { "sk", FallbackLmntVoiceLanguage.Sk },
        { "sl", FallbackLmntVoiceLanguage.Sl },
        { "sm", FallbackLmntVoiceLanguage.Sm },
        { "sn", FallbackLmntVoiceLanguage.Sn },
        { "so", FallbackLmntVoiceLanguage.So },
        { "sq", FallbackLmntVoiceLanguage.Sq },
        { "sr", FallbackLmntVoiceLanguage.Sr },
        { "ss", FallbackLmntVoiceLanguage.Ss },
        { "st", FallbackLmntVoiceLanguage.St },
        { "su", FallbackLmntVoiceLanguage.Su },
        { "sv", FallbackLmntVoiceLanguage.Sv },
        { "sw", FallbackLmntVoiceLanguage.Sw },
        { "ta", FallbackLmntVoiceLanguage.Ta },
        { "te", FallbackLmntVoiceLanguage.Te },
        { "tg", FallbackLmntVoiceLanguage.Tg },
        { "th", FallbackLmntVoiceLanguage.Th },
        { "ti", FallbackLmntVoiceLanguage.Ti },
        { "tk", FallbackLmntVoiceLanguage.Tk },
        { "tl", FallbackLmntVoiceLanguage.Tl },
        { "tn", FallbackLmntVoiceLanguage.Tn },
        { "to", FallbackLmntVoiceLanguage.To },
        { "tr", FallbackLmntVoiceLanguage.Tr },
        { "ts", FallbackLmntVoiceLanguage.Ts },
        { "tt", FallbackLmntVoiceLanguage.Tt },
        { "tw", FallbackLmntVoiceLanguage.Tw },
        { "ty", FallbackLmntVoiceLanguage.Ty },
        { "ug", FallbackLmntVoiceLanguage.Ug },
        { "uk", FallbackLmntVoiceLanguage.Uk },
        { "ur", FallbackLmntVoiceLanguage.Ur },
        { "uz", FallbackLmntVoiceLanguage.Uz },
        { "ve", FallbackLmntVoiceLanguage.Ve },
        { "vi", FallbackLmntVoiceLanguage.Vi },
        { "vo", FallbackLmntVoiceLanguage.Vo },
        { "wa", FallbackLmntVoiceLanguage.Wa },
        { "wo", FallbackLmntVoiceLanguage.Wo },
        { "xh", FallbackLmntVoiceLanguage.Xh },
        { "yi", FallbackLmntVoiceLanguage.Yi },
        { "yue", FallbackLmntVoiceLanguage.Yue },
        { "yo", FallbackLmntVoiceLanguage.Yo },
        { "za", FallbackLmntVoiceLanguage.Za },
        { "zh", FallbackLmntVoiceLanguage.Zh },
        { "zu", FallbackLmntVoiceLanguage.Zu },
        { "auto", FallbackLmntVoiceLanguage.Auto },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackLmntVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackLmntVoiceLanguage.Aa, "aa" },
        { FallbackLmntVoiceLanguage.Ab, "ab" },
        { FallbackLmntVoiceLanguage.Ae, "ae" },
        { FallbackLmntVoiceLanguage.Af, "af" },
        { FallbackLmntVoiceLanguage.Ak, "ak" },
        { FallbackLmntVoiceLanguage.Am, "am" },
        { FallbackLmntVoiceLanguage.An, "an" },
        { FallbackLmntVoiceLanguage.Ar, "ar" },
        { FallbackLmntVoiceLanguage.As, "as" },
        { FallbackLmntVoiceLanguage.Av, "av" },
        { FallbackLmntVoiceLanguage.Ay, "ay" },
        { FallbackLmntVoiceLanguage.Az, "az" },
        { FallbackLmntVoiceLanguage.Ba, "ba" },
        { FallbackLmntVoiceLanguage.Be, "be" },
        { FallbackLmntVoiceLanguage.Bg, "bg" },
        { FallbackLmntVoiceLanguage.Bh, "bh" },
        { FallbackLmntVoiceLanguage.Bi, "bi" },
        { FallbackLmntVoiceLanguage.Bm, "bm" },
        { FallbackLmntVoiceLanguage.Bn, "bn" },
        { FallbackLmntVoiceLanguage.Bo, "bo" },
        { FallbackLmntVoiceLanguage.Br, "br" },
        { FallbackLmntVoiceLanguage.Bs, "bs" },
        { FallbackLmntVoiceLanguage.Ca, "ca" },
        { FallbackLmntVoiceLanguage.Ce, "ce" },
        { FallbackLmntVoiceLanguage.Ch, "ch" },
        { FallbackLmntVoiceLanguage.Co, "co" },
        { FallbackLmntVoiceLanguage.Cr, "cr" },
        { FallbackLmntVoiceLanguage.Cs, "cs" },
        { FallbackLmntVoiceLanguage.Cu, "cu" },
        { FallbackLmntVoiceLanguage.Cv, "cv" },
        { FallbackLmntVoiceLanguage.Cy, "cy" },
        { FallbackLmntVoiceLanguage.Da, "da" },
        { FallbackLmntVoiceLanguage.De, "de" },
        { FallbackLmntVoiceLanguage.Dv, "dv" },
        { FallbackLmntVoiceLanguage.Dz, "dz" },
        { FallbackLmntVoiceLanguage.Ee, "ee" },
        { FallbackLmntVoiceLanguage.El, "el" },
        { FallbackLmntVoiceLanguage.En, "en" },
        { FallbackLmntVoiceLanguage.Eo, "eo" },
        { FallbackLmntVoiceLanguage.Es, "es" },
        { FallbackLmntVoiceLanguage.Et, "et" },
        { FallbackLmntVoiceLanguage.Eu, "eu" },
        { FallbackLmntVoiceLanguage.Fa, "fa" },
        { FallbackLmntVoiceLanguage.Ff, "ff" },
        { FallbackLmntVoiceLanguage.Fi, "fi" },
        { FallbackLmntVoiceLanguage.Fj, "fj" },
        { FallbackLmntVoiceLanguage.Fo, "fo" },
        { FallbackLmntVoiceLanguage.Fr, "fr" },
        { FallbackLmntVoiceLanguage.Fy, "fy" },
        { FallbackLmntVoiceLanguage.Ga, "ga" },
        { FallbackLmntVoiceLanguage.Gd, "gd" },
        { FallbackLmntVoiceLanguage.Gl, "gl" },
        { FallbackLmntVoiceLanguage.Gn, "gn" },
        { FallbackLmntVoiceLanguage.Gu, "gu" },
        { FallbackLmntVoiceLanguage.Gv, "gv" },
        { FallbackLmntVoiceLanguage.Ha, "ha" },
        { FallbackLmntVoiceLanguage.He, "he" },
        { FallbackLmntVoiceLanguage.Hi, "hi" },
        { FallbackLmntVoiceLanguage.Ho, "ho" },
        { FallbackLmntVoiceLanguage.Hr, "hr" },
        { FallbackLmntVoiceLanguage.Ht, "ht" },
        { FallbackLmntVoiceLanguage.Hu, "hu" },
        { FallbackLmntVoiceLanguage.Hy, "hy" },
        { FallbackLmntVoiceLanguage.Hz, "hz" },
        { FallbackLmntVoiceLanguage.Ia, "ia" },
        { FallbackLmntVoiceLanguage.Id, "id" },
        { FallbackLmntVoiceLanguage.Ie, "ie" },
        { FallbackLmntVoiceLanguage.Ig, "ig" },
        { FallbackLmntVoiceLanguage.Ii, "ii" },
        { FallbackLmntVoiceLanguage.Ik, "ik" },
        { FallbackLmntVoiceLanguage.Io, "io" },
        { FallbackLmntVoiceLanguage.Is, "is" },
        { FallbackLmntVoiceLanguage.It, "it" },
        { FallbackLmntVoiceLanguage.Iu, "iu" },
        { FallbackLmntVoiceLanguage.Ja, "ja" },
        { FallbackLmntVoiceLanguage.Jv, "jv" },
        { FallbackLmntVoiceLanguage.Ka, "ka" },
        { FallbackLmntVoiceLanguage.Kg, "kg" },
        { FallbackLmntVoiceLanguage.Ki, "ki" },
        { FallbackLmntVoiceLanguage.Kj, "kj" },
        { FallbackLmntVoiceLanguage.Kk, "kk" },
        { FallbackLmntVoiceLanguage.Kl, "kl" },
        { FallbackLmntVoiceLanguage.Km, "km" },
        { FallbackLmntVoiceLanguage.Kn, "kn" },
        { FallbackLmntVoiceLanguage.Ko, "ko" },
        { FallbackLmntVoiceLanguage.Kr, "kr" },
        { FallbackLmntVoiceLanguage.Ks, "ks" },
        { FallbackLmntVoiceLanguage.Ku, "ku" },
        { FallbackLmntVoiceLanguage.Kv, "kv" },
        { FallbackLmntVoiceLanguage.Kw, "kw" },
        { FallbackLmntVoiceLanguage.Ky, "ky" },
        { FallbackLmntVoiceLanguage.La, "la" },
        { FallbackLmntVoiceLanguage.Lb, "lb" },
        { FallbackLmntVoiceLanguage.Lg, "lg" },
        { FallbackLmntVoiceLanguage.Li, "li" },
        { FallbackLmntVoiceLanguage.Ln, "ln" },
        { FallbackLmntVoiceLanguage.Lo, "lo" },
        { FallbackLmntVoiceLanguage.Lt, "lt" },
        { FallbackLmntVoiceLanguage.Lu, "lu" },
        { FallbackLmntVoiceLanguage.Lv, "lv" },
        { FallbackLmntVoiceLanguage.Mg, "mg" },
        { FallbackLmntVoiceLanguage.Mh, "mh" },
        { FallbackLmntVoiceLanguage.Mi, "mi" },
        { FallbackLmntVoiceLanguage.Mk, "mk" },
        { FallbackLmntVoiceLanguage.Ml, "ml" },
        { FallbackLmntVoiceLanguage.Mn, "mn" },
        { FallbackLmntVoiceLanguage.Mr, "mr" },
        { FallbackLmntVoiceLanguage.Ms, "ms" },
        { FallbackLmntVoiceLanguage.Mt, "mt" },
        { FallbackLmntVoiceLanguage.My, "my" },
        { FallbackLmntVoiceLanguage.Na, "na" },
        { FallbackLmntVoiceLanguage.Nb, "nb" },
        { FallbackLmntVoiceLanguage.Nd, "nd" },
        { FallbackLmntVoiceLanguage.Ne, "ne" },
        { FallbackLmntVoiceLanguage.Ng, "ng" },
        { FallbackLmntVoiceLanguage.Nl, "nl" },
        { FallbackLmntVoiceLanguage.Nn, "nn" },
        { FallbackLmntVoiceLanguage.No, "no" },
        { FallbackLmntVoiceLanguage.Nr, "nr" },
        { FallbackLmntVoiceLanguage.Nv, "nv" },
        { FallbackLmntVoiceLanguage.Ny, "ny" },
        { FallbackLmntVoiceLanguage.Oc, "oc" },
        { FallbackLmntVoiceLanguage.Oj, "oj" },
        { FallbackLmntVoiceLanguage.Om, "om" },
        { FallbackLmntVoiceLanguage.Or, "or" },
        { FallbackLmntVoiceLanguage.Os, "os" },
        { FallbackLmntVoiceLanguage.Pa, "pa" },
        { FallbackLmntVoiceLanguage.Pi, "pi" },
        { FallbackLmntVoiceLanguage.Pl, "pl" },
        { FallbackLmntVoiceLanguage.Ps, "ps" },
        { FallbackLmntVoiceLanguage.Pt, "pt" },
        { FallbackLmntVoiceLanguage.Qu, "qu" },
        { FallbackLmntVoiceLanguage.Rm, "rm" },
        { FallbackLmntVoiceLanguage.Rn, "rn" },
        { FallbackLmntVoiceLanguage.Ro, "ro" },
        { FallbackLmntVoiceLanguage.Ru, "ru" },
        { FallbackLmntVoiceLanguage.Rw, "rw" },
        { FallbackLmntVoiceLanguage.Sa, "sa" },
        { FallbackLmntVoiceLanguage.Sc, "sc" },
        { FallbackLmntVoiceLanguage.Sd, "sd" },
        { FallbackLmntVoiceLanguage.Se, "se" },
        { FallbackLmntVoiceLanguage.Sg, "sg" },
        { FallbackLmntVoiceLanguage.Si, "si" },
        { FallbackLmntVoiceLanguage.Sk, "sk" },
        { FallbackLmntVoiceLanguage.Sl, "sl" },
        { FallbackLmntVoiceLanguage.Sm, "sm" },
        { FallbackLmntVoiceLanguage.Sn, "sn" },
        { FallbackLmntVoiceLanguage.So, "so" },
        { FallbackLmntVoiceLanguage.Sq, "sq" },
        { FallbackLmntVoiceLanguage.Sr, "sr" },
        { FallbackLmntVoiceLanguage.Ss, "ss" },
        { FallbackLmntVoiceLanguage.St, "st" },
        { FallbackLmntVoiceLanguage.Su, "su" },
        { FallbackLmntVoiceLanguage.Sv, "sv" },
        { FallbackLmntVoiceLanguage.Sw, "sw" },
        { FallbackLmntVoiceLanguage.Ta, "ta" },
        { FallbackLmntVoiceLanguage.Te, "te" },
        { FallbackLmntVoiceLanguage.Tg, "tg" },
        { FallbackLmntVoiceLanguage.Th, "th" },
        { FallbackLmntVoiceLanguage.Ti, "ti" },
        { FallbackLmntVoiceLanguage.Tk, "tk" },
        { FallbackLmntVoiceLanguage.Tl, "tl" },
        { FallbackLmntVoiceLanguage.Tn, "tn" },
        { FallbackLmntVoiceLanguage.To, "to" },
        { FallbackLmntVoiceLanguage.Tr, "tr" },
        { FallbackLmntVoiceLanguage.Ts, "ts" },
        { FallbackLmntVoiceLanguage.Tt, "tt" },
        { FallbackLmntVoiceLanguage.Tw, "tw" },
        { FallbackLmntVoiceLanguage.Ty, "ty" },
        { FallbackLmntVoiceLanguage.Ug, "ug" },
        { FallbackLmntVoiceLanguage.Uk, "uk" },
        { FallbackLmntVoiceLanguage.Ur, "ur" },
        { FallbackLmntVoiceLanguage.Uz, "uz" },
        { FallbackLmntVoiceLanguage.Ve, "ve" },
        { FallbackLmntVoiceLanguage.Vi, "vi" },
        { FallbackLmntVoiceLanguage.Vo, "vo" },
        { FallbackLmntVoiceLanguage.Wa, "wa" },
        { FallbackLmntVoiceLanguage.Wo, "wo" },
        { FallbackLmntVoiceLanguage.Xh, "xh" },
        { FallbackLmntVoiceLanguage.Yi, "yi" },
        { FallbackLmntVoiceLanguage.Yue, "yue" },
        { FallbackLmntVoiceLanguage.Yo, "yo" },
        { FallbackLmntVoiceLanguage.Za, "za" },
        { FallbackLmntVoiceLanguage.Zh, "zh" },
        { FallbackLmntVoiceLanguage.Zu, "zu" },
        { FallbackLmntVoiceLanguage.Auto, "auto" },
    };

    public override FallbackLmntVoiceLanguage Read(
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
        FallbackLmntVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackLmntVoiceLanguage ReadAsPropertyName(
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
        FallbackLmntVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
