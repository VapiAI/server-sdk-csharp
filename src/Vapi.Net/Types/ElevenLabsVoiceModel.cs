using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsVoiceModelSerializer))]
public enum ElevenLabsVoiceModel
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

internal class ElevenLabsVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsVoiceModel
    > _stringToEnum = new()
    {
        { "eleven_multilingual_v2", ElevenLabsVoiceModel.ElevenMultilingualV2 },
        { "eleven_turbo_v2", ElevenLabsVoiceModel.ElevenTurboV2 },
        { "eleven_turbo_v2_5", ElevenLabsVoiceModel.ElevenTurboV25 },
        { "eleven_flash_v2", ElevenLabsVoiceModel.ElevenFlashV2 },
        { "eleven_flash_v2_5", ElevenLabsVoiceModel.ElevenFlashV25 },
        { "eleven_monolingual_v1", ElevenLabsVoiceModel.ElevenMonolingualV1 },
        { "eleven_v3", ElevenLabsVoiceModel.ElevenV3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsVoiceModel,
        string
    > _enumToString = new()
    {
        { ElevenLabsVoiceModel.ElevenMultilingualV2, "eleven_multilingual_v2" },
        { ElevenLabsVoiceModel.ElevenTurboV2, "eleven_turbo_v2" },
        { ElevenLabsVoiceModel.ElevenTurboV25, "eleven_turbo_v2_5" },
        { ElevenLabsVoiceModel.ElevenFlashV2, "eleven_flash_v2" },
        { ElevenLabsVoiceModel.ElevenFlashV25, "eleven_flash_v2_5" },
        { ElevenLabsVoiceModel.ElevenMonolingualV1, "eleven_monolingual_v1" },
        { ElevenLabsVoiceModel.ElevenV3, "eleven_v3" },
    };

    public override ElevenLabsVoiceModel Read(
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
        ElevenLabsVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsVoiceModel ReadAsPropertyName(
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
        ElevenLabsVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
