using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TalkscriberTranscriberLanguageSerializer))]
public enum TalkscriberTranscriberLanguage
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "la")]
    La,

    [EnumMember(Value = "mi")]
    Mi,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "cy")]
    Cy,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "br")]
    Br,

    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "is")]
    Is,

    [EnumMember(Value = "hy")]
    Hy,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "mn")]
    Mn,

    [EnumMember(Value = "bs")]
    Bs,

    [EnumMember(Value = "kk")]
    Kk,

    [EnumMember(Value = "sq")]
    Sq,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "si")]
    Si,

    [EnumMember(Value = "km")]
    Km,

    [EnumMember(Value = "sn")]
    Sn,

    [EnumMember(Value = "yo")]
    Yo,

    [EnumMember(Value = "so")]
    So,

    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "oc")]
    Oc,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "tg")]
    Tg,

    [EnumMember(Value = "sd")]
    Sd,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "am")]
    Am,

    [EnumMember(Value = "yi")]
    Yi,

    [EnumMember(Value = "lo")]
    Lo,

    [EnumMember(Value = "uz")]
    Uz,

    [EnumMember(Value = "fo")]
    Fo,

    [EnumMember(Value = "ht")]
    Ht,

    [EnumMember(Value = "ps")]
    Ps,

    [EnumMember(Value = "tk")]
    Tk,

    [EnumMember(Value = "nn")]
    Nn,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "sa")]
    Sa,

    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "my")]
    My,

    [EnumMember(Value = "bo")]
    Bo,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "mg")]
    Mg,

    [EnumMember(Value = "as")]
    As,

    [EnumMember(Value = "tt")]
    Tt,

    [EnumMember(Value = "haw")]
    Haw,

    [EnumMember(Value = "ln")]
    Ln,

    [EnumMember(Value = "ha")]
    Ha,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "jw")]
    Jw,

    [EnumMember(Value = "su")]
    Su,

    [EnumMember(Value = "yue")]
    Yue,
}

