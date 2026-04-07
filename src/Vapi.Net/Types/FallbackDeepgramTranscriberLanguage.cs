using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackDeepgramTranscriberLanguageSerializer))]
public enum FallbackDeepgramTranscriberLanguage
{
    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "da-DK")]
    DaDk,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "de-CH")]
    DeCh,

    [EnumMember(Value = "el")]
    El,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "en-AU")]
    EnAu,

    [EnumMember(Value = "en-GB")]
    EnGb,

    [EnumMember(Value = "en-IN")]
    EnIn,

    [EnumMember(Value = "en-NZ")]
    EnNz,

    [EnumMember(Value = "en-US")]
    EnUs,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "es-419")]
    Es419,

    [EnumMember(Value = "es-LATAM")]
    EsLatam,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "fr-CA")]
    FrCa,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "hi-Latn")]
    HiLatn,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "ko-KR")]
    KoKr,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "multi")]
    Multi,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "nl-BE")]
    NlBe,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "sv-SE")]
    SvSe,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "taq")]
    Taq,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "th-TH")]
    ThTh,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "zh-CN")]
    ZhCn,

    [EnumMember(Value = "zh-Hans")]
    ZhHans,

    [EnumMember(Value = "zh-Hant")]
    ZhHant,

    [EnumMember(Value = "zh-TW")]
    ZhTw,
}

