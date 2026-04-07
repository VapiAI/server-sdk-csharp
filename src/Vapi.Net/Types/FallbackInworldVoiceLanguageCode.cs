using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackInworldVoiceLanguageCodeSerializer))]
public enum FallbackInworldVoiceLanguageCode
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "ar")]
    Ar,
}

internal class FallbackInworldVoiceLanguageCodeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackInworldVoiceLanguageCode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackInworldVoiceLanguageCode
    > _stringToEnum = new()
    {
        { "en", FallbackInworldVoiceLanguageCode.En },
        { "zh", FallbackInworldVoiceLanguageCode.Zh },
        { "ko", FallbackInworldVoiceLanguageCode.Ko },
        { "nl", FallbackInworldVoiceLanguageCode.Nl },
        { "fr", FallbackInworldVoiceLanguageCode.Fr },
        { "es", FallbackInworldVoiceLanguageCode.Es },
        { "ja", FallbackInworldVoiceLanguageCode.Ja },
        { "de", FallbackInworldVoiceLanguageCode.De },
        { "it", FallbackInworldVoiceLanguageCode.It },
        { "pl", FallbackInworldVoiceLanguageCode.Pl },
        { "pt", FallbackInworldVoiceLanguageCode.Pt },
        { "ru", FallbackInworldVoiceLanguageCode.Ru },
        { "hi", FallbackInworldVoiceLanguageCode.Hi },
        { "he", FallbackInworldVoiceLanguageCode.He },
        { "ar", FallbackInworldVoiceLanguageCode.Ar },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackInworldVoiceLanguageCode,
        string
    > _enumToString = new()
    {
        { FallbackInworldVoiceLanguageCode.En, "en" },
        { FallbackInworldVoiceLanguageCode.Zh, "zh" },
        { FallbackInworldVoiceLanguageCode.Ko, "ko" },
        { FallbackInworldVoiceLanguageCode.Nl, "nl" },
        { FallbackInworldVoiceLanguageCode.Fr, "fr" },
        { FallbackInworldVoiceLanguageCode.Es, "es" },
        { FallbackInworldVoiceLanguageCode.Ja, "ja" },
        { FallbackInworldVoiceLanguageCode.De, "de" },
        { FallbackInworldVoiceLanguageCode.It, "it" },
        { FallbackInworldVoiceLanguageCode.Pl, "pl" },
        { FallbackInworldVoiceLanguageCode.Pt, "pt" },
        { FallbackInworldVoiceLanguageCode.Ru, "ru" },
        { FallbackInworldVoiceLanguageCode.Hi, "hi" },
        { FallbackInworldVoiceLanguageCode.He, "he" },
        { FallbackInworldVoiceLanguageCode.Ar, "ar" },
    };

    public override FallbackInworldVoiceLanguageCode Read(
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
        FallbackInworldVoiceLanguageCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackInworldVoiceLanguageCode ReadAsPropertyName(
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
        FallbackInworldVoiceLanguageCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
