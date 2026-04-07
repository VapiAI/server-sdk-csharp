using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackCartesiaVoiceLanguageSerializer))]
public enum FallbackCartesiaVoiceLanguage
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

internal class FallbackCartesiaVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackCartesiaVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackCartesiaVoiceLanguage
    > _stringToEnum = new()
    {
        { "ar", FallbackCartesiaVoiceLanguage.Ar },
        { "bg", FallbackCartesiaVoiceLanguage.Bg },
        { "bn", FallbackCartesiaVoiceLanguage.Bn },
        { "cs", FallbackCartesiaVoiceLanguage.Cs },
        { "da", FallbackCartesiaVoiceLanguage.Da },
        { "de", FallbackCartesiaVoiceLanguage.De },
        { "el", FallbackCartesiaVoiceLanguage.El },
        { "en", FallbackCartesiaVoiceLanguage.En },
        { "es", FallbackCartesiaVoiceLanguage.Es },
        { "fi", FallbackCartesiaVoiceLanguage.Fi },
        { "fr", FallbackCartesiaVoiceLanguage.Fr },
        { "gu", FallbackCartesiaVoiceLanguage.Gu },
        { "he", FallbackCartesiaVoiceLanguage.He },
        { "hi", FallbackCartesiaVoiceLanguage.Hi },
        { "hr", FallbackCartesiaVoiceLanguage.Hr },
        { "hu", FallbackCartesiaVoiceLanguage.Hu },
        { "id", FallbackCartesiaVoiceLanguage.Id },
        { "it", FallbackCartesiaVoiceLanguage.It },
        { "ja", FallbackCartesiaVoiceLanguage.Ja },
        { "ka", FallbackCartesiaVoiceLanguage.Ka },
        { "kn", FallbackCartesiaVoiceLanguage.Kn },
        { "ko", FallbackCartesiaVoiceLanguage.Ko },
        { "ml", FallbackCartesiaVoiceLanguage.Ml },
        { "mr", FallbackCartesiaVoiceLanguage.Mr },
        { "ms", FallbackCartesiaVoiceLanguage.Ms },
        { "nl", FallbackCartesiaVoiceLanguage.Nl },
        { "no", FallbackCartesiaVoiceLanguage.No },
        { "pa", FallbackCartesiaVoiceLanguage.Pa },
        { "pl", FallbackCartesiaVoiceLanguage.Pl },
        { "pt", FallbackCartesiaVoiceLanguage.Pt },
        { "ro", FallbackCartesiaVoiceLanguage.Ro },
        { "ru", FallbackCartesiaVoiceLanguage.Ru },
        { "sk", FallbackCartesiaVoiceLanguage.Sk },
        { "sv", FallbackCartesiaVoiceLanguage.Sv },
        { "ta", FallbackCartesiaVoiceLanguage.Ta },
        { "te", FallbackCartesiaVoiceLanguage.Te },
        { "th", FallbackCartesiaVoiceLanguage.Th },
        { "tl", FallbackCartesiaVoiceLanguage.Tl },
        { "tr", FallbackCartesiaVoiceLanguage.Tr },
        { "uk", FallbackCartesiaVoiceLanguage.Uk },
        { "vi", FallbackCartesiaVoiceLanguage.Vi },
        { "zh", FallbackCartesiaVoiceLanguage.Zh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackCartesiaVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackCartesiaVoiceLanguage.Ar, "ar" },
        { FallbackCartesiaVoiceLanguage.Bg, "bg" },
        { FallbackCartesiaVoiceLanguage.Bn, "bn" },
        { FallbackCartesiaVoiceLanguage.Cs, "cs" },
        { FallbackCartesiaVoiceLanguage.Da, "da" },
        { FallbackCartesiaVoiceLanguage.De, "de" },
        { FallbackCartesiaVoiceLanguage.El, "el" },
        { FallbackCartesiaVoiceLanguage.En, "en" },
        { FallbackCartesiaVoiceLanguage.Es, "es" },
        { FallbackCartesiaVoiceLanguage.Fi, "fi" },
        { FallbackCartesiaVoiceLanguage.Fr, "fr" },
        { FallbackCartesiaVoiceLanguage.Gu, "gu" },
        { FallbackCartesiaVoiceLanguage.He, "he" },
        { FallbackCartesiaVoiceLanguage.Hi, "hi" },
        { FallbackCartesiaVoiceLanguage.Hr, "hr" },
        { FallbackCartesiaVoiceLanguage.Hu, "hu" },
        { FallbackCartesiaVoiceLanguage.Id, "id" },
        { FallbackCartesiaVoiceLanguage.It, "it" },
        { FallbackCartesiaVoiceLanguage.Ja, "ja" },
        { FallbackCartesiaVoiceLanguage.Ka, "ka" },
        { FallbackCartesiaVoiceLanguage.Kn, "kn" },
        { FallbackCartesiaVoiceLanguage.Ko, "ko" },
        { FallbackCartesiaVoiceLanguage.Ml, "ml" },
        { FallbackCartesiaVoiceLanguage.Mr, "mr" },
        { FallbackCartesiaVoiceLanguage.Ms, "ms" },
        { FallbackCartesiaVoiceLanguage.Nl, "nl" },
        { FallbackCartesiaVoiceLanguage.No, "no" },
        { FallbackCartesiaVoiceLanguage.Pa, "pa" },
        { FallbackCartesiaVoiceLanguage.Pl, "pl" },
        { FallbackCartesiaVoiceLanguage.Pt, "pt" },
        { FallbackCartesiaVoiceLanguage.Ro, "ro" },
        { FallbackCartesiaVoiceLanguage.Ru, "ru" },
        { FallbackCartesiaVoiceLanguage.Sk, "sk" },
        { FallbackCartesiaVoiceLanguage.Sv, "sv" },
        { FallbackCartesiaVoiceLanguage.Ta, "ta" },
        { FallbackCartesiaVoiceLanguage.Te, "te" },
        { FallbackCartesiaVoiceLanguage.Th, "th" },
        { FallbackCartesiaVoiceLanguage.Tl, "tl" },
        { FallbackCartesiaVoiceLanguage.Tr, "tr" },
        { FallbackCartesiaVoiceLanguage.Uk, "uk" },
        { FallbackCartesiaVoiceLanguage.Vi, "vi" },
        { FallbackCartesiaVoiceLanguage.Zh, "zh" },
    };

    public override FallbackCartesiaVoiceLanguage Read(
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
        FallbackCartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackCartesiaVoiceLanguage ReadAsPropertyName(
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
        FallbackCartesiaVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
