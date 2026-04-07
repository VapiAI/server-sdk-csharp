using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RimeAiVoiceModelSerializer))]
public enum RimeAiVoiceModel
{
    [EnumMember(Value = "arcana")]
    Arcana,

    [EnumMember(Value = "mistv2")]
    Mistv2,

    [EnumMember(Value = "mist")]
    Mist,
}

internal class RimeAiVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RimeAiVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RimeAiVoiceModel
    > _stringToEnum = new()
    {
        { "arcana", RimeAiVoiceModel.Arcana },
        { "mistv2", RimeAiVoiceModel.Mistv2 },
        { "mist", RimeAiVoiceModel.Mist },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RimeAiVoiceModel,
        string
    > _enumToString = new()
    {
        { RimeAiVoiceModel.Arcana, "arcana" },
        { RimeAiVoiceModel.Mistv2, "mistv2" },
        { RimeAiVoiceModel.Mist, "mist" },
    };

    public override RimeAiVoiceModel Read(
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
        RimeAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RimeAiVoiceModel ReadAsPropertyName(
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
        RimeAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
