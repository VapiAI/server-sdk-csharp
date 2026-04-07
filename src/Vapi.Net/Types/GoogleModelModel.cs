using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleModelModelSerializer))]
public enum GoogleModelModel
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

internal class GoogleModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleModelModel
    > _stringToEnum = new()
    {
        { "gemini-3-flash-preview", GoogleModelModel.Gemini3FlashPreview },
        { "gemini-2.5-pro", GoogleModelModel.Gemini25Pro },
        { "gemini-2.5-flash", GoogleModelModel.Gemini25Flash },
        { "gemini-2.5-flash-lite", GoogleModelModel.Gemini25FlashLite },
        { "gemini-2.0-flash-thinking-exp", GoogleModelModel.Gemini20FlashThinkingExp },
        { "gemini-2.0-pro-exp-02-05", GoogleModelModel.Gemini20ProExp0205 },
        { "gemini-2.0-flash", GoogleModelModel.Gemini20Flash },
        { "gemini-2.0-flash-lite", GoogleModelModel.Gemini20FlashLite },
        { "gemini-2.0-flash-exp", GoogleModelModel.Gemini20FlashExp },
        { "gemini-2.0-flash-realtime-exp", GoogleModelModel.Gemini20FlashRealtimeExp },
        { "gemini-1.5-flash", GoogleModelModel.Gemini15Flash },
        { "gemini-1.5-flash-002", GoogleModelModel.Gemini15Flash002 },
        { "gemini-1.5-pro", GoogleModelModel.Gemini15Pro },
        { "gemini-1.5-pro-002", GoogleModelModel.Gemini15Pro002 },
        { "gemini-1.0-pro", GoogleModelModel.Gemini10Pro },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleModelModel,
        string
    > _enumToString = new()
    {
        { GoogleModelModel.Gemini3FlashPreview, "gemini-3-flash-preview" },
        { GoogleModelModel.Gemini25Pro, "gemini-2.5-pro" },
        { GoogleModelModel.Gemini25Flash, "gemini-2.5-flash" },
        { GoogleModelModel.Gemini25FlashLite, "gemini-2.5-flash-lite" },
        { GoogleModelModel.Gemini20FlashThinkingExp, "gemini-2.0-flash-thinking-exp" },
        { GoogleModelModel.Gemini20ProExp0205, "gemini-2.0-pro-exp-02-05" },
        { GoogleModelModel.Gemini20Flash, "gemini-2.0-flash" },
        { GoogleModelModel.Gemini20FlashLite, "gemini-2.0-flash-lite" },
        { GoogleModelModel.Gemini20FlashExp, "gemini-2.0-flash-exp" },
        { GoogleModelModel.Gemini20FlashRealtimeExp, "gemini-2.0-flash-realtime-exp" },
        { GoogleModelModel.Gemini15Flash, "gemini-1.5-flash" },
        { GoogleModelModel.Gemini15Flash002, "gemini-1.5-flash-002" },
        { GoogleModelModel.Gemini15Pro, "gemini-1.5-pro" },
        { GoogleModelModel.Gemini15Pro002, "gemini-1.5-pro-002" },
        { GoogleModelModel.Gemini10Pro, "gemini-1.0-pro" },
    };

    public override GoogleModelModel Read(
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
        GoogleModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleModelModel ReadAsPropertyName(
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
        GoogleModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
