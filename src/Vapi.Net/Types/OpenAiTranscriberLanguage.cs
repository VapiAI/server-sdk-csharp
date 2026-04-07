using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiTranscriberLanguageSerializer))]
public enum OpenAiTranscriberLanguage
{
    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "hy")]
    Hy,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "bs")]
    Bs,

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

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "el")]
    El,

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

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "kk")]
    Kk,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "mi")]
    Mi,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "cy")]
    Cy,
}

internal class OpenAiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "af", OpenAiTranscriberLanguage.Af },
        { "ar", OpenAiTranscriberLanguage.Ar },
        { "hy", OpenAiTranscriberLanguage.Hy },
        { "az", OpenAiTranscriberLanguage.Az },
        { "be", OpenAiTranscriberLanguage.Be },
        { "bs", OpenAiTranscriberLanguage.Bs },
        { "bg", OpenAiTranscriberLanguage.Bg },
        { "ca", OpenAiTranscriberLanguage.Ca },
        { "zh", OpenAiTranscriberLanguage.Zh },
        { "hr", OpenAiTranscriberLanguage.Hr },
        { "cs", OpenAiTranscriberLanguage.Cs },
        { "da", OpenAiTranscriberLanguage.Da },
        { "nl", OpenAiTranscriberLanguage.Nl },
        { "en", OpenAiTranscriberLanguage.En },
        { "et", OpenAiTranscriberLanguage.Et },
        { "fi", OpenAiTranscriberLanguage.Fi },
        { "fr", OpenAiTranscriberLanguage.Fr },
        { "gl", OpenAiTranscriberLanguage.Gl },
        { "de", OpenAiTranscriberLanguage.De },
        { "el", OpenAiTranscriberLanguage.El },
        { "he", OpenAiTranscriberLanguage.He },
        { "hi", OpenAiTranscriberLanguage.Hi },
        { "hu", OpenAiTranscriberLanguage.Hu },
        { "is", OpenAiTranscriberLanguage.Is },
        { "id", OpenAiTranscriberLanguage.Id },
        { "it", OpenAiTranscriberLanguage.It },
        { "ja", OpenAiTranscriberLanguage.Ja },
        { "kn", OpenAiTranscriberLanguage.Kn },
        { "kk", OpenAiTranscriberLanguage.Kk },
        { "ko", OpenAiTranscriberLanguage.Ko },
        { "lv", OpenAiTranscriberLanguage.Lv },
        { "lt", OpenAiTranscriberLanguage.Lt },
        { "mk", OpenAiTranscriberLanguage.Mk },
        { "ms", OpenAiTranscriberLanguage.Ms },
        { "mr", OpenAiTranscriberLanguage.Mr },
        { "mi", OpenAiTranscriberLanguage.Mi },
        { "ne", OpenAiTranscriberLanguage.Ne },
        { "no", OpenAiTranscriberLanguage.No },
        { "fa", OpenAiTranscriberLanguage.Fa },
        { "pl", OpenAiTranscriberLanguage.Pl },
        { "pt", OpenAiTranscriberLanguage.Pt },
        { "ro", OpenAiTranscriberLanguage.Ro },
        { "ru", OpenAiTranscriberLanguage.Ru },
        { "sr", OpenAiTranscriberLanguage.Sr },
        { "sk", OpenAiTranscriberLanguage.Sk },
        { "sl", OpenAiTranscriberLanguage.Sl },
        { "es", OpenAiTranscriberLanguage.Es },
        { "sw", OpenAiTranscriberLanguage.Sw },
        { "sv", OpenAiTranscriberLanguage.Sv },
        { "tl", OpenAiTranscriberLanguage.Tl },
        { "ta", OpenAiTranscriberLanguage.Ta },
        { "th", OpenAiTranscriberLanguage.Th },
        { "tr", OpenAiTranscriberLanguage.Tr },
        { "uk", OpenAiTranscriberLanguage.Uk },
        { "ur", OpenAiTranscriberLanguage.Ur },
        { "vi", OpenAiTranscriberLanguage.Vi },
        { "cy", OpenAiTranscriberLanguage.Cy },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { OpenAiTranscriberLanguage.Af, "af" },
        { OpenAiTranscriberLanguage.Ar, "ar" },
        { OpenAiTranscriberLanguage.Hy, "hy" },
        { OpenAiTranscriberLanguage.Az, "az" },
        { OpenAiTranscriberLanguage.Be, "be" },
        { OpenAiTranscriberLanguage.Bs, "bs" },
        { OpenAiTranscriberLanguage.Bg, "bg" },
        { OpenAiTranscriberLanguage.Ca, "ca" },
        { OpenAiTranscriberLanguage.Zh, "zh" },
        { OpenAiTranscriberLanguage.Hr, "hr" },
        { OpenAiTranscriberLanguage.Cs, "cs" },
        { OpenAiTranscriberLanguage.Da, "da" },
        { OpenAiTranscriberLanguage.Nl, "nl" },
        { OpenAiTranscriberLanguage.En, "en" },
        { OpenAiTranscriberLanguage.Et, "et" },
        { OpenAiTranscriberLanguage.Fi, "fi" },
        { OpenAiTranscriberLanguage.Fr, "fr" },
        { OpenAiTranscriberLanguage.Gl, "gl" },
        { OpenAiTranscriberLanguage.De, "de" },
        { OpenAiTranscriberLanguage.El, "el" },
        { OpenAiTranscriberLanguage.He, "he" },
        { OpenAiTranscriberLanguage.Hi, "hi" },
        { OpenAiTranscriberLanguage.Hu, "hu" },
        { OpenAiTranscriberLanguage.Is, "is" },
        { OpenAiTranscriberLanguage.Id, "id" },
        { OpenAiTranscriberLanguage.It, "it" },
        { OpenAiTranscriberLanguage.Ja, "ja" },
        { OpenAiTranscriberLanguage.Kn, "kn" },
        { OpenAiTranscriberLanguage.Kk, "kk" },
        { OpenAiTranscriberLanguage.Ko, "ko" },
        { OpenAiTranscriberLanguage.Lv, "lv" },
        { OpenAiTranscriberLanguage.Lt, "lt" },
        { OpenAiTranscriberLanguage.Mk, "mk" },
        { OpenAiTranscriberLanguage.Ms, "ms" },
        { OpenAiTranscriberLanguage.Mr, "mr" },
        { OpenAiTranscriberLanguage.Mi, "mi" },
        { OpenAiTranscriberLanguage.Ne, "ne" },
        { OpenAiTranscriberLanguage.No, "no" },
        { OpenAiTranscriberLanguage.Fa, "fa" },
        { OpenAiTranscriberLanguage.Pl, "pl" },
        { OpenAiTranscriberLanguage.Pt, "pt" },
        { OpenAiTranscriberLanguage.Ro, "ro" },
        { OpenAiTranscriberLanguage.Ru, "ru" },
        { OpenAiTranscriberLanguage.Sr, "sr" },
        { OpenAiTranscriberLanguage.Sk, "sk" },
        { OpenAiTranscriberLanguage.Sl, "sl" },
        { OpenAiTranscriberLanguage.Es, "es" },
        { OpenAiTranscriberLanguage.Sw, "sw" },
        { OpenAiTranscriberLanguage.Sv, "sv" },
        { OpenAiTranscriberLanguage.Tl, "tl" },
        { OpenAiTranscriberLanguage.Ta, "ta" },
        { OpenAiTranscriberLanguage.Th, "th" },
        { OpenAiTranscriberLanguage.Tr, "tr" },
        { OpenAiTranscriberLanguage.Uk, "uk" },
        { OpenAiTranscriberLanguage.Ur, "ur" },
        { OpenAiTranscriberLanguage.Vi, "vi" },
        { OpenAiTranscriberLanguage.Cy, "cy" },
    };

    public override OpenAiTranscriberLanguage Read(
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
        OpenAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiTranscriberLanguage ReadAsPropertyName(
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
        OpenAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
