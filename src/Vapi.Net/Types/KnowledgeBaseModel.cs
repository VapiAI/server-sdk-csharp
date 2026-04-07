using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(KnowledgeBaseModelSerializer))]
public enum KnowledgeBaseModel
{
    [EnumMember(Value = "gemini-3-flash-preview")]
    Gemini3FlashPreview,

    [EnumMember(Value = "gemini-2.5-pro")]
    Gemini25Pro,

    [EnumMember(Value = "gemini-2.5-flash")]
    Gemini25Flash,

    [EnumMember(Value = "gemini-2.5-flash-lite")]
    Gemini25FlashLite,

    [EnumMember(Value = "gemini-2.0-flash-thinking-exp")]
    Gemini20FlashThinkingExp,

    [EnumMember(Value = "gemini-2.0-pro-exp-02-05")]
    Gemini20ProExp0205,

    [EnumMember(Value = "gemini-2.0-flash")]
    Gemini20Flash,

    [EnumMember(Value = "gemini-2.0-flash-lite")]
    Gemini20FlashLite,

    [EnumMember(Value = "gemini-2.0-flash-exp")]
    Gemini20FlashExp,

    [EnumMember(Value = "gemini-2.0-flash-realtime-exp")]
    Gemini20FlashRealtimeExp,

    [EnumMember(Value = "gemini-1.5-flash")]
    Gemini15Flash,

    [EnumMember(Value = "gemini-1.5-flash-002")]
    Gemini15Flash002,

    [EnumMember(Value = "gemini-1.5-pro")]
    Gemini15Pro,

    [EnumMember(Value = "gemini-1.5-pro-002")]
    Gemini15Pro002,

    [EnumMember(Value = "gemini-1.0-pro")]
    Gemini10Pro,
}

internal class KnowledgeBaseModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<KnowledgeBaseModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        KnowledgeBaseModel
    > _stringToEnum = new()
    {
        { "gemini-3-flash-preview", KnowledgeBaseModel.Gemini3FlashPreview },
        { "gemini-2.5-pro", KnowledgeBaseModel.Gemini25Pro },
        { "gemini-2.5-flash", KnowledgeBaseModel.Gemini25Flash },
        { "gemini-2.5-flash-lite", KnowledgeBaseModel.Gemini25FlashLite },
        { "gemini-2.0-flash-thinking-exp", KnowledgeBaseModel.Gemini20FlashThinkingExp },
        { "gemini-2.0-pro-exp-02-05", KnowledgeBaseModel.Gemini20ProExp0205 },
        { "gemini-2.0-flash", KnowledgeBaseModel.Gemini20Flash },
        { "gemini-2.0-flash-lite", KnowledgeBaseModel.Gemini20FlashLite },
        { "gemini-2.0-flash-exp", KnowledgeBaseModel.Gemini20FlashExp },
        { "gemini-2.0-flash-realtime-exp", KnowledgeBaseModel.Gemini20FlashRealtimeExp },
        { "gemini-1.5-flash", KnowledgeBaseModel.Gemini15Flash },
        { "gemini-1.5-flash-002", KnowledgeBaseModel.Gemini15Flash002 },
        { "gemini-1.5-pro", KnowledgeBaseModel.Gemini15Pro },
        { "gemini-1.5-pro-002", KnowledgeBaseModel.Gemini15Pro002 },
        { "gemini-1.0-pro", KnowledgeBaseModel.Gemini10Pro },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        KnowledgeBaseModel,
        string
    > _enumToString = new()
    {
        { KnowledgeBaseModel.Gemini3FlashPreview, "gemini-3-flash-preview" },
        { KnowledgeBaseModel.Gemini25Pro, "gemini-2.5-pro" },
        { KnowledgeBaseModel.Gemini25Flash, "gemini-2.5-flash" },
        { KnowledgeBaseModel.Gemini25FlashLite, "gemini-2.5-flash-lite" },
        { KnowledgeBaseModel.Gemini20FlashThinkingExp, "gemini-2.0-flash-thinking-exp" },
        { KnowledgeBaseModel.Gemini20ProExp0205, "gemini-2.0-pro-exp-02-05" },
        { KnowledgeBaseModel.Gemini20Flash, "gemini-2.0-flash" },
        { KnowledgeBaseModel.Gemini20FlashLite, "gemini-2.0-flash-lite" },
        { KnowledgeBaseModel.Gemini20FlashExp, "gemini-2.0-flash-exp" },
        { KnowledgeBaseModel.Gemini20FlashRealtimeExp, "gemini-2.0-flash-realtime-exp" },
        { KnowledgeBaseModel.Gemini15Flash, "gemini-1.5-flash" },
        { KnowledgeBaseModel.Gemini15Flash002, "gemini-1.5-flash-002" },
        { KnowledgeBaseModel.Gemini15Pro, "gemini-1.5-pro" },
        { KnowledgeBaseModel.Gemini15Pro002, "gemini-1.5-pro-002" },
        { KnowledgeBaseModel.Gemini10Pro, "gemini-1.0-pro" },
    };

    public override KnowledgeBaseModel Read(
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
        KnowledgeBaseModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override KnowledgeBaseModel ReadAsPropertyName(
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
        KnowledgeBaseModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
