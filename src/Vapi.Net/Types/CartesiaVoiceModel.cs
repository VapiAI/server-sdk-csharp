using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaVoiceModelSerializer))]
public enum CartesiaVoiceModel
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

internal class CartesiaVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaVoiceModel
    > _stringToEnum = new()
    {
        { "sonic-3", CartesiaVoiceModel.Sonic3 },
        { "sonic-3-2026-01-12", CartesiaVoiceModel.Sonic320260112 },
        { "sonic-3-2025-10-27", CartesiaVoiceModel.Sonic320251027 },
        { "sonic-2", CartesiaVoiceModel.Sonic2 },
        { "sonic-2-2025-06-11", CartesiaVoiceModel.Sonic220250611 },
        { "sonic-english", CartesiaVoiceModel.SonicEnglish },
        { "sonic-multilingual", CartesiaVoiceModel.SonicMultilingual },
        { "sonic-preview", CartesiaVoiceModel.SonicPreview },
        { "sonic", CartesiaVoiceModel.Sonic },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaVoiceModel,
        string
    > _enumToString = new()
    {
        { CartesiaVoiceModel.Sonic3, "sonic-3" },
        { CartesiaVoiceModel.Sonic320260112, "sonic-3-2026-01-12" },
        { CartesiaVoiceModel.Sonic320251027, "sonic-3-2025-10-27" },
        { CartesiaVoiceModel.Sonic2, "sonic-2" },
        { CartesiaVoiceModel.Sonic220250611, "sonic-2-2025-06-11" },
        { CartesiaVoiceModel.SonicEnglish, "sonic-english" },
        { CartesiaVoiceModel.SonicMultilingual, "sonic-multilingual" },
        { CartesiaVoiceModel.SonicPreview, "sonic-preview" },
        { CartesiaVoiceModel.Sonic, "sonic" },
    };

    public override CartesiaVoiceModel Read(
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
        CartesiaVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaVoiceModel ReadAsPropertyName(
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
        CartesiaVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
