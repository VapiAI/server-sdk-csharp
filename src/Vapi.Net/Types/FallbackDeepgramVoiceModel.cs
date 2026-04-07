using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackDeepgramVoiceModelSerializer))]
public enum FallbackDeepgramVoiceModel
{
    [EnumMember(Value = "aura")]
    Aura,

    [EnumMember(Value = "aura-2")]
    Aura2,
}

internal class FallbackDeepgramVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackDeepgramVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackDeepgramVoiceModel
    > _stringToEnum = new()
    {
        { "aura", FallbackDeepgramVoiceModel.Aura },
        { "aura-2", FallbackDeepgramVoiceModel.Aura2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackDeepgramVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackDeepgramVoiceModel.Aura, "aura" },
        { FallbackDeepgramVoiceModel.Aura2, "aura-2" },
    };

    public override FallbackDeepgramVoiceModel Read(
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
        FallbackDeepgramVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackDeepgramVoiceModel ReadAsPropertyName(
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
        FallbackDeepgramVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
