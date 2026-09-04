using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantVersionBackgroundSoundZeroSerializer))]
public enum AssistantVersionBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}

internal class AssistantVersionBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantVersionBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantVersionBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", AssistantVersionBackgroundSoundZero.Off },
        { "office", AssistantVersionBackgroundSoundZero.Office },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantVersionBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { AssistantVersionBackgroundSoundZero.Off, "off" },
        { AssistantVersionBackgroundSoundZero.Office, "office" },
    };

    public override AssistantVersionBackgroundSoundZero Read(
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
        AssistantVersionBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantVersionBackgroundSoundZero ReadAsPropertyName(
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
        AssistantVersionBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
