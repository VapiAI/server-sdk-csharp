using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGladiaTranscriberLanguagesSerializer))]
public enum FallbackGladiaTranscriberLanguages
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

internal class FallbackGladiaTranscriberLanguagesSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGladiaTranscriberLanguages>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGladiaTranscriberLanguages
    > _stringToEnum = new()
    {
        { "af", FallbackGladiaTranscriberLanguages.Af },
        { "sq", FallbackGladiaTranscriberLanguages.Sq },
        { "am", FallbackGladiaTranscriberLanguages.Am },
        { "ar", FallbackGladiaTranscriberLanguages.Ar },
        { "hy", FallbackGladiaTranscriberLanguages.Hy },
        { "as", FallbackGladiaTranscriberLanguages.As },
        { "az", FallbackGladiaTranscriberLanguages.Az },
        { "ba", FallbackGladiaTranscriberLanguages.Ba },
        { "eu", FallbackGladiaTranscriberLanguages.Eu },
        { "be", FallbackGladiaTranscriberLanguages.Be },
        { "bn", FallbackGladiaTranscriberLanguages.Bn },
        { "bs", FallbackGladiaTranscriberLanguages.Bs },
        { "br", FallbackGladiaTranscriberLanguages.Br },
        { "bg", FallbackGladiaTranscriberLanguages.Bg },
        { "ca", FallbackGladiaTranscriberLanguages.Ca },
        { "zh", FallbackGladiaTranscriberLanguages.Zh },
        { "hr", FallbackGladiaTranscriberLanguages.Hr },
        { "cs", FallbackGladiaTranscriberLanguages.Cs },
        { "da", FallbackGladiaTranscriberLanguages.Da },
        { "nl", FallbackGladiaTranscriberLanguages.Nl },
        { "en", FallbackGladiaTranscriberLanguages.En },
        { "et", FallbackGladiaTranscriberLanguages.Et },
        { "fo", FallbackGladiaTranscriberLanguages.Fo },
        { "fi", FallbackGladiaTranscriberLanguages.Fi },
        { "fr", FallbackGladiaTranscriberLanguages.Fr },
        { "gl", FallbackGladiaTranscriberLanguages.Gl },
        { "ka", FallbackGladiaTranscriberLanguages.Ka },
        { "de", FallbackGladiaTranscriberLanguages.De },
        { "el", FallbackGladiaTranscriberLanguages.El },
        { "gu", FallbackGladiaTranscriberLanguages.Gu },
        { "ht", FallbackGladiaTranscriberLanguages.Ht },
        { "ha", FallbackGladiaTranscriberLanguages.Ha },
        { "haw", FallbackGladiaTranscriberLanguages.Haw },
        { "he", FallbackGladiaTranscriberLanguages.He },
        { "hi", FallbackGladiaTranscriberLanguages.Hi },
        { "hu", FallbackGladiaTranscriberLanguages.Hu },
        { "is", FallbackGladiaTranscriberLanguages.Is },
        { "id", FallbackGladiaTranscriberLanguages.Id },
        { "it", FallbackGladiaTranscriberLanguages.It },
        { "ja", FallbackGladiaTranscriberLanguages.Ja },
        { "jv", FallbackGladiaTranscriberLanguages.Jv },
        { "kn", FallbackGladiaTranscriberLanguages.Kn },
        { "kk", FallbackGladiaTranscriberLanguages.Kk },
        { "km", FallbackGladiaTranscriberLanguages.Km },
        { "ko", FallbackGladiaTranscriberLanguages.Ko },
        { "lo", FallbackGladiaTranscriberLanguages.Lo },
        { "la", FallbackGladiaTranscriberLanguages.La },
        { "lv", FallbackGladiaTranscriberLanguages.Lv },
        { "ln", FallbackGladiaTranscriberLanguages.Ln },
        { "lt", FallbackGladiaTranscriberLanguages.Lt },
        { "lb", FallbackGladiaTranscriberLanguages.Lb },
        { "mk", FallbackGladiaTranscriberLanguages.Mk },
        { "mg", FallbackGladiaTranscriberLanguages.Mg },
        { "ms", FallbackGladiaTranscriberLanguages.Ms },
        { "ml", FallbackGladiaTranscriberLanguages.Ml },
        { "mt", FallbackGladiaTranscriberLanguages.Mt },
        { "mi", FallbackGladiaTranscriberLanguages.Mi },
        { "mr", FallbackGladiaTranscriberLanguages.Mr },
        { "mn", FallbackGladiaTranscriberLanguages.Mn },
        { "my", FallbackGladiaTranscriberLanguages.My },
        { "ne", FallbackGladiaTranscriberLanguages.Ne },
        { "no", FallbackGladiaTranscriberLanguages.No },
        { "nn", FallbackGladiaTranscriberLanguages.Nn },
        { "oc", FallbackGladiaTranscriberLanguages.Oc },
        { "ps", FallbackGladiaTranscriberLanguages.Ps },
        { "fa", FallbackGladiaTranscriberLanguages.Fa },
        { "pl", FallbackGladiaTranscriberLanguages.Pl },
        { "pt", FallbackGladiaTranscriberLanguages.Pt },
        { "pa", FallbackGladiaTranscriberLanguages.Pa },
        { "ro", FallbackGladiaTranscriberLanguages.Ro },
        { "ru", FallbackGladiaTranscriberLanguages.Ru },
        { "sa", FallbackGladiaTranscriberLanguages.Sa },
        { "sr", FallbackGladiaTranscriberLanguages.Sr },
        { "sn", FallbackGladiaTranscriberLanguages.Sn },
        { "sd", FallbackGladiaTranscriberLanguages.Sd },
        { "si", FallbackGladiaTranscriberLanguages.Si },
        { "sk", FallbackGladiaTranscriberLanguages.Sk },
        { "sl", FallbackGladiaTranscriberLanguages.Sl },
        { "so", FallbackGladiaTranscriberLanguages.So },
        { "es", FallbackGladiaTranscriberLanguages.Es },
        { "su", FallbackGladiaTranscriberLanguages.Su },
        { "sw", FallbackGladiaTranscriberLanguages.Sw },
        { "sv", FallbackGladiaTranscriberLanguages.Sv },
        { "tl", FallbackGladiaTranscriberLanguages.Tl },
        { "tg", FallbackGladiaTranscriberLanguages.Tg },
        { "ta", FallbackGladiaTranscriberLanguages.Ta },
        { "tt", FallbackGladiaTranscriberLanguages.Tt },
        { "te", FallbackGladiaTranscriberLanguages.Te },
        { "th", FallbackGladiaTranscriberLanguages.Th },
        { "bo", FallbackGladiaTranscriberLanguages.Bo },
        { "tr", FallbackGladiaTranscriberLanguages.Tr },
        { "tk", FallbackGladiaTranscriberLanguages.Tk },
        { "uk", FallbackGladiaTranscriberLanguages.Uk },
        { "ur", FallbackGladiaTranscriberLanguages.Ur },
        { "uz", FallbackGladiaTranscriberLanguages.Uz },
        { "vi", FallbackGladiaTranscriberLanguages.Vi },
        { "cy", FallbackGladiaTranscriberLanguages.Cy },
        { "yi", FallbackGladiaTranscriberLanguages.Yi },
        { "yo", FallbackGladiaTranscriberLanguages.Yo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGladiaTranscriberLanguages,
        string
    > _enumToString = new()
    {
        { FallbackGladiaTranscriberLanguages.Af, "af" },
        { FallbackGladiaTranscriberLanguages.Sq, "sq" },
        { FallbackGladiaTranscriberLanguages.Am, "am" },
        { FallbackGladiaTranscriberLanguages.Ar, "ar" },
        { FallbackGladiaTranscriberLanguages.Hy, "hy" },
        { FallbackGladiaTranscriberLanguages.As, "as" },
        { FallbackGladiaTranscriberLanguages.Az, "az" },
        { FallbackGladiaTranscriberLanguages.Ba, "ba" },
        { FallbackGladiaTranscriberLanguages.Eu, "eu" },
        { FallbackGladiaTranscriberLanguages.Be, "be" },
        { FallbackGladiaTranscriberLanguages.Bn, "bn" },
        { FallbackGladiaTranscriberLanguages.Bs, "bs" },
        { FallbackGladiaTranscriberLanguages.Br, "br" },
        { FallbackGladiaTranscriberLanguages.Bg, "bg" },
        { FallbackGladiaTranscriberLanguages.Ca, "ca" },
        { FallbackGladiaTranscriberLanguages.Zh, "zh" },
        { FallbackGladiaTranscriberLanguages.Hr, "hr" },
        { FallbackGladiaTranscriberLanguages.Cs, "cs" },
        { FallbackGladiaTranscriberLanguages.Da, "da" },
        { FallbackGladiaTranscriberLanguages.Nl, "nl" },
        { FallbackGladiaTranscriberLanguages.En, "en" },
        { FallbackGladiaTranscriberLanguages.Et, "et" },
        { FallbackGladiaTranscriberLanguages.Fo, "fo" },
        { FallbackGladiaTranscriberLanguages.Fi, "fi" },
        { FallbackGladiaTranscriberLanguages.Fr, "fr" },
        { FallbackGladiaTranscriberLanguages.Gl, "gl" },
        { FallbackGladiaTranscriberLanguages.Ka, "ka" },
        { FallbackGladiaTranscriberLanguages.De, "de" },
        { FallbackGladiaTranscriberLanguages.El, "el" },
        { FallbackGladiaTranscriberLanguages.Gu, "gu" },
        { FallbackGladiaTranscriberLanguages.Ht, "ht" },
        { FallbackGladiaTranscriberLanguages.Ha, "ha" },
        { FallbackGladiaTranscriberLanguages.Haw, "haw" },
        { FallbackGladiaTranscriberLanguages.He, "he" },
        { FallbackGladiaTranscriberLanguages.Hi, "hi" },
        { FallbackGladiaTranscriberLanguages.Hu, "hu" },
        { FallbackGladiaTranscriberLanguages.Is, "is" },
        { FallbackGladiaTranscriberLanguages.Id, "id" },
        { FallbackGladiaTranscriberLanguages.It, "it" },
        { FallbackGladiaTranscriberLanguages.Ja, "ja" },
        { FallbackGladiaTranscriberLanguages.Jv, "jv" },
        { FallbackGladiaTranscriberLanguages.Kn, "kn" },
        { FallbackGladiaTranscriberLanguages.Kk, "kk" },
        { FallbackGladiaTranscriberLanguages.Km, "km" },
        { FallbackGladiaTranscriberLanguages.Ko, "ko" },
        { FallbackGladiaTranscriberLanguages.Lo, "lo" },
        { FallbackGladiaTranscriberLanguages.La, "la" },
        { FallbackGladiaTranscriberLanguages.Lv, "lv" },
        { FallbackGladiaTranscriberLanguages.Ln, "ln" },
        { FallbackGladiaTranscriberLanguages.Lt, "lt" },
        { FallbackGladiaTranscriberLanguages.Lb, "lb" },
        { FallbackGladiaTranscriberLanguages.Mk, "mk" },
        { FallbackGladiaTranscriberLanguages.Mg, "mg" },
        { FallbackGladiaTranscriberLanguages.Ms, "ms" },
        { FallbackGladiaTranscriberLanguages.Ml, "ml" },
        { FallbackGladiaTranscriberLanguages.Mt, "mt" },
        { FallbackGladiaTranscriberLanguages.Mi, "mi" },
        { FallbackGladiaTranscriberLanguages.Mr, "mr" },
        { FallbackGladiaTranscriberLanguages.Mn, "mn" },
        { FallbackGladiaTranscriberLanguages.My, "my" },
        { FallbackGladiaTranscriberLanguages.Ne, "ne" },
        { FallbackGladiaTranscriberLanguages.No, "no" },
        { FallbackGladiaTranscriberLanguages.Nn, "nn" },
        { FallbackGladiaTranscriberLanguages.Oc, "oc" },
        { FallbackGladiaTranscriberLanguages.Ps, "ps" },
        { FallbackGladiaTranscriberLanguages.Fa, "fa" },
        { FallbackGladiaTranscriberLanguages.Pl, "pl" },
        { FallbackGladiaTranscriberLanguages.Pt, "pt" },
        { FallbackGladiaTranscriberLanguages.Pa, "pa" },
        { FallbackGladiaTranscriberLanguages.Ro, "ro" },
        { FallbackGladiaTranscriberLanguages.Ru, "ru" },
        { FallbackGladiaTranscriberLanguages.Sa, "sa" },
        { FallbackGladiaTranscriberLanguages.Sr, "sr" },
        { FallbackGladiaTranscriberLanguages.Sn, "sn" },
        { FallbackGladiaTranscriberLanguages.Sd, "sd" },
        { FallbackGladiaTranscriberLanguages.Si, "si" },
        { FallbackGladiaTranscriberLanguages.Sk, "sk" },
        { FallbackGladiaTranscriberLanguages.Sl, "sl" },
        { FallbackGladiaTranscriberLanguages.So, "so" },
        { FallbackGladiaTranscriberLanguages.Es, "es" },
        { FallbackGladiaTranscriberLanguages.Su, "su" },
        { FallbackGladiaTranscriberLanguages.Sw, "sw" },
        { FallbackGladiaTranscriberLanguages.Sv, "sv" },
        { FallbackGladiaTranscriberLanguages.Tl, "tl" },
        { FallbackGladiaTranscriberLanguages.Tg, "tg" },
        { FallbackGladiaTranscriberLanguages.Ta, "ta" },
        { FallbackGladiaTranscriberLanguages.Tt, "tt" },
        { FallbackGladiaTranscriberLanguages.Te, "te" },
        { FallbackGladiaTranscriberLanguages.Th, "th" },
        { FallbackGladiaTranscriberLanguages.Bo, "bo" },
        { FallbackGladiaTranscriberLanguages.Tr, "tr" },
        { FallbackGladiaTranscriberLanguages.Tk, "tk" },
        { FallbackGladiaTranscriberLanguages.Uk, "uk" },
        { FallbackGladiaTranscriberLanguages.Ur, "ur" },
        { FallbackGladiaTranscriberLanguages.Uz, "uz" },
        { FallbackGladiaTranscriberLanguages.Vi, "vi" },
        { FallbackGladiaTranscriberLanguages.Cy, "cy" },
        { FallbackGladiaTranscriberLanguages.Yi, "yi" },
        { FallbackGladiaTranscriberLanguages.Yo, "yo" },
    };

    public override FallbackGladiaTranscriberLanguages Read(
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
        FallbackGladiaTranscriberLanguages value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGladiaTranscriberLanguages ReadAsPropertyName(
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
        FallbackGladiaTranscriberLanguages value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
