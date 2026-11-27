using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsTranscriberLanguagesItemSerializer))]
public enum ElevenLabsTranscriberLanguagesItem
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

internal class ElevenLabsTranscriberLanguagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsTranscriberLanguagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsTranscriberLanguagesItem
    > _stringToEnum = new()
    {
        { "aa", ElevenLabsTranscriberLanguagesItem.Aa },
        { "ab", ElevenLabsTranscriberLanguagesItem.Ab },
        { "ae", ElevenLabsTranscriberLanguagesItem.Ae },
        { "af", ElevenLabsTranscriberLanguagesItem.Af },
        { "ak", ElevenLabsTranscriberLanguagesItem.Ak },
        { "am", ElevenLabsTranscriberLanguagesItem.Am },
        { "an", ElevenLabsTranscriberLanguagesItem.An },
        { "ar", ElevenLabsTranscriberLanguagesItem.Ar },
        { "as", ElevenLabsTranscriberLanguagesItem.As },
        { "av", ElevenLabsTranscriberLanguagesItem.Av },
        { "ay", ElevenLabsTranscriberLanguagesItem.Ay },
        { "az", ElevenLabsTranscriberLanguagesItem.Az },
        { "ba", ElevenLabsTranscriberLanguagesItem.Ba },
        { "be", ElevenLabsTranscriberLanguagesItem.Be },
        { "bg", ElevenLabsTranscriberLanguagesItem.Bg },
        { "bh", ElevenLabsTranscriberLanguagesItem.Bh },
        { "bi", ElevenLabsTranscriberLanguagesItem.Bi },
        { "bm", ElevenLabsTranscriberLanguagesItem.Bm },
        { "bn", ElevenLabsTranscriberLanguagesItem.Bn },
        { "bo", ElevenLabsTranscriberLanguagesItem.Bo },
        { "br", ElevenLabsTranscriberLanguagesItem.Br },
        { "bs", ElevenLabsTranscriberLanguagesItem.Bs },
        { "ca", ElevenLabsTranscriberLanguagesItem.Ca },
        { "ce", ElevenLabsTranscriberLanguagesItem.Ce },
        { "ch", ElevenLabsTranscriberLanguagesItem.Ch },
        { "co", ElevenLabsTranscriberLanguagesItem.Co },
        { "cr", ElevenLabsTranscriberLanguagesItem.Cr },
        { "cs", ElevenLabsTranscriberLanguagesItem.Cs },
        { "cu", ElevenLabsTranscriberLanguagesItem.Cu },
        { "cv", ElevenLabsTranscriberLanguagesItem.Cv },
        { "cy", ElevenLabsTranscriberLanguagesItem.Cy },
        { "da", ElevenLabsTranscriberLanguagesItem.Da },
        { "de", ElevenLabsTranscriberLanguagesItem.De },
        { "dv", ElevenLabsTranscriberLanguagesItem.Dv },
        { "dz", ElevenLabsTranscriberLanguagesItem.Dz },
        { "ee", ElevenLabsTranscriberLanguagesItem.Ee },
        { "el", ElevenLabsTranscriberLanguagesItem.El },
        { "en", ElevenLabsTranscriberLanguagesItem.En },
        { "eo", ElevenLabsTranscriberLanguagesItem.Eo },
        { "es", ElevenLabsTranscriberLanguagesItem.Es },
        { "et", ElevenLabsTranscriberLanguagesItem.Et },
        { "eu", ElevenLabsTranscriberLanguagesItem.Eu },
        { "fa", ElevenLabsTranscriberLanguagesItem.Fa },
        { "ff", ElevenLabsTranscriberLanguagesItem.Ff },
        { "fi", ElevenLabsTranscriberLanguagesItem.Fi },
        { "fj", ElevenLabsTranscriberLanguagesItem.Fj },
        { "fo", ElevenLabsTranscriberLanguagesItem.Fo },
        { "fr", ElevenLabsTranscriberLanguagesItem.Fr },
        { "fy", ElevenLabsTranscriberLanguagesItem.Fy },
        { "ga", ElevenLabsTranscriberLanguagesItem.Ga },
        { "gd", ElevenLabsTranscriberLanguagesItem.Gd },
        { "gl", ElevenLabsTranscriberLanguagesItem.Gl },
        { "gn", ElevenLabsTranscriberLanguagesItem.Gn },
        { "gu", ElevenLabsTranscriberLanguagesItem.Gu },
        { "gv", ElevenLabsTranscriberLanguagesItem.Gv },
        { "ha", ElevenLabsTranscriberLanguagesItem.Ha },
        { "he", ElevenLabsTranscriberLanguagesItem.He },
        { "hi", ElevenLabsTranscriberLanguagesItem.Hi },
        { "ho", ElevenLabsTranscriberLanguagesItem.Ho },
        { "hr", ElevenLabsTranscriberLanguagesItem.Hr },
        { "ht", ElevenLabsTranscriberLanguagesItem.Ht },
        { "hu", ElevenLabsTranscriberLanguagesItem.Hu },
        { "hy", ElevenLabsTranscriberLanguagesItem.Hy },
        { "hz", ElevenLabsTranscriberLanguagesItem.Hz },
        { "ia", ElevenLabsTranscriberLanguagesItem.Ia },
        { "id", ElevenLabsTranscriberLanguagesItem.Id },
        { "ie", ElevenLabsTranscriberLanguagesItem.Ie },
        { "ig", ElevenLabsTranscriberLanguagesItem.Ig },
        { "ii", ElevenLabsTranscriberLanguagesItem.Ii },
        { "ik", ElevenLabsTranscriberLanguagesItem.Ik },
        { "io", ElevenLabsTranscriberLanguagesItem.Io },
        { "is", ElevenLabsTranscriberLanguagesItem.Is },
        { "it", ElevenLabsTranscriberLanguagesItem.It },
        { "iu", ElevenLabsTranscriberLanguagesItem.Iu },
        { "ja", ElevenLabsTranscriberLanguagesItem.Ja },
        { "jv", ElevenLabsTranscriberLanguagesItem.Jv },
        { "ka", ElevenLabsTranscriberLanguagesItem.Ka },
        { "kg", ElevenLabsTranscriberLanguagesItem.Kg },
        { "ki", ElevenLabsTranscriberLanguagesItem.Ki },
        { "kj", ElevenLabsTranscriberLanguagesItem.Kj },
        { "kk", ElevenLabsTranscriberLanguagesItem.Kk },
        { "kl", ElevenLabsTranscriberLanguagesItem.Kl },
        { "km", ElevenLabsTranscriberLanguagesItem.Km },
        { "kn", ElevenLabsTranscriberLanguagesItem.Kn },
        { "ko", ElevenLabsTranscriberLanguagesItem.Ko },
        { "kr", ElevenLabsTranscriberLanguagesItem.Kr },
        { "ks", ElevenLabsTranscriberLanguagesItem.Ks },
        { "ku", ElevenLabsTranscriberLanguagesItem.Ku },
        { "kv", ElevenLabsTranscriberLanguagesItem.Kv },
        { "kw", ElevenLabsTranscriberLanguagesItem.Kw },
        { "ky", ElevenLabsTranscriberLanguagesItem.Ky },
        { "la", ElevenLabsTranscriberLanguagesItem.La },
        { "lb", ElevenLabsTranscriberLanguagesItem.Lb },
        { "lg", ElevenLabsTranscriberLanguagesItem.Lg },
        { "li", ElevenLabsTranscriberLanguagesItem.Li },
        { "ln", ElevenLabsTranscriberLanguagesItem.Ln },
        { "lo", ElevenLabsTranscriberLanguagesItem.Lo },
        { "lt", ElevenLabsTranscriberLanguagesItem.Lt },
        { "lu", ElevenLabsTranscriberLanguagesItem.Lu },
        { "lv", ElevenLabsTranscriberLanguagesItem.Lv },
        { "mg", ElevenLabsTranscriberLanguagesItem.Mg },
        { "mh", ElevenLabsTranscriberLanguagesItem.Mh },
        { "mi", ElevenLabsTranscriberLanguagesItem.Mi },
        { "mk", ElevenLabsTranscriberLanguagesItem.Mk },
        { "ml", ElevenLabsTranscriberLanguagesItem.Ml },
        { "mn", ElevenLabsTranscriberLanguagesItem.Mn },
        { "mr", ElevenLabsTranscriberLanguagesItem.Mr },
        { "ms", ElevenLabsTranscriberLanguagesItem.Ms },
        { "mt", ElevenLabsTranscriberLanguagesItem.Mt },
        { "my", ElevenLabsTranscriberLanguagesItem.My },
        { "na", ElevenLabsTranscriberLanguagesItem.Na },
        { "nb", ElevenLabsTranscriberLanguagesItem.Nb },
        { "nd", ElevenLabsTranscriberLanguagesItem.Nd },
        { "ne", ElevenLabsTranscriberLanguagesItem.Ne },
        { "ng", ElevenLabsTranscriberLanguagesItem.Ng },
        { "nl", ElevenLabsTranscriberLanguagesItem.Nl },
        { "nn", ElevenLabsTranscriberLanguagesItem.Nn },
        { "no", ElevenLabsTranscriberLanguagesItem.No },
        { "nr", ElevenLabsTranscriberLanguagesItem.Nr },
        { "nv", ElevenLabsTranscriberLanguagesItem.Nv },
        { "ny", ElevenLabsTranscriberLanguagesItem.Ny },
        { "oc", ElevenLabsTranscriberLanguagesItem.Oc },
        { "oj", ElevenLabsTranscriberLanguagesItem.Oj },
        { "om", ElevenLabsTranscriberLanguagesItem.Om },
        { "or", ElevenLabsTranscriberLanguagesItem.Or },
        { "os", ElevenLabsTranscriberLanguagesItem.Os },
        { "pa", ElevenLabsTranscriberLanguagesItem.Pa },
        { "pi", ElevenLabsTranscriberLanguagesItem.Pi },
        { "pl", ElevenLabsTranscriberLanguagesItem.Pl },
        { "ps", ElevenLabsTranscriberLanguagesItem.Ps },
        { "pt", ElevenLabsTranscriberLanguagesItem.Pt },
        { "qu", ElevenLabsTranscriberLanguagesItem.Qu },
        { "rm", ElevenLabsTranscriberLanguagesItem.Rm },
        { "rn", ElevenLabsTranscriberLanguagesItem.Rn },
        { "ro", ElevenLabsTranscriberLanguagesItem.Ro },
        { "ru", ElevenLabsTranscriberLanguagesItem.Ru },
        { "rw", ElevenLabsTranscriberLanguagesItem.Rw },
        { "sa", ElevenLabsTranscriberLanguagesItem.Sa },
        { "sc", ElevenLabsTranscriberLanguagesItem.Sc },
        { "sd", ElevenLabsTranscriberLanguagesItem.Sd },
        { "se", ElevenLabsTranscriberLanguagesItem.Se },
        { "sg", ElevenLabsTranscriberLanguagesItem.Sg },
        { "si", ElevenLabsTranscriberLanguagesItem.Si },
        { "sk", ElevenLabsTranscriberLanguagesItem.Sk },
        { "sl", ElevenLabsTranscriberLanguagesItem.Sl },
        { "sm", ElevenLabsTranscriberLanguagesItem.Sm },
        { "sn", ElevenLabsTranscriberLanguagesItem.Sn },
        { "so", ElevenLabsTranscriberLanguagesItem.So },
        { "sq", ElevenLabsTranscriberLanguagesItem.Sq },
        { "sr", ElevenLabsTranscriberLanguagesItem.Sr },
        { "ss", ElevenLabsTranscriberLanguagesItem.Ss },
        { "st", ElevenLabsTranscriberLanguagesItem.St },
        { "su", ElevenLabsTranscriberLanguagesItem.Su },
        { "sv", ElevenLabsTranscriberLanguagesItem.Sv },
        { "sw", ElevenLabsTranscriberLanguagesItem.Sw },
        { "ta", ElevenLabsTranscriberLanguagesItem.Ta },
        { "te", ElevenLabsTranscriberLanguagesItem.Te },
        { "tg", ElevenLabsTranscriberLanguagesItem.Tg },
        { "th", ElevenLabsTranscriberLanguagesItem.Th },
        { "ti", ElevenLabsTranscriberLanguagesItem.Ti },
        { "tk", ElevenLabsTranscriberLanguagesItem.Tk },
        { "tl", ElevenLabsTranscriberLanguagesItem.Tl },
        { "tn", ElevenLabsTranscriberLanguagesItem.Tn },
        { "to", ElevenLabsTranscriberLanguagesItem.To },
        { "tr", ElevenLabsTranscriberLanguagesItem.Tr },
        { "ts", ElevenLabsTranscriberLanguagesItem.Ts },
        { "tt", ElevenLabsTranscriberLanguagesItem.Tt },
        { "tw", ElevenLabsTranscriberLanguagesItem.Tw },
        { "ty", ElevenLabsTranscriberLanguagesItem.Ty },
        { "ug", ElevenLabsTranscriberLanguagesItem.Ug },
        { "uk", ElevenLabsTranscriberLanguagesItem.Uk },
        { "ur", ElevenLabsTranscriberLanguagesItem.Ur },
        { "uz", ElevenLabsTranscriberLanguagesItem.Uz },
        { "ve", ElevenLabsTranscriberLanguagesItem.Ve },
        { "vi", ElevenLabsTranscriberLanguagesItem.Vi },
        { "vo", ElevenLabsTranscriberLanguagesItem.Vo },
        { "wa", ElevenLabsTranscriberLanguagesItem.Wa },
        { "wo", ElevenLabsTranscriberLanguagesItem.Wo },
        { "xh", ElevenLabsTranscriberLanguagesItem.Xh },
        { "yi", ElevenLabsTranscriberLanguagesItem.Yi },
        { "yue", ElevenLabsTranscriberLanguagesItem.Yue },
        { "yo", ElevenLabsTranscriberLanguagesItem.Yo },
        { "za", ElevenLabsTranscriberLanguagesItem.Za },
        { "zh", ElevenLabsTranscriberLanguagesItem.Zh },
        { "zu", ElevenLabsTranscriberLanguagesItem.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsTranscriberLanguagesItem,
        string
    > _enumToString = new()
    {
        { ElevenLabsTranscriberLanguagesItem.Aa, "aa" },
        { ElevenLabsTranscriberLanguagesItem.Ab, "ab" },
        { ElevenLabsTranscriberLanguagesItem.Ae, "ae" },
        { ElevenLabsTranscriberLanguagesItem.Af, "af" },
        { ElevenLabsTranscriberLanguagesItem.Ak, "ak" },
        { ElevenLabsTranscriberLanguagesItem.Am, "am" },
        { ElevenLabsTranscriberLanguagesItem.An, "an" },
        { ElevenLabsTranscriberLanguagesItem.Ar, "ar" },
        { ElevenLabsTranscriberLanguagesItem.As, "as" },
        { ElevenLabsTranscriberLanguagesItem.Av, "av" },
        { ElevenLabsTranscriberLanguagesItem.Ay, "ay" },
        { ElevenLabsTranscriberLanguagesItem.Az, "az" },
        { ElevenLabsTranscriberLanguagesItem.Ba, "ba" },
        { ElevenLabsTranscriberLanguagesItem.Be, "be" },
        { ElevenLabsTranscriberLanguagesItem.Bg, "bg" },
        { ElevenLabsTranscriberLanguagesItem.Bh, "bh" },
        { ElevenLabsTranscriberLanguagesItem.Bi, "bi" },
        { ElevenLabsTranscriberLanguagesItem.Bm, "bm" },
        { ElevenLabsTranscriberLanguagesItem.Bn, "bn" },
        { ElevenLabsTranscriberLanguagesItem.Bo, "bo" },
        { ElevenLabsTranscriberLanguagesItem.Br, "br" },
        { ElevenLabsTranscriberLanguagesItem.Bs, "bs" },
        { ElevenLabsTranscriberLanguagesItem.Ca, "ca" },
        { ElevenLabsTranscriberLanguagesItem.Ce, "ce" },
        { ElevenLabsTranscriberLanguagesItem.Ch, "ch" },
        { ElevenLabsTranscriberLanguagesItem.Co, "co" },
        { ElevenLabsTranscriberLanguagesItem.Cr, "cr" },
        { ElevenLabsTranscriberLanguagesItem.Cs, "cs" },
        { ElevenLabsTranscriberLanguagesItem.Cu, "cu" },
        { ElevenLabsTranscriberLanguagesItem.Cv, "cv" },
        { ElevenLabsTranscriberLanguagesItem.Cy, "cy" },
        { ElevenLabsTranscriberLanguagesItem.Da, "da" },
        { ElevenLabsTranscriberLanguagesItem.De, "de" },
        { ElevenLabsTranscriberLanguagesItem.Dv, "dv" },
        { ElevenLabsTranscriberLanguagesItem.Dz, "dz" },
        { ElevenLabsTranscriberLanguagesItem.Ee, "ee" },
        { ElevenLabsTranscriberLanguagesItem.El, "el" },
        { ElevenLabsTranscriberLanguagesItem.En, "en" },
        { ElevenLabsTranscriberLanguagesItem.Eo, "eo" },
        { ElevenLabsTranscriberLanguagesItem.Es, "es" },
        { ElevenLabsTranscriberLanguagesItem.Et, "et" },
        { ElevenLabsTranscriberLanguagesItem.Eu, "eu" },
        { ElevenLabsTranscriberLanguagesItem.Fa, "fa" },
        { ElevenLabsTranscriberLanguagesItem.Ff, "ff" },
        { ElevenLabsTranscriberLanguagesItem.Fi, "fi" },
        { ElevenLabsTranscriberLanguagesItem.Fj, "fj" },
        { ElevenLabsTranscriberLanguagesItem.Fo, "fo" },
        { ElevenLabsTranscriberLanguagesItem.Fr, "fr" },
        { ElevenLabsTranscriberLanguagesItem.Fy, "fy" },
        { ElevenLabsTranscriberLanguagesItem.Ga, "ga" },
        { ElevenLabsTranscriberLanguagesItem.Gd, "gd" },
        { ElevenLabsTranscriberLanguagesItem.Gl, "gl" },
        { ElevenLabsTranscriberLanguagesItem.Gn, "gn" },
        { ElevenLabsTranscriberLanguagesItem.Gu, "gu" },
        { ElevenLabsTranscriberLanguagesItem.Gv, "gv" },
        { ElevenLabsTranscriberLanguagesItem.Ha, "ha" },
        { ElevenLabsTranscriberLanguagesItem.He, "he" },
        { ElevenLabsTranscriberLanguagesItem.Hi, "hi" },
        { ElevenLabsTranscriberLanguagesItem.Ho, "ho" },
        { ElevenLabsTranscriberLanguagesItem.Hr, "hr" },
        { ElevenLabsTranscriberLanguagesItem.Ht, "ht" },
        { ElevenLabsTranscriberLanguagesItem.Hu, "hu" },
        { ElevenLabsTranscriberLanguagesItem.Hy, "hy" },
        { ElevenLabsTranscriberLanguagesItem.Hz, "hz" },
        { ElevenLabsTranscriberLanguagesItem.Ia, "ia" },
        { ElevenLabsTranscriberLanguagesItem.Id, "id" },
        { ElevenLabsTranscriberLanguagesItem.Ie, "ie" },
        { ElevenLabsTranscriberLanguagesItem.Ig, "ig" },
        { ElevenLabsTranscriberLanguagesItem.Ii, "ii" },
        { ElevenLabsTranscriberLanguagesItem.Ik, "ik" },
        { ElevenLabsTranscriberLanguagesItem.Io, "io" },
        { ElevenLabsTranscriberLanguagesItem.Is, "is" },
        { ElevenLabsTranscriberLanguagesItem.It, "it" },
        { ElevenLabsTranscriberLanguagesItem.Iu, "iu" },
        { ElevenLabsTranscriberLanguagesItem.Ja, "ja" },
        { ElevenLabsTranscriberLanguagesItem.Jv, "jv" },
        { ElevenLabsTranscriberLanguagesItem.Ka, "ka" },
        { ElevenLabsTranscriberLanguagesItem.Kg, "kg" },
        { ElevenLabsTranscriberLanguagesItem.Ki, "ki" },
        { ElevenLabsTranscriberLanguagesItem.Kj, "kj" },
        { ElevenLabsTranscriberLanguagesItem.Kk, "kk" },
        { ElevenLabsTranscriberLanguagesItem.Kl, "kl" },
        { ElevenLabsTranscriberLanguagesItem.Km, "km" },
        { ElevenLabsTranscriberLanguagesItem.Kn, "kn" },
        { ElevenLabsTranscriberLanguagesItem.Ko, "ko" },
        { ElevenLabsTranscriberLanguagesItem.Kr, "kr" },
        { ElevenLabsTranscriberLanguagesItem.Ks, "ks" },
        { ElevenLabsTranscriberLanguagesItem.Ku, "ku" },
        { ElevenLabsTranscriberLanguagesItem.Kv, "kv" },
        { ElevenLabsTranscriberLanguagesItem.Kw, "kw" },
        { ElevenLabsTranscriberLanguagesItem.Ky, "ky" },
        { ElevenLabsTranscriberLanguagesItem.La, "la" },
        { ElevenLabsTranscriberLanguagesItem.Lb, "lb" },
        { ElevenLabsTranscriberLanguagesItem.Lg, "lg" },
        { ElevenLabsTranscriberLanguagesItem.Li, "li" },
        { ElevenLabsTranscriberLanguagesItem.Ln, "ln" },
        { ElevenLabsTranscriberLanguagesItem.Lo, "lo" },
        { ElevenLabsTranscriberLanguagesItem.Lt, "lt" },
        { ElevenLabsTranscriberLanguagesItem.Lu, "lu" },
        { ElevenLabsTranscriberLanguagesItem.Lv, "lv" },
        { ElevenLabsTranscriberLanguagesItem.Mg, "mg" },
        { ElevenLabsTranscriberLanguagesItem.Mh, "mh" },
        { ElevenLabsTranscriberLanguagesItem.Mi, "mi" },
        { ElevenLabsTranscriberLanguagesItem.Mk, "mk" },
        { ElevenLabsTranscriberLanguagesItem.Ml, "ml" },
        { ElevenLabsTranscriberLanguagesItem.Mn, "mn" },
        { ElevenLabsTranscriberLanguagesItem.Mr, "mr" },
        { ElevenLabsTranscriberLanguagesItem.Ms, "ms" },
        { ElevenLabsTranscriberLanguagesItem.Mt, "mt" },
        { ElevenLabsTranscriberLanguagesItem.My, "my" },
        { ElevenLabsTranscriberLanguagesItem.Na, "na" },
        { ElevenLabsTranscriberLanguagesItem.Nb, "nb" },
        { ElevenLabsTranscriberLanguagesItem.Nd, "nd" },
        { ElevenLabsTranscriberLanguagesItem.Ne, "ne" },
        { ElevenLabsTranscriberLanguagesItem.Ng, "ng" },
        { ElevenLabsTranscriberLanguagesItem.Nl, "nl" },
        { ElevenLabsTranscriberLanguagesItem.Nn, "nn" },
        { ElevenLabsTranscriberLanguagesItem.No, "no" },
        { ElevenLabsTranscriberLanguagesItem.Nr, "nr" },
        { ElevenLabsTranscriberLanguagesItem.Nv, "nv" },
        { ElevenLabsTranscriberLanguagesItem.Ny, "ny" },
        { ElevenLabsTranscriberLanguagesItem.Oc, "oc" },
        { ElevenLabsTranscriberLanguagesItem.Oj, "oj" },
        { ElevenLabsTranscriberLanguagesItem.Om, "om" },
        { ElevenLabsTranscriberLanguagesItem.Or, "or" },
        { ElevenLabsTranscriberLanguagesItem.Os, "os" },
        { ElevenLabsTranscriberLanguagesItem.Pa, "pa" },
        { ElevenLabsTranscriberLanguagesItem.Pi, "pi" },
        { ElevenLabsTranscriberLanguagesItem.Pl, "pl" },
        { ElevenLabsTranscriberLanguagesItem.Ps, "ps" },
        { ElevenLabsTranscriberLanguagesItem.Pt, "pt" },
        { ElevenLabsTranscriberLanguagesItem.Qu, "qu" },
        { ElevenLabsTranscriberLanguagesItem.Rm, "rm" },
        { ElevenLabsTranscriberLanguagesItem.Rn, "rn" },
        { ElevenLabsTranscriberLanguagesItem.Ro, "ro" },
        { ElevenLabsTranscriberLanguagesItem.Ru, "ru" },
        { ElevenLabsTranscriberLanguagesItem.Rw, "rw" },
        { ElevenLabsTranscriberLanguagesItem.Sa, "sa" },
        { ElevenLabsTranscriberLanguagesItem.Sc, "sc" },
        { ElevenLabsTranscriberLanguagesItem.Sd, "sd" },
        { ElevenLabsTranscriberLanguagesItem.Se, "se" },
        { ElevenLabsTranscriberLanguagesItem.Sg, "sg" },
        { ElevenLabsTranscriberLanguagesItem.Si, "si" },
        { ElevenLabsTranscriberLanguagesItem.Sk, "sk" },
        { ElevenLabsTranscriberLanguagesItem.Sl, "sl" },
        { ElevenLabsTranscriberLanguagesItem.Sm, "sm" },
        { ElevenLabsTranscriberLanguagesItem.Sn, "sn" },
        { ElevenLabsTranscriberLanguagesItem.So, "so" },
        { ElevenLabsTranscriberLanguagesItem.Sq, "sq" },
        { ElevenLabsTranscriberLanguagesItem.Sr, "sr" },
        { ElevenLabsTranscriberLanguagesItem.Ss, "ss" },
        { ElevenLabsTranscriberLanguagesItem.St, "st" },
        { ElevenLabsTranscriberLanguagesItem.Su, "su" },
        { ElevenLabsTranscriberLanguagesItem.Sv, "sv" },
        { ElevenLabsTranscriberLanguagesItem.Sw, "sw" },
        { ElevenLabsTranscriberLanguagesItem.Ta, "ta" },
        { ElevenLabsTranscriberLanguagesItem.Te, "te" },
        { ElevenLabsTranscriberLanguagesItem.Tg, "tg" },
        { ElevenLabsTranscriberLanguagesItem.Th, "th" },
        { ElevenLabsTranscriberLanguagesItem.Ti, "ti" },
        { ElevenLabsTranscriberLanguagesItem.Tk, "tk" },
        { ElevenLabsTranscriberLanguagesItem.Tl, "tl" },
        { ElevenLabsTranscriberLanguagesItem.Tn, "tn" },
        { ElevenLabsTranscriberLanguagesItem.To, "to" },
        { ElevenLabsTranscriberLanguagesItem.Tr, "tr" },
        { ElevenLabsTranscriberLanguagesItem.Ts, "ts" },
        { ElevenLabsTranscriberLanguagesItem.Tt, "tt" },
        { ElevenLabsTranscriberLanguagesItem.Tw, "tw" },
        { ElevenLabsTranscriberLanguagesItem.Ty, "ty" },
        { ElevenLabsTranscriberLanguagesItem.Ug, "ug" },
        { ElevenLabsTranscriberLanguagesItem.Uk, "uk" },
        { ElevenLabsTranscriberLanguagesItem.Ur, "ur" },
        { ElevenLabsTranscriberLanguagesItem.Uz, "uz" },
        { ElevenLabsTranscriberLanguagesItem.Ve, "ve" },
        { ElevenLabsTranscriberLanguagesItem.Vi, "vi" },
        { ElevenLabsTranscriberLanguagesItem.Vo, "vo" },
        { ElevenLabsTranscriberLanguagesItem.Wa, "wa" },
        { ElevenLabsTranscriberLanguagesItem.Wo, "wo" },
        { ElevenLabsTranscriberLanguagesItem.Xh, "xh" },
        { ElevenLabsTranscriberLanguagesItem.Yi, "yi" },
        { ElevenLabsTranscriberLanguagesItem.Yue, "yue" },
        { ElevenLabsTranscriberLanguagesItem.Yo, "yo" },
        { ElevenLabsTranscriberLanguagesItem.Za, "za" },
        { ElevenLabsTranscriberLanguagesItem.Zh, "zh" },
        { ElevenLabsTranscriberLanguagesItem.Zu, "zu" },
    };

    public override ElevenLabsTranscriberLanguagesItem Read(
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
        ElevenLabsTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsTranscriberLanguagesItem ReadAsPropertyName(
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
        ElevenLabsTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
