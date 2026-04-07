using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepgramVoiceModelSerializer))]
public enum DeepgramVoiceModel
{
    [EnumMember(Value = "aura")]
    Aura,

    [EnumMember(Value = "aura-2")]
    Aura2,
}

internal class DeepgramVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepgramVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepgramVoiceModel
    > _stringToEnum = new()
    {
        { "aura", DeepgramVoiceModel.Aura },
        { "aura-2", DeepgramVoiceModel.Aura2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepgramVoiceModel,
        string
    > _enumToString = new()
    {
        { DeepgramVoiceModel.Aura, "aura" },
        { DeepgramVoiceModel.Aura2, "aura-2" },
    };

    public override DeepgramVoiceModel Read(
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
        DeepgramVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepgramVoiceModel ReadAsPropertyName(
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
        DeepgramVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
