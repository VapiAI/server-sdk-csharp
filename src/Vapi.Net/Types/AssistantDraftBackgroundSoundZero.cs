using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantDraftBackgroundSoundZeroSerializer))]
public enum AssistantDraftBackgroundSoundZero
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

internal class AssistantDraftBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantDraftBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantDraftBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", AssistantDraftBackgroundSoundZero.Off },
        { "office", AssistantDraftBackgroundSoundZero.Office },
        { "white-noise", AssistantDraftBackgroundSoundZero.WhiteNoise },
        { "city", AssistantDraftBackgroundSoundZero.City },
        { "crowd", AssistantDraftBackgroundSoundZero.Crowd },
        { "farm", AssistantDraftBackgroundSoundZero.Farm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantDraftBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { AssistantDraftBackgroundSoundZero.Off, "off" },
        { AssistantDraftBackgroundSoundZero.Office, "office" },
        { AssistantDraftBackgroundSoundZero.WhiteNoise, "white-noise" },
        { AssistantDraftBackgroundSoundZero.City, "city" },
        { AssistantDraftBackgroundSoundZero.Crowd, "crowd" },
        { AssistantDraftBackgroundSoundZero.Farm, "farm" },
    };

    public override AssistantDraftBackgroundSoundZero Read(
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
        AssistantDraftBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantDraftBackgroundSoundZero ReadAsPropertyName(
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
        AssistantDraftBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
