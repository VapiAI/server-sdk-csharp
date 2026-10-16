using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiVoiceLanguageSerializer))]
public enum VapiVoiceLanguage
{
    [EnumMember(Value = "en-US")]
    EnUs,

    [EnumMember(Value = "en-GB")]
    EnGb,

    [EnumMember(Value = "en-AU")]
    EnAu,

    [EnumMember(Value = "en-CA")]
    EnCa,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "fr-FR")]
    FrFr,

    [EnumMember(Value = "fr-CA")]
    FrCa,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "pt-PT")]
    PtPt,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "es-ES")]
    EsEs,

    [EnumMember(Value = "es-MX")]
    EsMx,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "fil")]
    Fil,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ar-SA")]
    ArSa,

    [EnumMember(Value = "ar-AE")]
    ArAe,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "ar-EG")]
    ArEg,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "ka")]
    Ka,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "te")]
    Te,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tl")]
    Tl,
}

internal class VapiVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiVoiceLanguage
    > _stringToEnum = new()
    {
        { "en-US", VapiVoiceLanguage.EnUs },
        { "en-GB", VapiVoiceLanguage.EnGb },
        { "en-AU", VapiVoiceLanguage.EnAu },
        { "en-CA", VapiVoiceLanguage.EnCa },
        { "ja", VapiVoiceLanguage.Ja },
        { "zh", VapiVoiceLanguage.Zh },
        { "de", VapiVoiceLanguage.De },
        { "hi", VapiVoiceLanguage.Hi },
        { "fr-FR", VapiVoiceLanguage.FrFr },
        { "fr-CA", VapiVoiceLanguage.FrCa },
        { "ko", VapiVoiceLanguage.Ko },
        { "pt-BR", VapiVoiceLanguage.PtBr },
        { "pt-PT", VapiVoiceLanguage.PtPt },
        { "it", VapiVoiceLanguage.It },
        { "es-ES", VapiVoiceLanguage.EsEs },
        { "es-MX", VapiVoiceLanguage.EsMx },
        { "id", VapiVoiceLanguage.Id },
        { "nl", VapiVoiceLanguage.Nl },
        { "tr", VapiVoiceLanguage.Tr },
        { "fil", VapiVoiceLanguage.Fil },
        { "pl", VapiVoiceLanguage.Pl },
        { "sv", VapiVoiceLanguage.Sv },
        { "bg", VapiVoiceLanguage.Bg },
        { "ro", VapiVoiceLanguage.Ro },
        { "ar-SA", VapiVoiceLanguage.ArSa },
        { "ar-AE", VapiVoiceLanguage.ArAe },
        { "cs", VapiVoiceLanguage.Cs },
        { "el", VapiVoiceLanguage.El },
        { "fi", VapiVoiceLanguage.Fi },
        { "hr", VapiVoiceLanguage.Hr },
        { "ms", VapiVoiceLanguage.Ms },
        { "sk", VapiVoiceLanguage.Sk },
        { "da", VapiVoiceLanguage.Da },
        { "ta", VapiVoiceLanguage.Ta },
        { "uk", VapiVoiceLanguage.Uk },
        { "ru", VapiVoiceLanguage.Ru },
        { "hu", VapiVoiceLanguage.Hu },
        { "no", VapiVoiceLanguage.No },
        { "vi", VapiVoiceLanguage.Vi },
        { "auto", VapiVoiceLanguage.Auto },
        { "en", VapiVoiceLanguage.En },
        { "ar", VapiVoiceLanguage.Ar },
        { "ar-EG", VapiVoiceLanguage.ArEg },
        { "bn", VapiVoiceLanguage.Bn },
        { "es", VapiVoiceLanguage.Es },
        { "fr", VapiVoiceLanguage.Fr },
        { "gu", VapiVoiceLanguage.Gu },
        { "he", VapiVoiceLanguage.He },
        { "ka", VapiVoiceLanguage.Ka },
        { "kn", VapiVoiceLanguage.Kn },
        { "ml", VapiVoiceLanguage.Ml },
        { "mr", VapiVoiceLanguage.Mr },
        { "pa", VapiVoiceLanguage.Pa },
        { "pt", VapiVoiceLanguage.Pt },
        { "te", VapiVoiceLanguage.Te },
        { "th", VapiVoiceLanguage.Th },
        { "tl", VapiVoiceLanguage.Tl },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiVoiceLanguage,
        string
    > _enumToString = new()
    {
        { VapiVoiceLanguage.EnUs, "en-US" },
        { VapiVoiceLanguage.EnGb, "en-GB" },
        { VapiVoiceLanguage.EnAu, "en-AU" },
        { VapiVoiceLanguage.EnCa, "en-CA" },
        { VapiVoiceLanguage.Ja, "ja" },
        { VapiVoiceLanguage.Zh, "zh" },
        { VapiVoiceLanguage.De, "de" },
        { VapiVoiceLanguage.Hi, "hi" },
        { VapiVoiceLanguage.FrFr, "fr-FR" },
        { VapiVoiceLanguage.FrCa, "fr-CA" },
        { VapiVoiceLanguage.Ko, "ko" },
        { VapiVoiceLanguage.PtBr, "pt-BR" },
        { VapiVoiceLanguage.PtPt, "pt-PT" },
        { VapiVoiceLanguage.It, "it" },
        { VapiVoiceLanguage.EsEs, "es-ES" },
        { VapiVoiceLanguage.EsMx, "es-MX" },
        { VapiVoiceLanguage.Id, "id" },
        { VapiVoiceLanguage.Nl, "nl" },
        { VapiVoiceLanguage.Tr, "tr" },
        { VapiVoiceLanguage.Fil, "fil" },
        { VapiVoiceLanguage.Pl, "pl" },
        { VapiVoiceLanguage.Sv, "sv" },
        { VapiVoiceLanguage.Bg, "bg" },
        { VapiVoiceLanguage.Ro, "ro" },
        { VapiVoiceLanguage.ArSa, "ar-SA" },
        { VapiVoiceLanguage.ArAe, "ar-AE" },
        { VapiVoiceLanguage.Cs, "cs" },
        { VapiVoiceLanguage.El, "el" },
        { VapiVoiceLanguage.Fi, "fi" },
        { VapiVoiceLanguage.Hr, "hr" },
        { VapiVoiceLanguage.Ms, "ms" },
        { VapiVoiceLanguage.Sk, "sk" },
        { VapiVoiceLanguage.Da, "da" },
        { VapiVoiceLanguage.Ta, "ta" },
        { VapiVoiceLanguage.Uk, "uk" },
        { VapiVoiceLanguage.Ru, "ru" },
        { VapiVoiceLanguage.Hu, "hu" },
        { VapiVoiceLanguage.No, "no" },
        { VapiVoiceLanguage.Vi, "vi" },
        { VapiVoiceLanguage.Auto, "auto" },
        { VapiVoiceLanguage.En, "en" },
        { VapiVoiceLanguage.Ar, "ar" },
        { VapiVoiceLanguage.ArEg, "ar-EG" },
        { VapiVoiceLanguage.Bn, "bn" },
        { VapiVoiceLanguage.Es, "es" },
        { VapiVoiceLanguage.Fr, "fr" },
        { VapiVoiceLanguage.Gu, "gu" },
        { VapiVoiceLanguage.He, "he" },
        { VapiVoiceLanguage.Ka, "ka" },
        { VapiVoiceLanguage.Kn, "kn" },
        { VapiVoiceLanguage.Ml, "ml" },
        { VapiVoiceLanguage.Mr, "mr" },
        { VapiVoiceLanguage.Pa, "pa" },
        { VapiVoiceLanguage.Pt, "pt" },
        { VapiVoiceLanguage.Te, "te" },
        { VapiVoiceLanguage.Th, "th" },
        { VapiVoiceLanguage.Tl, "tl" },
    };

    public override VapiVoiceLanguage Read(
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
        VapiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiVoiceLanguage ReadAsPropertyName(
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
        VapiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
