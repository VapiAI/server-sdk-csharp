using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateWorkflowDtoBackgroundSoundZeroSerializer))]
public enum UpdateWorkflowDtoBackgroundSoundZero
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

internal class UpdateWorkflowDtoBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateWorkflowDtoBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateWorkflowDtoBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", UpdateWorkflowDtoBackgroundSoundZero.Off },
        { "office", UpdateWorkflowDtoBackgroundSoundZero.Office },
        { "white-noise", UpdateWorkflowDtoBackgroundSoundZero.WhiteNoise },
        { "city", UpdateWorkflowDtoBackgroundSoundZero.City },
        { "crowd", UpdateWorkflowDtoBackgroundSoundZero.Crowd },
        { "farm", UpdateWorkflowDtoBackgroundSoundZero.Farm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateWorkflowDtoBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { UpdateWorkflowDtoBackgroundSoundZero.Off, "off" },
        { UpdateWorkflowDtoBackgroundSoundZero.Office, "office" },
        { UpdateWorkflowDtoBackgroundSoundZero.WhiteNoise, "white-noise" },
        { UpdateWorkflowDtoBackgroundSoundZero.City, "city" },
        { UpdateWorkflowDtoBackgroundSoundZero.Crowd, "crowd" },
        { UpdateWorkflowDtoBackgroundSoundZero.Farm, "farm" },
    };

    public override UpdateWorkflowDtoBackgroundSoundZero Read(
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
        UpdateWorkflowDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateWorkflowDtoBackgroundSoundZero ReadAsPropertyName(
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
        UpdateWorkflowDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