internal class TalkscriberTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TalkscriberTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TalkscriberTranscriberLanguage
    > _stringToEnum = new()
    {
        { "en", TalkscriberTranscriberLanguage.En },
        { "zh", TalkscriberTranscriberLanguage.Zh },
        { "de", TalkscriberTranscriberLanguage.De },
        { "es", TalkscriberTranscriberLanguage.Es },
        { "ru", TalkscriberTranscriberLanguage.Ru },
        { "ko", TalkscriberTranscriberLanguage.Ko },
        { "fr", TalkscriberTranscriberLanguage.Fr },
        { "ja", TalkscriberTranscriberLanguage.Ja },
        { "pt", TalkscriberTranscriberLanguage.Pt },
        { "tr", TalkscriberTranscriberLanguage.Tr },
        { "pl", TalkscriberTranscriberLanguage.Pl },
        { "ca", TalkscriberTranscriberLanguage.Ca },
        { "nl", TalkscriberTranscriberLanguage.Nl },
        { "ar", TalkscriberTranscriberLanguage.Ar },
        { "sv", TalkscriberTranscriberLanguage.Sv },
        { "it", TalkscriberTranscriberLanguage.It },
        { "id", TalkscriberTranscriberLanguage.Id },
        { "hi", TalkscriberTranscriberLanguage.Hi },
        { "fi", TalkscriberTranscriberLanguage.Fi },
        { "vi", TalkscriberTranscriberLanguage.Vi },
        { "he", TalkscriberTranscriberLanguage.He },
        { "uk", TalkscriberTranscriberLanguage.Uk },
        { "el", TalkscriberTranscriberLanguage.El },
        { "ms", TalkscriberTranscriberLanguage.Ms },
        { "cs", TalkscriberTranscriberLanguage.Cs },
        { "ro", TalkscriberTranscriberLanguage.Ro },
        { "da", TalkscriberTranscriberLanguage.Da },
        { "hu", TalkscriberTranscriberLanguage.Hu },
        { "ta", TalkscriberTranscriberLanguage.Ta },
        { "no", TalkscriberTranscriberLanguage.No },
        { "th", TalkscriberTranscriberLanguage.Th },
        { "ur", TalkscriberTranscriberLanguage.Ur },
        { "hr", TalkscriberTranscriberLanguage.Hr },
        { "bg", TalkscriberTranscriberLanguage.Bg },
        { "lt", TalkscriberTranscriberLanguage.Lt },
        { "la", TalkscriberTranscriberLanguage.La },
        { "mi", TalkscriberTranscriberLanguage.Mi },
        { "ml", TalkscriberTranscriberLanguage.Ml },
        { "cy", TalkscriberTranscriberLanguage.Cy },
        { "sk", TalkscriberTranscriberLanguage.Sk },
        { "te", TalkscriberTranscriberLanguage.Te },
        { "fa", TalkscriberTranscriberLanguage.Fa },
        { "lv", TalkscriberTranscriberLanguage.Lv },
        { "bn", TalkscriberTranscriberLanguage.Bn },
        { "sr", TalkscriberTranscriberLanguage.Sr },
        { "az", TalkscriberTranscriberLanguage.Az },
        { "sl", TalkscriberTranscriberLanguage.Sl },
        { "kn", TalkscriberTranscriberLanguage.Kn },
        { "et", TalkscriberTranscriberLanguage.Et },
        { "mk", TalkscriberTranscriberLanguage.Mk },
        { "br", TalkscriberTranscriberLanguage.Br },
        { "eu", TalkscriberTranscriberLanguage.Eu },
        { "is", TalkscriberTranscriberLanguage.Is },
        { "hy", TalkscriberTranscriberLanguage.Hy },
        { "ne", TalkscriberTranscriberLanguage.Ne },
        { "mn", TalkscriberTranscriberLanguage.Mn },
        { "bs", TalkscriberTranscriberLanguage.Bs },
        { "kk", TalkscriberTranscriberLanguage.Kk },
        { "sq", TalkscriberTranscriberLanguage.Sq },
        { "sw", TalkscriberTranscriberLanguage.Sw },
        { "gl", TalkscriberTranscriberLanguage.Gl },
        { "mr", TalkscriberTranscriberLanguage.Mr },
        { "pa", TalkscriberTranscriberLanguage.Pa },
        { "si", TalkscriberTranscriberLanguage.Si },
        { "km", TalkscriberTranscriberLanguage.Km },
        { "sn", TalkscriberTranscriberLanguage.Sn },
        { "yo", TalkscriberTranscriberLanguage.Yo },
        { "so", TalkscriberTranscriberLanguage.So },
        { "af", TalkscriberTranscriberLanguage.Af },
        { "oc", TalkscriberTranscriberLanguage.Oc },
        { "ka", TalkscriberTranscriberLanguage.Ka },
        { "be", TalkscriberTranscriberLanguage.Be },
        { "tg", TalkscriberTranscriberLanguage.Tg },
        { "sd", TalkscriberTranscriberLanguage.Sd },
        { "gu", TalkscriberTranscriberLanguage.Gu },
        { "am", TalkscriberTranscriberLanguage.Am },
        { "yi", TalkscriberTranscriberLanguage.Yi },
        { "lo", TalkscriberTranscriberLanguage.Lo },
        { "uz", TalkscriberTranscriberLanguage.Uz },
        { "fo", TalkscriberTranscriberLanguage.Fo },
        { "ht", TalkscriberTranscriberLanguage.Ht },
        { "ps", TalkscriberTranscriberLanguage.Ps },
        { "tk", TalkscriberTranscriberLanguage.Tk },
        { "nn", TalkscriberTranscriberLanguage.Nn },
        { "mt", TalkscriberTranscriberLanguage.Mt },
        { "sa", TalkscriberTranscriberLanguage.Sa },
        { "lb", TalkscriberTranscriberLanguage.Lb },
        { "my", TalkscriberTranscriberLanguage.My },
        { "bo", TalkscriberTranscriberLanguage.Bo },
        { "tl", TalkscriberTranscriberLanguage.Tl },
        { "mg", TalkscriberTranscriberLanguage.Mg },
        { "as", TalkscriberTranscriberLanguage.As },
        { "tt", TalkscriberTranscriberLanguage.Tt },
        { "haw", TalkscriberTranscriberLanguage.Haw },
        { "ln", TalkscriberTranscriberLanguage.Ln },
        { "ha", TalkscriberTranscriberLanguage.Ha },
        { "ba", TalkscriberTranscriberLanguage.Ba },
        { "jw", TalkscriberTranscriberLanguage.Jw },
        { "su", TalkscriberTranscriberLanguage.Su },
        { "yue", TalkscriberTranscriberLanguage.Yue },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TalkscriberTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { TalkscriberTranscriberLanguage.En, "en" },
        { TalkscriberTranscriberLanguage.Zh, "zh" },
        { TalkscriberTranscriberLanguage.De, "de" },
        { TalkscriberTranscriberLanguage.Es, "es" },
        { TalkscriberTranscriberLanguage.Ru, "ru" },
        { TalkscriberTranscriberLanguage.Ko, "ko" },
        { TalkscriberTranscriberLanguage.Fr, "fr" },
        { TalkscriberTranscriberLanguage.Ja, "ja" },
        { TalkscriberTranscriberLanguage.Pt, "pt" },
        { TalkscriberTranscriberLanguage.Tr, "tr" },
        { TalkscriberTranscriberLanguage.Pl, "pl" },
        { TalkscriberTranscriberLanguage.Ca, "ca" },
        { TalkscriberTranscriberLanguage.Nl, "nl" },
        { TalkscriberTranscriberLanguage.Ar, "ar" },
        { TalkscriberTranscriberLanguage.Sv, "sv" },
        { TalkscriberTranscriberLanguage.It, "it" },
        { TalkscriberTranscriberLanguage.Id, "id" },
        { TalkscriberTranscriberLanguage.Hi, "hi" },
        { TalkscriberTranscriberLanguage.Fi, "fi" },
        { TalkscriberTranscriberLanguage.Vi, "vi" },
        { TalkscriberTranscriberLanguage.He, "he" },
        { TalkscriberTranscriberLanguage.Uk, "uk" },
        { TalkscriberTranscriberLanguage.El, "el" },
        { TalkscriberTranscriberLanguage.Ms, "ms" },
        { TalkscriberTranscriberLanguage.Cs, "cs" },
        { TalkscriberTranscriberLanguage.Ro, "ro" },
        { TalkscriberTranscriberLanguage.Da, "da" },
        { TalkscriberTranscriberLanguage.Hu, "hu" },
        { TalkscriberTranscriberLanguage.Ta, "ta" },
        { TalkscriberTranscriberLanguage.No, "no" },
        { TalkscriberTranscriberLanguage.Th, "th" },
        { TalkscriberTranscriberLanguage.Ur, "ur" },
        { TalkscriberTranscriberLanguage.Hr, "hr" },
        { TalkscriberTranscriberLanguage.Bg, "bg" },
        { TalkscriberTranscriberLanguage.Lt, "lt" },
        { TalkscriberTranscriberLanguage.La, "la" },
        { TalkscriberTranscriberLanguage.Mi, "mi" },
        { TalkscriberTranscriberLanguage.Ml, "ml" },
        { TalkscriberTranscriberLanguage.Cy, "cy" },
        { TalkscriberTranscriberLanguage.Sk, "sk" },
        { TalkscriberTranscriberLanguage.Te, "te" },
        { TalkscriberTranscriberLanguage.Fa, "fa" },
        { TalkscriberTranscriberLanguage.Lv, "lv" },
        { TalkscriberTranscriberLanguage.Bn, "bn" },
        { TalkscriberTranscriberLanguage.Sr, "sr" },
        { TalkscriberTranscriberLanguage.Az, "az" },
        { TalkscriberTranscriberLanguage.Sl, "sl" },
        { TalkscriberTranscriberLanguage.Kn, "kn" },
        { TalkscriberTranscriberLanguage.Et, "et" },
        { TalkscriberTranscriberLanguage.Mk, "mk" },
        { TalkscriberTranscriberLanguage.Br, "br" },
        { TalkscriberTranscriberLanguage.Eu, "eu" },
        { TalkscriberTranscriberLanguage.Is, "is" },
        { TalkscriberTranscriberLanguage.Hy, "hy" },
        { TalkscriberTranscriberLanguage.Ne, "ne" },
        { TalkscriberTranscriberLanguage.Mn, "mn" },
        { TalkscriberTranscriberLanguage.Bs, "bs" },
        { TalkscriberTranscriberLanguage.Kk, "kk" },
        { TalkscriberTranscriberLanguage.Sq, "sq" },
        { TalkscriberTranscriberLanguage.Sw, "sw" },
        { TalkscriberTranscriberLanguage.Gl, "gl" },
        { TalkscriberTranscriberLanguage.Mr, "mr" },
        { TalkscriberTranscriberLanguage.Pa, "pa" },
        { TalkscriberTranscriberLanguage.Si, "si" },
        { TalkscriberTranscriberLanguage.Km, "km" },
        { TalkscriberTranscriberLanguage.Sn, "sn" },
        { TalkscriberTranscriberLanguage.Yo, "yo" },
        { TalkscriberTranscriberLanguage.So, "so" },
        { TalkscriberTranscriberLanguage.Af, "af" },
        { TalkscriberTranscriberLanguage.Oc, "oc" },
        { TalkscriberTranscriberLanguage.Ka, "ka" },
        { TalkscriberTranscriberLanguage.Be, "be" },
        { TalkscriberTranscriberLanguage.Tg, "tg" },
        { TalkscriberTranscriberLanguage.Sd, "sd" },
        { TalkscriberTranscriberLanguage.Gu, "gu" },
        { TalkscriberTranscriberLanguage.Am, "am" },
        { TalkscriberTranscriberLanguage.Yi, "yi" },
        { TalkscriberTranscriberLanguage.Lo, "lo" },
        { TalkscriberTranscriberLanguage.Uz, "uz" },
        { TalkscriberTranscriberLanguage.Fo, "fo" },
        { TalkscriberTranscriberLanguage.Ht, "ht" },
        { TalkscriberTranscriberLanguage.Ps, "ps" },
        { TalkscriberTranscriberLanguage.Tk, "tk" },
        { TalkscriberTranscriberLanguage.Nn, "nn" },
        { TalkscriberTranscriberLanguage.Mt, "mt" },
        { TalkscriberTranscriberLanguage.Sa, "sa" },
        { TalkscriberTranscriberLanguage.Lb, "lb" },
        { TalkscriberTranscriberLanguage.My, "my" },
        { TalkscriberTranscriberLanguage.Bo, "bo" },
        { TalkscriberTranscriberLanguage.Tl, "tl" },
        { TalkscriberTranscriberLanguage.Mg, "mg" },
        { TalkscriberTranscriberLanguage.As, "as" },
        { TalkscriberTranscriberLanguage.Tt, "tt" },
        { TalkscriberTranscriberLanguage.Haw, "haw" },
        { TalkscriberTranscriberLanguage.Ln, "ln" },
        { TalkscriberTranscriberLanguage.Ha, "ha" },
        { TalkscriberTranscriberLanguage.Ba, "ba" },
        { TalkscriberTranscriberLanguage.Jw, "jw" },
        { TalkscriberTranscriberLanguage.Su, "su" },
        { TalkscriberTranscriberLanguage.Yue, "yue" },
    };

    public override TalkscriberTranscriberLanguage Read(
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
        TalkscriberTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TalkscriberTranscriberLanguage ReadAsPropertyName(
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
        TalkscriberTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
