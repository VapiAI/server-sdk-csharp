using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackCartesiaVoiceModelSerializer))]
public enum FallbackCartesiaVoiceModel
{
    [EnumMember(Value = "sonic-3")]
    Sonic3,

    [EnumMember(Value = "sonic-3-2026-01-12")]
    Sonic320260112,

    [EnumMember(Value = "sonic-3-2025-10-27")]
    Sonic320251027,

    [EnumMember(Value = "sonic-2")]
    Sonic2,

    [EnumMember(Value = "sonic-2-2025-06-11")]
    Sonic220250611,

    [EnumMember(Value = "sonic-english")]
    SonicEnglish,

    [EnumMember(Value = "sonic-multilingual")]
    SonicMultilingual,

    [EnumMember(Value = "sonic-preview")]
    SonicPreview,

    [EnumMember(Value = "sonic")]
    Sonic,
}

internal class FallbackCartesiaVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackCartesiaVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackCartesiaVoiceModel
    > _stringToEnum = new()
    {
        { "sonic-3", FallbackCartesiaVoiceModel.Sonic3 },
        { "sonic-3-2026-01-12", FallbackCartesiaVoiceModel.Sonic320260112 },
        { "sonic-3-2025-10-27", FallbackCartesiaVoiceModel.Sonic320251027 },
        { "sonic-2", FallbackCartesiaVoiceModel.Sonic2 },
        { "sonic-2-2025-06-11", FallbackCartesiaVoiceModel.Sonic220250611 },
        { "sonic-english", FallbackCartesiaVoiceModel.SonicEnglish },
        { "sonic-multilingual", FallbackCartesiaVoiceModel.SonicMultilingual },
        { "sonic-preview", FallbackCartesiaVoiceModel.SonicPreview },
        { "sonic", FallbackCartesiaVoiceModel.Sonic },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackCartesiaVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackCartesiaVoiceModel.Sonic3, "sonic-3" },
        { FallbackCartesiaVoiceModel.Sonic320260112, "sonic-3-2026-01-12" },
        { FallbackCartesiaVoiceModel.Sonic320251027, "sonic-3-2025-10-27" },
        { FallbackCartesiaVoiceModel.Sonic2, "sonic-2" },
        { FallbackCartesiaVoiceModel.Sonic220250611, "sonic-2-2025-06-11" },
        { FallbackCartesiaVoiceModel.SonicEnglish, "sonic-english" },
        { FallbackCartesiaVoiceModel.SonicMultilingual, "sonic-multilingual" },
        { FallbackCartesiaVoiceModel.SonicPreview, "sonic-preview" },
        { FallbackCartesiaVoiceModel.Sonic, "sonic" },
    };

    public override FallbackCartesiaVoiceModel Read(
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
        FallbackCartesiaVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackCartesiaVoiceModel ReadAsPropertyName(
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
        FallbackCartesiaVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
