using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GladiaTranscriberLanguageSerializer))]
public enum GladiaTranscriberLanguage
{
    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "sq")]
    Sq,

    [EnumMember(Value = "am")]
    Am,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "hy")]
    Hy,

    [EnumMember(Value = "as")]
    As,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "bs")]
    Bs,

    [EnumMember(Value = "br")]
    Br,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "fo")]
    Fo,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "ht")]
    Ht,

    [EnumMember(Value = "ha")]
    Ha,

    [EnumMember(Value = "haw")]
    Haw,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "is")]
    Is,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "jv")]
    Jv,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "kk")]
    Kk,

    [EnumMember(Value = "km")]
    Km,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "lo")]
    Lo,

    [EnumMember(Value = "la")]
    La,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "ln")]
    Ln,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "mg")]
    Mg,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "mi")]
    Mi,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "mn")]
    Mn,

    [EnumMember(Value = "my")]
    My,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "nn")]
    Nn,

    [EnumMember(Value = "oc")]
    Oc,

    [EnumMember(Value = "ps")]
    Ps,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sa")]
    Sa,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "sn")]
    Sn,

    [EnumMember(Value = "sd")]
    Sd,

    [EnumMember(Value = "si")]
    Si,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "so")]
    So,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "su")]
    Su,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "tg")]
    Tg,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "tt")]
    Tt,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "bo")]
    Bo,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "tk")]
    Tk,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "uz")]
    Uz,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "cy")]
    Cy,

    [EnumMember(Value = "yi")]
    Yi,

    [EnumMember(Value = "yo")]
    Yo,
}

