using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferAssistantBackgroundSoundZeroSerializer))]
public enum TransferAssistantBackgroundSoundZero
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}

internal class TransferAssistantBackgroundSoundZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferAssistantBackgroundSoundZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferAssistantBackgroundSoundZero
    > _stringToEnum = new()
    {
        { "off", TransferAssistantBackgroundSoundZero.Off },
        { "office", TransferAssistantBackgroundSoundZero.Office },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferAssistantBackgroundSoundZero,
        string
    > _enumToString = new()
    {
        { TransferAssistantBackgroundSoundZero.Off, "off" },
        { TransferAssistantBackgroundSoundZero.Office, "office" },
    };

    public override TransferAssistantBackgroundSoundZero Read(
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
        TransferAssistantBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferAssistantBackgroundSoundZero ReadAsPropertyName(
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
        TransferAssistantBackgroundSoundZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
