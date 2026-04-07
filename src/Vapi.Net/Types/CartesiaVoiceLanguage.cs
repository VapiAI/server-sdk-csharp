using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaVoiceLanguageSerializer))]
public enum CartesiaVoiceLanguage
{
    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "zh")]
    Zh,
}

internal class CartesiaVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaVoiceLanguage
    > _stringToEnum = new()
    {
        { "ar", CartesiaVoiceLanguage.Ar },
        { "bg", CartesiaVoiceLanguage.Bg },
        { "bn", CartesiaVoiceLanguage.Bn },
        { "cs", CartesiaVoiceLanguage.Cs },
        { "da", CartesiaVoiceLanguage.Da },
        { "de", CartesiaVoiceLanguage.De },
        { "el", CartesiaVoiceLanguage.El },
        { "en", CartesiaVoiceLanguage.En },
        { "es", CartesiaVoiceLanguage.Es },
        { "fi", CartesiaVoiceLanguage.Fi },
        { "fr", CartesiaVoiceLanguage.Fr },
        { "gu", CartesiaVoiceLanguage.Gu },
        { "he", CartesiaVoiceLanguage.He },
        { "hi", CartesiaVoiceLanguage.Hi },
        { "hr", CartesiaVoiceLanguage.Hr },
        { "hu", CartesiaVoiceLanguage.Hu },
        { "id", CartesiaVoiceLanguage.Id },
        { "it", CartesiaVoiceLanguage.It },
        { "ja", CartesiaVoiceLanguage.Ja },
        { "ka", CartesiaVoiceLanguage.Ka },
        { "kn", CartesiaVoiceLanguage.Kn },
        { "ko", CartesiaVoiceLanguage.Ko },
        { "ml", CartesiaVoiceLanguage.Ml },
        { "mr", CartesiaVoiceLanguage.Mr },
        { "ms", CartesiaVoiceLanguage.Ms },
        { "nl", CartesiaVoiceLanguage.Nl },
        { "no", CartesiaVoiceLanguage.No },
        { "pa", CartesiaVoiceLanguage.Pa },
        { "pl", CartesiaVoiceLanguage.Pl },
        { "pt", CartesiaVoiceLanguage.Pt },
        { "ro", CartesiaVoiceLanguage.Ro },
        { "ru", CartesiaVoiceLanguage.Ru },
        { "sk", CartesiaVoiceLanguage.Sk },
        { "sv", CartesiaVoiceLanguage.Sv },
        { "ta", CartesiaVoiceLanguage.Ta },
        { "te", CartesiaVoiceLanguage.Te },
        { "th", CartesiaVoiceLanguage.Th },
        { "tl", CartesiaVoiceLanguage.Tl },
        { "tr", CartesiaVoiceLanguage.Tr },
        { "uk", CartesiaVoiceLanguage.Uk },
        { "vi", CartesiaVoiceLanguage.Vi },
        { "zh", CartesiaVoiceLanguage.Zh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaVoiceLanguage,
        string
    > _enumToString = new()
    {
        { CartesiaVoiceLanguage.Ar, "ar" },
        { CartesiaVoiceLanguage.Bg, "bg" },
        { CartesiaVoiceLanguage.Bn, "bn" },
        { CartesiaVoiceLanguage.Cs, "cs" },
        { CartesiaVoiceLanguage.Da, "da" },
        { CartesiaVoiceLanguage.De, "de" },
        { CartesiaVoiceLanguage.El, "el" },
        { CartesiaVoiceLanguage.En, "en" },
        { CartesiaVoiceLanguage.Es, "es" },
        { CartesiaVoiceLanguage.Fi, "fi" },
        { CartesiaVoiceLanguage.Fr, "fr" },
        { CartesiaVoiceLanguage.Gu, "gu" },
        { CartesiaVoiceLanguage.He, "he" },
        { CartesiaVoiceLanguage.Hi, "hi" },
        { CartesiaVoiceLanguage.Hr, "hr" },
        { CartesiaVoiceLanguage.Hu, "hu" },
        { CartesiaVoiceLanguage.Id, "id" },
        { CartesiaVoiceLanguage.It, "it" },
        { CartesiaVoiceLanguage.Ja, "ja" },
        { CartesiaVoiceLanguage.Ka, "ka" },
        { CartesiaVoiceLanguage.Kn, "kn" },
        { CartesiaVoiceLanguage.Ko, "ko" },
        { CartesiaVoiceLanguage.Ml, "ml" },
        { CartesiaVoiceLanguage.Mr, "mr" },
        { CartesiaVoiceLanguage.Ms, "ms" },
        { CartesiaVoiceLanguage.Nl, "nl" },
        { CartesiaVoiceLanguage.No, "no" },
        { CartesiaVoiceLanguage.Pa, "pa" },
        { CartesiaVoiceLanguage.Pl, "pl" },
        { CartesiaVoiceLanguage.Pt, "pt" },
        { CartesiaVoiceLanguage.Ro, "ro" },
        { CartesiaVoiceLanguage.Ru, "ru" },
        { CartesiaVoiceLanguage.Sk, "sk" },
        { CartesiaVoiceLanguage.Sv, "sv" },
        { CartesiaVoiceLanguage.Ta, "ta" },
        { CartesiaVoiceLanguage.Te, "te" },
        { CartesiaVoiceLanguage.Th, "th" },
        { CartesiaVoiceLanguage.Tl, "tl" },
        { CartesiaVoiceLanguage.Tr, "tr" },
        { CartesiaVoiceLanguage.Uk, "uk" },
        { CartesiaVoiceLanguage.Vi, "vi" },
        { CartesiaVoiceLanguage.Zh, "zh" },
    };

    public override CartesiaVoiceLanguage Read(
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
        CartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaVoiceLanguage ReadAsPropertyName(
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
        CartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
