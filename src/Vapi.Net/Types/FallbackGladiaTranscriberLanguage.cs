using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGladiaTranscriberLanguageSerializer))]
public enum FallbackGladiaTranscriberLanguage
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

internal class FallbackGladiaTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGladiaTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGladiaTranscriberLanguage
    > _stringToEnum = new()
    {
        { "af", FallbackGladiaTranscriberLanguage.Af },
        { "sq", FallbackGladiaTranscriberLanguage.Sq },
        { "am", FallbackGladiaTranscriberLanguage.Am },
        { "ar", FallbackGladiaTranscriberLanguage.Ar },
        { "hy", FallbackGladiaTranscriberLanguage.Hy },
        { "as", FallbackGladiaTranscriberLanguage.As },
        { "az", FallbackGladiaTranscriberLanguage.Az },
        { "ba", FallbackGladiaTranscriberLanguage.Ba },
        { "eu", FallbackGladiaTranscriberLanguage.Eu },
        { "be", FallbackGladiaTranscriberLanguage.Be },
        { "bn", FallbackGladiaTranscriberLanguage.Bn },
        { "bs", FallbackGladiaTranscriberLanguage.Bs },
        { "br", FallbackGladiaTranscriberLanguage.Br },
        { "bg", FallbackGladiaTranscriberLanguage.Bg },
        { "ca", FallbackGladiaTranscriberLanguage.Ca },
        { "zh", FallbackGladiaTranscriberLanguage.Zh },
        { "hr", FallbackGladiaTranscriberLanguage.Hr },
        { "cs", FallbackGladiaTranscriberLanguage.Cs },
        { "da", FallbackGladiaTranscriberLanguage.Da },
        { "nl", FallbackGladiaTranscriberLanguage.Nl },
        { "en", FallbackGladiaTranscriberLanguage.En },
        { "et", FallbackGladiaTranscriberLanguage.Et },
        { "fo", FallbackGladiaTranscriberLanguage.Fo },
        { "fi", FallbackGladiaTranscriberLanguage.Fi },
        { "fr", FallbackGladiaTranscriberLanguage.Fr },
        { "gl", FallbackGladiaTranscriberLanguage.Gl },
        { "ka", FallbackGladiaTranscriberLanguage.Ka },
        { "de", FallbackGladiaTranscriberLanguage.De },
        { "el", FallbackGladiaTranscriberLanguage.El },
        { "gu", FallbackGladiaTranscriberLanguage.Gu },
        { "ht", FallbackGladiaTranscriberLanguage.Ht },
        { "ha", FallbackGladiaTranscriberLanguage.Ha },
        { "haw", FallbackGladiaTranscriberLanguage.Haw },
        { "he", FallbackGladiaTranscriberLanguage.He },
        { "hi", FallbackGladiaTranscriberLanguage.Hi },
        { "hu", FallbackGladiaTranscriberLanguage.Hu },
        { "is", FallbackGladiaTranscriberLanguage.Is },
        { "id", FallbackGladiaTranscriberLanguage.Id },
        { "it", FallbackGladiaTranscriberLanguage.It },
        { "ja", FallbackGladiaTranscriberLanguage.Ja },
        { "jv", FallbackGladiaTranscriberLanguage.Jv },
        { "kn", FallbackGladiaTranscriberLanguage.Kn },
        { "kk", FallbackGladiaTranscriberLanguage.Kk },
        { "km", FallbackGladiaTranscriberLanguage.Km },
        { "ko", FallbackGladiaTranscriberLanguage.Ko },
        { "lo", FallbackGladiaTranscriberLanguage.Lo },
        { "la", FallbackGladiaTranscriberLanguage.La },
        { "lv", FallbackGladiaTranscriberLanguage.Lv },
        { "ln", FallbackGladiaTranscriberLanguage.Ln },
        { "lt", FallbackGladiaTranscriberLanguage.Lt },
        { "lb", FallbackGladiaTranscriberLanguage.Lb },
        { "mk", FallbackGladiaTranscriberLanguage.Mk },
        { "mg", FallbackGladiaTranscriberLanguage.Mg },
        { "ms", FallbackGladiaTranscriberLanguage.Ms },
        { "ml", FallbackGladiaTranscriberLanguage.Ml },
        { "mt", FallbackGladiaTranscriberLanguage.Mt },
        { "mi", FallbackGladiaTranscriberLanguage.Mi },
        { "mr", FallbackGladiaTranscriberLanguage.Mr },
        { "mn", FallbackGladiaTranscriberLanguage.Mn },
        { "my", FallbackGladiaTranscriberLanguage.My },
        { "ne", FallbackGladiaTranscriberLanguage.Ne },
        { "no", FallbackGladiaTranscriberLanguage.No },
        { "nn", FallbackGladiaTranscriberLanguage.Nn },
        { "oc", FallbackGladiaTranscriberLanguage.Oc },
        { "ps", FallbackGladiaTranscriberLanguage.Ps },
        { "fa", FallbackGladiaTranscriberLanguage.Fa },
        { "pl", FallbackGladiaTranscriberLanguage.Pl },
        { "pt", FallbackGladiaTranscriberLanguage.Pt },
        { "pa", FallbackGladiaTranscriberLanguage.Pa },
        { "ro", FallbackGladiaTranscriberLanguage.Ro },
        { "ru", FallbackGladiaTranscriberLanguage.Ru },
        { "sa", FallbackGladiaTranscriberLanguage.Sa },
        { "sr", FallbackGladiaTranscriberLanguage.Sr },
        { "sn", FallbackGladiaTranscriberLanguage.Sn },
        { "sd", FallbackGladiaTranscriberLanguage.Sd },
        { "si", FallbackGladiaTranscriberLanguage.Si },
        { "sk", FallbackGladiaTranscriberLanguage.Sk },
        { "sl", FallbackGladiaTranscriberLanguage.Sl },
        { "so", FallbackGladiaTranscriberLanguage.So },
        { "es", FallbackGladiaTranscriberLanguage.Es },
        { "su", FallbackGladiaTranscriberLanguage.Su },
        { "sw", FallbackGladiaTranscriberLanguage.Sw },
        { "sv", FallbackGladiaTranscriberLanguage.Sv },
        { "tl", FallbackGladiaTranscriberLanguage.Tl },
        { "tg", FallbackGladiaTranscriberLanguage.Tg },
        { "ta", FallbackGladiaTranscriberLanguage.Ta },
        { "tt", FallbackGladiaTranscriberLanguage.Tt },
        { "te", FallbackGladiaTranscriberLanguage.Te },
        { "th", FallbackGladiaTranscriberLanguage.Th },
        { "bo", FallbackGladiaTranscriberLanguage.Bo },
        { "tr", FallbackGladiaTranscriberLanguage.Tr },
        { "tk", FallbackGladiaTranscriberLanguage.Tk },
        { "uk", FallbackGladiaTranscriberLanguage.Uk },
        { "ur", FallbackGladiaTranscriberLanguage.Ur },
        { "uz", FallbackGladiaTranscriberLanguage.Uz },
        { "vi", FallbackGladiaTranscriberLanguage.Vi },
        { "cy", FallbackGladiaTranscriberLanguage.Cy },
        { "yi", FallbackGladiaTranscriberLanguage.Yi },
        { "yo", FallbackGladiaTranscriberLanguage.Yo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGladiaTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackGladiaTranscriberLanguage.Af, "af" },
        { FallbackGladiaTranscriberLanguage.Sq, "sq" },
        { FallbackGladiaTranscriberLanguage.Am, "am" },
        { FallbackGladiaTranscriberLanguage.Ar, "ar" },
        { FallbackGladiaTranscriberLanguage.Hy, "hy" },
        { FallbackGladiaTranscriberLanguage.As, "as" },
        { FallbackGladiaTranscriberLanguage.Az, "az" },
        { FallbackGladiaTranscriberLanguage.Ba, "ba" },
        { FallbackGladiaTranscriberLanguage.Eu, "eu" },
        { FallbackGladiaTranscriberLanguage.Be, "be" },
        { FallbackGladiaTranscriberLanguage.Bn, "bn" },
        { FallbackGladiaTranscriberLanguage.Bs, "bs" },
        { FallbackGladiaTranscriberLanguage.Br, "br" },
        { FallbackGladiaTranscriberLanguage.Bg, "bg" },
        { FallbackGladiaTranscriberLanguage.Ca, "ca" },
        { FallbackGladiaTranscriberLanguage.Zh, "zh" },
        { FallbackGladiaTranscriberLanguage.Hr, "hr" },
        { FallbackGladiaTranscriberLanguage.Cs, "cs" },
        { FallbackGladiaTranscriberLanguage.Da, "da" },
        { FallbackGladiaTranscriberLanguage.Nl, "nl" },
        { FallbackGladiaTranscriberLanguage.En, "en" },
        { FallbackGladiaTranscriberLanguage.Et, "et" },
        { FallbackGladiaTranscriberLanguage.Fo, "fo" },
        { FallbackGladiaTranscriberLanguage.Fi, "fi" },
        { FallbackGladiaTranscriberLanguage.Fr, "fr" },
        { FallbackGladiaTranscriberLanguage.Gl, "gl" },
        { FallbackGladiaTranscriberLanguage.Ka, "ka" },
        { FallbackGladiaTranscriberLanguage.De, "de" },
        { FallbackGladiaTranscriberLanguage.El, "el" },
        { FallbackGladiaTranscriberLanguage.Gu, "gu" },
        { FallbackGladiaTranscriberLanguage.Ht, "ht" },
        { FallbackGladiaTranscriberLanguage.Ha, "ha" },
        { FallbackGladiaTranscriberLanguage.Haw, "haw" },
        { FallbackGladiaTranscriberLanguage.He, "he" },
        { FallbackGladiaTranscriberLanguage.Hi, "hi" },
        { FallbackGladiaTranscriberLanguage.Hu, "hu" },
        { FallbackGladiaTranscriberLanguage.Is, "is" },
        { FallbackGladiaTranscriberLanguage.Id, "id" },
        { FallbackGladiaTranscriberLanguage.It, "it" },
        { FallbackGladiaTranscriberLanguage.Ja, "ja" },
        { FallbackGladiaTranscriberLanguage.Jv, "jv" },
        { FallbackGladiaTranscriberLanguage.Kn, "kn" },
        { FallbackGladiaTranscriberLanguage.Kk, "kk" },
        { FallbackGladiaTranscriberLanguage.Km, "km" },
        { FallbackGladiaTranscriberLanguage.Ko, "ko" },
        { FallbackGladiaTranscriberLanguage.Lo, "lo" },
        { FallbackGladiaTranscriberLanguage.La, "la" },
        { FallbackGladiaTranscriberLanguage.Lv, "lv" },
        { FallbackGladiaTranscriberLanguage.Ln, "ln" },
        { FallbackGladiaTranscriberLanguage.Lt, "lt" },
        { FallbackGladiaTranscriberLanguage.Lb, "lb" },
        { FallbackGladiaTranscriberLanguage.Mk, "mk" },
        { FallbackGladiaTranscriberLanguage.Mg, "mg" },
        { FallbackGladiaTranscriberLanguage.Ms, "ms" },
        { FallbackGladiaTranscriberLanguage.Ml, "ml" },
        { FallbackGladiaTranscriberLanguage.Mt, "mt" },
        { FallbackGladiaTranscriberLanguage.Mi, "mi" },
        { FallbackGladiaTranscriberLanguage.Mr, "mr" },
        { FallbackGladiaTranscriberLanguage.Mn, "mn" },
        { FallbackGladiaTranscriberLanguage.My, "my" },
        { FallbackGladiaTranscriberLanguage.Ne, "ne" },
        { FallbackGladiaTranscriberLanguage.No, "no" },
        { FallbackGladiaTranscriberLanguage.Nn, "nn" },
        { FallbackGladiaTranscriberLanguage.Oc, "oc" },
        { FallbackGladiaTranscriberLanguage.Ps, "ps" },
        { FallbackGladiaTranscriberLanguage.Fa, "fa" },
        { FallbackGladiaTranscriberLanguage.Pl, "pl" },
        { FallbackGladiaTranscriberLanguage.Pt, "pt" },
        { FallbackGladiaTranscriberLanguage.Pa, "pa" },
        { FallbackGladiaTranscriberLanguage.Ro, "ro" },
        { FallbackGladiaTranscriberLanguage.Ru, "ru" },
        { FallbackGladiaTranscriberLanguage.Sa, "sa" },
        { FallbackGladiaTranscriberLanguage.Sr, "sr" },
        { FallbackGladiaTranscriberLanguage.Sn, "sn" },
        { FallbackGladiaTranscriberLanguage.Sd, "sd" },
        { FallbackGladiaTranscriberLanguage.Si, "si" },
        { FallbackGladiaTranscriberLanguage.Sk, "sk" },
        { FallbackGladiaTranscriberLanguage.Sl, "sl" },
        { FallbackGladiaTranscriberLanguage.So, "so" },
        { FallbackGladiaTranscriberLanguage.Es, "es" },
        { FallbackGladiaTranscriberLanguage.Su, "su" },
        { FallbackGladiaTranscriberLanguage.Sw, "sw" },
        { FallbackGladiaTranscriberLanguage.Sv, "sv" },
        { FallbackGladiaTranscriberLanguage.Tl, "tl" },
        { FallbackGladiaTranscriberLanguage.Tg, "tg" },
        { FallbackGladiaTranscriberLanguage.Ta, "ta" },
        { FallbackGladiaTranscriberLanguage.Tt, "tt" },
        { FallbackGladiaTranscriberLanguage.Te, "te" },
        { FallbackGladiaTranscriberLanguage.Th, "th" },
        { FallbackGladiaTranscriberLanguage.Bo, "bo" },
        { FallbackGladiaTranscriberLanguage.Tr, "tr" },
        { FallbackGladiaTranscriberLanguage.Tk, "tk" },
        { FallbackGladiaTranscriberLanguage.Uk, "uk" },
        { FallbackGladiaTranscriberLanguage.Ur, "ur" },
        { FallbackGladiaTranscriberLanguage.Uz, "uz" },
        { FallbackGladiaTranscriberLanguage.Vi, "vi" },
        { FallbackGladiaTranscriberLanguage.Cy, "cy" },
        { FallbackGladiaTranscriberLanguage.Yi, "yi" },
        { FallbackGladiaTranscriberLanguage.Yo, "yo" },
    };

    public override FallbackGladiaTranscriberLanguage Read(
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
        FallbackGladiaTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGladiaTranscriberLanguage ReadAsPropertyName(
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
        FallbackGladiaTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
