using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAssemblyAiTranscriberLanguageCodesItemSerializer))]
public enum FallbackAssemblyAiTranscriberLanguageCodesItem
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "da")]
    Da,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "he")]
    He,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "zh")]
    Zh,
}

internal class FallbackAssemblyAiTranscriberLanguageCodesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAssemblyAiTranscriberLanguageCodesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAssemblyAiTranscriberLanguageCodesItem
    > _stringToEnum = new()
    {
        { "en", FallbackAssemblyAiTranscriberLanguageCodesItem.En },
        { "es", FallbackAssemblyAiTranscriberLanguageCodesItem.Es },
        { "fr", FallbackAssemblyAiTranscriberLanguageCodesItem.Fr },
        { "de", FallbackAssemblyAiTranscriberLanguageCodesItem.De },
        { "it", FallbackAssemblyAiTranscriberLanguageCodesItem.It },
        { "pt", FallbackAssemblyAiTranscriberLanguageCodesItem.Pt },
        { "tr", FallbackAssemblyAiTranscriberLanguageCodesItem.Tr },
        { "nl", FallbackAssemblyAiTranscriberLanguageCodesItem.Nl },
        { "sv", FallbackAssemblyAiTranscriberLanguageCodesItem.Sv },
        { "no", FallbackAssemblyAiTranscriberLanguageCodesItem.No },
        { "da", FallbackAssemblyAiTranscriberLanguageCodesItem.Da },
        { "fi", FallbackAssemblyAiTranscriberLanguageCodesItem.Fi },
        { "hi", FallbackAssemblyAiTranscriberLanguageCodesItem.Hi },
        { "vi", FallbackAssemblyAiTranscriberLanguageCodesItem.Vi },
        { "ar", FallbackAssemblyAiTranscriberLanguageCodesItem.Ar },
        { "he", FallbackAssemblyAiTranscriberLanguageCodesItem.He },
        { "ja", FallbackAssemblyAiTranscriberLanguageCodesItem.Ja },
        { "zh", FallbackAssemblyAiTranscriberLanguageCodesItem.Zh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAssemblyAiTranscriberLanguageCodesItem,
        string
    > _enumToString = new()
    {
        { FallbackAssemblyAiTranscriberLanguageCodesItem.En, "en" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Es, "es" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Fr, "fr" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.De, "de" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.It, "it" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Pt, "pt" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Tr, "tr" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Nl, "nl" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Sv, "sv" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.No, "no" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Da, "da" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Fi, "fi" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Hi, "hi" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Vi, "vi" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ar, "ar" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.He, "he" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ja, "ja" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Zh, "zh" },
    };

    public override FallbackAssemblyAiTranscriberLanguageCodesItem Read(
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
        FallbackAssemblyAiTranscriberLanguageCodesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAssemblyAiTranscriberLanguageCodesItem ReadAsPropertyName(
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
        FallbackAssemblyAiTranscriberLanguageCodesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
