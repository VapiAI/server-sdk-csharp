using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepgramTranscriberLanguageSerializer))]
public enum DeepgramTranscriberLanguage
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

internal class DeepgramTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepgramTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepgramTranscriberLanguage
    > _stringToEnum = new()
    {
        { "bg", DeepgramTranscriberLanguage.Bg },
        { "ca", DeepgramTranscriberLanguage.Ca },
        { "cs", DeepgramTranscriberLanguage.Cs },
        { "da", DeepgramTranscriberLanguage.Da },
        { "da-DK", DeepgramTranscriberLanguage.DaDk },
        { "de", DeepgramTranscriberLanguage.De },
        { "de-CH", DeepgramTranscriberLanguage.DeCh },
        { "el", DeepgramTranscriberLanguage.El },
        { "en", DeepgramTranscriberLanguage.En },
        { "en-AU", DeepgramTranscriberLanguage.EnAu },
        { "en-GB", DeepgramTranscriberLanguage.EnGb },
        { "en-IN", DeepgramTranscriberLanguage.EnIn },
        { "en-NZ", DeepgramTranscriberLanguage.EnNz },
        { "en-US", DeepgramTranscriberLanguage.EnUs },
        { "es", DeepgramTranscriberLanguage.Es },
        { "es-419", DeepgramTranscriberLanguage.Es419 },
        { "es-LATAM", DeepgramTranscriberLanguage.EsLatam },
        { "et", DeepgramTranscriberLanguage.Et },
        { "fi", DeepgramTranscriberLanguage.Fi },
        { "fr", DeepgramTranscriberLanguage.Fr },
        { "fr-CA", DeepgramTranscriberLanguage.FrCa },
        { "hi", DeepgramTranscriberLanguage.Hi },
        { "hi-Latn", DeepgramTranscriberLanguage.HiLatn },
        { "hu", DeepgramTranscriberLanguage.Hu },
        { "id", DeepgramTranscriberLanguage.Id },
        { "it", DeepgramTranscriberLanguage.It },
        { "ja", DeepgramTranscriberLanguage.Ja },
        { "ko", DeepgramTranscriberLanguage.Ko },
        { "ko-KR", DeepgramTranscriberLanguage.KoKr },
        { "lt", DeepgramTranscriberLanguage.Lt },
        { "lv", DeepgramTranscriberLanguage.Lv },
        { "ms", DeepgramTranscriberLanguage.Ms },
        { "multi", DeepgramTranscriberLanguage.Multi },
        { "nl", DeepgramTranscriberLanguage.Nl },
        { "nl-BE", DeepgramTranscriberLanguage.NlBe },
        { "no", DeepgramTranscriberLanguage.No },
        { "pl", DeepgramTranscriberLanguage.Pl },
        { "pt", DeepgramTranscriberLanguage.Pt },
        { "pt-BR", DeepgramTranscriberLanguage.PtBr },
        { "ro", DeepgramTranscriberLanguage.Ro },
        { "ru", DeepgramTranscriberLanguage.Ru },
        { "sk", DeepgramTranscriberLanguage.Sk },
        { "sv", DeepgramTranscriberLanguage.Sv },
        { "sv-SE", DeepgramTranscriberLanguage.SvSe },
        { "ta", DeepgramTranscriberLanguage.Ta },
        { "taq", DeepgramTranscriberLanguage.Taq },
        { "th", DeepgramTranscriberLanguage.Th },
        { "th-TH", DeepgramTranscriberLanguage.ThTh },
        { "tr", DeepgramTranscriberLanguage.Tr },
        { "uk", DeepgramTranscriberLanguage.Uk },
        { "vi", DeepgramTranscriberLanguage.Vi },
        { "zh", DeepgramTranscriberLanguage.Zh },
        { "zh-CN", DeepgramTranscriberLanguage.ZhCn },
        { "zh-Hans", DeepgramTranscriberLanguage.ZhHans },
        { "zh-Hant", DeepgramTranscriberLanguage.ZhHant },
        { "zh-TW", DeepgramTranscriberLanguage.ZhTw },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepgramTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { DeepgramTranscriberLanguage.Bg, "bg" },
        { DeepgramTranscriberLanguage.Ca, "ca" },
        { DeepgramTranscriberLanguage.Cs, "cs" },
        { DeepgramTranscriberLanguage.Da, "da" },
        { DeepgramTranscriberLanguage.DaDk, "da-DK" },
        { DeepgramTranscriberLanguage.De, "de" },
        { DeepgramTranscriberLanguage.DeCh, "de-CH" },
        { DeepgramTranscriberLanguage.El, "el" },
        { DeepgramTranscriberLanguage.En, "en" },
        { DeepgramTranscriberLanguage.EnAu, "en-AU" },
        { DeepgramTranscriberLanguage.EnGb, "en-GB" },
        { DeepgramTranscriberLanguage.EnIn, "en-IN" },
        { DeepgramTranscriberLanguage.EnNz, "en-NZ" },
        { DeepgramTranscriberLanguage.EnUs, "en-US" },
        { DeepgramTranscriberLanguage.Es, "es" },
        { DeepgramTranscriberLanguage.Es419, "es-419" },
        { DeepgramTranscriberLanguage.EsLatam, "es-LATAM" },
        { DeepgramTranscriberLanguage.Et, "et" },
        { DeepgramTranscriberLanguage.Fi, "fi" },
        { DeepgramTranscriberLanguage.Fr, "fr" },
        { DeepgramTranscriberLanguage.FrCa, "fr-CA" },
        { DeepgramTranscriberLanguage.Hi, "hi" },
        { DeepgramTranscriberLanguage.HiLatn, "hi-Latn" },
        { DeepgramTranscriberLanguage.Hu, "hu" },
        { DeepgramTranscriberLanguage.Id, "id" },
        { DeepgramTranscriberLanguage.It, "it" },
        { DeepgramTranscriberLanguage.Ja, "ja" },
        { DeepgramTranscriberLanguage.Ko, "ko" },
        { DeepgramTranscriberLanguage.KoKr, "ko-KR" },
        { DeepgramTranscriberLanguage.Lt, "lt" },
        { DeepgramTranscriberLanguage.Lv, "lv" },
        { DeepgramTranscriberLanguage.Ms, "ms" },
        { DeepgramTranscriberLanguage.Multi, "multi" },
        { DeepgramTranscriberLanguage.Nl, "nl" },
        { DeepgramTranscriberLanguage.NlBe, "nl-BE" },
        { DeepgramTranscriberLanguage.No, "no" },
        { DeepgramTranscriberLanguage.Pl, "pl" },
        { DeepgramTranscriberLanguage.Pt, "pt" },
        { DeepgramTranscriberLanguage.PtBr, "pt-BR" },
        { DeepgramTranscriberLanguage.Ro, "ro" },
        { DeepgramTranscriberLanguage.Ru, "ru" },
        { DeepgramTranscriberLanguage.Sk, "sk" },
        { DeepgramTranscriberLanguage.Sv, "sv" },
        { DeepgramTranscriberLanguage.SvSe, "sv-SE" },
        { DeepgramTranscriberLanguage.Ta, "ta" },
        { DeepgramTranscriberLanguage.Taq, "taq" },
        { DeepgramTranscriberLanguage.Th, "th" },
        { DeepgramTranscriberLanguage.ThTh, "th-TH" },
        { DeepgramTranscriberLanguage.Tr, "tr" },
        { DeepgramTranscriberLanguage.Uk, "uk" },
        { DeepgramTranscriberLanguage.Vi, "vi" },
        { DeepgramTranscriberLanguage.Zh, "zh" },
        { DeepgramTranscriberLanguage.ZhCn, "zh-CN" },
        { DeepgramTranscriberLanguage.ZhHans, "zh-Hans" },
        { DeepgramTranscriberLanguage.ZhHant, "zh-Hant" },
        { DeepgramTranscriberLanguage.ZhTw, "zh-TW" },
    };

    public override DeepgramTranscriberLanguage Read(
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
        DeepgramTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepgramTranscriberLanguage ReadAsPropertyName(
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
        DeepgramTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
