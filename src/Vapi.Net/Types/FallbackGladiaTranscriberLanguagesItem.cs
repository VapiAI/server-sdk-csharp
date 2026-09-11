using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGladiaTranscriberLanguagesItemSerializer))]
public enum FallbackGladiaTranscriberLanguagesItem
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

internal class FallbackGladiaTranscriberLanguagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGladiaTranscriberLanguagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGladiaTranscriberLanguagesItem
    > _stringToEnum = new()
    {
        { "af", FallbackGladiaTranscriberLanguagesItem.Af },
        { "sq", FallbackGladiaTranscriberLanguagesItem.Sq },
        { "am", FallbackGladiaTranscriberLanguagesItem.Am },
        { "ar", FallbackGladiaTranscriberLanguagesItem.Ar },
        { "hy", FallbackGladiaTranscriberLanguagesItem.Hy },
        { "as", FallbackGladiaTranscriberLanguagesItem.As },
        { "az", FallbackGladiaTranscriberLanguagesItem.Az },
        { "ba", FallbackGladiaTranscriberLanguagesItem.Ba },
        { "eu", FallbackGladiaTranscriberLanguagesItem.Eu },
        { "be", FallbackGladiaTranscriberLanguagesItem.Be },
        { "bn", FallbackGladiaTranscriberLanguagesItem.Bn },
        { "bs", FallbackGladiaTranscriberLanguagesItem.Bs },
        { "br", FallbackGladiaTranscriberLanguagesItem.Br },
        { "bg", FallbackGladiaTranscriberLanguagesItem.Bg },
        { "ca", FallbackGladiaTranscriberLanguagesItem.Ca },
        { "zh", FallbackGladiaTranscriberLanguagesItem.Zh },
        { "hr", FallbackGladiaTranscriberLanguagesItem.Hr },
        { "cs", FallbackGladiaTranscriberLanguagesItem.Cs },
        { "da", FallbackGladiaTranscriberLanguagesItem.Da },
        { "nl", FallbackGladiaTranscriberLanguagesItem.Nl },
        { "en", FallbackGladiaTranscriberLanguagesItem.En },
        { "et", FallbackGladiaTranscriberLanguagesItem.Et },
        { "fo", FallbackGladiaTranscriberLanguagesItem.Fo },
        { "fi", FallbackGladiaTranscriberLanguagesItem.Fi },
        { "fr", FallbackGladiaTranscriberLanguagesItem.Fr },
        { "gl", FallbackGladiaTranscriberLanguagesItem.Gl },
        { "ka", FallbackGladiaTranscriberLanguagesItem.Ka },
        { "de", FallbackGladiaTranscriberLanguagesItem.De },
        { "el", FallbackGladiaTranscriberLanguagesItem.El },
        { "gu", FallbackGladiaTranscriberLanguagesItem.Gu },
        { "ht", FallbackGladiaTranscriberLanguagesItem.Ht },
        { "ha", FallbackGladiaTranscriberLanguagesItem.Ha },
        { "haw", FallbackGladiaTranscriberLanguagesItem.Haw },
        { "he", FallbackGladiaTranscriberLanguagesItem.He },
        { "hi", FallbackGladiaTranscriberLanguagesItem.Hi },
        { "hu", FallbackGladiaTranscriberLanguagesItem.Hu },
        { "is", FallbackGladiaTranscriberLanguagesItem.Is },
        { "id", FallbackGladiaTranscriberLanguagesItem.Id },
        { "it", FallbackGladiaTranscriberLanguagesItem.It },
        { "ja", FallbackGladiaTranscriberLanguagesItem.Ja },
        { "jv", FallbackGladiaTranscriberLanguagesItem.Jv },
        { "kn", FallbackGladiaTranscriberLanguagesItem.Kn },
        { "kk", FallbackGladiaTranscriberLanguagesItem.Kk },
        { "km", FallbackGladiaTranscriberLanguagesItem.Km },
        { "ko", FallbackGladiaTranscriberLanguagesItem.Ko },
        { "lo", FallbackGladiaTranscriberLanguagesItem.Lo },
        { "la", FallbackGladiaTranscriberLanguagesItem.La },
        { "lv", FallbackGladiaTranscriberLanguagesItem.Lv },
        { "ln", FallbackGladiaTranscriberLanguagesItem.Ln },
        { "lt", FallbackGladiaTranscriberLanguagesItem.Lt },
        { "lb", FallbackGladiaTranscriberLanguagesItem.Lb },
        { "mk", FallbackGladiaTranscriberLanguagesItem.Mk },
        { "mg", FallbackGladiaTranscriberLanguagesItem.Mg },
        { "ms", FallbackGladiaTranscriberLanguagesItem.Ms },
        { "ml", FallbackGladiaTranscriberLanguagesItem.Ml },
        { "mt", FallbackGladiaTranscriberLanguagesItem.Mt },
        { "mi", FallbackGladiaTranscriberLanguagesItem.Mi },
        { "mr", FallbackGladiaTranscriberLanguagesItem.Mr },
        { "mn", FallbackGladiaTranscriberLanguagesItem.Mn },
        { "my", FallbackGladiaTranscriberLanguagesItem.My },
        { "ne", FallbackGladiaTranscriberLanguagesItem.Ne },
        { "no", FallbackGladiaTranscriberLanguagesItem.No },
        { "nn", FallbackGladiaTranscriberLanguagesItem.Nn },
        { "oc", FallbackGladiaTranscriberLanguagesItem.Oc },
        { "ps", FallbackGladiaTranscriberLanguagesItem.Ps },
        { "fa", FallbackGladiaTranscriberLanguagesItem.Fa },
        { "pl", FallbackGladiaTranscriberLanguagesItem.Pl },
        { "pt", FallbackGladiaTranscriberLanguagesItem.Pt },
        { "pa", FallbackGladiaTranscriberLanguagesItem.Pa },
        { "ro", FallbackGladiaTranscriberLanguagesItem.Ro },
        { "ru", FallbackGladiaTranscriberLanguagesItem.Ru },
        { "sa", FallbackGladiaTranscriberLanguagesItem.Sa },
        { "sr", FallbackGladiaTranscriberLanguagesItem.Sr },
        { "sn", FallbackGladiaTranscriberLanguagesItem.Sn },
        { "sd", FallbackGladiaTranscriberLanguagesItem.Sd },
        { "si", FallbackGladiaTranscriberLanguagesItem.Si },
        { "sk", FallbackGladiaTranscriberLanguagesItem.Sk },
        { "sl", FallbackGladiaTranscriberLanguagesItem.Sl },
        { "so", FallbackGladiaTranscriberLanguagesItem.So },
        { "es", FallbackGladiaTranscriberLanguagesItem.Es },
        { "su", FallbackGladiaTranscriberLanguagesItem.Su },
        { "sw", FallbackGladiaTranscriberLanguagesItem.Sw },
        { "sv", FallbackGladiaTranscriberLanguagesItem.Sv },
        { "tl", FallbackGladiaTranscriberLanguagesItem.Tl },
        { "tg", FallbackGladiaTranscriberLanguagesItem.Tg },
        { "ta", FallbackGladiaTranscriberLanguagesItem.Ta },
        { "tt", FallbackGladiaTranscriberLanguagesItem.Tt },
        { "te", FallbackGladiaTranscriberLanguagesItem.Te },
        { "th", FallbackGladiaTranscriberLanguagesItem.Th },
        { "bo", FallbackGladiaTranscriberLanguagesItem.Bo },
        { "tr", FallbackGladiaTranscriberLanguagesItem.Tr },
        { "tk", FallbackGladiaTranscriberLanguagesItem.Tk },
        { "uk", FallbackGladiaTranscriberLanguagesItem.Uk },
        { "ur", FallbackGladiaTranscriberLanguagesItem.Ur },
        { "uz", FallbackGladiaTranscriberLanguagesItem.Uz },
        { "vi", FallbackGladiaTranscriberLanguagesItem.Vi },
        { "cy", FallbackGladiaTranscriberLanguagesItem.Cy },
        { "yi", FallbackGladiaTranscriberLanguagesItem.Yi },
        { "yo", FallbackGladiaTranscriberLanguagesItem.Yo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGladiaTranscriberLanguagesItem,
        string
    > _enumToString = new()
    {
        { FallbackGladiaTranscriberLanguagesItem.Af, "af" },
        { FallbackGladiaTranscriberLanguagesItem.Sq, "sq" },
        { FallbackGladiaTranscriberLanguagesItem.Am, "am" },
        { FallbackGladiaTranscriberLanguagesItem.Ar, "ar" },
        { FallbackGladiaTranscriberLanguagesItem.Hy, "hy" },
        { FallbackGladiaTranscriberLanguagesItem.As, "as" },
        { FallbackGladiaTranscriberLanguagesItem.Az, "az" },
        { FallbackGladiaTranscriberLanguagesItem.Ba, "ba" },
        { FallbackGladiaTranscriberLanguagesItem.Eu, "eu" },
        { FallbackGladiaTranscriberLanguagesItem.Be, "be" },
        { FallbackGladiaTranscriberLanguagesItem.Bn, "bn" },
        { FallbackGladiaTranscriberLanguagesItem.Bs, "bs" },
        { FallbackGladiaTranscriberLanguagesItem.Br, "br" },
        { FallbackGladiaTranscriberLanguagesItem.Bg, "bg" },
        { FallbackGladiaTranscriberLanguagesItem.Ca, "ca" },
        { FallbackGladiaTranscriberLanguagesItem.Zh, "zh" },
        { FallbackGladiaTranscriberLanguagesItem.Hr, "hr" },
        { FallbackGladiaTranscriberLanguagesItem.Cs, "cs" },
        { FallbackGladiaTranscriberLanguagesItem.Da, "da" },
        { FallbackGladiaTranscriberLanguagesItem.Nl, "nl" },
        { FallbackGladiaTranscriberLanguagesItem.En, "en" },
        { FallbackGladiaTranscriberLanguagesItem.Et, "et" },
        { FallbackGladiaTranscriberLanguagesItem.Fo, "fo" },
        { FallbackGladiaTranscriberLanguagesItem.Fi, "fi" },
        { FallbackGladiaTranscriberLanguagesItem.Fr, "fr" },
        { FallbackGladiaTranscriberLanguagesItem.Gl, "gl" },
        { FallbackGladiaTranscriberLanguagesItem.Ka, "ka" },
        { FallbackGladiaTranscriberLanguagesItem.De, "de" },
        { FallbackGladiaTranscriberLanguagesItem.El, "el" },
        { FallbackGladiaTranscriberLanguagesItem.Gu, "gu" },
        { FallbackGladiaTranscriberLanguagesItem.Ht, "ht" },
        { FallbackGladiaTranscriberLanguagesItem.Ha, "ha" },
        { FallbackGladiaTranscriberLanguagesItem.Haw, "haw" },
        { FallbackGladiaTranscriberLanguagesItem.He, "he" },
        { FallbackGladiaTranscriberLanguagesItem.Hi, "hi" },
        { FallbackGladiaTranscriberLanguagesItem.Hu, "hu" },
        { FallbackGladiaTranscriberLanguagesItem.Is, "is" },
        { FallbackGladiaTranscriberLanguagesItem.Id, "id" },
        { FallbackGladiaTranscriberLanguagesItem.It, "it" },
        { FallbackGladiaTranscriberLanguagesItem.Ja, "ja" },
        { FallbackGladiaTranscriberLanguagesItem.Jv, "jv" },
        { FallbackGladiaTranscriberLanguagesItem.Kn, "kn" },
        { FallbackGladiaTranscriberLanguagesItem.Kk, "kk" },
        { FallbackGladiaTranscriberLanguagesItem.Km, "km" },
        { FallbackGladiaTranscriberLanguagesItem.Ko, "ko" },
        { FallbackGladiaTranscriberLanguagesItem.Lo, "lo" },
        { FallbackGladiaTranscriberLanguagesItem.La, "la" },
        { FallbackGladiaTranscriberLanguagesItem.Lv, "lv" },
        { FallbackGladiaTranscriberLanguagesItem.Ln, "ln" },
        { FallbackGladiaTranscriberLanguagesItem.Lt, "lt" },
        { FallbackGladiaTranscriberLanguagesItem.Lb, "lb" },
        { FallbackGladiaTranscriberLanguagesItem.Mk, "mk" },
        { FallbackGladiaTranscriberLanguagesItem.Mg, "mg" },
        { FallbackGladiaTranscriberLanguagesItem.Ms, "ms" },
        { FallbackGladiaTranscriberLanguagesItem.Ml, "ml" },
        { FallbackGladiaTranscriberLanguagesItem.Mt, "mt" },
        { FallbackGladiaTranscriberLanguagesItem.Mi, "mi" },
        { FallbackGladiaTranscriberLanguagesItem.Mr, "mr" },
        { FallbackGladiaTranscriberLanguagesItem.Mn, "mn" },
        { FallbackGladiaTranscriberLanguagesItem.My, "my" },
        { FallbackGladiaTranscriberLanguagesItem.Ne, "ne" },
        { FallbackGladiaTranscriberLanguagesItem.No, "no" },
        { FallbackGladiaTranscriberLanguagesItem.Nn, "nn" },
        { FallbackGladiaTranscriberLanguagesItem.Oc, "oc" },
        { FallbackGladiaTranscriberLanguagesItem.Ps, "ps" },
        { FallbackGladiaTranscriberLanguagesItem.Fa, "fa" },
        { FallbackGladiaTranscriberLanguagesItem.Pl, "pl" },
        { FallbackGladiaTranscriberLanguagesItem.Pt, "pt" },
        { FallbackGladiaTranscriberLanguagesItem.Pa, "pa" },
        { FallbackGladiaTranscriberLanguagesItem.Ro, "ro" },
        { FallbackGladiaTranscriberLanguagesItem.Ru, "ru" },
        { FallbackGladiaTranscriberLanguagesItem.Sa, "sa" },
        { FallbackGladiaTranscriberLanguagesItem.Sr, "sr" },
        { FallbackGladiaTranscriberLanguagesItem.Sn, "sn" },
        { FallbackGladiaTranscriberLanguagesItem.Sd, "sd" },
        { FallbackGladiaTranscriberLanguagesItem.Si, "si" },
        { FallbackGladiaTranscriberLanguagesItem.Sk, "sk" },
        { FallbackGladiaTranscriberLanguagesItem.Sl, "sl" },
        { FallbackGladiaTranscriberLanguagesItem.So, "so" },
        { FallbackGladiaTranscriberLanguagesItem.Es, "es" },
        { FallbackGladiaTranscriberLanguagesItem.Su, "su" },
        { FallbackGladiaTranscriberLanguagesItem.Sw, "sw" },
        { FallbackGladiaTranscriberLanguagesItem.Sv, "sv" },
        { FallbackGladiaTranscriberLanguagesItem.Tl, "tl" },
        { FallbackGladiaTranscriberLanguagesItem.Tg, "tg" },
        { FallbackGladiaTranscriberLanguagesItem.Ta, "ta" },
        { FallbackGladiaTranscriberLanguagesItem.Tt, "tt" },
        { FallbackGladiaTranscriberLanguagesItem.Te, "te" },
        { FallbackGladiaTranscriberLanguagesItem.Th, "th" },
        { FallbackGladiaTranscriberLanguagesItem.Bo, "bo" },
        { FallbackGladiaTranscriberLanguagesItem.Tr, "tr" },
        { FallbackGladiaTranscriberLanguagesItem.Tk, "tk" },
        { FallbackGladiaTranscriberLanguagesItem.Uk, "uk" },
        { FallbackGladiaTranscriberLanguagesItem.Ur, "ur" },
        { FallbackGladiaTranscriberLanguagesItem.Uz, "uz" },
        { FallbackGladiaTranscriberLanguagesItem.Vi, "vi" },
        { FallbackGladiaTranscriberLanguagesItem.Cy, "cy" },
        { FallbackGladiaTranscriberLanguagesItem.Yi, "yi" },
        { FallbackGladiaTranscriberLanguagesItem.Yo, "yo" },
    };

    public override FallbackGladiaTranscriberLanguagesItem Read(
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
        FallbackGladiaTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGladiaTranscriberLanguagesItem ReadAsPropertyName(
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
        FallbackGladiaTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
