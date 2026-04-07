using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackRimeAiVoiceModelSerializer))]
public enum FallbackRimeAiVoiceModel
{
    [EnumMember(Value = "arcana")]
    Arcana,

    [EnumMember(Value = "mistv2")]
    Mistv2,

    [EnumMember(Value = "mist")]
    Mist,
}

internal class FallbackRimeAiVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackRimeAiVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackRimeAiVoiceModel
    > _stringToEnum = new()
    {
        { "arcana", FallbackRimeAiVoiceModel.Arcana },
        { "mistv2", FallbackRimeAiVoiceModel.Mistv2 },
        { "mist", FallbackRimeAiVoiceModel.Mist },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackRimeAiVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackRimeAiVoiceModel.Arcana, "arcana" },
        { FallbackRimeAiVoiceModel.Mistv2, "mistv2" },
        { FallbackRimeAiVoiceModel.Mist, "mist" },
    };

    public override FallbackRimeAiVoiceModel Read(
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
        FallbackRimeAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackRimeAiVoiceModel ReadAsPropertyName(
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
        FallbackRimeAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
