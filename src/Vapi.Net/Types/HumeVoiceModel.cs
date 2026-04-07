using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(HumeVoiceModelSerializer))]
public enum HumeVoiceModel
{
    [EnumMember(Value = "octave")]
    Octave,

    [EnumMember(Value = "octave2")]
    Octave2,
}

internal class HumeVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<HumeVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        HumeVoiceModel
    > _stringToEnum = new()
    {
        { "octave", HumeVoiceModel.Octave },
        { "octave2", HumeVoiceModel.Octave2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        HumeVoiceModel,
        string
    > _enumToString = new()
    {
        { HumeVoiceModel.Octave, "octave" },
        { HumeVoiceModel.Octave2, "octave2" },
    };

    public override HumeVoiceModel Read(
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
        HumeVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override HumeVoiceModel ReadAsPropertyName(
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
        HumeVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
