using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantSaveResponseBackgroundSoundZeroSerializer))]
public enum AssistantSaveResponseBackgroundSoundZero
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

internal class AssistantSaveResponseBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantSaveResponseBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantSaveResponseBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", AssistantSaveResponseBackgroundSoundZero.Off },
        { "office", AssistantSaveResponseBackgroundSoundZero.Office },
        { "white-noise", AssistantSaveResponseBackgroundSoundZero.WhiteNoise },
        { "city", AssistantSaveResponseBackgroundSoundZero.City },
        { "crowd", AssistantSaveResponseBackgroundSoundZero.Crowd },
        { "farm", AssistantSaveResponseBackgroundSoundZero.Farm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantSaveResponseBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { AssistantSaveResponseBackgroundSoundZero.Off, "off" },
        { AssistantSaveResponseBackgroundSoundZero.Office, "office" },
        { AssistantSaveResponseBackgroundSoundZero.WhiteNoise, "white-noise" },
        { AssistantSaveResponseBackgroundSoundZero.City, "city" },
        { AssistantSaveResponseBackgroundSoundZero.Crowd, "crowd" },
        { AssistantSaveResponseBackgroundSoundZero.Farm, "farm" },
    };

    public override AssistantSaveResponseBackgroundSoundZero Read(
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
        AssistantSaveResponseBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantSaveResponseBackgroundSoundZero ReadAsPropertyName(
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
        AssistantSaveResponseBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
