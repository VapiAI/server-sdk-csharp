using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssemblyAiTranscriberLanguageCodesItemSerializer))]
public enum AssemblyAiTranscriberLanguageCodesItem
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

internal class AssemblyAiTranscriberLanguageCodesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssemblyAiTranscriberLanguageCodesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssemblyAiTranscriberLanguageCodesItem
    > _stringToEnum = new()
    {
        { "en", AssemblyAiTranscriberLanguageCodesItem.En },
        { "es", AssemblyAiTranscriberLanguageCodesItem.Es },
        { "fr", AssemblyAiTranscriberLanguageCodesItem.Fr },
        { "de", AssemblyAiTranscriberLanguageCodesItem.De },
        { "it", AssemblyAiTranscriberLanguageCodesItem.It },
        { "pt", AssemblyAiTranscriberLanguageCodesItem.Pt },
        { "tr", AssemblyAiTranscriberLanguageCodesItem.Tr },
        { "nl", AssemblyAiTranscriberLanguageCodesItem.Nl },
        { "sv", AssemblyAiTranscriberLanguageCodesItem.Sv },
        { "no", AssemblyAiTranscriberLanguageCodesItem.No },
        { "da", AssemblyAiTranscriberLanguageCodesItem.Da },
        { "fi", AssemblyAiTranscriberLanguageCodesItem.Fi },
        { "hi", AssemblyAiTranscriberLanguageCodesItem.Hi },
        { "vi", AssemblyAiTranscriberLanguageCodesItem.Vi },
        { "ar", AssemblyAiTranscriberLanguageCodesItem.Ar },
        { "he", AssemblyAiTranscriberLanguageCodesItem.He },
        { "ja", AssemblyAiTranscriberLanguageCodesItem.Ja },
        { "zh", AssemblyAiTranscriberLanguageCodesItem.Zh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssemblyAiTranscriberLanguageCodesItem,
        string
    > _enumToString = new()
    {
        { AssemblyAiTranscriberLanguageCodesItem.En, "en" },
        { AssemblyAiTranscriberLanguageCodesItem.Es, "es" },
        { AssemblyAiTranscriberLanguageCodesItem.Fr, "fr" },
        { AssemblyAiTranscriberLanguageCodesItem.De, "de" },
        { AssemblyAiTranscriberLanguageCodesItem.It, "it" },
        { AssemblyAiTranscriberLanguageCodesItem.Pt, "pt" },
        { AssemblyAiTranscriberLanguageCodesItem.Tr, "tr" },
        { AssemblyAiTranscriberLanguageCodesItem.Nl, "nl" },
        { AssemblyAiTranscriberLanguageCodesItem.Sv, "sv" },
        { AssemblyAiTranscriberLanguageCodesItem.No, "no" },
        { AssemblyAiTranscriberLanguageCodesItem.Da, "da" },
        { AssemblyAiTranscriberLanguageCodesItem.Fi, "fi" },
        { AssemblyAiTranscriberLanguageCodesItem.Hi, "hi" },
        { AssemblyAiTranscriberLanguageCodesItem.Vi, "vi" },
        { AssemblyAiTranscriberLanguageCodesItem.Ar, "ar" },
        { AssemblyAiTranscriberLanguageCodesItem.He, "he" },
        { AssemblyAiTranscriberLanguageCodesItem.Ja, "ja" },
        { AssemblyAiTranscriberLanguageCodesItem.Zh, "zh" },
    };

    public override AssemblyAiTranscriberLanguageCodesItem Read(
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
        AssemblyAiTranscriberLanguageCodesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssemblyAiTranscriberLanguageCodesItem ReadAsPropertyName(
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
        AssemblyAiTranscriberLanguageCodesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
