using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackOpenAiTranscriberLanguageSerializer))]
public enum FallbackOpenAiTranscriberLanguage
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

internal class FallbackOpenAiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackOpenAiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackOpenAiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "af", FallbackOpenAiTranscriberLanguage.Af },
        { "ar", FallbackOpenAiTranscriberLanguage.Ar },
        { "hy", FallbackOpenAiTranscriberLanguage.Hy },
        { "az", FallbackOpenAiTranscriberLanguage.Az },
        { "be", FallbackOpenAiTranscriberLanguage.Be },
        { "bs", FallbackOpenAiTranscriberLanguage.Bs },
        { "bg", FallbackOpenAiTranscriberLanguage.Bg },
        { "ca", FallbackOpenAiTranscriberLanguage.Ca },
        { "zh", FallbackOpenAiTranscriberLanguage.Zh },
        { "hr", FallbackOpenAiTranscriberLanguage.Hr },
        { "cs", FallbackOpenAiTranscriberLanguage.Cs },
        { "da", FallbackOpenAiTranscriberLanguage.Da },
        { "nl", FallbackOpenAiTranscriberLanguage.Nl },
        { "en", FallbackOpenAiTranscriberLanguage.En },
        { "et", FallbackOpenAiTranscriberLanguage.Et },
        { "fi", FallbackOpenAiTranscriberLanguage.Fi },
        { "fr", FallbackOpenAiTranscriberLanguage.Fr },
        { "gl", FallbackOpenAiTranscriberLanguage.Gl },
        { "de", FallbackOpenAiTranscriberLanguage.De },
        { "el", FallbackOpenAiTranscriberLanguage.El },
        { "he", FallbackOpenAiTranscriberLanguage.He },
        { "hi", FallbackOpenAiTranscriberLanguage.Hi },
        { "hu", FallbackOpenAiTranscriberLanguage.Hu },
        { "is", FallbackOpenAiTranscriberLanguage.Is },
        { "id", FallbackOpenAiTranscriberLanguage.Id },
        { "it", FallbackOpenAiTranscriberLanguage.It },
        { "ja", FallbackOpenAiTranscriberLanguage.Ja },
        { "kn", FallbackOpenAiTranscriberLanguage.Kn },
        { "kk", FallbackOpenAiTranscriberLanguage.Kk },
        { "ko", FallbackOpenAiTranscriberLanguage.Ko },
        { "lv", FallbackOpenAiTranscriberLanguage.Lv },
        { "lt", FallbackOpenAiTranscriberLanguage.Lt },
        { "mk", FallbackOpenAiTranscriberLanguage.Mk },
        { "ms", FallbackOpenAiTranscriberLanguage.Ms },
        { "mr", FallbackOpenAiTranscriberLanguage.Mr },
        { "mi", FallbackOpenAiTranscriberLanguage.Mi },
        { "ne", FallbackOpenAiTranscriberLanguage.Ne },
        { "no", FallbackOpenAiTranscriberLanguage.No },
        { "fa", FallbackOpenAiTranscriberLanguage.Fa },
        { "pl", FallbackOpenAiTranscriberLanguage.Pl },
        { "pt", FallbackOpenAiTranscriberLanguage.Pt },
        { "ro", FallbackOpenAiTranscriberLanguage.Ro },
        { "ru", FallbackOpenAiTranscriberLanguage.Ru },
        { "sr", FallbackOpenAiTranscriberLanguage.Sr },
        { "sk", FallbackOpenAiTranscriberLanguage.Sk },
        { "sl", FallbackOpenAiTranscriberLanguage.Sl },
        { "es", FallbackOpenAiTranscriberLanguage.Es },
        { "sw", FallbackOpenAiTranscriberLanguage.Sw },
        { "sv", FallbackOpenAiTranscriberLanguage.Sv },
        { "tl", FallbackOpenAiTranscriberLanguage.Tl },
        { "ta", FallbackOpenAiTranscriberLanguage.Ta },
        { "th", FallbackOpenAiTranscriberLanguage.Th },
        { "tr", FallbackOpenAiTranscriberLanguage.Tr },
        { "uk", FallbackOpenAiTranscriberLanguage.Uk },
        { "ur", FallbackOpenAiTranscriberLanguage.Ur },
        { "vi", FallbackOpenAiTranscriberLanguage.Vi },
        { "cy", FallbackOpenAiTranscriberLanguage.Cy },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackOpenAiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackOpenAiTranscriberLanguage.Af, "af" },
        { FallbackOpenAiTranscriberLanguage.Ar, "ar" },
        { FallbackOpenAiTranscriberLanguage.Hy, "hy" },
        { FallbackOpenAiTranscriberLanguage.Az, "az" },
        { FallbackOpenAiTranscriberLanguage.Be, "be" },
        { FallbackOpenAiTranscriberLanguage.Bs, "bs" },
        { FallbackOpenAiTranscriberLanguage.Bg, "bg" },
        { FallbackOpenAiTranscriberLanguage.Ca, "ca" },
        { FallbackOpenAiTranscriberLanguage.Zh, "zh" },
        { FallbackOpenAiTranscriberLanguage.Hr, "hr" },
        { FallbackOpenAiTranscriberLanguage.Cs, "cs" },
        { FallbackOpenAiTranscriberLanguage.Da, "da" },
        { FallbackOpenAiTranscriberLanguage.Nl, "nl" },
        { FallbackOpenAiTranscriberLanguage.En, "en" },
        { FallbackOpenAiTranscriberLanguage.Et, "et" },
        { FallbackOpenAiTranscriberLanguage.Fi, "fi" },
        { FallbackOpenAiTranscriberLanguage.Fr, "fr" },
        { FallbackOpenAiTranscriberLanguage.Gl, "gl" },
        { FallbackOpenAiTranscriberLanguage.De, "de" },
        { FallbackOpenAiTranscriberLanguage.El, "el" },
        { FallbackOpenAiTranscriberLanguage.He, "he" },
        { FallbackOpenAiTranscriberLanguage.Hi, "hi" },
        { FallbackOpenAiTranscriberLanguage.Hu, "hu" },
        { FallbackOpenAiTranscriberLanguage.Is, "is" },
        { FallbackOpenAiTranscriberLanguage.Id, "id" },
        { FallbackOpenAiTranscriberLanguage.It, "it" },
        { FallbackOpenAiTranscriberLanguage.Ja, "ja" },
        { FallbackOpenAiTranscriberLanguage.Kn, "kn" },
        { FallbackOpenAiTranscriberLanguage.Kk, "kk" },
        { FallbackOpenAiTranscriberLanguage.Ko, "ko" },
        { FallbackOpenAiTranscriberLanguage.Lv, "lv" },
        { FallbackOpenAiTranscriberLanguage.Lt, "lt" },
        { FallbackOpenAiTranscriberLanguage.Mk, "mk" },
        { FallbackOpenAiTranscriberLanguage.Ms, "ms" },
        { FallbackOpenAiTranscriberLanguage.Mr, "mr" },
        { FallbackOpenAiTranscriberLanguage.Mi, "mi" },
        { FallbackOpenAiTranscriberLanguage.Ne, "ne" },
        { FallbackOpenAiTranscriberLanguage.No, "no" },
        { FallbackOpenAiTranscriberLanguage.Fa, "fa" },
        { FallbackOpenAiTranscriberLanguage.Pl, "pl" },
        { FallbackOpenAiTranscriberLanguage.Pt, "pt" },
        { FallbackOpenAiTranscriberLanguage.Ro, "ro" },
        { FallbackOpenAiTranscriberLanguage.Ru, "ru" },
        { FallbackOpenAiTranscriberLanguage.Sr, "sr" },
        { FallbackOpenAiTranscriberLanguage.Sk, "sk" },
        { FallbackOpenAiTranscriberLanguage.Sl, "sl" },
        { FallbackOpenAiTranscriberLanguage.Es, "es" },
        { FallbackOpenAiTranscriberLanguage.Sw, "sw" },
        { FallbackOpenAiTranscriberLanguage.Sv, "sv" },
        { FallbackOpenAiTranscriberLanguage.Tl, "tl" },
        { FallbackOpenAiTranscriberLanguage.Ta, "ta" },
        { FallbackOpenAiTranscriberLanguage.Th, "th" },
        { FallbackOpenAiTranscriberLanguage.Tr, "tr" },
        { FallbackOpenAiTranscriberLanguage.Uk, "uk" },
        { FallbackOpenAiTranscriberLanguage.Ur, "ur" },
        { FallbackOpenAiTranscriberLanguage.Vi, "vi" },
        { FallbackOpenAiTranscriberLanguage.Cy, "cy" },
    };

    public override FallbackOpenAiTranscriberLanguage Read(
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
        FallbackOpenAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackOpenAiTranscriberLanguage ReadAsPropertyName(
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
        FallbackOpenAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
