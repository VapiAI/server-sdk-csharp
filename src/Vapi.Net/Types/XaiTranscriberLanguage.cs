using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(XaiTranscriberLanguageSerializer))]
public enum XaiTranscriberLanguage
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

internal class XaiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<XaiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        XaiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "ar", XaiTranscriberLanguage.Ar },
        { "cs", XaiTranscriberLanguage.Cs },
        { "da", XaiTranscriberLanguage.Da },
        { "nl", XaiTranscriberLanguage.Nl },
        { "en", XaiTranscriberLanguage.En },
        { "fil", XaiTranscriberLanguage.Fil },
        { "fr", XaiTranscriberLanguage.Fr },
        { "de", XaiTranscriberLanguage.De },
        { "hi", XaiTranscriberLanguage.Hi },
        { "id", XaiTranscriberLanguage.Id },
        { "it", XaiTranscriberLanguage.It },
        { "ja", XaiTranscriberLanguage.Ja },
        { "ko", XaiTranscriberLanguage.Ko },
        { "mk", XaiTranscriberLanguage.Mk },
        { "ms", XaiTranscriberLanguage.Ms },
        { "fa", XaiTranscriberLanguage.Fa },
        { "pl", XaiTranscriberLanguage.Pl },
        { "pt", XaiTranscriberLanguage.Pt },
        { "ro", XaiTranscriberLanguage.Ro },
        { "ru", XaiTranscriberLanguage.Ru },
        { "es", XaiTranscriberLanguage.Es },
        { "sv", XaiTranscriberLanguage.Sv },
        { "th", XaiTranscriberLanguage.Th },
        { "tr", XaiTranscriberLanguage.Tr },
        { "vi", XaiTranscriberLanguage.Vi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        XaiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { XaiTranscriberLanguage.Ar, "ar" },
        { XaiTranscriberLanguage.Cs, "cs" },
        { XaiTranscriberLanguage.Da, "da" },
        { XaiTranscriberLanguage.Nl, "nl" },
        { XaiTranscriberLanguage.En, "en" },
        { XaiTranscriberLanguage.Fil, "fil" },
        { XaiTranscriberLanguage.Fr, "fr" },
        { XaiTranscriberLanguage.De, "de" },
        { XaiTranscriberLanguage.Hi, "hi" },
        { XaiTranscriberLanguage.Id, "id" },
        { XaiTranscriberLanguage.It, "it" },
        { XaiTranscriberLanguage.Ja, "ja" },
        { XaiTranscriberLanguage.Ko, "ko" },
        { XaiTranscriberLanguage.Mk, "mk" },
        { XaiTranscriberLanguage.Ms, "ms" },
        { XaiTranscriberLanguage.Fa, "fa" },
        { XaiTranscriberLanguage.Pl, "pl" },
        { XaiTranscriberLanguage.Pt, "pt" },
        { XaiTranscriberLanguage.Ro, "ro" },
        { XaiTranscriberLanguage.Ru, "ru" },
        { XaiTranscriberLanguage.Es, "es" },
        { XaiTranscriberLanguage.Sv, "sv" },
        { XaiTranscriberLanguage.Th, "th" },
        { XaiTranscriberLanguage.Tr, "tr" },
        { XaiTranscriberLanguage.Vi, "vi" },
    };

    public override XaiTranscriberLanguage Read(
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
        XaiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override XaiTranscriberLanguage ReadAsPropertyName(
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
        XaiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
