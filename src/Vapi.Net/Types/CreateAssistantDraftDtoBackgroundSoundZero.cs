using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDraftDtoBackgroundSoundZeroSerializer))]
public enum CreateAssistantDraftDtoBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}

internal class CreateAssistantDraftDtoBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDraftDtoBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDraftDtoBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", CreateAssistantDraftDtoBackgroundSoundZero.Off },
        { "office", CreateAssistantDraftDtoBackgroundSoundZero.Office },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDraftDtoBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { CreateAssistantDraftDtoBackgroundSoundZero.Off, "off" },
        { CreateAssistantDraftDtoBackgroundSoundZero.Office, "office" },
    };

    public override CreateAssistantDraftDtoBackgroundSoundZero Read(
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
        CreateAssistantDraftDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDraftDtoBackgroundSoundZero ReadAsPropertyName(
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
        CreateAssistantDraftDtoBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