internal class GladiaTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GladiaTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GladiaTranscriberLanguage
    > _stringToEnum = new()
    {
        { "af", GladiaTranscriberLanguage.Af },
        { "sq", GladiaTranscriberLanguage.Sq },
        { "am", GladiaTranscriberLanguage.Am },
        { "ar", GladiaTranscriberLanguage.Ar },
        { "hy", GladiaTranscriberLanguage.Hy },
        { "as", GladiaTranscriberLanguage.As },
        { "az", GladiaTranscriberLanguage.Az },
        { "ba", GladiaTranscriberLanguage.Ba },
        { "eu", GladiaTranscriberLanguage.Eu },
        { "be", GladiaTranscriberLanguage.Be },
        { "bn", GladiaTranscriberLanguage.Bn },
        { "bs", GladiaTranscriberLanguage.Bs },
        { "br", GladiaTranscriberLanguage.Br },
        { "bg", GladiaTranscriberLanguage.Bg },
        { "ca", GladiaTranscriberLanguage.Ca },
        { "zh", GladiaTranscriberLanguage.Zh },
        { "hr", GladiaTranscriberLanguage.Hr },
        { "cs", GladiaTranscriberLanguage.Cs },
        { "da", GladiaTranscriberLanguage.Da },
        { "nl", GladiaTranscriberLanguage.Nl },
        { "en", GladiaTranscriberLanguage.En },
        { "et", GladiaTranscriberLanguage.Et },
        { "fo", GladiaTranscriberLanguage.Fo },
        { "fi", GladiaTranscriberLanguage.Fi },
        { "fr", GladiaTranscriberLanguage.Fr },
        { "gl", GladiaTranscriberLanguage.Gl },
        { "ka", GladiaTranscriberLanguage.Ka },
        { "de", GladiaTranscriberLanguage.De },
        { "el", GladiaTranscriberLanguage.El },
        { "gu", GladiaTranscriberLanguage.Gu },
        { "ht", GladiaTranscriberLanguage.Ht },
        { "ha", GladiaTranscriberLanguage.Ha },
        { "haw", GladiaTranscriberLanguage.Haw },
        { "he", GladiaTranscriberLanguage.He },
        { "hi", GladiaTranscriberLanguage.Hi },
        { "hu", GladiaTranscriberLanguage.Hu },
        { "is", GladiaTranscriberLanguage.Is },
        { "id", GladiaTranscriberLanguage.Id },
        { "it", GladiaTranscriberLanguage.It },
        { "ja", GladiaTranscriberLanguage.Ja },
        { "jv", GladiaTranscriberLanguage.Jv },
        { "kn", GladiaTranscriberLanguage.Kn },
        { "kk", GladiaTranscriberLanguage.Kk },
        { "km", GladiaTranscriberLanguage.Km },
        { "ko", GladiaTranscriberLanguage.Ko },
        { "lo", GladiaTranscriberLanguage.Lo },
        { "la", GladiaTranscriberLanguage.La },
        { "lv", GladiaTranscriberLanguage.Lv },
        { "ln", GladiaTranscriberLanguage.Ln },
        { "lt", GladiaTranscriberLanguage.Lt },
        { "lb", GladiaTranscriberLanguage.Lb },
        { "mk", GladiaTranscriberLanguage.Mk },
        { "mg", GladiaTranscriberLanguage.Mg },
        { "ms", GladiaTranscriberLanguage.Ms },
        { "ml", GladiaTranscriberLanguage.Ml },
        { "mt", GladiaTranscriberLanguage.Mt },
        { "mi", GladiaTranscriberLanguage.Mi },
        { "mr", GladiaTranscriberLanguage.Mr },
        { "mn", GladiaTranscriberLanguage.Mn },
        { "my", GladiaTranscriberLanguage.My },
        { "ne", GladiaTranscriberLanguage.Ne },
        { "no", GladiaTranscriberLanguage.No },
        { "nn", GladiaTranscriberLanguage.Nn },
        { "oc", GladiaTranscriberLanguage.Oc },
        { "ps", GladiaTranscriberLanguage.Ps },
        { "fa", GladiaTranscriberLanguage.Fa },
        { "pl", GladiaTranscriberLanguage.Pl },
        { "pt", GladiaTranscriberLanguage.Pt },
        { "pa", GladiaTranscriberLanguage.Pa },
        { "ro", GladiaTranscriberLanguage.Ro },
        { "ru", GladiaTranscriberLanguage.Ru },
        { "sa", GladiaTranscriberLanguage.Sa },
        { "sr", GladiaTranscriberLanguage.Sr },
        { "sn", GladiaTranscriberLanguage.Sn },
        { "sd", GladiaTranscriberLanguage.Sd },
        { "si", GladiaTranscriberLanguage.Si },
        { "sk", GladiaTranscriberLanguage.Sk },
        { "sl", GladiaTranscriberLanguage.Sl },
        { "so", GladiaTranscriberLanguage.So },
        { "es", GladiaTranscriberLanguage.Es },
        { "su", GladiaTranscriberLanguage.Su },
        { "sw", GladiaTranscriberLanguage.Sw },
        { "sv", GladiaTranscriberLanguage.Sv },
        { "tl", GladiaTranscriberLanguage.Tl },
        { "tg", GladiaTranscriberLanguage.Tg },
        { "ta", GladiaTranscriberLanguage.Ta },
        { "tt", GladiaTranscriberLanguage.Tt },
        { "te", GladiaTranscriberLanguage.Te },
        { "th", GladiaTranscriberLanguage.Th },
        { "bo", GladiaTranscriberLanguage.Bo },
        { "tr", GladiaTranscriberLanguage.Tr },
        { "tk", GladiaTranscriberLanguage.Tk },
        { "uk", GladiaTranscriberLanguage.Uk },
        { "ur", GladiaTranscriberLanguage.Ur },
        { "uz", GladiaTranscriberLanguage.Uz },
        { "vi", GladiaTranscriberLanguage.Vi },
        { "cy", GladiaTranscriberLanguage.Cy },
        { "yi", GladiaTranscriberLanguage.Yi },
        { "yo", GladiaTranscriberLanguage.Yo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GladiaTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { GladiaTranscriberLanguage.Af, "af" },
        { GladiaTranscriberLanguage.Sq, "sq" },
        { GladiaTranscriberLanguage.Am, "am" },
        { GladiaTranscriberLanguage.Ar, "ar" },
        { GladiaTranscriberLanguage.Hy, "hy" },
        { GladiaTranscriberLanguage.As, "as" },
        { GladiaTranscriberLanguage.Az, "az" },
        { GladiaTranscriberLanguage.Ba, "ba" },
        { GladiaTranscriberLanguage.Eu, "eu" },
        { GladiaTranscriberLanguage.Be, "be" },
        { GladiaTranscriberLanguage.Bn, "bn" },
        { GladiaTranscriberLanguage.Bs, "bs" },
        { GladiaTranscriberLanguage.Br, "br" },
        { GladiaTranscriberLanguage.Bg, "bg" },
        { GladiaTranscriberLanguage.Ca, "ca" },
        { GladiaTranscriberLanguage.Zh, "zh" },
        { GladiaTranscriberLanguage.Hr, "hr" },
        { GladiaTranscriberLanguage.Cs, "cs" },
        { GladiaTranscriberLanguage.Da, "da" },
        { GladiaTranscriberLanguage.Nl, "nl" },
        { GladiaTranscriberLanguage.En, "en" },
        { GladiaTranscriberLanguage.Et, "et" },
        { GladiaTranscriberLanguage.Fo, "fo" },
        { GladiaTranscriberLanguage.Fi, "fi" },
        { GladiaTranscriberLanguage.Fr, "fr" },
        { GladiaTranscriberLanguage.Gl, "gl" },
        { GladiaTranscriberLanguage.Ka, "ka" },
        { GladiaTranscriberLanguage.De, "de" },
        { GladiaTranscriberLanguage.El, "el" },
        { GladiaTranscriberLanguage.Gu, "gu" },
        { GladiaTranscriberLanguage.Ht, "ht" },
        { GladiaTranscriberLanguage.Ha, "ha" },
        { GladiaTranscriberLanguage.Haw, "haw" },
        { GladiaTranscriberLanguage.He, "he" },
        { GladiaTranscriberLanguage.Hi, "hi" },
        { GladiaTranscriberLanguage.Hu, "hu" },
        { GladiaTranscriberLanguage.Is, "is" },
        { GladiaTranscriberLanguage.Id, "id" },
        { GladiaTranscriberLanguage.It, "it" },
        { GladiaTranscriberLanguage.Ja, "ja" },
        { GladiaTranscriberLanguage.Jv, "jv" },
        { GladiaTranscriberLanguage.Kn, "kn" },
        { GladiaTranscriberLanguage.Kk, "kk" },
        { GladiaTranscriberLanguage.Km, "km" },
        { GladiaTranscriberLanguage.Ko, "ko" },
        { GladiaTranscriberLanguage.Lo, "lo" },
        { GladiaTranscriberLanguage.La, "la" },
        { GladiaTranscriberLanguage.Lv, "lv" },
        { GladiaTranscriberLanguage.Ln, "ln" },
        { GladiaTranscriberLanguage.Lt, "lt" },
        { GladiaTranscriberLanguage.Lb, "lb" },
        { GladiaTranscriberLanguage.Mk, "mk" },
        { GladiaTranscriberLanguage.Mg, "mg" },
        { GladiaTranscriberLanguage.Ms, "ms" },
        { GladiaTranscriberLanguage.Ml, "ml" },
        { GladiaTranscriberLanguage.Mt, "mt" },
        { GladiaTranscriberLanguage.Mi, "mi" },
        { GladiaTranscriberLanguage.Mr, "mr" },
        { GladiaTranscriberLanguage.Mn, "mn" },
        { GladiaTranscriberLanguage.My, "my" },
        { GladiaTranscriberLanguage.Ne, "ne" },
        { GladiaTranscriberLanguage.No, "no" },
        { GladiaTranscriberLanguage.Nn, "nn" },
        { GladiaTranscriberLanguage.Oc, "oc" },
        { GladiaTranscriberLanguage.Ps, "ps" },
        { GladiaTranscriberLanguage.Fa, "fa" },
        { GladiaTranscriberLanguage.Pl, "pl" },
        { GladiaTranscriberLanguage.Pt, "pt" },
        { GladiaTranscriberLanguage.Pa, "pa" },
        { GladiaTranscriberLanguage.Ro, "ro" },
        { GladiaTranscriberLanguage.Ru, "ru" },
        { GladiaTranscriberLanguage.Sa, "sa" },
        { GladiaTranscriberLanguage.Sr, "sr" },
        { GladiaTranscriberLanguage.Sn, "sn" },
        { GladiaTranscriberLanguage.Sd, "sd" },
        { GladiaTranscriberLanguage.Si, "si" },
        { GladiaTranscriberLanguage.Sk, "sk" },
        { GladiaTranscriberLanguage.Sl, "sl" },
        { GladiaTranscriberLanguage.So, "so" },
        { GladiaTranscriberLanguage.Es, "es" },
        { GladiaTranscriberLanguage.Su, "su" },
        { GladiaTranscriberLanguage.Sw, "sw" },
        { GladiaTranscriberLanguage.Sv, "sv" },
        { GladiaTranscriberLanguage.Tl, "tl" },
        { GladiaTranscriberLanguage.Tg, "tg" },
        { GladiaTranscriberLanguage.Ta, "ta" },
        { GladiaTranscriberLanguage.Tt, "tt" },
        { GladiaTranscriberLanguage.Te, "te" },
        { GladiaTranscriberLanguage.Th, "th" },
        { GladiaTranscriberLanguage.Bo, "bo" },
        { GladiaTranscriberLanguage.Tr, "tr" },
        { GladiaTranscriberLanguage.Tk, "tk" },
        { GladiaTranscriberLanguage.Uk, "uk" },
        { GladiaTranscriberLanguage.Ur, "ur" },
        { GladiaTranscriberLanguage.Uz, "uz" },
        { GladiaTranscriberLanguage.Vi, "vi" },
        { GladiaTranscriberLanguage.Cy, "cy" },
        { GladiaTranscriberLanguage.Yi, "yi" },
        { GladiaTranscriberLanguage.Yo, "yo" },
    };

    public override GladiaTranscriberLanguage Read(
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
        GladiaTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GladiaTranscriberLanguage ReadAsPropertyName(
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
        GladiaTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
