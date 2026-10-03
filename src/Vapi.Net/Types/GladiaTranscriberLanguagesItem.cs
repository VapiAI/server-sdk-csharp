using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GladiaTranscriberLanguagesItemSerializer))]
public enum GladiaTranscriberLanguagesItem
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

internal class GladiaTranscriberLanguagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GladiaTranscriberLanguagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GladiaTranscriberLanguagesItem
    > _stringToEnum = new()
    {
        { "af", GladiaTranscriberLanguagesItem.Af },
        { "sq", GladiaTranscriberLanguagesItem.Sq },
        { "am", GladiaTranscriberLanguagesItem.Am },
        { "ar", GladiaTranscriberLanguagesItem.Ar },
        { "hy", GladiaTranscriberLanguagesItem.Hy },
        { "as", GladiaTranscriberLanguagesItem.As },
        { "az", GladiaTranscriberLanguagesItem.Az },
        { "ba", GladiaTranscriberLanguagesItem.Ba },
        { "eu", GladiaTranscriberLanguagesItem.Eu },
        { "be", GladiaTranscriberLanguagesItem.Be },
        { "bn", GladiaTranscriberLanguagesItem.Bn },
        { "bs", GladiaTranscriberLanguagesItem.Bs },
        { "br", GladiaTranscriberLanguagesItem.Br },
        { "bg", GladiaTranscriberLanguagesItem.Bg },
        { "ca", GladiaTranscriberLanguagesItem.Ca },
        { "zh", GladiaTranscriberLanguagesItem.Zh },
        { "hr", GladiaTranscriberLanguagesItem.Hr },
        { "cs", GladiaTranscriberLanguagesItem.Cs },
        { "da", GladiaTranscriberLanguagesItem.Da },
        { "nl", GladiaTranscriberLanguagesItem.Nl },
        { "en", GladiaTranscriberLanguagesItem.En },
        { "et", GladiaTranscriberLanguagesItem.Et },
        { "fo", GladiaTranscriberLanguagesItem.Fo },
        { "fi", GladiaTranscriberLanguagesItem.Fi },
        { "fr", GladiaTranscriberLanguagesItem.Fr },
        { "gl", GladiaTranscriberLanguagesItem.Gl },
        { "ka", GladiaTranscriberLanguagesItem.Ka },
        { "de", GladiaTranscriberLanguagesItem.De },
        { "el", GladiaTranscriberLanguagesItem.El },
        { "gu", GladiaTranscriberLanguagesItem.Gu },
        { "ht", GladiaTranscriberLanguagesItem.Ht },
        { "ha", GladiaTranscriberLanguagesItem.Ha },
        { "haw", GladiaTranscriberLanguagesItem.Haw },
        { "he", GladiaTranscriberLanguagesItem.He },
        { "hi", GladiaTranscriberLanguagesItem.Hi },
        { "hu", GladiaTranscriberLanguagesItem.Hu },
        { "is", GladiaTranscriberLanguagesItem.Is },
        { "id", GladiaTranscriberLanguagesItem.Id },
        { "it", GladiaTranscriberLanguagesItem.It },
        { "ja", GladiaTranscriberLanguagesItem.Ja },
        { "jv", GladiaTranscriberLanguagesItem.Jv },
        { "kn", GladiaTranscriberLanguagesItem.Kn },
        { "kk", GladiaTranscriberLanguagesItem.Kk },
        { "km", GladiaTranscriberLanguagesItem.Km },
        { "ko", GladiaTranscriberLanguagesItem.Ko },
        { "lo", GladiaTranscriberLanguagesItem.Lo },
        { "la", GladiaTranscriberLanguagesItem.La },
        { "lv", GladiaTranscriberLanguagesItem.Lv },
        { "ln", GladiaTranscriberLanguagesItem.Ln },
        { "lt", GladiaTranscriberLanguagesItem.Lt },
        { "lb", GladiaTranscriberLanguagesItem.Lb },
        { "mk", GladiaTranscriberLanguagesItem.Mk },
        { "mg", GladiaTranscriberLanguagesItem.Mg },
        { "ms", GladiaTranscriberLanguagesItem.Ms },
        { "ml", GladiaTranscriberLanguagesItem.Ml },
        { "mt", GladiaTranscriberLanguagesItem.Mt },
        { "mi", GladiaTranscriberLanguagesItem.Mi },
        { "mr", GladiaTranscriberLanguagesItem.Mr },
        { "mn", GladiaTranscriberLanguagesItem.Mn },
        { "my", GladiaTranscriberLanguagesItem.My },
        { "ne", GladiaTranscriberLanguagesItem.Ne },
        { "no", GladiaTranscriberLanguagesItem.No },
        { "nn", GladiaTranscriberLanguagesItem.Nn },
        { "oc", GladiaTranscriberLanguagesItem.Oc },
        { "ps", GladiaTranscriberLanguagesItem.Ps },
        { "fa", GladiaTranscriberLanguagesItem.Fa },
        { "pl", GladiaTranscriberLanguagesItem.Pl },
        { "pt", GladiaTranscriberLanguagesItem.Pt },
        { "pa", GladiaTranscriberLanguagesItem.Pa },
        { "ro", GladiaTranscriberLanguagesItem.Ro },
        { "ru", GladiaTranscriberLanguagesItem.Ru },
        { "sa", GladiaTranscriberLanguagesItem.Sa },
        { "sr", GladiaTranscriberLanguagesItem.Sr },
        { "sn", GladiaTranscriberLanguagesItem.Sn },
        { "sd", GladiaTranscriberLanguagesItem.Sd },
        { "si", GladiaTranscriberLanguagesItem.Si },
        { "sk", GladiaTranscriberLanguagesItem.Sk },
        { "sl", GladiaTranscriberLanguagesItem.Sl },
        { "so", GladiaTranscriberLanguagesItem.So },
        { "es", GladiaTranscriberLanguagesItem.Es },
        { "su", GladiaTranscriberLanguagesItem.Su },
        { "sw", GladiaTranscriberLanguagesItem.Sw },
        { "sv", GladiaTranscriberLanguagesItem.Sv },
        { "tl", GladiaTranscriberLanguagesItem.Tl },
        { "tg", GladiaTranscriberLanguagesItem.Tg },
        { "ta", GladiaTranscriberLanguagesItem.Ta },
        { "tt", GladiaTranscriberLanguagesItem.Tt },
        { "te", GladiaTranscriberLanguagesItem.Te },
        { "th", GladiaTranscriberLanguagesItem.Th },
        { "bo", GladiaTranscriberLanguagesItem.Bo },
        { "tr", GladiaTranscriberLanguagesItem.Tr },
        { "tk", GladiaTranscriberLanguagesItem.Tk },
        { "uk", GladiaTranscriberLanguagesItem.Uk },
        { "ur", GladiaTranscriberLanguagesItem.Ur },
        { "uz", GladiaTranscriberLanguagesItem.Uz },
        { "vi", GladiaTranscriberLanguagesItem.Vi },
        { "cy", GladiaTranscriberLanguagesItem.Cy },
        { "yi", GladiaTranscriberLanguagesItem.Yi },
        { "yo", GladiaTranscriberLanguagesItem.Yo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GladiaTranscriberLanguagesItem,
        string
    > _enumToString = new()
    {
        { GladiaTranscriberLanguagesItem.Af, "af" },
        { GladiaTranscriberLanguagesItem.Sq, "sq" },
        { GladiaTranscriberLanguagesItem.Am, "am" },
        { GladiaTranscriberLanguagesItem.Ar, "ar" },
        { GladiaTranscriberLanguagesItem.Hy, "hy" },
        { GladiaTranscriberLanguagesItem.As, "as" },
        { GladiaTranscriberLanguagesItem.Az, "az" },
        { GladiaTranscriberLanguagesItem.Ba, "ba" },
        { GladiaTranscriberLanguagesItem.Eu, "eu" },
        { GladiaTranscriberLanguagesItem.Be, "be" },
        { GladiaTranscriberLanguagesItem.Bn, "bn" },
        { GladiaTranscriberLanguagesItem.Bs, "bs" },
        { GladiaTranscriberLanguagesItem.Br, "br" },
        { GladiaTranscriberLanguagesItem.Bg, "bg" },
        { GladiaTranscriberLanguagesItem.Ca, "ca" },
        { GladiaTranscriberLanguagesItem.Zh, "zh" },
        { GladiaTranscriberLanguagesItem.Hr, "hr" },
        { GladiaTranscriberLanguagesItem.Cs, "cs" },
        { GladiaTranscriberLanguagesItem.Da, "da" },
        { GladiaTranscriberLanguagesItem.Nl, "nl" },
        { GladiaTranscriberLanguagesItem.En, "en" },
        { GladiaTranscriberLanguagesItem.Et, "et" },
        { GladiaTranscriberLanguagesItem.Fo, "fo" },
        { GladiaTranscriberLanguagesItem.Fi, "fi" },
        { GladiaTranscriberLanguagesItem.Fr, "fr" },
        { GladiaTranscriberLanguagesItem.Gl, "gl" },
        { GladiaTranscriberLanguagesItem.Ka, "ka" },
        { GladiaTranscriberLanguagesItem.De, "de" },
        { GladiaTranscriberLanguagesItem.El, "el" },
        { GladiaTranscriberLanguagesItem.Gu, "gu" },
        { GladiaTranscriberLanguagesItem.Ht, "ht" },
        { GladiaTranscriberLanguagesItem.Ha, "ha" },
        { GladiaTranscriberLanguagesItem.Haw, "haw" },
        { GladiaTranscriberLanguagesItem.He, "he" },
        { GladiaTranscriberLanguagesItem.Hi, "hi" },
        { GladiaTranscriberLanguagesItem.Hu, "hu" },
        { GladiaTranscriberLanguagesItem.Is, "is" },
        { GladiaTranscriberLanguagesItem.Id, "id" },
        { GladiaTranscriberLanguagesItem.It, "it" },
        { GladiaTranscriberLanguagesItem.Ja, "ja" },
        { GladiaTranscriberLanguagesItem.Jv, "jv" },
        { GladiaTranscriberLanguagesItem.Kn, "kn" },
        { GladiaTranscriberLanguagesItem.Kk, "kk" },
        { GladiaTranscriberLanguagesItem.Km, "km" },
        { GladiaTranscriberLanguagesItem.Ko, "ko" },
        { GladiaTranscriberLanguagesItem.Lo, "lo" },
        { GladiaTranscriberLanguagesItem.La, "la" },
        { GladiaTranscriberLanguagesItem.Lv, "lv" },
        { GladiaTranscriberLanguagesItem.Ln, "ln" },
        { GladiaTranscriberLanguagesItem.Lt, "lt" },
        { GladiaTranscriberLanguagesItem.Lb, "lb" },
        { GladiaTranscriberLanguagesItem.Mk, "mk" },
        { GladiaTranscriberLanguagesItem.Mg, "mg" },
        { GladiaTranscriberLanguagesItem.Ms, "ms" },
        { GladiaTranscriberLanguagesItem.Ml, "ml" },
        { GladiaTranscriberLanguagesItem.Mt, "mt" },
        { GladiaTranscriberLanguagesItem.Mi, "mi" },
        { GladiaTranscriberLanguagesItem.Mr, "mr" },
        { GladiaTranscriberLanguagesItem.Mn, "mn" },
        { GladiaTranscriberLanguagesItem.My, "my" },
        { GladiaTranscriberLanguagesItem.Ne, "ne" },
        { GladiaTranscriberLanguagesItem.No, "no" },
        { GladiaTranscriberLanguagesItem.Nn, "nn" },
        { GladiaTranscriberLanguagesItem.Oc, "oc" },
        { GladiaTranscriberLanguagesItem.Ps, "ps" },
        { GladiaTranscriberLanguagesItem.Fa, "fa" },
        { GladiaTranscriberLanguagesItem.Pl, "pl" },
        { GladiaTranscriberLanguagesItem.Pt, "pt" },
        { GladiaTranscriberLanguagesItem.Pa, "pa" },
        { GladiaTranscriberLanguagesItem.Ro, "ro" },
        { GladiaTranscriberLanguagesItem.Ru, "ru" },
        { GladiaTranscriberLanguagesItem.Sa, "sa" },
        { GladiaTranscriberLanguagesItem.Sr, "sr" },
        { GladiaTranscriberLanguagesItem.Sn, "sn" },
        { GladiaTranscriberLanguagesItem.Sd, "sd" },
        { GladiaTranscriberLanguagesItem.Si, "si" },
        { GladiaTranscriberLanguagesItem.Sk, "sk" },
        { GladiaTranscriberLanguagesItem.Sl, "sl" },
        { GladiaTranscriberLanguagesItem.So, "so" },
        { GladiaTranscriberLanguagesItem.Es, "es" },
        { GladiaTranscriberLanguagesItem.Su, "su" },
        { GladiaTranscriberLanguagesItem.Sw, "sw" },
        { GladiaTranscriberLanguagesItem.Sv, "sv" },
        { GladiaTranscriberLanguagesItem.Tl, "tl" },
        { GladiaTranscriberLanguagesItem.Tg, "tg" },
        { GladiaTranscriberLanguagesItem.Ta, "ta" },
        { GladiaTranscriberLanguagesItem.Tt, "tt" },
        { GladiaTranscriberLanguagesItem.Te, "te" },
        { GladiaTranscriberLanguagesItem.Th, "th" },
        { GladiaTranscriberLanguagesItem.Bo, "bo" },
        { GladiaTranscriberLanguagesItem.Tr, "tr" },
        { GladiaTranscriberLanguagesItem.Tk, "tk" },
        { GladiaTranscriberLanguagesItem.Uk, "uk" },
        { GladiaTranscriberLanguagesItem.Ur, "ur" },
        { GladiaTranscriberLanguagesItem.Uz, "uz" },
        { GladiaTranscriberLanguagesItem.Vi, "vi" },
        { GladiaTranscriberLanguagesItem.Cy, "cy" },
        { GladiaTranscriberLanguagesItem.Yi, "yi" },
        { GladiaTranscriberLanguagesItem.Yo, "yo" },
    };

    public override GladiaTranscriberLanguagesItem Read(
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
        GladiaTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GladiaTranscriberLanguagesItem ReadAsPropertyName(
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
        GladiaTranscriberLanguagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
