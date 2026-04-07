using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateWorkflowDtoBackgroundSoundZeroSerializer))]
public enum CreateWorkflowDtoBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}

internal class CreateWorkflowDtoBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateWorkflowDtoBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateWorkflowDtoBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", CreateWorkflowDtoBackgroundSoundZero.Off },
        { "office", CreateWorkflowDtoBackgroundSoundZero.Office },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateWorkflowDtoBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { CreateWorkflowDtoBackgroundSoundZero.Off, "off" },
        { CreateWorkflowDtoBackgroundSoundZero.Office, "office" },
    };

    public override CreateWorkflowDtoBackgroundSoundZero Read(
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
        CreateWorkflowDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateWorkflowDtoBackgroundSoundZero ReadAsPropertyName(
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
        CreateWorkflowDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
