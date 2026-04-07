using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RimeAiVoiceLanguageSerializer))]
public enum RimeAiVoiceLanguage
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

internal class RimeAiVoiceLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RimeAiVoiceLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RimeAiVoiceLanguage
    > _stringToEnum = new()
    {
        { "en", RimeAiVoiceLanguage.En },
        { "es", RimeAiVoiceLanguage.Es },
        { "de", RimeAiVoiceLanguage.De },
        { "fr", RimeAiVoiceLanguage.Fr },
        { "ar", RimeAiVoiceLanguage.Ar },
        { "hi", RimeAiVoiceLanguage.Hi },
        { "ja", RimeAiVoiceLanguage.Ja },
        { "he", RimeAiVoiceLanguage.He },
        { "pt", RimeAiVoiceLanguage.Pt },
        { "ta", RimeAiVoiceLanguage.Ta },
        { "si", RimeAiVoiceLanguage.Si },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RimeAiVoiceLanguage,
        string
    > _enumToString = new()
    {
        { RimeAiVoiceLanguage.En, "en" },
        { RimeAiVoiceLanguage.Es, "es" },
        { RimeAiVoiceLanguage.De, "de" },
        { RimeAiVoiceLanguage.Fr, "fr" },
        { RimeAiVoiceLanguage.Ar, "ar" },
        { RimeAiVoiceLanguage.Hi, "hi" },
        { RimeAiVoiceLanguage.Ja, "ja" },
        { RimeAiVoiceLanguage.He, "he" },
        { RimeAiVoiceLanguage.Pt, "pt" },
        { RimeAiVoiceLanguage.Ta, "ta" },
        { RimeAiVoiceLanguage.Si, "si" },
    };

    public override RimeAiVoiceLanguage Read(
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
        RimeAiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RimeAiVoiceLanguage ReadAsPropertyName(
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
        RimeAiVoiceLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
