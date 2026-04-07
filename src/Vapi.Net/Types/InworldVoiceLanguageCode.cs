using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InworldVoiceLanguageCodeSerializer))]
public enum InworldVoiceLanguageCode
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

internal class InworldVoiceLanguageCodeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InworldVoiceLanguageCode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InworldVoiceLanguageCode
    > _stringToEnum = new()
    {
        { "en", InworldVoiceLanguageCode.En },
        { "zh", InworldVoiceLanguageCode.Zh },
        { "ko", InworldVoiceLanguageCode.Ko },
        { "nl", InworldVoiceLanguageCode.Nl },
        { "fr", InworldVoiceLanguageCode.Fr },
        { "es", InworldVoiceLanguageCode.Es },
        { "ja", InworldVoiceLanguageCode.Ja },
        { "de", InworldVoiceLanguageCode.De },
        { "it", InworldVoiceLanguageCode.It },
        { "pl", InworldVoiceLanguageCode.Pl },
        { "pt", InworldVoiceLanguageCode.Pt },
        { "ru", InworldVoiceLanguageCode.Ru },
        { "hi", InworldVoiceLanguageCode.Hi },
        { "he", InworldVoiceLanguageCode.He },
        { "ar", InworldVoiceLanguageCode.Ar },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InworldVoiceLanguageCode,
        string
    > _enumToString = new()
    {
        { InworldVoiceLanguageCode.En, "en" },
        { InworldVoiceLanguageCode.Zh, "zh" },
        { InworldVoiceLanguageCode.Ko, "ko" },
        { InworldVoiceLanguageCode.Nl, "nl" },
        { InworldVoiceLanguageCode.Fr, "fr" },
        { InworldVoiceLanguageCode.Es, "es" },
        { InworldVoiceLanguageCode.Ja, "ja" },
        { InworldVoiceLanguageCode.De, "de" },
        { InworldVoiceLanguageCode.It, "it" },
        { InworldVoiceLanguageCode.Pl, "pl" },
        { InworldVoiceLanguageCode.Pt, "pt" },
        { InworldVoiceLanguageCode.Ru, "ru" },
        { InworldVoiceLanguageCode.Hi, "hi" },
        { InworldVoiceLanguageCode.He, "he" },
        { InworldVoiceLanguageCode.Ar, "ar" },
    };

    public override InworldVoiceLanguageCode Read(
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
        InworldVoiceLanguageCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InworldVoiceLanguageCode ReadAsPropertyName(
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
        InworldVoiceLanguageCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
