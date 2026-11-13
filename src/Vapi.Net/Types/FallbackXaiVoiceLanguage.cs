using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackXaiVoiceLanguageSerializer))]
public enum FallbackXaiVoiceLanguage
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "ar-EG")]
    ArEg,

    [EnumMember(Value = "ar-SA")]
    ArSa,

    [EnumMember(Value = "ar-AE")]
    ArAe,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "pt-BR")]
    PtBr,

    [EnumMember(Value = "pt-PT")]
    PtPt,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "es-MX")]
    EsMx,

    [EnumMember(Value = "es-ES")]
    EsEs,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "vi")]
    Vi,
}

internal class FallbackXaiVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackXaiVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackXaiVoiceLanguage
    > _stringToEnum = new()
    {
        { "auto", FallbackXaiVoiceLanguage.Auto },
        { "en", FallbackXaiVoiceLanguage.En },
        { "ar-EG", FallbackXaiVoiceLanguage.ArEg },
        { "ar-SA", FallbackXaiVoiceLanguage.ArSa },
        { "ar-AE", FallbackXaiVoiceLanguage.ArAe },
        { "bn", FallbackXaiVoiceLanguage.Bn },
        { "zh", FallbackXaiVoiceLanguage.Zh },
        { "fr", FallbackXaiVoiceLanguage.Fr },
        { "de", FallbackXaiVoiceLanguage.De },
        { "hi", FallbackXaiVoiceLanguage.Hi },
        { "id", FallbackXaiVoiceLanguage.Id },
        { "it", FallbackXaiVoiceLanguage.It },
        { "ja", FallbackXaiVoiceLanguage.Ja },
        { "ko", FallbackXaiVoiceLanguage.Ko },
        { "pt-BR", FallbackXaiVoiceLanguage.PtBr },
        { "pt-PT", FallbackXaiVoiceLanguage.PtPt },
        { "ru", FallbackXaiVoiceLanguage.Ru },
        { "es-MX", FallbackXaiVoiceLanguage.EsMx },
        { "es-ES", FallbackXaiVoiceLanguage.EsEs },
        { "tr", FallbackXaiVoiceLanguage.Tr },
        { "vi", FallbackXaiVoiceLanguage.Vi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackXaiVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackXaiVoiceLanguage.Auto, "auto" },
        { FallbackXaiVoiceLanguage.En, "en" },
        { FallbackXaiVoiceLanguage.ArEg, "ar-EG" },
        { FallbackXaiVoiceLanguage.ArSa, "ar-SA" },
        { FallbackXaiVoiceLanguage.ArAe, "ar-AE" },
        { FallbackXaiVoiceLanguage.Bn, "bn" },
        { FallbackXaiVoiceLanguage.Zh, "zh" },
        { FallbackXaiVoiceLanguage.Fr, "fr" },
        { FallbackXaiVoiceLanguage.De, "de" },
        { FallbackXaiVoiceLanguage.Hi, "hi" },
        { FallbackXaiVoiceLanguage.Id, "id" },
        { FallbackXaiVoiceLanguage.It, "it" },
        { FallbackXaiVoiceLanguage.Ja, "ja" },
        { FallbackXaiVoiceLanguage.Ko, "ko" },
        { FallbackXaiVoiceLanguage.PtBr, "pt-BR" },
        { FallbackXaiVoiceLanguage.PtPt, "pt-PT" },
        { FallbackXaiVoiceLanguage.Ru, "ru" },
        { FallbackXaiVoiceLanguage.EsMx, "es-MX" },
        { FallbackXaiVoiceLanguage.EsEs, "es-ES" },
        { FallbackXaiVoiceLanguage.Tr, "tr" },
        { FallbackXaiVoiceLanguage.Vi, "vi" },
    };

    public override FallbackXaiVoiceLanguage Read(
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
        FallbackXaiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackXaiVoiceLanguage ReadAsPropertyName(
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
        FallbackXaiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
