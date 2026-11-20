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

    [EnumMember(Value = "ur")]
    Ur,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "fa")]
    Fa,

    [EnumMember(Value = "yue")]
    Yue,

    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "zu")]
    Zu,

    [EnumMember(Value = "xh")]
    Xh,

    [EnumMember(Value = "nn")]
    Nn,
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
        { "ur", FallbackAssemblyAiTranscriberLanguageCodesItem.Ur },
        { "ru", FallbackAssemblyAiTranscriberLanguageCodesItem.Ru },
        { "ko", FallbackAssemblyAiTranscriberLanguageCodesItem.Ko },
        { "ca", FallbackAssemblyAiTranscriberLanguageCodesItem.Ca },
        { "gl", FallbackAssemblyAiTranscriberLanguageCodesItem.Gl },
        { "ro", FallbackAssemblyAiTranscriberLanguageCodesItem.Ro },
        { "et", FallbackAssemblyAiTranscriberLanguageCodesItem.Et },
        { "fa", FallbackAssemblyAiTranscriberLanguageCodesItem.Fa },
        { "yue", FallbackAssemblyAiTranscriberLanguageCodesItem.Yue },
        { "af", FallbackAssemblyAiTranscriberLanguageCodesItem.Af },
        { "mr", FallbackAssemblyAiTranscriberLanguageCodesItem.Mr },
        { "zu", FallbackAssemblyAiTranscriberLanguageCodesItem.Zu },
        { "xh", FallbackAssemblyAiTranscriberLanguageCodesItem.Xh },
        { "nn", FallbackAssemblyAiTranscriberLanguageCodesItem.Nn },
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
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ur, "ur" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ru, "ru" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ko, "ko" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ca, "ca" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Gl, "gl" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Ro, "ro" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Et, "et" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Fa, "fa" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Yue, "yue" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Af, "af" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Mr, "mr" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Zu, "zu" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Xh, "xh" },
        { FallbackAssemblyAiTranscriberLanguageCodesItem.Nn, "nn" },
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