internal class FallbackDeepgramTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackDeepgramTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackDeepgramTranscriberLanguage
    > _stringToEnum = new()
    {
        { "bg", FallbackDeepgramTranscriberLanguage.Bg },
        { "ca", FallbackDeepgramTranscriberLanguage.Ca },
        { "cs", FallbackDeepgramTranscriberLanguage.Cs },
        { "da", FallbackDeepgramTranscriberLanguage.Da },
        { "da-DK", FallbackDeepgramTranscriberLanguage.DaDk },
        { "de", FallbackDeepgramTranscriberLanguage.De },
        { "de-CH", FallbackDeepgramTranscriberLanguage.DeCh },
        { "el", FallbackDeepgramTranscriberLanguage.El },
        { "en", FallbackDeepgramTranscriberLanguage.En },
        { "en-AU", FallbackDeepgramTranscriberLanguage.EnAu },
        { "en-GB", FallbackDeepgramTranscriberLanguage.EnGb },
        { "en-IN", FallbackDeepgramTranscriberLanguage.EnIn },
        { "en-NZ", FallbackDeepgramTranscriberLanguage.EnNz },
        { "en-US", FallbackDeepgramTranscriberLanguage.EnUs },
        { "es", FallbackDeepgramTranscriberLanguage.Es },
        { "es-419", FallbackDeepgramTranscriberLanguage.Es419 },
        { "es-LATAM", FallbackDeepgramTranscriberLanguage.EsLatam },
        { "et", FallbackDeepgramTranscriberLanguage.Et },
        { "fi", FallbackDeepgramTranscriberLanguage.Fi },
        { "fr", FallbackDeepgramTranscriberLanguage.Fr },
        { "fr-CA", FallbackDeepgramTranscriberLanguage.FrCa },
        { "hi", FallbackDeepgramTranscriberLanguage.Hi },
        { "hi-Latn", FallbackDeepgramTranscriberLanguage.HiLatn },
        { "hu", FallbackDeepgramTranscriberLanguage.Hu },
        { "id", FallbackDeepgramTranscriberLanguage.Id },
        { "it", FallbackDeepgramTranscriberLanguage.It },
        { "ja", FallbackDeepgramTranscriberLanguage.Ja },
        { "ko", FallbackDeepgramTranscriberLanguage.Ko },
        { "ko-KR", FallbackDeepgramTranscriberLanguage.KoKr },
        { "lt", FallbackDeepgramTranscriberLanguage.Lt },
        { "lv", FallbackDeepgramTranscriberLanguage.Lv },
        { "ms", FallbackDeepgramTranscriberLanguage.Ms },
        { "multi", FallbackDeepgramTranscriberLanguage.Multi },
        { "nl", FallbackDeepgramTranscriberLanguage.Nl },
        { "nl-BE", FallbackDeepgramTranscriberLanguage.NlBe },
        { "no", FallbackDeepgramTranscriberLanguage.No },
        { "pl", FallbackDeepgramTranscriberLanguage.Pl },
        { "pt", FallbackDeepgramTranscriberLanguage.Pt },
        { "pt-BR", FallbackDeepgramTranscriberLanguage.PtBr },
        { "ro", FallbackDeepgramTranscriberLanguage.Ro },
        { "ru", FallbackDeepgramTranscriberLanguage.Ru },
        { "sk", FallbackDeepgramTranscriberLanguage.Sk },
        { "sv", FallbackDeepgramTranscriberLanguage.Sv },
        { "sv-SE", FallbackDeepgramTranscriberLanguage.SvSe },
        { "ta", FallbackDeepgramTranscriberLanguage.Ta },
        { "taq", FallbackDeepgramTranscriberLanguage.Taq },
        { "th", FallbackDeepgramTranscriberLanguage.Th },
        { "th-TH", FallbackDeepgramTranscriberLanguage.ThTh },
        { "tr", FallbackDeepgramTranscriberLanguage.Tr },
        { "uk", FallbackDeepgramTranscriberLanguage.Uk },
        { "vi", FallbackDeepgramTranscriberLanguage.Vi },
        { "zh", FallbackDeepgramTranscriberLanguage.Zh },
        { "zh-CN", FallbackDeepgramTranscriberLanguage.ZhCn },
        { "zh-Hans", FallbackDeepgramTranscriberLanguage.ZhHans },
        { "zh-Hant", FallbackDeepgramTranscriberLanguage.ZhHant },
        { "zh-TW", FallbackDeepgramTranscriberLanguage.ZhTw },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackDeepgramTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackDeepgramTranscriberLanguage.Bg, "bg" },
        { FallbackDeepgramTranscriberLanguage.Ca, "ca" },
        { FallbackDeepgramTranscriberLanguage.Cs, "cs" },
        { FallbackDeepgramTranscriberLanguage.Da, "da" },
        { FallbackDeepgramTranscriberLanguage.DaDk, "da-DK" },
        { FallbackDeepgramTranscriberLanguage.De, "de" },
        { FallbackDeepgramTranscriberLanguage.DeCh, "de-CH" },
        { FallbackDeepgramTranscriberLanguage.El, "el" },
        { FallbackDeepgramTranscriberLanguage.En, "en" },
        { FallbackDeepgramTranscriberLanguage.EnAu, "en-AU" },
        { FallbackDeepgramTranscriberLanguage.EnGb, "en-GB" },
        { FallbackDeepgramTranscriberLanguage.EnIn, "en-IN" },
        { FallbackDeepgramTranscriberLanguage.EnNz, "en-NZ" },
        { FallbackDeepgramTranscriberLanguage.EnUs, "en-US" },
        { FallbackDeepgramTranscriberLanguage.Es, "es" },
        { FallbackDeepgramTranscriberLanguage.Es419, "es-419" },
        { FallbackDeepgramTranscriberLanguage.EsLatam, "es-LATAM" },
        { FallbackDeepgramTranscriberLanguage.Et, "et" },
        { FallbackDeepgramTranscriberLanguage.Fi, "fi" },
        { FallbackDeepgramTranscriberLanguage.Fr, "fr" },
        { FallbackDeepgramTranscriberLanguage.FrCa, "fr-CA" },
        { FallbackDeepgramTranscriberLanguage.Hi, "hi" },
        { FallbackDeepgramTranscriberLanguage.HiLatn, "hi-Latn" },
        { FallbackDeepgramTranscriberLanguage.Hu, "hu" },
        { FallbackDeepgramTranscriberLanguage.Id, "id" },
        { FallbackDeepgramTranscriberLanguage.It, "it" },
        { FallbackDeepgramTranscriberLanguage.Ja, "ja" },
        { FallbackDeepgramTranscriberLanguage.Ko, "ko" },
        { FallbackDeepgramTranscriberLanguage.KoKr, "ko-KR" },
        { FallbackDeepgramTranscriberLanguage.Lt, "lt" },
        { FallbackDeepgramTranscriberLanguage.Lv, "lv" },
        { FallbackDeepgramTranscriberLanguage.Ms, "ms" },
        { FallbackDeepgramTranscriberLanguage.Multi, "multi" },
        { FallbackDeepgramTranscriberLanguage.Nl, "nl" },
        { FallbackDeepgramTranscriberLanguage.NlBe, "nl-BE" },
        { FallbackDeepgramTranscriberLanguage.No, "no" },
        { FallbackDeepgramTranscriberLanguage.Pl, "pl" },
        { FallbackDeepgramTranscriberLanguage.Pt, "pt" },
        { FallbackDeepgramTranscriberLanguage.PtBr, "pt-BR" },
        { FallbackDeepgramTranscriberLanguage.Ro, "ro" },
        { FallbackDeepgramTranscriberLanguage.Ru, "ru" },
        { FallbackDeepgramTranscriberLanguage.Sk, "sk" },
        { FallbackDeepgramTranscriberLanguage.Sv, "sv" },
        { FallbackDeepgramTranscriberLanguage.SvSe, "sv-SE" },
        { FallbackDeepgramTranscriberLanguage.Ta, "ta" },
        { FallbackDeepgramTranscriberLanguage.Taq, "taq" },
        { FallbackDeepgramTranscriberLanguage.Th, "th" },
        { FallbackDeepgramTranscriberLanguage.ThTh, "th-TH" },
        { FallbackDeepgramTranscriberLanguage.Tr, "tr" },
        { FallbackDeepgramTranscriberLanguage.Uk, "uk" },
        { FallbackDeepgramTranscriberLanguage.Vi, "vi" },
        { FallbackDeepgramTranscriberLanguage.Zh, "zh" },
        { FallbackDeepgramTranscriberLanguage.ZhCn, "zh-CN" },
        { FallbackDeepgramTranscriberLanguage.ZhHans, "zh-Hans" },
        { FallbackDeepgramTranscriberLanguage.ZhHant, "zh-Hant" },
        { FallbackDeepgramTranscriberLanguage.ZhTw, "zh-TW" },
    };

    public override FallbackDeepgramTranscriberLanguage Read(
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
        FallbackDeepgramTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackDeepgramTranscriberLanguage ReadAsPropertyName(
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
        FallbackDeepgramTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
