using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackTalkscriberTranscriberLanguageSerializer))]
public enum FallbackTalkscriberTranscriberLanguage
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

internal class FallbackTalkscriberTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackTalkscriberTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackTalkscriberTranscriberLanguage
    > _stringToEnum = new()
    {
        { "en", FallbackTalkscriberTranscriberLanguage.En },
        { "zh", FallbackTalkscriberTranscriberLanguage.Zh },
        { "de", FallbackTalkscriberTranscriberLanguage.De },
        { "es", FallbackTalkscriberTranscriberLanguage.Es },
        { "ru", FallbackTalkscriberTranscriberLanguage.Ru },
        { "ko", FallbackTalkscriberTranscriberLanguage.Ko },
        { "fr", FallbackTalkscriberTranscriberLanguage.Fr },
        { "ja", FallbackTalkscriberTranscriberLanguage.Ja },
        { "pt", FallbackTalkscriberTranscriberLanguage.Pt },
        { "tr", FallbackTalkscriberTranscriberLanguage.Tr },
        { "pl", FallbackTalkscriberTranscriberLanguage.Pl },
        { "ca", FallbackTalkscriberTranscriberLanguage.Ca },
        { "nl", FallbackTalkscriberTranscriberLanguage.Nl },
        { "ar", FallbackTalkscriberTranscriberLanguage.Ar },
        { "sv", FallbackTalkscriberTranscriberLanguage.Sv },
        { "it", FallbackTalkscriberTranscriberLanguage.It },
        { "id", FallbackTalkscriberTranscriberLanguage.Id },
        { "hi", FallbackTalkscriberTranscriberLanguage.Hi },
        { "fi", FallbackTalkscriberTranscriberLanguage.Fi },
        { "vi", FallbackTalkscriberTranscriberLanguage.Vi },
        { "he", FallbackTalkscriberTranscriberLanguage.He },
        { "uk", FallbackTalkscriberTranscriberLanguage.Uk },
        { "el", FallbackTalkscriberTranscriberLanguage.El },
        { "ms", FallbackTalkscriberTranscriberLanguage.Ms },
        { "cs", FallbackTalkscriberTranscriberLanguage.Cs },
        { "ro", FallbackTalkscriberTranscriberLanguage.Ro },
        { "da", FallbackTalkscriberTranscriberLanguage.Da },
        { "hu", FallbackTalkscriberTranscriberLanguage.Hu },
        { "ta", FallbackTalkscriberTranscriberLanguage.Ta },
        { "no", FallbackTalkscriberTranscriberLanguage.No },
        { "th", FallbackTalkscriberTranscriberLanguage.Th },
        { "ur", FallbackTalkscriberTranscriberLanguage.Ur },
        { "hr", FallbackTalkscriberTranscriberLanguage.Hr },
        { "bg", FallbackTalkscriberTranscriberLanguage.Bg },
        { "lt", FallbackTalkscriberTranscriberLanguage.Lt },
        { "la", FallbackTalkscriberTranscriberLanguage.La },
        { "mi", FallbackTalkscriberTranscriberLanguage.Mi },
        { "ml", FallbackTalkscriberTranscriberLanguage.Ml },
        { "cy", FallbackTalkscriberTranscriberLanguage.Cy },
        { "sk", FallbackTalkscriberTranscriberLanguage.Sk },
        { "te", FallbackTalkscriberTranscriberLanguage.Te },
        { "fa", FallbackTalkscriberTranscriberLanguage.Fa },
        { "lv", FallbackTalkscriberTranscriberLanguage.Lv },
        { "bn", FallbackTalkscriberTranscriberLanguage.Bn },
        { "sr", FallbackTalkscriberTranscriberLanguage.Sr },
        { "az", FallbackTalkscriberTranscriberLanguage.Az },
        { "sl", FallbackTalkscriberTranscriberLanguage.Sl },
        { "kn", FallbackTalkscriberTranscriberLanguage.Kn },
        { "et", FallbackTalkscriberTranscriberLanguage.Et },
        { "mk", FallbackTalkscriberTranscriberLanguage.Mk },
        { "br", FallbackTalkscriberTranscriberLanguage.Br },
        { "eu", FallbackTalkscriberTranscriberLanguage.Eu },
        { "is", FallbackTalkscriberTranscriberLanguage.Is },
        { "hy", FallbackTalkscriberTranscriberLanguage.Hy },
        { "ne", FallbackTalkscriberTranscriberLanguage.Ne },
        { "mn", FallbackTalkscriberTranscriberLanguage.Mn },
        { "bs", FallbackTalkscriberTranscriberLanguage.Bs },
        { "kk", FallbackTalkscriberTranscriberLanguage.Kk },
        { "sq", FallbackTalkscriberTranscriberLanguage.Sq },
        { "sw", FallbackTalkscriberTranscriberLanguage.Sw },
        { "gl", FallbackTalkscriberTranscriberLanguage.Gl },
        { "mr", FallbackTalkscriberTranscriberLanguage.Mr },
        { "pa", FallbackTalkscriberTranscriberLanguage.Pa },
        { "si", FallbackTalkscriberTranscriberLanguage.Si },
        { "km", FallbackTalkscriberTranscriberLanguage.Km },
        { "sn", FallbackTalkscriberTranscriberLanguage.Sn },
        { "yo", FallbackTalkscriberTranscriberLanguage.Yo },
        { "so", FallbackTalkscriberTranscriberLanguage.So },
        { "af", FallbackTalkscriberTranscriberLanguage.Af },
        { "oc", FallbackTalkscriberTranscriberLanguage.Oc },
        { "ka", FallbackTalkscriberTranscriberLanguage.Ka },
        { "be", FallbackTalkscriberTranscriberLanguage.Be },
        { "tg", FallbackTalkscriberTranscriberLanguage.Tg },
        { "sd", FallbackTalkscriberTranscriberLanguage.Sd },
        { "gu", FallbackTalkscriberTranscriberLanguage.Gu },
        { "am", FallbackTalkscriberTranscriberLanguage.Am },
        { "yi", FallbackTalkscriberTranscriberLanguage.Yi },
        { "lo", FallbackTalkscriberTranscriberLanguage.Lo },
        { "uz", FallbackTalkscriberTranscriberLanguage.Uz },
        { "fo", FallbackTalkscriberTranscriberLanguage.Fo },
        { "ht", FallbackTalkscriberTranscriberLanguage.Ht },
        { "ps", FallbackTalkscriberTranscriberLanguage.Ps },
        { "tk", FallbackTalkscriberTranscriberLanguage.Tk },
        { "nn", FallbackTalkscriberTranscriberLanguage.Nn },
        { "mt", FallbackTalkscriberTranscriberLanguage.Mt },
        { "sa", FallbackTalkscriberTranscriberLanguage.Sa },
        { "lb", FallbackTalkscriberTranscriberLanguage.Lb },
        { "my", FallbackTalkscriberTranscriberLanguage.My },
        { "bo", FallbackTalkscriberTranscriberLanguage.Bo },
        { "tl", FallbackTalkscriberTranscriberLanguage.Tl },
        { "mg", FallbackTalkscriberTranscriberLanguage.Mg },
        { "as", FallbackTalkscriberTranscriberLanguage.As },
        { "tt", FallbackTalkscriberTranscriberLanguage.Tt },
        { "haw", FallbackTalkscriberTranscriberLanguage.Haw },
        { "ln", FallbackTalkscriberTranscriberLanguage.Ln },
        { "ha", FallbackTalkscriberTranscriberLanguage.Ha },
        { "ba", FallbackTalkscriberTranscriberLanguage.Ba },
        { "jw", FallbackTalkscriberTranscriberLanguage.Jw },
        { "su", FallbackTalkscriberTranscriberLanguage.Su },
        { "yue", FallbackTalkscriberTranscriberLanguage.Yue },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackTalkscriberTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackTalkscriberTranscriberLanguage.En, "en" },
        { FallbackTalkscriberTranscriberLanguage.Zh, "zh" },
        { FallbackTalkscriberTranscriberLanguage.De, "de" },
        { FallbackTalkscriberTranscriberLanguage.Es, "es" },
        { FallbackTalkscriberTranscriberLanguage.Ru, "ru" },
        { FallbackTalkscriberTranscriberLanguage.Ko, "ko" },
        { FallbackTalkscriberTranscriberLanguage.Fr, "fr" },
        { FallbackTalkscriberTranscriberLanguage.Ja, "ja" },
        { FallbackTalkscriberTranscriberLanguage.Pt, "pt" },
        { FallbackTalkscriberTranscriberLanguage.Tr, "tr" },
        { FallbackTalkscriberTranscriberLanguage.Pl, "pl" },
        { FallbackTalkscriberTranscriberLanguage.Ca, "ca" },
        { FallbackTalkscriberTranscriberLanguage.Nl, "nl" },
        { FallbackTalkscriberTranscriberLanguage.Ar, "ar" },
        { FallbackTalkscriberTranscriberLanguage.Sv, "sv" },
        { FallbackTalkscriberTranscriberLanguage.It, "it" },
        { FallbackTalkscriberTranscriberLanguage.Id, "id" },
        { FallbackTalkscriberTranscriberLanguage.Hi, "hi" },
        { FallbackTalkscriberTranscriberLanguage.Fi, "fi" },
        { FallbackTalkscriberTranscriberLanguage.Vi, "vi" },
        { FallbackTalkscriberTranscriberLanguage.He, "he" },
        { FallbackTalkscriberTranscriberLanguage.Uk, "uk" },
        { FallbackTalkscriberTranscriberLanguage.El, "el" },
        { FallbackTalkscriberTranscriberLanguage.Ms, "ms" },
        { FallbackTalkscriberTranscriberLanguage.Cs, "cs" },
        { FallbackTalkscriberTranscriberLanguage.Ro, "ro" },
        { FallbackTalkscriberTranscriberLanguage.Da, "da" },
        { FallbackTalkscriberTranscriberLanguage.Hu, "hu" },
        { FallbackTalkscriberTranscriberLanguage.Ta, "ta" },
        { FallbackTalkscriberTranscriberLanguage.No, "no" },
        { FallbackTalkscriberTranscriberLanguage.Th, "th" },
        { FallbackTalkscriberTranscriberLanguage.Ur, "ur" },
        { FallbackTalkscriberTranscriberLanguage.Hr, "hr" },
        { FallbackTalkscriberTranscriberLanguage.Bg, "bg" },
        { FallbackTalkscriberTranscriberLanguage.Lt, "lt" },
        { FallbackTalkscriberTranscriberLanguage.La, "la" },
        { FallbackTalkscriberTranscriberLanguage.Mi, "mi" },
        { FallbackTalkscriberTranscriberLanguage.Ml, "ml" },
        { FallbackTalkscriberTranscriberLanguage.Cy, "cy" },
        { FallbackTalkscriberTranscriberLanguage.Sk, "sk" },
        { FallbackTalkscriberTranscriberLanguage.Te, "te" },
        { FallbackTalkscriberTranscriberLanguage.Fa, "fa" },
        { FallbackTalkscriberTranscriberLanguage.Lv, "lv" },
        { FallbackTalkscriberTranscriberLanguage.Bn, "bn" },
        { FallbackTalkscriberTranscriberLanguage.Sr, "sr" },
        { FallbackTalkscriberTranscriberLanguage.Az, "az" },
        { FallbackTalkscriberTranscriberLanguage.Sl, "sl" },
        { FallbackTalkscriberTranscriberLanguage.Kn, "kn" },
        { FallbackTalkscriberTranscriberLanguage.Et, "et" },
        { FallbackTalkscriberTranscriberLanguage.Mk, "mk" },
        { FallbackTalkscriberTranscriberLanguage.Br, "br" },
        { FallbackTalkscriberTranscriberLanguage.Eu, "eu" },
        { FallbackTalkscriberTranscriberLanguage.Is, "is" },
        { FallbackTalkscriberTranscriberLanguage.Hy, "hy" },
        { FallbackTalkscriberTranscriberLanguage.Ne, "ne" },
        { FallbackTalkscriberTranscriberLanguage.Mn, "mn" },
        { FallbackTalkscriberTranscriberLanguage.Bs, "bs" },
        { FallbackTalkscriberTranscriberLanguage.Kk, "kk" },
        { FallbackTalkscriberTranscriberLanguage.Sq, "sq" },
        { FallbackTalkscriberTranscriberLanguage.Sw, "sw" },
        { FallbackTalkscriberTranscriberLanguage.Gl, "gl" },
        { FallbackTalkscriberTranscriberLanguage.Mr, "mr" },
        { FallbackTalkscriberTranscriberLanguage.Pa, "pa" },
        { FallbackTalkscriberTranscriberLanguage.Si, "si" },
        { FallbackTalkscriberTranscriberLanguage.Km, "km" },
        { FallbackTalkscriberTranscriberLanguage.Sn, "sn" },
        { FallbackTalkscriberTranscriberLanguage.Yo, "yo" },
        { FallbackTalkscriberTranscriberLanguage.So, "so" },
        { FallbackTalkscriberTranscriberLanguage.Af, "af" },
        { FallbackTalkscriberTranscriberLanguage.Oc, "oc" },
        { FallbackTalkscriberTranscriberLanguage.Ka, "ka" },
        { FallbackTalkscriberTranscriberLanguage.Be, "be" },
        { FallbackTalkscriberTranscriberLanguage.Tg, "tg" },
        { FallbackTalkscriberTranscriberLanguage.Sd, "sd" },
        { FallbackTalkscriberTranscriberLanguage.Gu, "gu" },
        { FallbackTalkscriberTranscriberLanguage.Am, "am" },
        { FallbackTalkscriberTranscriberLanguage.Yi, "yi" },
        { FallbackTalkscriberTranscriberLanguage.Lo, "lo" },
        { FallbackTalkscriberTranscriberLanguage.Uz, "uz" },
        { FallbackTalkscriberTranscriberLanguage.Fo, "fo" },
        { FallbackTalkscriberTranscriberLanguage.Ht, "ht" },
        { FallbackTalkscriberTranscriberLanguage.Ps, "ps" },
        { FallbackTalkscriberTranscriberLanguage.Tk, "tk" },
        { FallbackTalkscriberTranscriberLanguage.Nn, "nn" },
        { FallbackTalkscriberTranscriberLanguage.Mt, "mt" },
        { FallbackTalkscriberTranscriberLanguage.Sa, "sa" },
        { FallbackTalkscriberTranscriberLanguage.Lb, "lb" },
        { FallbackTalkscriberTranscriberLanguage.My, "my" },
        { FallbackTalkscriberTranscriberLanguage.Bo, "bo" },
        { FallbackTalkscriberTranscriberLanguage.Tl, "tl" },
        { FallbackTalkscriberTranscriberLanguage.Mg, "mg" },
        { FallbackTalkscriberTranscriberLanguage.As, "as" },
        { FallbackTalkscriberTranscriberLanguage.Tt, "tt" },
        { FallbackTalkscriberTranscriberLanguage.Haw, "haw" },
        { FallbackTalkscriberTranscriberLanguage.Ln, "ln" },
        { FallbackTalkscriberTranscriberLanguage.Ha, "ha" },
        { FallbackTalkscriberTranscriberLanguage.Ba, "ba" },
        { FallbackTalkscriberTranscriberLanguage.Jw, "jw" },
        { FallbackTalkscriberTranscriberLanguage.Su, "su" },
        { FallbackTalkscriberTranscriberLanguage.Yue, "yue" },
    };

    public override FallbackTalkscriberTranscriberLanguage Read(
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
        FallbackTalkscriberTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackTalkscriberTranscriberLanguage ReadAsPropertyName(
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
        FallbackTalkscriberTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
