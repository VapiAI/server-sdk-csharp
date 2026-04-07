using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackRimeAiVoiceLanguageSerializer))]
public enum FallbackRimeAiVoiceLanguage
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "ta")]
    Ta,

    [EnumMember(Value = "si")]
    Si,
}

internal class FallbackRimeAiVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackRimeAiVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackRimeAiVoiceLanguage
    > _stringToEnum = new()
    {
        { "en", FallbackRimeAiVoiceLanguage.En },
        { "es", FallbackRimeAiVoiceLanguage.Es },
        { "de", FallbackRimeAiVoiceLanguage.De },
        { "fr", FallbackRimeAiVoiceLanguage.Fr },
        { "ar", FallbackRimeAiVoiceLanguage.Ar },
        { "hi", FallbackRimeAiVoiceLanguage.Hi },
        { "ja", FallbackRimeAiVoiceLanguage.Ja },
        { "he", FallbackRimeAiVoiceLanguage.He },
        { "pt", FallbackRimeAiVoiceLanguage.Pt },
        { "ta", FallbackRimeAiVoiceLanguage.Ta },
        { "si", FallbackRimeAiVoiceLanguage.Si },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackRimeAiVoiceLanguage,
        string
    > _enumToString = new()
    {
        { FallbackRimeAiVoiceLanguage.En, "en" },
        { FallbackRimeAiVoiceLanguage.Es, "es" },
        { FallbackRimeAiVoiceLanguage.De, "de" },
        { FallbackRimeAiVoiceLanguage.Fr, "fr" },
        { FallbackRimeAiVoiceLanguage.Ar, "ar" },
        { FallbackRimeAiVoiceLanguage.Hi, "hi" },
        { FallbackRimeAiVoiceLanguage.Ja, "ja" },
        { FallbackRimeAiVoiceLanguage.He, "he" },
        { FallbackRimeAiVoiceLanguage.Pt, "pt" },
        { FallbackRimeAiVoiceLanguage.Ta, "ta" },
        { FallbackRimeAiVoiceLanguage.Si, "si" },
    };

    public override FallbackRimeAiVoiceLanguage Read(
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
        FallbackRimeAiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackRimeAiVoiceLanguage ReadAsPropertyName(
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
        FallbackRimeAiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
