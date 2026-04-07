using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSesameVoiceModelSerializer))]
public enum FallbackSesameVoiceModel
{
    [EnumMember(Value = "csm-1b")]
    Csm1B,
}

internal class FallbackSesameVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSesameVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSesameVoiceModel
    > _stringToEnum = new() { { "csm-1b", FallbackSesameVoiceModel.Csm1B } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSesameVoiceModel,
        string
    > _enumToString = new() { { FallbackSesameVoiceModel.Csm1B, "csm-1b" } };

    public override FallbackSesameVoiceModel Read(
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
        FallbackSesameVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSesameVoiceModel ReadAsPropertyName(
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
        FallbackSesameVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
