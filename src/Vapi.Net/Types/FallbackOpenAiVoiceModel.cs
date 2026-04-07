using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackOpenAiVoiceModelSerializer))]
public enum FallbackOpenAiVoiceModel
{
    [EnumMember(Value = "tts-1")]
    Tts1,

    [EnumMember(Value = "tts-1-hd")]
    Tts1Hd,

    [EnumMember(Value = "gpt-4o-mini-tts")]
    Gpt4OMiniTts,
}

internal class FallbackOpenAiVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackOpenAiVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackOpenAiVoiceModel
    > _stringToEnum = new()
    {
        { "tts-1", FallbackOpenAiVoiceModel.Tts1 },
        { "tts-1-hd", FallbackOpenAiVoiceModel.Tts1Hd },
        { "gpt-4o-mini-tts", FallbackOpenAiVoiceModel.Gpt4OMiniTts },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackOpenAiVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackOpenAiVoiceModel.Tts1, "tts-1" },
        { FallbackOpenAiVoiceModel.Tts1Hd, "tts-1-hd" },
        { FallbackOpenAiVoiceModel.Gpt4OMiniTts, "gpt-4o-mini-tts" },
    };

    public override FallbackOpenAiVoiceModel Read(
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
        FallbackOpenAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackOpenAiVoiceModel ReadAsPropertyName(
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
        FallbackOpenAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
