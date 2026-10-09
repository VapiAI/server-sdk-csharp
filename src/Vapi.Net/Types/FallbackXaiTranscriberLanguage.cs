using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackXaiTranscriberLanguageSerializer))]
public enum FallbackXaiTranscriberLanguage
{
    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "cs")]
    Cs,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "fil")]
    Fil,

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

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "ms")]
    Ms,

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

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "vi")]
    Vi,
}

internal class FallbackXaiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackXaiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackXaiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "ar", FallbackXaiTranscriberLanguage.Ar },
        { "cs", FallbackXaiTranscriberLanguage.Cs },
        { "da", FallbackXaiTranscriberLanguage.Da },
        { "nl", FallbackXaiTranscriberLanguage.Nl },
        { "en", FallbackXaiTranscriberLanguage.En },
        { "fil", FallbackXaiTranscriberLanguage.Fil },
        { "fr", FallbackXaiTranscriberLanguage.Fr },
        { "de", FallbackXaiTranscriberLanguage.De },
        { "hi", FallbackXaiTranscriberLanguage.Hi },
        { "id", FallbackXaiTranscriberLanguage.Id },
        { "it", FallbackXaiTranscriberLanguage.It },
        { "ja", FallbackXaiTranscriberLanguage.Ja },
        { "ko", FallbackXaiTranscriberLanguage.Ko },
        { "mk", FallbackXaiTranscriberLanguage.Mk },
        { "ms", FallbackXaiTranscriberLanguage.Ms },
        { "fa", FallbackXaiTranscriberLanguage.Fa },
        { "pl", FallbackXaiTranscriberLanguage.Pl },
        { "pt", FallbackXaiTranscriberLanguage.Pt },
        { "ro", FallbackXaiTranscriberLanguage.Ro },
        { "ru", FallbackXaiTranscriberLanguage.Ru },
        { "es", FallbackXaiTranscriberLanguage.Es },
        { "sv", FallbackXaiTranscriberLanguage.Sv },
        { "th", FallbackXaiTranscriberLanguage.Th },
        { "tr", FallbackXaiTranscriberLanguage.Tr },
        { "vi", FallbackXaiTranscriberLanguage.Vi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackXaiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackXaiTranscriberLanguage.Ar, "ar" },
        { FallbackXaiTranscriberLanguage.Cs, "cs" },
        { FallbackXaiTranscriberLanguage.Da, "da" },
        { FallbackXaiTranscriberLanguage.Nl, "nl" },
        { FallbackXaiTranscriberLanguage.En, "en" },
        { FallbackXaiTranscriberLanguage.Fil, "fil" },
        { FallbackXaiTranscriberLanguage.Fr, "fr" },
        { FallbackXaiTranscriberLanguage.De, "de" },
        { FallbackXaiTranscriberLanguage.Hi, "hi" },
        { FallbackXaiTranscriberLanguage.Id, "id" },
        { FallbackXaiTranscriberLanguage.It, "it" },
        { FallbackXaiTranscriberLanguage.Ja, "ja" },
        { FallbackXaiTranscriberLanguage.Ko, "ko" },
        { FallbackXaiTranscriberLanguage.Mk, "mk" },
        { FallbackXaiTranscriberLanguage.Ms, "ms" },
        { FallbackXaiTranscriberLanguage.Fa, "fa" },
        { FallbackXaiTranscriberLanguage.Pl, "pl" },
        { FallbackXaiTranscriberLanguage.Pt, "pt" },
        { FallbackXaiTranscriberLanguage.Ro, "ro" },
        { FallbackXaiTranscriberLanguage.Ru, "ru" },
        { FallbackXaiTranscriberLanguage.Es, "es" },
        { FallbackXaiTranscriberLanguage.Sv, "sv" },
        { FallbackXaiTranscriberLanguage.Th, "th" },
        { FallbackXaiTranscriberLanguage.Tr, "tr" },
        { FallbackXaiTranscriberLanguage.Vi, "vi" },
    };

    public override FallbackXaiTranscriberLanguage Read(
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
        FallbackXaiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackXaiTranscriberLanguage ReadAsPropertyName(
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
        FallbackXaiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
