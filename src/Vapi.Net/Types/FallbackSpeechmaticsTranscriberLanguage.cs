using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSpeechmaticsTranscriberLanguageSerializer))]
public enum FallbackSpeechmaticsTranscriberLanguage
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "ar_en")]
    ArEn,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "yue")]
    Yue,

    [EnumMember(Value = "ca")]
    Ca,

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

    [EnumMember(Value = "eo")]
    Eo,

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

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "ia")]
    Ia,

    [EnumMember(Value = "ga")]
    Ga,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "en_ms")]
    EnMs,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "cmn")]
    Cmn,

    [EnumMember(Value = "cmn_en")]
    CmnEn,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "mn")]
    Mn,

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

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "en_es")]
    EnEs,

    [EnumMember(Value = "sw")]
    Sw,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "en_ta")]
    EnTa,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "ug")]
    Ug,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "cy")]
    Cy,
}

internal class FallbackSpeechmaticsTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSpeechmaticsTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSpeechmaticsTranscriberLanguage
    > _stringToEnum = new()
    {
        { "auto", FallbackSpeechmaticsTranscriberLanguage.Auto },
        { "ar", FallbackSpeechmaticsTranscriberLanguage.Ar },
        { "ar_en", FallbackSpeechmaticsTranscriberLanguage.ArEn },
        { "ba", FallbackSpeechmaticsTranscriberLanguage.Ba },
        { "eu", FallbackSpeechmaticsTranscriberLanguage.Eu },
        { "be", FallbackSpeechmaticsTranscriberLanguage.Be },
        { "bn", FallbackSpeechmaticsTranscriberLanguage.Bn },
        { "bg", FallbackSpeechmaticsTranscriberLanguage.Bg },
        { "yue", FallbackSpeechmaticsTranscriberLanguage.Yue },
        { "ca", FallbackSpeechmaticsTranscriberLanguage.Ca },
        { "hr", FallbackSpeechmaticsTranscriberLanguage.Hr },
        { "cs", FallbackSpeechmaticsTranscriberLanguage.Cs },
        { "da", FallbackSpeechmaticsTranscriberLanguage.Da },
        { "nl", FallbackSpeechmaticsTranscriberLanguage.Nl },
        { "en", FallbackSpeechmaticsTranscriberLanguage.En },
        { "eo", FallbackSpeechmaticsTranscriberLanguage.Eo },
        { "et", FallbackSpeechmaticsTranscriberLanguage.Et },
        { "fi", FallbackSpeechmaticsTranscriberLanguage.Fi },
        { "fr", FallbackSpeechmaticsTranscriberLanguage.Fr },
        { "gl", FallbackSpeechmaticsTranscriberLanguage.Gl },
        { "de", FallbackSpeechmaticsTranscriberLanguage.De },
        { "el", FallbackSpeechmaticsTranscriberLanguage.El },
        { "he", FallbackSpeechmaticsTranscriberLanguage.He },
        { "hi", FallbackSpeechmaticsTranscriberLanguage.Hi },
        { "hu", FallbackSpeechmaticsTranscriberLanguage.Hu },
        { "id", FallbackSpeechmaticsTranscriberLanguage.Id },
        { "ia", FallbackSpeechmaticsTranscriberLanguage.Ia },
        { "ga", FallbackSpeechmaticsTranscriberLanguage.Ga },
        { "it", FallbackSpeechmaticsTranscriberLanguage.It },
        { "ja", FallbackSpeechmaticsTranscriberLanguage.Ja },
        { "ko", FallbackSpeechmaticsTranscriberLanguage.Ko },
        { "lv", FallbackSpeechmaticsTranscriberLanguage.Lv },
        { "lt", FallbackSpeechmaticsTranscriberLanguage.Lt },
        { "ms", FallbackSpeechmaticsTranscriberLanguage.Ms },
        { "en_ms", FallbackSpeechmaticsTranscriberLanguage.EnMs },
        { "mt", FallbackSpeechmaticsTranscriberLanguage.Mt },
        { "cmn", FallbackSpeechmaticsTranscriberLanguage.Cmn },
        { "cmn_en", FallbackSpeechmaticsTranscriberLanguage.CmnEn },
        { "mr", FallbackSpeechmaticsTranscriberLanguage.Mr },
        { "mn", FallbackSpeechmaticsTranscriberLanguage.Mn },
        { "no", FallbackSpeechmaticsTranscriberLanguage.No },
        { "fa", FallbackSpeechmaticsTranscriberLanguage.Fa },
        { "pl", FallbackSpeechmaticsTranscriberLanguage.Pl },
        { "pt", FallbackSpeechmaticsTranscriberLanguage.Pt },
        { "ro", FallbackSpeechmaticsTranscriberLanguage.Ro },
        { "ru", FallbackSpeechmaticsTranscriberLanguage.Ru },
        { "sk", FallbackSpeechmaticsTranscriberLanguage.Sk },
        { "sl", FallbackSpeechmaticsTranscriberLanguage.Sl },
        { "es", FallbackSpeechmaticsTranscriberLanguage.Es },
        { "en_es", FallbackSpeechmaticsTranscriberLanguage.EnEs },
        { "sw", FallbackSpeechmaticsTranscriberLanguage.Sw },
        { "sv", FallbackSpeechmaticsTranscriberLanguage.Sv },
        { "tl", FallbackSpeechmaticsTranscriberLanguage.Tl },
        { "ta", FallbackSpeechmaticsTranscriberLanguage.Ta },
        { "en_ta", FallbackSpeechmaticsTranscriberLanguage.EnTa },
        { "th", FallbackSpeechmaticsTranscriberLanguage.Th },
        { "tr", FallbackSpeechmaticsTranscriberLanguage.Tr },
        { "uk", FallbackSpeechmaticsTranscriberLanguage.Uk },
        { "ur", FallbackSpeechmaticsTranscriberLanguage.Ur },
        { "ug", FallbackSpeechmaticsTranscriberLanguage.Ug },
        { "vi", FallbackSpeechmaticsTranscriberLanguage.Vi },
        { "cy", FallbackSpeechmaticsTranscriberLanguage.Cy },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSpeechmaticsTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackSpeechmaticsTranscriberLanguage.Auto, "auto" },
        { FallbackSpeechmaticsTranscriberLanguage.Ar, "ar" },
        { FallbackSpeechmaticsTranscriberLanguage.ArEn, "ar_en" },
        { FallbackSpeechmaticsTranscriberLanguage.Ba, "ba" },
        { FallbackSpeechmaticsTranscriberLanguage.Eu, "eu" },
        { FallbackSpeechmaticsTranscriberLanguage.Be, "be" },
        { FallbackSpeechmaticsTranscriberLanguage.Bn, "bn" },
        { FallbackSpeechmaticsTranscriberLanguage.Bg, "bg" },
        { FallbackSpeechmaticsTranscriberLanguage.Yue, "yue" },
        { FallbackSpeechmaticsTranscriberLanguage.Ca, "ca" },
        { FallbackSpeechmaticsTranscriberLanguage.Hr, "hr" },
        { FallbackSpeechmaticsTranscriberLanguage.Cs, "cs" },
        { FallbackSpeechmaticsTranscriberLanguage.Da, "da" },
        { FallbackSpeechmaticsTranscriberLanguage.Nl, "nl" },
        { FallbackSpeechmaticsTranscriberLanguage.En, "en" },
        { FallbackSpeechmaticsTranscriberLanguage.Eo, "eo" },
        { FallbackSpeechmaticsTranscriberLanguage.Et, "et" },
        { FallbackSpeechmaticsTranscriberLanguage.Fi, "fi" },
        { FallbackSpeechmaticsTranscriberLanguage.Fr, "fr" },
        { FallbackSpeechmaticsTranscriberLanguage.Gl, "gl" },
        { FallbackSpeechmaticsTranscriberLanguage.De, "de" },
        { FallbackSpeechmaticsTranscriberLanguage.El, "el" },
        { FallbackSpeechmaticsTranscriberLanguage.He, "he" },
        { FallbackSpeechmaticsTranscriberLanguage.Hi, "hi" },
        { FallbackSpeechmaticsTranscriberLanguage.Hu, "hu" },
        { FallbackSpeechmaticsTranscriberLanguage.Id, "id" },
        { FallbackSpeechmaticsTranscriberLanguage.Ia, "ia" },
        { FallbackSpeechmaticsTranscriberLanguage.Ga, "ga" },
        { FallbackSpeechmaticsTranscriberLanguage.It, "it" },
        { FallbackSpeechmaticsTranscriberLanguage.Ja, "ja" },
        { FallbackSpeechmaticsTranscriberLanguage.Ko, "ko" },
        { FallbackSpeechmaticsTranscriberLanguage.Lv, "lv" },
        { FallbackSpeechmaticsTranscriberLanguage.Lt, "lt" },
        { FallbackSpeechmaticsTranscriberLanguage.Ms, "ms" },
        { FallbackSpeechmaticsTranscriberLanguage.EnMs, "en_ms" },
        { FallbackSpeechmaticsTranscriberLanguage.Mt, "mt" },
        { FallbackSpeechmaticsTranscriberLanguage.Cmn, "cmn" },
        { FallbackSpeechmaticsTranscriberLanguage.CmnEn, "cmn_en" },
        { FallbackSpeechmaticsTranscriberLanguage.Mr, "mr" },
        { FallbackSpeechmaticsTranscriberLanguage.Mn, "mn" },
        { FallbackSpeechmaticsTranscriberLanguage.No, "no" },
        { FallbackSpeechmaticsTranscriberLanguage.Fa, "fa" },
        { FallbackSpeechmaticsTranscriberLanguage.Pl, "pl" },
        { FallbackSpeechmaticsTranscriberLanguage.Pt, "pt" },
        { FallbackSpeechmaticsTranscriberLanguage.Ro, "ro" },
        { FallbackSpeechmaticsTranscriberLanguage.Ru, "ru" },
        { FallbackSpeechmaticsTranscriberLanguage.Sk, "sk" },
        { FallbackSpeechmaticsTranscriberLanguage.Sl, "sl" },
        { FallbackSpeechmaticsTranscriberLanguage.Es, "es" },
        { FallbackSpeechmaticsTranscriberLanguage.EnEs, "en_es" },
        { FallbackSpeechmaticsTranscriberLanguage.Sw, "sw" },
        { FallbackSpeechmaticsTranscriberLanguage.Sv, "sv" },
        { FallbackSpeechmaticsTranscriberLanguage.Tl, "tl" },
        { FallbackSpeechmaticsTranscriberLanguage.Ta, "ta" },
        { FallbackSpeechmaticsTranscriberLanguage.EnTa, "en_ta" },
        { FallbackSpeechmaticsTranscriberLanguage.Th, "th" },
        { FallbackSpeechmaticsTranscriberLanguage.Tr, "tr" },
        { FallbackSpeechmaticsTranscriberLanguage.Uk, "uk" },
        { FallbackSpeechmaticsTranscriberLanguage.Ur, "ur" },
        { FallbackSpeechmaticsTranscriberLanguage.Ug, "ug" },
        { FallbackSpeechmaticsTranscriberLanguage.Vi, "vi" },
        { FallbackSpeechmaticsTranscriberLanguage.Cy, "cy" },
    };

    public override FallbackSpeechmaticsTranscriberLanguage Read(
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
        FallbackSpeechmaticsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSpeechmaticsTranscriberLanguage ReadAsPropertyName(
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
        FallbackSpeechmaticsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
