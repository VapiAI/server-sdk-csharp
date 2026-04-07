using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WorkflowUserEditableBackgroundSoundZeroSerializer))]
public enum WorkflowUserEditableBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}

internal class WorkflowUserEditableBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WorkflowUserEditableBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WorkflowUserEditableBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", WorkflowUserEditableBackgroundSoundZero.Off },
        { "office", WorkflowUserEditableBackgroundSoundZero.Office },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        WorkflowUserEditableBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { WorkflowUserEditableBackgroundSoundZero.Off, "off" },
        { WorkflowUserEditableBackgroundSoundZero.Office, "office" },
    };

    public override WorkflowUserEditableBackgroundSoundZero Read(
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
        WorkflowUserEditableBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WorkflowUserEditableBackgroundSoundZero ReadAsPropertyName(
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
        WorkflowUserEditableBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
