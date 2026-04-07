using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameSerializer))]
public enum GeminiMultimodalLivePrebuiltVoiceConfigVoiceName
{
    [EnumMember(Value = "Puck")]
    Puck,

    [EnumMember(Value = "Charon")]
    Charon,

    [EnumMember(Value = "Kore")]
    Kore,

    [EnumMember(Value = "Fenrir")]
    Fenrir,

    [EnumMember(Value = "Aoede")]
    Aoede,
}

internal class GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GeminiMultimodalLivePrebuiltVoiceConfigVoiceName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GeminiMultimodalLivePrebuiltVoiceConfigVoiceName
    > _stringToEnum = new()
    {
        { "Puck", GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Puck },
        { "Charon", GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Charon },
        { "Kore", GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Kore },
        { "Fenrir", GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Fenrir },
        { "Aoede", GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Aoede },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GeminiMultimodalLivePrebuiltVoiceConfigVoiceName,
        string
    > _enumToString = new()
    {
        { GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Puck, "Puck" },
        { GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Charon, "Charon" },
        { GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Kore, "Kore" },
        { GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Fenrir, "Fenrir" },
        { GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Aoede, "Aoede" },
    };

    public override GeminiMultimodalLivePrebuiltVoiceConfigVoiceName Read(
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
        GeminiMultimodalLivePrebuiltVoiceConfigVoiceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GeminiMultimodalLivePrebuiltVoiceConfigVoiceName ReadAsPropertyName(
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
        GeminiMultimodalLivePrebuiltVoiceConfigVoiceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
