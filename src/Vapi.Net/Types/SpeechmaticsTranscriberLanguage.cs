using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SpeechmaticsTranscriberLanguageSerializer))]
public enum SpeechmaticsTranscriberLanguage
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

internal class SpeechmaticsTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SpeechmaticsTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SpeechmaticsTranscriberLanguage
    > _stringToEnum = new()
    {
        { "auto", SpeechmaticsTranscriberLanguage.Auto },
        { "ar", SpeechmaticsTranscriberLanguage.Ar },
        { "ar_en", SpeechmaticsTranscriberLanguage.ArEn },
        { "ba", SpeechmaticsTranscriberLanguage.Ba },
        { "eu", SpeechmaticsTranscriberLanguage.Eu },
        { "be", SpeechmaticsTranscriberLanguage.Be },
        { "bn", SpeechmaticsTranscriberLanguage.Bn },
        { "bg", SpeechmaticsTranscriberLanguage.Bg },
        { "yue", SpeechmaticsTranscriberLanguage.Yue },
        { "ca", SpeechmaticsTranscriberLanguage.Ca },
        { "hr", SpeechmaticsTranscriberLanguage.Hr },
        { "cs", SpeechmaticsTranscriberLanguage.Cs },
        { "da", SpeechmaticsTranscriberLanguage.Da },
        { "nl", SpeechmaticsTranscriberLanguage.Nl },
        { "en", SpeechmaticsTranscriberLanguage.En },
        { "eo", SpeechmaticsTranscriberLanguage.Eo },
        { "et", SpeechmaticsTranscriberLanguage.Et },
        { "fi", SpeechmaticsTranscriberLanguage.Fi },
        { "fr", SpeechmaticsTranscriberLanguage.Fr },
        { "gl", SpeechmaticsTranscriberLanguage.Gl },
        { "de", SpeechmaticsTranscriberLanguage.De },
        { "el", SpeechmaticsTranscriberLanguage.El },
        { "he", SpeechmaticsTranscriberLanguage.He },
        { "hi", SpeechmaticsTranscriberLanguage.Hi },
        { "hu", SpeechmaticsTranscriberLanguage.Hu },
        { "id", SpeechmaticsTranscriberLanguage.Id },
        { "ia", SpeechmaticsTranscriberLanguage.Ia },
        { "ga", SpeechmaticsTranscriberLanguage.Ga },
        { "it", SpeechmaticsTranscriberLanguage.It },
        { "ja", SpeechmaticsTranscriberLanguage.Ja },
        { "ko", SpeechmaticsTranscriberLanguage.Ko },
        { "lv", SpeechmaticsTranscriberLanguage.Lv },
        { "lt", SpeechmaticsTranscriberLanguage.Lt },
        { "ms", SpeechmaticsTranscriberLanguage.Ms },
        { "en_ms", SpeechmaticsTranscriberLanguage.EnMs },
        { "mt", SpeechmaticsTranscriberLanguage.Mt },
        { "cmn", SpeechmaticsTranscriberLanguage.Cmn },
        { "cmn_en", SpeechmaticsTranscriberLanguage.CmnEn },
        { "mr", SpeechmaticsTranscriberLanguage.Mr },
        { "mn", SpeechmaticsTranscriberLanguage.Mn },
        { "no", SpeechmaticsTranscriberLanguage.No },
        { "fa", SpeechmaticsTranscriberLanguage.Fa },
        { "pl", SpeechmaticsTranscriberLanguage.Pl },
        { "pt", SpeechmaticsTranscriberLanguage.Pt },
        { "ro", SpeechmaticsTranscriberLanguage.Ro },
        { "ru", SpeechmaticsTranscriberLanguage.Ru },
        { "sk", SpeechmaticsTranscriberLanguage.Sk },
        { "sl", SpeechmaticsTranscriberLanguage.Sl },
        { "es", SpeechmaticsTranscriberLanguage.Es },
        { "en_es", SpeechmaticsTranscriberLanguage.EnEs },
        { "sw", SpeechmaticsTranscriberLanguage.Sw },
        { "sv", SpeechmaticsTranscriberLanguage.Sv },
        { "tl", SpeechmaticsTranscriberLanguage.Tl },
        { "ta", SpeechmaticsTranscriberLanguage.Ta },
        { "en_ta", SpeechmaticsTranscriberLanguage.EnTa },
        { "th", SpeechmaticsTranscriberLanguage.Th },
        { "tr", SpeechmaticsTranscriberLanguage.Tr },
        { "uk", SpeechmaticsTranscriberLanguage.Uk },
        { "ur", SpeechmaticsTranscriberLanguage.Ur },
        { "ug", SpeechmaticsTranscriberLanguage.Ug },
        { "vi", SpeechmaticsTranscriberLanguage.Vi },
        { "cy", SpeechmaticsTranscriberLanguage.Cy },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SpeechmaticsTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { SpeechmaticsTranscriberLanguage.Auto, "auto" },
        { SpeechmaticsTranscriberLanguage.Ar, "ar" },
        { SpeechmaticsTranscriberLanguage.ArEn, "ar_en" },
        { SpeechmaticsTranscriberLanguage.Ba, "ba" },
        { SpeechmaticsTranscriberLanguage.Eu, "eu" },
        { SpeechmaticsTranscriberLanguage.Be, "be" },
        { SpeechmaticsTranscriberLanguage.Bn, "bn" },
        { SpeechmaticsTranscriberLanguage.Bg, "bg" },
        { SpeechmaticsTranscriberLanguage.Yue, "yue" },
        { SpeechmaticsTranscriberLanguage.Ca, "ca" },
        { SpeechmaticsTranscriberLanguage.Hr, "hr" },
        { SpeechmaticsTranscriberLanguage.Cs, "cs" },
        { SpeechmaticsTranscriberLanguage.Da, "da" },
        { SpeechmaticsTranscriberLanguage.Nl, "nl" },
        { SpeechmaticsTranscriberLanguage.En, "en" },
        { SpeechmaticsTranscriberLanguage.Eo, "eo" },
        { SpeechmaticsTranscriberLanguage.Et, "et" },
        { SpeechmaticsTranscriberLanguage.Fi, "fi" },
        { SpeechmaticsTranscriberLanguage.Fr, "fr" },
        { SpeechmaticsTranscriberLanguage.Gl, "gl" },
        { SpeechmaticsTranscriberLanguage.De, "de" },
        { SpeechmaticsTranscriberLanguage.El, "el" },
        { SpeechmaticsTranscriberLanguage.He, "he" },
        { SpeechmaticsTranscriberLanguage.Hi, "hi" },
        { SpeechmaticsTranscriberLanguage.Hu, "hu" },
        { SpeechmaticsTranscriberLanguage.Id, "id" },
        { SpeechmaticsTranscriberLanguage.Ia, "ia" },
        { SpeechmaticsTranscriberLanguage.Ga, "ga" },
        { SpeechmaticsTranscriberLanguage.It, "it" },
        { SpeechmaticsTranscriberLanguage.Ja, "ja" },
        { SpeechmaticsTranscriberLanguage.Ko, "ko" },
        { SpeechmaticsTranscriberLanguage.Lv, "lv" },
        { SpeechmaticsTranscriberLanguage.Lt, "lt" },
        { SpeechmaticsTranscriberLanguage.Ms, "ms" },
        { SpeechmaticsTranscriberLanguage.EnMs, "en_ms" },
        { SpeechmaticsTranscriberLanguage.Mt, "mt" },
        { SpeechmaticsTranscriberLanguage.Cmn, "cmn" },
        { SpeechmaticsTranscriberLanguage.CmnEn, "cmn_en" },
        { SpeechmaticsTranscriberLanguage.Mr, "mr" },
        { SpeechmaticsTranscriberLanguage.Mn, "mn" },
        { SpeechmaticsTranscriberLanguage.No, "no" },
        { SpeechmaticsTranscriberLanguage.Fa, "fa" },
        { SpeechmaticsTranscriberLanguage.Pl, "pl" },
        { SpeechmaticsTranscriberLanguage.Pt, "pt" },
        { SpeechmaticsTranscriberLanguage.Ro, "ro" },
        { SpeechmaticsTranscriberLanguage.Ru, "ru" },
        { SpeechmaticsTranscriberLanguage.Sk, "sk" },
        { SpeechmaticsTranscriberLanguage.Sl, "sl" },
        { SpeechmaticsTranscriberLanguage.Es, "es" },
        { SpeechmaticsTranscriberLanguage.EnEs, "en_es" },
        { SpeechmaticsTranscriberLanguage.Sw, "sw" },
        { SpeechmaticsTranscriberLanguage.Sv, "sv" },
        { SpeechmaticsTranscriberLanguage.Tl, "tl" },
        { SpeechmaticsTranscriberLanguage.Ta, "ta" },
        { SpeechmaticsTranscriberLanguage.EnTa, "en_ta" },
        { SpeechmaticsTranscriberLanguage.Th, "th" },
        { SpeechmaticsTranscriberLanguage.Tr, "tr" },
        { SpeechmaticsTranscriberLanguage.Uk, "uk" },
        { SpeechmaticsTranscriberLanguage.Ur, "ur" },
        { SpeechmaticsTranscriberLanguage.Ug, "ug" },
        { SpeechmaticsTranscriberLanguage.Vi, "vi" },
        { SpeechmaticsTranscriberLanguage.Cy, "cy" },
    };

    public override SpeechmaticsTranscriberLanguage Read(
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
        SpeechmaticsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SpeechmaticsTranscriberLanguage ReadAsPropertyName(
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
        SpeechmaticsTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
