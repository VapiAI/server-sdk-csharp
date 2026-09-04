using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDraftDtoBackgroundSoundZeroSerializer))]
public enum UpdateAssistantDraftDtoBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}

internal class UpdateAssistantDraftDtoBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDraftDtoBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDraftDtoBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", UpdateAssistantDraftDtoBackgroundSoundZero.Off },
        { "office", UpdateAssistantDraftDtoBackgroundSoundZero.Office },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDraftDtoBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { UpdateAssistantDraftDtoBackgroundSoundZero.Off, "off" },
        { UpdateAssistantDraftDtoBackgroundSoundZero.Office, "office" },
    };

    public override UpdateAssistantDraftDtoBackgroundSoundZero Read(
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
        UpdateAssistantDraftDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDraftDtoBackgroundSoundZero ReadAsPropertyName(
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
        UpdateAssistantDraftDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
