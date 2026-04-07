using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GladiaTranscriberLanguagesSerializer))]
public enum GladiaTranscriberLanguages
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

internal class GladiaTranscriberLanguagesSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GladiaTranscriberLanguages>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GladiaTranscriberLanguages
    > _stringToEnum = new()
    {
        { "af", GladiaTranscriberLanguages.Af },
        { "sq", GladiaTranscriberLanguages.Sq },
        { "am", GladiaTranscriberLanguages.Am },
        { "ar", GladiaTranscriberLanguages.Ar },
        { "hy", GladiaTranscriberLanguages.Hy },
        { "as", GladiaTranscriberLanguages.As },
        { "az", GladiaTranscriberLanguages.Az },
        { "ba", GladiaTranscriberLanguages.Ba },
        { "eu", GladiaTranscriberLanguages.Eu },
        { "be", GladiaTranscriberLanguages.Be },
        { "bn", GladiaTranscriberLanguages.Bn },
        { "bs", GladiaTranscriberLanguages.Bs },
        { "br", GladiaTranscriberLanguages.Br },
        { "bg", GladiaTranscriberLanguages.Bg },
        { "ca", GladiaTranscriberLanguages.Ca },
        { "zh", GladiaTranscriberLanguages.Zh },
        { "hr", GladiaTranscriberLanguages.Hr },
        { "cs", GladiaTranscriberLanguages.Cs },
        { "da", GladiaTranscriberLanguages.Da },
        { "nl", GladiaTranscriberLanguages.Nl },
        { "en", GladiaTranscriberLanguages.En },
        { "et", GladiaTranscriberLanguages.Et },
        { "fo", GladiaTranscriberLanguages.Fo },
        { "fi", GladiaTranscriberLanguages.Fi },
        { "fr", GladiaTranscriberLanguages.Fr },
        { "gl", GladiaTranscriberLanguages.Gl },
        { "ka", GladiaTranscriberLanguages.Ka },
        { "de", GladiaTranscriberLanguages.De },
        { "el", GladiaTranscriberLanguages.El },
        { "gu", GladiaTranscriberLanguages.Gu },
        { "ht", GladiaTranscriberLanguages.Ht },
        { "ha", GladiaTranscriberLanguages.Ha },
        { "haw", GladiaTranscriberLanguages.Haw },
        { "he", GladiaTranscriberLanguages.He },
        { "hi", GladiaTranscriberLanguages.Hi },
        { "hu", GladiaTranscriberLanguages.Hu },
        { "is", GladiaTranscriberLanguages.Is },
        { "id", GladiaTranscriberLanguages.Id },
        { "it", GladiaTranscriberLanguages.It },
        { "ja", GladiaTranscriberLanguages.Ja },
        { "jv", GladiaTranscriberLanguages.Jv },
        { "kn", GladiaTranscriberLanguages.Kn },
        { "kk", GladiaTranscriberLanguages.Kk },
        { "km", GladiaTranscriberLanguages.Km },
        { "ko", GladiaTranscriberLanguages.Ko },
        { "lo", GladiaTranscriberLanguages.Lo },
        { "la", GladiaTranscriberLanguages.La },
        { "lv", GladiaTranscriberLanguages.Lv },
        { "ln", GladiaTranscriberLanguages.Ln },
        { "lt", GladiaTranscriberLanguages.Lt },
        { "lb", GladiaTranscriberLanguages.Lb },
        { "mk", GladiaTranscriberLanguages.Mk },
        { "mg", GladiaTranscriberLanguages.Mg },
        { "ms", GladiaTranscriberLanguages.Ms },
        { "ml", GladiaTranscriberLanguages.Ml },
        { "mt", GladiaTranscriberLanguages.Mt },
        { "mi", GladiaTranscriberLanguages.Mi },
        { "mr", GladiaTranscriberLanguages.Mr },
        { "mn", GladiaTranscriberLanguages.Mn },
        { "my", GladiaTranscriberLanguages.My },
        { "ne", GladiaTranscriberLanguages.Ne },
        { "no", GladiaTranscriberLanguages.No },
        { "nn", GladiaTranscriberLanguages.Nn },
        { "oc", GladiaTranscriberLanguages.Oc },
        { "ps", GladiaTranscriberLanguages.Ps },
        { "fa", GladiaTranscriberLanguages.Fa },
        { "pl", GladiaTranscriberLanguages.Pl },
        { "pt", GladiaTranscriberLanguages.Pt },
        { "pa", GladiaTranscriberLanguages.Pa },
        { "ro", GladiaTranscriberLanguages.Ro },
        { "ru", GladiaTranscriberLanguages.Ru },
        { "sa", GladiaTranscriberLanguages.Sa },
        { "sr", GladiaTranscriberLanguages.Sr },
        { "sn", GladiaTranscriberLanguages.Sn },
        { "sd", GladiaTranscriberLanguages.Sd },
        { "si", GladiaTranscriberLanguages.Si },
        { "sk", GladiaTranscriberLanguages.Sk },
        { "sl", GladiaTranscriberLanguages.Sl },
        { "so", GladiaTranscriberLanguages.So },
        { "es", GladiaTranscriberLanguages.Es },
        { "su", GladiaTranscriberLanguages.Su },
        { "sw", GladiaTranscriberLanguages.Sw },
        { "sv", GladiaTranscriberLanguages.Sv },
        { "tl", GladiaTranscriberLanguages.Tl },
        { "tg", GladiaTranscriberLanguages.Tg },
        { "ta", GladiaTranscriberLanguages.Ta },
        { "tt", GladiaTranscriberLanguages.Tt },
        { "te", GladiaTranscriberLanguages.Te },
        { "th", GladiaTranscriberLanguages.Th },
        { "bo", GladiaTranscriberLanguages.Bo },
        { "tr", GladiaTranscriberLanguages.Tr },
        { "tk", GladiaTranscriberLanguages.Tk },
        { "uk", GladiaTranscriberLanguages.Uk },
        { "ur", GladiaTranscriberLanguages.Ur },
        { "uz", GladiaTranscriberLanguages.Uz },
        { "vi", GladiaTranscriberLanguages.Vi },
        { "cy", GladiaTranscriberLanguages.Cy },
        { "yi", GladiaTranscriberLanguages.Yi },
        { "yo", GladiaTranscriberLanguages.Yo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GladiaTranscriberLanguages,
        string
    > _enumToString = new()
    {
        { GladiaTranscriberLanguages.Af, "af" },
        { GladiaTranscriberLanguages.Sq, "sq" },
        { GladiaTranscriberLanguages.Am, "am" },
        { GladiaTranscriberLanguages.Ar, "ar" },
        { GladiaTranscriberLanguages.Hy, "hy" },
        { GladiaTranscriberLanguages.As, "as" },
        { GladiaTranscriberLanguages.Az, "az" },
        { GladiaTranscriberLanguages.Ba, "ba" },
        { GladiaTranscriberLanguages.Eu, "eu" },
        { GladiaTranscriberLanguages.Be, "be" },
        { GladiaTranscriberLanguages.Bn, "bn" },
        { GladiaTranscriberLanguages.Bs, "bs" },
        { GladiaTranscriberLanguages.Br, "br" },
        { GladiaTranscriberLanguages.Bg, "bg" },
        { GladiaTranscriberLanguages.Ca, "ca" },
        { GladiaTranscriberLanguages.Zh, "zh" },
        { GladiaTranscriberLanguages.Hr, "hr" },
        { GladiaTranscriberLanguages.Cs, "cs" },
        { GladiaTranscriberLanguages.Da, "da" },
        { GladiaTranscriberLanguages.Nl, "nl" },
        { GladiaTranscriberLanguages.En, "en" },
        { GladiaTranscriberLanguages.Et, "et" },
        { GladiaTranscriberLanguages.Fo, "fo" },
        { GladiaTranscriberLanguages.Fi, "fi" },
        { GladiaTranscriberLanguages.Fr, "fr" },
        { GladiaTranscriberLanguages.Gl, "gl" },
        { GladiaTranscriberLanguages.Ka, "ka" },
        { GladiaTranscriberLanguages.De, "de" },
        { GladiaTranscriberLanguages.El, "el" },
        { GladiaTranscriberLanguages.Gu, "gu" },
        { GladiaTranscriberLanguages.Ht, "ht" },
        { GladiaTranscriberLanguages.Ha, "ha" },
        { GladiaTranscriberLanguages.Haw, "haw" },
        { GladiaTranscriberLanguages.He, "he" },
        { GladiaTranscriberLanguages.Hi, "hi" },
        { GladiaTranscriberLanguages.Hu, "hu" },
        { GladiaTranscriberLanguages.Is, "is" },
        { GladiaTranscriberLanguages.Id, "id" },
        { GladiaTranscriberLanguages.It, "it" },
        { GladiaTranscriberLanguages.Ja, "ja" },
        { GladiaTranscriberLanguages.Jv, "jv" },
        { GladiaTranscriberLanguages.Kn, "kn" },
        { GladiaTranscriberLanguages.Kk, "kk" },
        { GladiaTranscriberLanguages.Km, "km" },
        { GladiaTranscriberLanguages.Ko, "ko" },
        { GladiaTranscriberLanguages.Lo, "lo" },
        { GladiaTranscriberLanguages.La, "la" },
        { GladiaTranscriberLanguages.Lv, "lv" },
        { GladiaTranscriberLanguages.Ln, "ln" },
        { GladiaTranscriberLanguages.Lt, "lt" },
        { GladiaTranscriberLanguages.Lb, "lb" },
        { GladiaTranscriberLanguages.Mk, "mk" },
        { GladiaTranscriberLanguages.Mg, "mg" },
        { GladiaTranscriberLanguages.Ms, "ms" },
        { GladiaTranscriberLanguages.Ml, "ml" },
        { GladiaTranscriberLanguages.Mt, "mt" },
        { GladiaTranscriberLanguages.Mi, "mi" },
        { GladiaTranscriberLanguages.Mr, "mr" },
        { GladiaTranscriberLanguages.Mn, "mn" },
        { GladiaTranscriberLanguages.My, "my" },
        { GladiaTranscriberLanguages.Ne, "ne" },
        { GladiaTranscriberLanguages.No, "no" },
        { GladiaTranscriberLanguages.Nn, "nn" },
        { GladiaTranscriberLanguages.Oc, "oc" },
        { GladiaTranscriberLanguages.Ps, "ps" },
        { GladiaTranscriberLanguages.Fa, "fa" },
        { GladiaTranscriberLanguages.Pl, "pl" },
        { GladiaTranscriberLanguages.Pt, "pt" },
        { GladiaTranscriberLanguages.Pa, "pa" },
        { GladiaTranscriberLanguages.Ro, "ro" },
        { GladiaTranscriberLanguages.Ru, "ru" },
        { GladiaTranscriberLanguages.Sa, "sa" },
        { GladiaTranscriberLanguages.Sr, "sr" },
        { GladiaTranscriberLanguages.Sn, "sn" },
        { GladiaTranscriberLanguages.Sd, "sd" },
        { GladiaTranscriberLanguages.Si, "si" },
        { GladiaTranscriberLanguages.Sk, "sk" },
        { GladiaTranscriberLanguages.Sl, "sl" },
        { GladiaTranscriberLanguages.So, "so" },
        { GladiaTranscriberLanguages.Es, "es" },
        { GladiaTranscriberLanguages.Su, "su" },
        { GladiaTranscriberLanguages.Sw, "sw" },
        { GladiaTranscriberLanguages.Sv, "sv" },
        { GladiaTranscriberLanguages.Tl, "tl" },
        { GladiaTranscriberLanguages.Tg, "tg" },
        { GladiaTranscriberLanguages.Ta, "ta" },
        { GladiaTranscriberLanguages.Tt, "tt" },
        { GladiaTranscriberLanguages.Te, "te" },
        { GladiaTranscriberLanguages.Th, "th" },
        { GladiaTranscriberLanguages.Bo, "bo" },
        { GladiaTranscriberLanguages.Tr, "tr" },
        { GladiaTranscriberLanguages.Tk, "tk" },
        { GladiaTranscriberLanguages.Uk, "uk" },
        { GladiaTranscriberLanguages.Ur, "ur" },
        { GladiaTranscriberLanguages.Uz, "uz" },
        { GladiaTranscriberLanguages.Vi, "vi" },
        { GladiaTranscriberLanguages.Cy, "cy" },
        { GladiaTranscriberLanguages.Yi, "yi" },
        { GladiaTranscriberLanguages.Yo, "yo" },
    };

    public override GladiaTranscriberLanguages Read(
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
        GladiaTranscriberLanguages value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GladiaTranscriberLanguages ReadAsPropertyName(
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
        GladiaTranscriberLanguages value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
