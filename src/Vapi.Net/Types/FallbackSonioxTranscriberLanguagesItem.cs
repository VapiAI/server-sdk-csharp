using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSonioxTranscriberLanguagesItemSerializer))]
public enum FallbackSonioxTranscriberLanguagesItem
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

internal class FallbackSonioxTranscriberLanguagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSonioxTranscriberLanguagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSonioxTranscriberLanguagesItem
    > _stringToEnum = new()
    {
        { "aa", FallbackSonioxTranscriberLanguagesItem.Aa },
        { "ab", FallbackSonioxTranscriberLanguagesItem.Ab },
        { "ae", FallbackSonioxTranscriberLanguagesItem.Ae },
        { "af", FallbackSonioxTranscriberLanguagesItem.Af },
        { "ak", FallbackSonioxTranscriberLanguagesItem.Ak },
        { "am", FallbackSonioxTranscriberLanguagesItem.Am },
        { "an", FallbackSonioxTranscriberLanguagesItem.An },
        { "ar", FallbackSonioxTranscriberLanguagesItem.Ar },
        { "as", FallbackSonioxTranscriberLanguagesItem.As },
        { "av", FallbackSonioxTranscriberLanguagesItem.Av },
        { "ay", FallbackSonioxTranscriberLanguagesItem.Ay },
        { "az", FallbackSonioxTranscriberLanguagesItem.Az },
        { "ba", FallbackSonioxTranscriberLanguagesItem.Ba },
        { "be", FallbackSonioxTranscriberLanguagesItem.Be },
        { "bg", FallbackSonioxTranscriberLanguagesItem.Bg },
        { "bh", FallbackSonioxTranscriberLanguagesItem.Bh },
        { "bi", FallbackSonioxTranscriberLanguagesItem.Bi },
        { "bm", FallbackSonioxTranscriberLanguagesItem.Bm },
        { "bn", FallbackSonioxTranscriberLanguagesItem.Bn },
        { "bo", FallbackSonioxTranscriberLanguagesItem.Bo },
        { "br", FallbackSonioxTranscriberLanguagesItem.Br },
        { "bs", FallbackSonioxTranscriberLanguagesItem.Bs },
        { "ca", FallbackSonioxTranscriberLanguagesItem.Ca },
        { "ce", FallbackSonioxTranscriberLanguagesItem.Ce },
        { "ch", FallbackSonioxTranscriberLanguagesItem.Ch },
        { "co", FallbackSonioxTranscriberLanguagesItem.Co },
        { "cr", FallbackSonioxTranscriberLanguagesItem.Cr },
        { "cs", FallbackSonioxTranscriberLanguagesItem.Cs },
        { "cu", FallbackSonioxTranscriberLanguagesItem.Cu },
        { "cv", FallbackSonioxTranscriberLanguagesItem.Cv },
        { "cy", FallbackSonioxTranscriberLanguagesItem.Cy },
        { "da", FallbackSonioxTranscriberLanguagesItem.Da },
        { "de", FallbackSonioxTranscriberLanguagesItem.De },
        { "dv", FallbackSonioxTranscriberLanguagesItem.Dv },
        { "dz", FallbackSonioxTranscriberLanguagesItem.Dz },
        { "ee", FallbackSonioxTranscriberLanguagesItem.Ee },
        { "el", FallbackSonioxTranscriberLanguagesItem.El },
        { "en", FallbackSonioxTranscriberLanguagesItem.En },
        { "eo", FallbackSonioxTranscriberLanguagesItem.Eo },
        { "es", FallbackSonioxTranscriberLanguagesItem.Es },
        { "et", FallbackSonioxTranscriberLanguagesItem.Et },
        { "eu", FallbackSonioxTranscriberLanguagesItem.Eu },
        { "fa", FallbackSonioxTranscriberLanguagesItem.Fa },
        { "ff", FallbackSonioxTranscriberLanguagesItem.Ff },
        { "fi", FallbackSonioxTranscriberLanguagesItem.Fi },
        { "fj", FallbackSonioxTranscriberLanguagesItem.Fj },
        { "fo", FallbackSonioxTranscriberLanguagesItem.Fo },
        { "fr", FallbackSonioxTranscriberLanguagesItem.Fr },
        { "fy", FallbackSonioxTranscriberLanguagesItem.Fy },
        { "ga", FallbackSonioxTranscriberLanguagesItem.Ga },
        { "gd", FallbackSonioxTranscriberLanguagesItem.Gd },
        { "gl", FallbackSonioxTranscriberLanguagesItem.Gl },
        { "gn", FallbackSonioxTranscriberLanguagesItem.Gn },
        { "gu", FallbackSonioxTranscriberLanguagesItem.Gu },
        { "gv", FallbackSonioxTranscriberLanguagesItem.Gv },
        { "ha", FallbackSonioxTranscriberLanguagesItem.Ha },
        { "he", FallbackSonioxTranscriberLanguagesItem.He },
        { "hi", FallbackSonioxTranscriberLanguagesItem.Hi },
        { "ho", FallbackSonioxTranscriberLanguagesItem.Ho },
        { "hr", FallbackSonioxTranscriberLanguagesItem.Hr },
        { "ht", FallbackSonioxTranscriberLanguagesItem.Ht },
        { "hu", FallbackSonioxTranscriberLanguagesItem.Hu },
        { "hy", FallbackSonioxTranscriberLanguagesItem.Hy },
        { "hz", FallbackSonioxTranscriberLanguagesItem.Hz },
        { "ia", FallbackSonioxTranscriberLanguagesItem.Ia },
        { "id", FallbackSonioxTranscriberLanguagesItem.Id },
        { "ie", FallbackSonioxTranscriberLanguagesItem.Ie },
        { "ig", FallbackSonioxTranscriberLanguagesItem.Ig },
        { "ii", FallbackSonioxTranscriberLanguagesItem.Ii },
        { "ik", FallbackSonioxTranscriberLanguagesItem.Ik },
        { "io", FallbackSonioxTranscriberLanguagesItem.Io },
        { "is", FallbackSonioxTranscriberLanguagesItem.Is },
        { "it", FallbackSonioxTranscriberLanguagesItem.It },
        { "iu", FallbackSonioxTranscriberLanguagesItem.Iu },
        { "ja", FallbackSonioxTranscriberLanguagesItem.Ja },
        { "jv", FallbackSonioxTranscriberLanguagesItem.Jv },
        { "ka", FallbackSonioxTranscriberLanguagesItem.Ka },
        { "kg", FallbackSonioxTranscriberLanguagesItem.Kg },
        { "ki", FallbackSonioxTranscriberLanguagesItem.Ki },
        { "kj", FallbackSonioxTranscriberLanguagesItem.Kj },
        { "kk", FallbackSonioxTranscriberLanguagesItem.Kk },
        { "kl", FallbackSonioxTranscriberLanguagesItem.Kl },
        { "km", FallbackSonioxTranscriberLanguagesItem.Km },
        { "kn", FallbackSonioxTranscriberLanguagesItem.Kn },
        { "ko", FallbackSonioxTranscriberLanguagesItem.Ko },
        { "kr", FallbackSonioxTranscriberLanguagesItem.Kr },
        { "ks", FallbackSonioxTranscriberLanguagesItem.Ks },
        { "ku", FallbackSonioxTranscriberLanguagesItem.Ku },
        { "kv", FallbackSonioxTranscriberLanguagesItem.Kv },
        { "kw", FallbackSonioxTranscriberLanguagesItem.Kw },
        { "ky", FallbackSonioxTranscriberLanguagesItem.Ky },
        { "la", FallbackSonioxTranscriberLanguagesItem.La },
        { "lb", FallbackSonioxTranscriberLanguagesItem.Lb },
        { "lg", FallbackSonioxTranscriberLanguagesItem.Lg },
        { "li", FallbackSonioxTranscriberLanguagesItem.Li },
        { "ln", FallbackSonioxTranscriberLanguagesItem.Ln },
        { "lo", FallbackSonioxTranscriberLanguagesItem.Lo },
        { "lt", FallbackSonioxTranscriberLanguagesItem.Lt },
        { "lu", FallbackSonioxTranscriberLanguagesItem.Lu },
        { "lv", FallbackSonioxTranscriberLanguagesItem.Lv },
        { "mg", FallbackSonioxTranscriberLanguagesItem.Mg },
        { "mh", FallbackSonioxTranscriberLanguagesItem.Mh },
        { "mi", FallbackSonioxTranscriberLanguagesItem.Mi },
        { "mk", FallbackSonioxTranscriberLanguagesItem.Mk },
        { "ml", FallbackSonioxTranscriberLanguagesItem.Ml },
        { "mn", FallbackSonioxTranscriberLanguagesItem.Mn },
        { "mr", FallbackSonioxTranscriberLanguagesItem.Mr },
        { "ms", FallbackSonioxTranscriberLanguagesItem.Ms },
        { "mt", FallbackSonioxTranscriberLanguagesItem.Mt },
        { "my", FallbackSonioxTranscriberLanguagesItem.My },
        { "na", FallbackSonioxTranscriberLanguagesItem.Na },
        { "nb", FallbackSonioxTranscriberLanguagesItem.Nb },
        { "nd", FallbackSonioxTranscriberLanguagesItem.Nd },
        { "ne", FallbackSonioxTranscriberLanguagesItem.Ne },
        { "ng", FallbackSonioxTranscriberLanguagesItem.Ng },
        { "nl", FallbackSonioxTranscriberLanguagesItem.Nl },
        { "nn", FallbackSonioxTranscriberLanguagesItem.Nn },
        { "no", FallbackSonioxTranscriberLanguagesItem.No },
        { "nr", FallbackSonioxTranscriberLanguagesItem.Nr },
        { "nv", FallbackSonioxTranscriberLanguagesItem.Nv },
        { "ny", FallbackSonioxTranscriberLanguagesItem.Ny },
        { "oc", FallbackSonioxTranscriberLanguagesItem.Oc },
        { "oj", FallbackSonioxTranscriberLanguagesItem.Oj },
        { "om", FallbackSonioxTranscriberLanguagesItem.Om },
        { "or", FallbackSonioxTranscriberLanguagesItem.Or },
        { "os", FallbackSonioxTranscriberLanguagesItem.Os },
        { "pa", FallbackSonioxTranscriberLanguagesItem.Pa },
        { "pi", FallbackSonioxTranscriberLanguagesItem.Pi },
        { "pl", FallbackSonioxTranscriberLanguagesItem.Pl },
        { "ps", FallbackSonioxTranscriberLanguagesItem.Ps },
        { "pt", FallbackSonioxTranscriberLanguagesItem.Pt },
        { "qu", FallbackSonioxTranscriberLanguagesItem.Qu },
        { "rm", FallbackSonioxTranscriberLanguagesItem.Rm },
        { "rn", FallbackSonioxTranscriberLanguagesItem.Rn },
        { "ro", FallbackSonioxTranscriberLanguagesItem.Ro },
        { "ru", FallbackSonioxTranscriberLanguagesItem.Ru },
        { "rw", FallbackSonioxTranscriberLanguagesItem.Rw },
        { "sa", FallbackSonioxTranscriberLanguagesItem.Sa },
        { "sc", FallbackSonioxTranscriberLanguagesItem.Sc },
        { "sd", FallbackSonioxTranscriberLanguagesItem.Sd },
        { "se", FallbackSonioxTranscriberLanguagesItem.Se },
        { "sg", FallbackSonioxTranscriberLanguagesItem.Sg },
        { "si", FallbackSonioxTranscriberLanguagesItem.Si },
        { "sk", FallbackSonioxTranscriberLanguagesItem.Sk },
        { "sl", FallbackSonioxTranscriberLanguagesItem.Sl },
        { "sm", FallbackSonioxTranscriberLanguagesItem.Sm },
        { "sn", FallbackSonioxTranscriberLanguagesItem.Sn },
        { "so", FallbackSonioxTranscriberLanguagesItem.So },
        { "sq", FallbackSonioxTranscriberLanguagesItem.Sq },
        { "sr", FallbackSonioxTranscriberLanguagesItem.Sr },
        { "ss", FallbackSonioxTranscriberLanguagesItem.Ss },
        { "st", FallbackSonioxTranscriberLanguagesItem.St },
        { "su", FallbackSonioxTranscriberLanguagesItem.Su },
        { "sv", FallbackSonioxTranscriberLanguagesItem.Sv },
        { "sw", FallbackSonioxTranscriberLanguagesItem.Sw },
        { "ta", FallbackSonioxTranscriberLanguagesItem.Ta },
        { "te", FallbackSonioxTranscriberLanguagesItem.Te },
        { "tg", FallbackSonioxTranscriberLanguagesItem.Tg },
        { "th", FallbackSonioxTranscriberLanguagesItem.Th },
        { "ti", FallbackSonioxTranscriberLanguagesItem.Ti },
        { "tk", FallbackSonioxTranscriberLanguagesItem.Tk },
        { "tl", FallbackSonioxTranscriberLanguagesItem.Tl },
        { "tn", FallbackSonioxTranscriberLanguagesItem.Tn },
        { "to", FallbackSonioxTranscriberLanguagesItem.To },
        { "tr", FallbackSonioxTranscriberLanguagesItem.Tr },
        { "ts", FallbackSonioxTranscriberLanguagesItem.Ts },
        { "tt", FallbackSonioxTranscriberLanguagesItem.Tt },
        { "tw", FallbackSonioxTranscriberLanguagesItem.Tw },
        { "ty", FallbackSonioxTranscriberLanguagesItem.Ty },
        { "ug", FallbackSonioxTranscriberLanguagesItem.Ug },
        { "uk", FallbackSonioxTranscriberLanguagesItem.Uk },
        { "ur", FallbackSonioxTranscriberLanguagesItem.Ur },
        { "uz", FallbackSonioxTranscriberLanguagesItem.Uz },
        { "ve", FallbackSonioxTranscriberLanguagesItem.Ve },
        { "vi", FallbackSonioxTranscriberLanguagesItem.Vi },
        { "vo", FallbackSonioxTranscriberLanguagesItem.Vo },
        { "wa", FallbackSonioxTranscriberLanguagesItem.Wa },
        { "wo", FallbackSonioxTranscriberLanguagesItem.Wo },
        { "xh", FallbackSonioxTranscriberLanguagesItem.Xh },
        { "yi", FallbackSonioxTranscriberLanguagesItem.Yi },
        { "yue", FallbackSonioxTranscriberLanguagesItem.Yue },
        { "yo", FallbackSonioxTranscriberLanguagesItem.Yo },
        { "za", FallbackSonioxTranscriberLanguagesItem.Za },
        { "zh", FallbackSonioxTranscriberLanguagesItem.Zh },
        { "zu", FallbackSonioxTranscriberLanguagesItem.Zu },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSonioxTranscriberLanguagesItem,
        string
    > _enumToString = new()
    {
        { FallbackSonioxTranscriberLanguagesItem.Aa, "aa" },
        { FallbackSonioxTranscriberLanguagesItem.Ab, "ab" },
        { FallbackSonioxTranscriberLanguagesItem.Ae, "ae" },
        { FallbackSonioxTranscriberLanguagesItem.Af, "af" },
        { FallbackSonioxTranscriberLanguagesItem.Ak, "ak" },
        { FallbackSonioxTranscriberLanguagesItem.Am, "am" },
        { FallbackSonioxTranscriberLanguagesItem.An, "an" },
        { FallbackSonioxTranscriberLanguagesItem.Ar, "ar" },
        { FallbackSonioxTranscriberLanguagesItem.As, "as" },
        { FallbackSonioxTranscriberLanguagesItem.Av, "av" },
        { FallbackSonioxTranscriberLanguagesItem.Ay, "ay" },
        { FallbackSonioxTranscriberLanguagesItem.Az, "az" },
        { FallbackSonioxTranscriberLanguagesItem.Ba, "ba" },
        { FallbackSonioxTranscriberLanguagesItem.Be, "be" },
        { FallbackSonioxTranscriberLanguagesItem.Bg, "bg" },
        { FallbackSonioxTranscriberLanguagesItem.Bh, "bh" },
        { FallbackSonioxTranscriberLanguagesItem.Bi, "bi" },
        { FallbackSonioxTranscriberLanguagesItem.Bm, "bm" },
        { FallbackSonioxTranscriberLanguagesItem.Bn, "bn" },
        { FallbackSonioxTranscriberLanguagesItem.Bo, "bo" },
        { FallbackSonioxTranscriberLanguagesItem.Br, "br" },
        { FallbackSonioxTranscriberLanguagesItem.Bs, "bs" },
        { FallbackSonioxTranscriberLanguagesItem.Ca, "ca" },
        { FallbackSonioxTranscriberLanguagesItem.Ce, "ce" },
        { FallbackSonioxTranscriberLanguagesItem.Ch, "ch" },
        { FallbackSonioxTranscriberLanguagesItem.Co, "co" },
        { FallbackSonioxTranscriberLanguagesItem.Cr, "cr" },
        { FallbackSonioxTranscriberLanguagesItem.Cs, "cs" },
        { FallbackSonioxTranscriberLanguagesItem.Cu, "cu" },
        { FallbackSonioxTranscriberLanguagesItem.Cv, "cv" },
        { FallbackSonioxTranscriberLanguagesItem.Cy, "cy" },
        { FallbackSonioxTranscriberLanguagesItem.Da, "da" },
        { FallbackSonioxTranscriberLanguagesItem.De, "de" },
        { FallbackSonioxTranscriberLanguagesItem.Dv, "dv" },
        { FallbackSonioxTranscriberLanguagesItem.Dz, "dz" },
        { FallbackSonioxTranscriberLanguagesItem.Ee, "ee" },
        { FallbackSonioxTranscriberLanguagesItem.El, "el" },
        { FallbackSonioxTranscriberLanguagesItem.En, "en" },
        { FallbackSonioxTranscriberLanguagesItem.Eo, "eo" },
        { FallbackSonioxTranscriberLanguagesItem.Es, "es" },
        { FallbackSonioxTranscriberLanguagesItem.Et, "et" },
        { FallbackSonioxTranscriberLanguagesItem.Eu, "eu" },
        { FallbackSonioxTranscriberLanguagesItem.Fa, "fa" },
        { FallbackSonioxTranscriberLanguagesItem.Ff, "ff" },
        { FallbackSonioxTranscriberLanguagesItem.Fi, "fi" },
        { FallbackSonioxTranscriberLanguagesItem.Fj, "fj" },
        { FallbackSonioxTranscriberLanguagesItem.Fo, "fo" },
        { FallbackSonioxTranscriberLanguagesItem.Fr, "fr" },
        { FallbackSonioxTranscriberLanguagesItem.Fy, "fy" },
        { FallbackSonioxTranscriberLanguagesItem.Ga, "ga" },
        { FallbackSonioxTranscriberLanguagesItem.Gd, "gd" },
        { FallbackSonioxTranscriberLanguagesItem.Gl, "gl" },
        { FallbackSonioxTranscriberLanguagesItem.Gn, "gn" },
        { FallbackSonioxTranscriberLanguagesItem.Gu, "gu" },
        { FallbackSonioxTranscriberLanguagesItem.Gv, "gv" },
        { FallbackSonioxTranscriberLanguagesItem.Ha, "ha" },
        { FallbackSonioxTranscriberLanguagesItem.He, "he" },
        { FallbackSonioxTranscriberLanguagesItem.Hi, "hi" },
        { FallbackSonioxTranscriberLanguagesItem.Ho, "ho" },
        { FallbackSonioxTranscriberLanguagesItem.Hr, "hr" },
        { FallbackSonioxTranscriberLanguagesItem.Ht, "ht" },
        { FallbackSonioxTranscriberLanguagesItem.Hu, "hu" },
        { FallbackSonioxTranscriberLanguagesItem.Hy, "hy" },
        { FallbackSonioxTranscriberLanguagesItem.Hz, "hz" },
        { FallbackSonioxTranscriberLanguagesItem.Ia, "ia" },
        { FallbackSonioxTranscriberLanguagesItem.Id, "id" },
        { FallbackSonioxTranscriberLanguagesItem.Ie, "ie" },
        { FallbackSonioxTranscriberLanguagesItem.Ig, "ig" },
        { FallbackSonioxTranscriberLanguagesItem.Ii, "ii" },
        { FallbackSonioxTranscriberLanguagesItem.Ik, "ik" },
        { FallbackSonioxTranscriberLanguagesItem.Io, "io" },
        { FallbackSonioxTranscriberLanguagesItem.Is, "is" },
        { FallbackSonioxTranscriberLanguagesItem.It, "it" },
        { FallbackSonioxTranscriberLanguagesItem.Iu, "iu" },
        { FallbackSonioxTranscriberLanguagesItem.Ja, "ja" },
        { FallbackSonioxTranscriberLanguagesItem.Jv, "jv" },
        { FallbackSonioxTranscriberLanguagesItem.Ka, "ka" },
        { FallbackSonioxTranscriberLanguagesItem.Kg, "kg" },
        { FallbackSonioxTranscriberLanguagesItem.Ki, "ki" },
        { FallbackSonioxTranscriberLanguagesItem.Kj, "kj" },
        { FallbackSonioxTranscriberLanguagesItem.Kk, "kk" },
        { FallbackSonioxTranscriberLanguagesItem.Kl, "kl" },
        { FallbackSonioxTranscriberLanguagesItem.Km, "km" },
        { FallbackSonioxTranscriberLanguagesItem.Kn, "kn" },
        { FallbackSonioxTranscriberLanguagesItem.Ko, "ko" },
        { FallbackSonioxTranscriberLanguagesItem.Kr, "kr" },
        { FallbackSonioxTranscriberLanguagesItem.Ks, "ks" },
        { FallbackSonioxTranscriberLanguagesItem.Ku, "ku" },
        { FallbackSonioxTranscriberLanguagesItem.Kv, "kv" },
        { FallbackSonioxTranscriberLanguagesItem.Kw, "kw" },
        { FallbackSonioxTranscriberLanguagesItem.Ky, "ky" },
        { FallbackSonioxTranscriberLanguagesItem.La, "la" },
        { FallbackSonioxTranscriberLanguagesItem.Lb, "lb" },
        { FallbackSonioxTranscriberLanguagesItem.Lg, "lg" },
        { FallbackSonioxTranscriberLanguagesItem.Li, "li" },
        { FallbackSonioxTranscriberLanguagesItem.Ln, "ln" },
        { FallbackSonioxTranscriberLanguagesItem.Lo, "lo" },
        { FallbackSonioxTranscriberLanguagesItem.Lt, "lt" },
        { FallbackSonioxTranscriberLanguagesItem.Lu, "lu" },
        { FallbackSonioxTranscriberLanguagesItem.Lv, "lv" },
        { FallbackSonioxTranscriberLanguagesItem.Mg, "mg" },
        { FallbackSonioxTranscriberLanguagesItem.Mh, "mh" },
        { FallbackSonioxTranscriberLanguagesItem.Mi, "mi" },
        { FallbackSonioxTranscriberLanguagesItem.Mk, "mk" },
        { FallbackSonioxTranscriberLanguagesItem.Ml, "ml" },
        { FallbackSonioxTranscriberLanguagesItem.Mn, "mn" },
        { FallbackSonioxTranscriberLanguagesItem.Mr, "mr" },
        { FallbackSonioxTranscriberLanguagesItem.Ms, "ms" },
        { FallbackSonioxTranscriberLanguagesItem.Mt, "mt" },
        { FallbackSonioxTranscriberLanguagesItem.My, "my" },
        { FallbackSonioxTranscriberLanguagesItem.Na, "na" },
        { FallbackSonioxTranscriberLanguagesItem.Nb, "nb" },
        { FallbackSonioxTranscriberLanguagesItem.Nd, "nd" },
        { FallbackSonioxTranscriberLanguagesItem.Ne, "ne" },
        { FallbackSonioxTranscriberLanguagesItem.Ng, "ng" },
        { FallbackSonioxTranscriberLanguagesItem.Nl, "nl" },
        { FallbackSonioxTranscriberLanguagesItem.Nn, "nn" },
        { FallbackSonioxTranscriberLanguagesItem.No, "no" },
        { FallbackSonioxTranscriberLanguagesItem.Nr, "nr" },
        { FallbackSonioxTranscriberLanguagesItem.Nv, "nv" },
        { FallbackSonioxTranscriberLanguagesItem.Ny, "ny" },
        { FallbackSonioxTranscriberLanguagesItem.Oc, "oc" },
        { FallbackSonioxTranscriberLanguagesItem.Oj, "oj" },
        { FallbackSonioxTranscriberLanguagesItem.Om, "om" },
        { FallbackSonioxTranscriberLanguagesItem.Or, "or" },
        { FallbackSonioxTranscriberLanguagesItem.Os, "os" },
        { FallbackSonioxTranscriberLanguagesItem.Pa, "pa" },
        { FallbackSonioxTranscriberLanguagesItem.Pi, "pi" },
        { FallbackSonioxTranscriberLanguagesItem.Pl, "pl" },
        { FallbackSonioxTranscriberLanguagesItem.Ps, "ps" },
        { FallbackSonioxTranscriberLanguagesItem.Pt, "pt" },
        { FallbackSonioxTranscriberLanguagesItem.Qu, "qu" },
        { FallbackSonioxTranscriberLanguagesItem.Rm, "rm" },
        { FallbackSonioxTranscriberLanguagesItem.Rn, "rn" },
        { FallbackSonioxTranscriberLanguagesItem.Ro, "ro" },
        { FallbackSonioxTranscriberLanguagesItem.Ru, "ru" },
        { FallbackSonioxTranscriberLanguagesItem.Rw, "rw" },
        { FallbackSonioxTranscriberLanguagesItem.Sa, "sa" },
        { FallbackSonioxTranscriberLanguagesItem.Sc, "sc" },
        { FallbackSonioxTranscriberLanguagesItem.Sd, "sd" },
        { FallbackSonioxTranscriberLanguagesItem.Se, "se" },
        { FallbackSonioxTranscriberLanguagesItem.Sg, "sg" },
        { FallbackSonioxTranscriberLanguagesItem.Si, "si" },
        { FallbackSonioxTranscriberLanguagesItem.Sk, "sk" },
        { FallbackSonioxTranscriberLanguagesItem.Sl, "sl" },
        { FallbackSonioxTranscriberLanguagesItem.Sm, "sm" },
        { FallbackSonioxTranscriberLanguagesItem.Sn, "sn" },
        { FallbackSonioxTranscriberLanguagesItem.So, "so" },
        { FallbackSonioxTranscriberLanguagesItem.Sq, "sq" },
        { FallbackSonioxTranscriberLanguagesItem.Sr, "sr" },
        { FallbackSonioxTranscriberLanguagesItem.Ss, "ss" },
        { FallbackSonioxTranscriberLanguagesItem.St, "st" },
        { FallbackSonioxTranscriberLanguagesItem.Su, "su" },
        { FallbackSonioxTranscriberLanguagesItem.Sv, "sv" },
        { FallbackSonioxTranscriberLanguagesItem.Sw, "sw" },
        { FallbackSonioxTranscriberLanguagesItem.Ta, "ta" },
        { FallbackSonioxTranscriberLanguagesItem.Te, "te" },
        { FallbackSonioxTranscriberLanguagesItem.Tg, "tg" },
        { FallbackSonioxTranscriberLanguagesItem.Th, "th" },
        { FallbackSonioxTranscriberLanguagesItem.Ti, "ti" },
        { FallbackSonioxTranscriberLanguagesItem.Tk, "tk" },
        { FallbackSonioxTranscriberLanguagesItem.Tl, "tl" },
        { FallbackSonioxTranscriberLanguagesItem.Tn, "tn" },
        { FallbackSonioxTranscriberLanguagesItem.To, "to" },
        { FallbackSonioxTranscriberLanguagesItem.Tr, "tr" },
        { FallbackSonioxTranscriberLanguagesItem.Ts, "ts" },
        { FallbackSonioxTranscriberLanguagesItem.Tt, "tt" },
        { FallbackSonioxTranscriberLanguagesItem.Tw, "tw" },
        { FallbackSonioxTranscriberLanguagesItem.Ty, "ty" },
        { FallbackSonioxTranscriberLanguagesItem.Ug, "ug" },
        { FallbackSonioxTranscriberLanguagesItem.Uk, "uk" },
        { FallbackSonioxTranscriberLanguagesItem.Ur, "ur" },
        { FallbackSonioxTranscriberLanguagesItem.Uz, "uz" },
        { FallbackSonioxTranscriberLanguagesItem.Ve, "ve" },
        { FallbackSonioxTranscriberLanguagesItem.Vi, "vi" },
        { FallbackSonioxTranscriberLanguagesItem.Vo, "vo" },
        { FallbackSonioxTranscriberLanguagesItem.Wa, "wa" },
        { FallbackSonioxTranscriberLanguagesItem.Wo, "wo" },
        { FallbackSonioxTranscriberLanguagesItem.Xh, "xh" },
        { FallbackSonioxTranscriberLanguagesItem.Yi, "yi" },
        { FallbackSonioxTranscriberLanguagesItem.Yue, "yue" },
        { FallbackSonioxTranscriberLanguagesItem.Yo, "yo" },
        { FallbackSonioxTranscriberLanguagesItem.Za, "za" },
        { FallbackSonioxTranscriberLanguagesItem.Zh, "zh" },
        { FallbackSonioxTranscriberLanguagesItem.Zu, "zu" },
    };

    public override FallbackSonioxTranscriberLanguagesItem Read(
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
        FallbackSonioxTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSonioxTranscriberLanguagesItem ReadAsPropertyName(
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
        FallbackSonioxTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
