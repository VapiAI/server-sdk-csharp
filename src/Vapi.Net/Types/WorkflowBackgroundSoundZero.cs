using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WorkflowBackgroundSoundZeroSerializer))]
public enum WorkflowBackgroundSoundZero
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

internal class WorkflowBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WorkflowBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WorkflowBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", WorkflowBackgroundSoundZero.Off },
        { "office", WorkflowBackgroundSoundZero.Office },
        { "white-noise", WorkflowBackgroundSoundZero.WhiteNoise },
        { "city", WorkflowBackgroundSoundZero.City },
        { "crowd", WorkflowBackgroundSoundZero.Crowd },
        { "farm", WorkflowBackgroundSoundZero.Farm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        WorkflowBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { WorkflowBackgroundSoundZero.Off, "off" },
        { WorkflowBackgroundSoundZero.Office, "office" },
        { WorkflowBackgroundSoundZero.WhiteNoise, "white-noise" },
        { WorkflowBackgroundSoundZero.City, "city" },
        { WorkflowBackgroundSoundZero.Crowd, "crowd" },
        { WorkflowBackgroundSoundZero.Farm, "farm" },
    };

    public override WorkflowBackgroundSoundZero Read(
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
        WorkflowBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WorkflowBackgroundSoundZero ReadAsPropertyName(
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
        WorkflowBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
