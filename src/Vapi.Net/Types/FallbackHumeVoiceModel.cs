using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackHumeVoiceModelSerializer))]
public enum FallbackHumeVoiceModel
{
    [EnumMember(Value = "octave")]
    Octave,

    [EnumMember(Value = "octave2")]
    Octave2,
}

internal class FallbackHumeVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackHumeVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackHumeVoiceModel
    > _stringToEnum = new()
    {
        { "octave", FallbackHumeVoiceModel.Octave },
        { "octave2", FallbackHumeVoiceModel.Octave2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackHumeVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackHumeVoiceModel.Octave, "octave" },
        { FallbackHumeVoiceModel.Octave2, "octave2" },
    };

    public override FallbackHumeVoiceModel Read(
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
        FallbackHumeVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackHumeVoiceModel ReadAsPropertyName(
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
        FallbackHumeVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
