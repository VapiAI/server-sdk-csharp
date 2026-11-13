using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransientAssistantDtoBackgroundSoundZeroSerializer))]
public enum TransientAssistantDtoBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,

    [EnumMember(Value = "white-noise")]
    WhiteNoise,

    [EnumMember(Value = "city")]
    City,

    [EnumMember(Value = "crowd")]
    Crowd,

    [EnumMember(Value = "farm")]
    Farm,
}

internal class TransientAssistantDtoBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransientAssistantDtoBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransientAssistantDtoBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", TransientAssistantDtoBackgroundSoundZero.Off },
        { "office", TransientAssistantDtoBackgroundSoundZero.Office },
        { "white-noise", TransientAssistantDtoBackgroundSoundZero.WhiteNoise },
        { "city", TransientAssistantDtoBackgroundSoundZero.City },
        { "crowd", TransientAssistantDtoBackgroundSoundZero.Crowd },
        { "farm", TransientAssistantDtoBackgroundSoundZero.Farm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransientAssistantDtoBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { TransientAssistantDtoBackgroundSoundZero.Off, "off" },
        { TransientAssistantDtoBackgroundSoundZero.Office, "office" },
        { TransientAssistantDtoBackgroundSoundZero.WhiteNoise, "white-noise" },
        { TransientAssistantDtoBackgroundSoundZero.City, "city" },
        { TransientAssistantDtoBackgroundSoundZero.Crowd, "crowd" },
        { TransientAssistantDtoBackgroundSoundZero.Farm, "farm" },
    };

    public override TransientAssistantDtoBackgroundSoundZero Read(
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
        TransientAssistantDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransientAssistantDtoBackgroundSoundZero ReadAsPropertyName(
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
        TransientAssistantDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
