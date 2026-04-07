using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackElevenLabsVoiceModelSerializer))]
public enum FallbackElevenLabsVoiceModel
{
    [EnumMember(Value = "eleven_multilingual_v2")]
    ElevenMultilingualV2,

    [EnumMember(Value = "eleven_turbo_v2")]
    ElevenTurboV2,

    [EnumMember(Value = "eleven_turbo_v2_5")]
    ElevenTurboV25,

    [EnumMember(Value = "eleven_flash_v2")]
    ElevenFlashV2,

    [EnumMember(Value = "eleven_flash_v2_5")]
    ElevenFlashV25,

    [EnumMember(Value = "eleven_monolingual_v1")]
    ElevenMonolingualV1,

    [EnumMember(Value = "eleven_v3")]
    ElevenV3,
}

internal class FallbackElevenLabsVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackElevenLabsVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackElevenLabsVoiceModel
    > _stringToEnum = new()
    {
        { "eleven_multilingual_v2", FallbackElevenLabsVoiceModel.ElevenMultilingualV2 },
        { "eleven_turbo_v2", FallbackElevenLabsVoiceModel.ElevenTurboV2 },
        { "eleven_turbo_v2_5", FallbackElevenLabsVoiceModel.ElevenTurboV25 },
        { "eleven_flash_v2", FallbackElevenLabsVoiceModel.ElevenFlashV2 },
        { "eleven_flash_v2_5", FallbackElevenLabsVoiceModel.ElevenFlashV25 },
        { "eleven_monolingual_v1", FallbackElevenLabsVoiceModel.ElevenMonolingualV1 },
        { "eleven_v3", FallbackElevenLabsVoiceModel.ElevenV3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackElevenLabsVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackElevenLabsVoiceModel.ElevenMultilingualV2, "eleven_multilingual_v2" },
        { FallbackElevenLabsVoiceModel.ElevenTurboV2, "eleven_turbo_v2" },
        { FallbackElevenLabsVoiceModel.ElevenTurboV25, "eleven_turbo_v2_5" },
        { FallbackElevenLabsVoiceModel.ElevenFlashV2, "eleven_flash_v2" },
        { FallbackElevenLabsVoiceModel.ElevenFlashV25, "eleven_flash_v2_5" },
        { FallbackElevenLabsVoiceModel.ElevenMonolingualV1, "eleven_monolingual_v1" },
        { FallbackElevenLabsVoiceModel.ElevenV3, "eleven_v3" },
    };

    public override FallbackElevenLabsVoiceModel Read(
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
        FallbackElevenLabsVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackElevenLabsVoiceModel ReadAsPropertyName(
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
        FallbackElevenLabsVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
